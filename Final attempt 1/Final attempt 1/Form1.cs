using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_attempt_1
{
    public partial class Form1 : Form
    {
        bool right;
        bool left;
        bool crouch;
        bool uncrouch;
        bool jump;
        int G = 29;
        int Force;
        int uod = 0;
        int pnt = 0;
        int highscore = 0;
        Random rnd = new Random();

        void Lose()
        {
            gametime.Enabled = false;
            if (pnt <= 10)
            {
                MessageBox.Show("Wow, That was Terrible!!!");
            }
            else if (11 <= pnt && pnt <= 20)
            {
                MessageBox.Show("Did a Rock hit you in the Face?");
            }
            else if (21 <= pnt && pnt <= 30)
            {
                MessageBox.Show("Not Bad");
            }
            else if (31 <= pnt && pnt <= 40)
            {
                MessageBox.Show("Congrats, you're ok");
            }
            else
            {
                MessageBox.Show("Not sure how you got this far");
            }
            picrock.Location = new Point(1000, 260);
            picbrick.Location = new Point(1000, 446);
            picbrad.Location = new Point(70, 368);
            lblpoints.Text = ("Points: " + pnt.ToString());
            btnstart.Enabled = true;
            if (pnt > highscore)
            {
                highscore = pnt;
                lblhigh.Text = ("HighScore: " + highscore.ToString());
            }
            //resest everything
            pnt = 0;
            left = false;
            right = false;
            crouch = false;
            uncrouch = true;
            picrock.Visible = false;
        }

        void Brickreset()
        {
            //resets the objects
            if (picbrick.Left <= -300)
            {
                picbrick.Location = new Point(1000, 446);
                picrock.Location = new Point(1000, 260);
                pnt++;
                lblpoints.Text = ("Points: " + pnt.ToString());
                if (pnt >= 11)
                {
                    uod = rnd.Next(0, 31);
                }
            }
        }

        void Rockreset()
        {
            //resets the objects
            if (picrock.Left <= -300)
            {
                picbrick.Location = new Point(1000, 446);
                picrock.Location = new Point(1000, 260);
                pnt++;
                lblpoints.Text = ("Points: " + pnt.ToString());
                if (pnt >= 11)
                {
                    uod = rnd.Next(0, 31);
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
            //Steve Wizardry
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //controls movement
            if (e.KeyCode == Keys.Left) { left = true; }
            if (e.KeyCode == Keys.Right) { right = true; }
            if (e.KeyCode == Keys.Down) { crouch = true; }
            if (e.KeyCode == Keys.Down) { uncrouch = false; }
            //if jumping, you cant jump
            if (jump == false)
            {
                if (e.KeyCode == Keys.Up)
                {
                    jump = true;
                    Force = G;
                }
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //disables movement after key release
            if (e.KeyCode == Keys.Left) { left = false; }
            if (e.KeyCode == Keys.Right) { right = false; }
            if (e.KeyCode == Keys.Down) { crouch = false; }
            if (e.KeyCode == Keys.Down) { uncrouch = true; }
        }
        private void Atimer_Tick(object sender, EventArgs e)
        {
            //controls the movement
            if (crouch == true) { picbrad.Height = 50; }
            if (uncrouch == true) { picbrad.Height = 150; }
            if (right == true) { picbrad.Left += 5; }
            if (left == true) { picbrad.Left -= 5; }

            //force spikes to 29 and rapidly decreses
            if (jump == true)
            {
                picbrad.Top -= Force; //gravity
                Force -= 1;
            }
            if (picbrad.Top + picbrad.Height >= 510)
            {
                picbrad.Top = 520 - picbrad.Height;
                jump = false;
            }
            else
            {
                picbrad.Top += 5;
            }
        }

        private void Gametime_Tick(object sender, EventArgs e)
        {
            //if rnd is less than 10 just the brick appears
            if (uod <= 10)
            {
                picbrick.Visible = true;
                picrock.Visible = false;
                if (picbrad.Bounds.IntersectsWith(picbrick.Bounds))
                {
                    Lose();
                }
                Brickreset();
            }
            //if rnd is between 11 and 20 just the rock appears
            if (11 <= uod && uod <= 20)
            {
                picbrick.Visible = false;
                picrock.Visible = true;
                if (picbrad.Bounds.IntersectsWith(picrock.Bounds))
                {
                    Lose();
                }
                Brickreset();

            }
            //if  rnd is between 21 and 25 both appear with the rock moving faster
            if (21 <= uod && uod <= 25)
            {
                picrock.Left -= 2;
                picbrick.Left += 4;
                picbrick.Visible = true;
                picrock.Visible = true;
                if (picbrad.Bounds.IntersectsWith(picbrick.Bounds))
                {
                    Lose();
                }
                if (picbrad.Bounds.IntersectsWith(picrock.Bounds))
                {
                    Lose();
                }
                Brickreset();
            }
            //if  rnd is between 26 and 30 both appear with the brick moving faster
            if (26 <= uod && uod <= 30)
            {
                picrock.Left += 4;
                picbrick.Left -= 4;
                picbrick.Visible = true;
                picrock.Visible = true;
                if (picbrad.Bounds.IntersectsWith(picbrick.Bounds))
                {
                    Lose();

                }
                if (picbrad.Bounds.IntersectsWith(picrock.Bounds))
                {
                    Lose();
                }
                Rockreset();

            }
            //controls the speed of the pictureboxes
            if (pnt <= 10) { picbrick.Left -= 6; picrock.Left -= 6; }
            else if (11 <= pnt && pnt <= 20) { picbrick.Left -= 8; picrock.Left -= 8; }
            else if (21 <= pnt && pnt <= 25) { picbrick.Left -= 10; picrock.Left -= 10; }
            else if (26 <= pnt && pnt <= 30) { picbrick.Left -= 12; picrock.Left -= 12; }
            else if (31 <= pnt && pnt <= 35) { picbrick.Left -= 14; picrock.Left -= 14; }
            else if (36 <= pnt && pnt <= 40) { picbrick.Left -= 16; picrock.Left -= 16; }
            else if (41 <= pnt && pnt <= 45) { picbrick.Left -= 18; picrock.Left -= 18; }
            else if (46 <= pnt && pnt <= 50) { picbrick.Left -= 20; picrock.Left -= 20; }
            else if (51 <= pnt && pnt <= 55) { picbrick.Left -= 22; picrock.Left -= 22; }
            else if (56 <= pnt && pnt <= 60) { picbrick.Left -= 24; picrock.Left -= 24; }
            else if (61 <= pnt && pnt <= 65) { picbrick.Left -= 26; picrock.Left -= 26; }
            else if (66 <= pnt && pnt <= 70) { picbrick.Left -= 28; picrock.Left -= 28; }
        }

        private void Btnstart_Click(object sender, EventArgs e)
        {
            gametime.Enabled = true;
            btnstart.Enabled = false;
        }
    }
}
