namespace Tedris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pBasliq = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lXal = new System.Windows.Forms.Label();
            this.lSeviyye = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bSoundOff = new Bunifu.Framework.UI.BunifuImageButton();
            this.bSoundON = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bStop = new Bunifu.Framework.UI.BunifuImageButton();
            this.bPlay = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.pBasliq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bSoundOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSoundON)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bPlay)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bExit)).BeginInit();
            this.SuspendLayout();
            // 
            // pBasliq
            // 
            this.pBasliq.BackColor = System.Drawing.Color.Blue;
            this.pBasliq.Controls.Add(this.bExit);
            this.pBasliq.Dock = System.Windows.Forms.DockStyle.Top;
            this.pBasliq.Location = new System.Drawing.Point(0, 0);
            this.pBasliq.Name = "pBasliq";
            this.pBasliq.Size = new System.Drawing.Size(450, 33);
            this.pBasliq.TabIndex = 6;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pBasliq;
            this.bunifuDragControl1.Vertical = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(260, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "XAL";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lXal
            // 
            this.lXal.AutoSize = true;
            this.lXal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lXal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lXal.Location = new System.Drawing.Point(321, 439);
            this.lXal.Name = "lXal";
            this.lXal.Size = new System.Drawing.Size(25, 25);
            this.lXal.TabIndex = 12;
            this.lXal.Text = "0";
            // 
            // lSeviyye
            // 
            this.lSeviyye.AutoSize = true;
            this.lSeviyye.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lSeviyye.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lSeviyye.Location = new System.Drawing.Point(352, 414);
            this.lSeviyye.Name = "lSeviyye";
            this.lSeviyye.Size = new System.Drawing.Size(25, 25);
            this.lSeviyye.TabIndex = 14;
            this.lSeviyye.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(260, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Səviyyə";
            // 
            // bSoundOff
            // 
            this.bSoundOff.BackColor = System.Drawing.Color.Transparent;
            this.bSoundOff.Image = global::Tedris.Properties.Resources.mute;
            this.bSoundOff.ImageActive = null;
            this.bSoundOff.Location = new System.Drawing.Point(315, 132);
            this.bSoundOff.Name = "bSoundOff";
            this.bSoundOff.Size = new System.Drawing.Size(40, 39);
            this.bSoundOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bSoundOff.TabIndex = 16;
            this.bSoundOff.TabStop = false;
            this.bSoundOff.Visible = false;
            this.bSoundOff.Zoom = 10;
            this.bSoundOff.Click += new System.EventHandler(this.bSoundOff_Click);
            // 
            // bSoundON
            // 
            this.bSoundON.BackColor = System.Drawing.Color.Transparent;
            this.bSoundON.Image = global::Tedris.Properties.Resources.sound;
            this.bSoundON.ImageActive = null;
            this.bSoundON.Location = new System.Drawing.Point(315, 132);
            this.bSoundON.Name = "bSoundON";
            this.bSoundON.Size = new System.Drawing.Size(40, 39);
            this.bSoundON.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bSoundON.TabIndex = 15;
            this.bSoundON.TabStop = false;
            this.bSoundON.Zoom = 10;
            this.bSoundON.Click += new System.EventHandler(this.bSoundOn_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::Tedris.Properties.Resources.tetrisHeader;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(254, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(196, 93);
            this.panel3.TabIndex = 1;
            // 
            // bStop
            // 
            this.bStop.BackColor = System.Drawing.Color.Transparent;
            this.bStop.Image = global::Tedris.Properties.Resources.stop;
            this.bStop.ImageActive = null;
            this.bStop.Location = new System.Drawing.Point(260, 132);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(40, 39);
            this.bStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bStop.TabIndex = 9;
            this.bStop.TabStop = false;
            this.bStop.Visible = false;
            this.bStop.Zoom = 10;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // bPlay
            // 
            this.bPlay.BackColor = System.Drawing.Color.Transparent;
            this.bPlay.Image = ((System.Drawing.Image)(resources.GetObject("bPlay.Image")));
            this.bPlay.ImageActive = null;
            this.bPlay.Location = new System.Drawing.Point(260, 132);
            this.bPlay.Name = "bPlay";
            this.bPlay.Size = new System.Drawing.Size(40, 39);
            this.bPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bPlay.TabIndex = 8;
            this.bPlay.TabStop = false;
            this.bPlay.Zoom = 10;
            this.bPlay.Click += new System.EventHandler(this.bPlay_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.BackgroundImage = global::Tedris.Properties.Resources._1_tetris;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 33);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(254, 446);
            this.panel4.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Tedris.Properties.Resources._1_tetris;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(27, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 400);
            this.panel1.TabIndex = 0;
            // 
            // bExit
            // 
            this.bExit.BackColor = System.Drawing.Color.Transparent;
            this.bExit.Image = global::Tedris.Properties.Resources.exit;
            this.bExit.ImageActive = null;
            this.bExit.Location = new System.Drawing.Point(412, 4);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(26, 26);
            this.bExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bExit.TabIndex = 0;
            this.bExit.TabStop = false;
            this.bExit.Zoom = 10;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(450, 479);
            this.Controls.Add(this.bSoundOff);
            this.Controls.Add(this.bSoundON);
            this.Controls.Add(this.lSeviyye);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lXal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.bStop);
            this.Controls.Add(this.bPlay);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pBasliq);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.pBasliq.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bSoundOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSoundON)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bPlay)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pBasliq;
        private Bunifu.Framework.UI.BunifuImageButton bExit;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuImageButton bPlay;
        private Bunifu.Framework.UI.BunifuImageButton bStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lXal;
        private System.Windows.Forms.Label lSeviyye;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuImageButton bSoundON;
        private Bunifu.Framework.UI.BunifuImageButton bSoundOff;
    }
}

