namespace Final_attempt_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gametime = new System.Windows.Forms.Timer(this.components);
            this.lblpoints = new System.Windows.Forms.Label();
            this.btnstart = new System.Windows.Forms.Button();
            this.Atimer = new System.Windows.Forms.Timer(this.components);
            this.lblhigh = new System.Windows.Forms.Label();
            this.picrock = new System.Windows.Forms.PictureBox();
            this.picbrad = new System.Windows.Forms.PictureBox();
            this.picbrick = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picrock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbrad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbrick)).BeginInit();
            this.SuspendLayout();
            // 
            // gametime
            // 
            this.gametime.Interval = 1;
            this.gametime.Tick += new System.EventHandler(this.Gametime_Tick);
            // 
            // lblpoints
            // 
            this.lblpoints.AutoSize = true;
            this.lblpoints.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpoints.Location = new System.Drawing.Point(12, 9);
            this.lblpoints.Name = "lblpoints";
            this.lblpoints.Size = new System.Drawing.Size(116, 27);
            this.lblpoints.TabIndex = 4;
            this.lblpoints.Text = "Points: 0";
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(897, 9);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(75, 23);
            this.btnstart.TabIndex = 5;
            this.btnstart.Text = "Start button";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.Btnstart_Click);
            // 
            // Atimer
            // 
            this.Atimer.Enabled = true;
            this.Atimer.Interval = 1;
            this.Atimer.Tick += new System.EventHandler(this.Atimer_Tick);
            // 
            // lblhigh
            // 
            this.lblhigh.AutoSize = true;
            this.lblhigh.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhigh.Location = new System.Drawing.Point(383, 9);
            this.lblhigh.Name = "lblhigh";
            this.lblhigh.Size = new System.Drawing.Size(165, 27);
            this.lblhigh.TabIndex = 7;
            this.lblhigh.Text = "HighScore: 0";
            // 
            // picrock
            // 
            this.picrock.Image = global::Final_attempt_1.Properties.Resources.Rock;
            this.picrock.Location = new System.Drawing.Point(934, 260);
            this.picrock.Name = "picrock";
            this.picrock.Size = new System.Drawing.Size(92, 116);
            this.picrock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picrock.TabIndex = 6;
            this.picrock.TabStop = false;
            this.picrock.Visible = false;
            // 
            // picbrad
            // 
            this.picbrad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picbrad.Image = global::Final_attempt_1.Properties.Resources.Brad_stick_figure2;
            this.picbrad.Location = new System.Drawing.Point(70, 368);
            this.picbrad.Name = "picbrad";
            this.picbrad.Size = new System.Drawing.Size(47, 145);
            this.picbrad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbrad.TabIndex = 1;
            this.picbrad.TabStop = false;
            // 
            // picbrick
            // 
            this.picbrick.Image = global::Final_attempt_1.Properties.Resources.Brick;
            this.picbrick.Location = new System.Drawing.Point(934, 446);
            this.picbrick.Name = "picbrick";
            this.picbrick.Size = new System.Drawing.Size(38, 74);
            this.picbrick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbrick.TabIndex = 0;
            this.picbrick.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final_attempt_1.Properties.Resources.Backround2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.lblhigh);
            this.Controls.Add(this.picrock);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.lblpoints);
            this.Controls.Add(this.picbrad);
            this.Controls.Add(this.picbrick);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picrock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbrad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbrick)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picbrick;
        private System.Windows.Forms.PictureBox picbrad;
        private System.Windows.Forms.Timer gametime;
        private System.Windows.Forms.Label lblpoints;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Timer Atimer;
        private System.Windows.Forms.PictureBox picrock;
        private System.Windows.Forms.Label lblhigh;
    }
}

