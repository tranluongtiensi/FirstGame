namespace Dinosaur2
{
    partial class GamePlay_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GamePlay_Page));
            this.Time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.rock1 = new System.Windows.Forms.PictureBox();
            this.rock2 = new System.Windows.Forms.PictureBox();
            this.rock7 = new System.Windows.Forms.PictureBox();
            this.rock9 = new System.Windows.Forms.PictureBox();
            this.woodBox = new System.Windows.Forms.PictureBox();
            this.woodBox4 = new System.Windows.Forms.PictureBox();
            this.Cactus1 = new System.Windows.Forms.PictureBox();
            this.Meteorite5 = new System.Windows.Forms.PictureBox();
            this.Meteorite6 = new System.Windows.Forms.PictureBox();
            this.Meteorite3 = new System.Windows.Forms.PictureBox();
            this.Meteorite4 = new System.Windows.Forms.PictureBox();
            this.Meteorite2 = new System.Windows.Forms.PictureBox();
            this.Meteorite = new System.Windows.Forms.PictureBox();
            this.woodBox6 = new System.Windows.Forms.PictureBox();
            this.woodBox5 = new System.Windows.Forms.PictureBox();
            this.woodBox2 = new System.Windows.Forms.PictureBox();
            this.woodBox3 = new System.Windows.Forms.PictureBox();
            this.Cactus6 = new System.Windows.Forms.PictureBox();
            this.Cactus5 = new System.Windows.Forms.PictureBox();
            this.Cactus4 = new System.Windows.Forms.PictureBox();
            this.Cactus3 = new System.Windows.Forms.PictureBox();
            this.Cactus8 = new System.Windows.Forms.PictureBox();
            this.Cactus12 = new System.Windows.Forms.PictureBox();
            this.Cactus11 = new System.Windows.Forms.PictureBox();
            this.Cactus9 = new System.Windows.Forms.PictureBox();
            this.Cactus2 = new System.Windows.Forms.PictureBox();
            this.Trex = new System.Windows.Forms.PictureBox();
            this.backgroundBottom = new System.Windows.Forms.PictureBox();
            this.backgroundAbove = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.woodBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.woodBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cactus1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Meteorite5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Meteorite6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Meteorite3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Meteorite4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Meteorite2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Meteorite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.woodBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.woodBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.woodBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.woodBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cactus6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cactus5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cactus4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cactus3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cactus8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cactus12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cactus11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cactus9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cactus2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundAbove)).BeginInit();
            this.SuspendLayout();
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.Location = new System.Drawing.Point(12, 29);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(122, 34);
            this.Time.TabIndex = 28;
            this.Time.Text = "Time: 0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.gameT);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 25;
            this.timer2.Tick += new System.EventHandler(this.Clock_Tick);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(45, 89);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 41;
            // 
            // rock1
            // 
            this.rock1.Image = global::Dinosaur2.Properties.Resources.Rock1;
            this.rock1.Location = new System.Drawing.Point(87, 532);
            this.rock1.Name = "rock1";
            this.rock1.Size = new System.Drawing.Size(33, 26);
            this.rock1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rock1.TabIndex = 45;
            this.rock1.TabStop = false;
            // 
            // rock2
            // 
            this.rock2.Image = global::Dinosaur2.Properties.Resources.Rock15;
            this.rock2.Location = new System.Drawing.Point(167, 438);
            this.rock2.Name = "rock2";
            this.rock2.Size = new System.Drawing.Size(93, 90);
            this.rock2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rock2.TabIndex = 44;
            this.rock2.TabStop = false;
            // 
            // rock7
            // 
            this.rock7.Image = global::Dinosaur2.Properties.Resources.Rock16;
            this.rock7.Location = new System.Drawing.Point(129, 534);
            this.rock7.Name = "rock7";
            this.rock7.Size = new System.Drawing.Size(86, 53);
            this.rock7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rock7.TabIndex = 44;
            this.rock7.TabStop = false;
            this.rock7.Click += new System.EventHandler(this.rock7_Click);
            // 
            // rock9
            // 
            this.rock9.Image = global::Dinosaur2.Properties.Resources.Rock14;
            this.rock9.Location = new System.Drawing.Point(242, 526);
            this.rock9.Name = "rock9";
            this.rock9.Size = new System.Drawing.Size(93, 90);
            this.rock9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rock9.TabIndex = 44;
            this.rock9.TabStop = false;
            this.rock9.Click += new System.EventHandler(this.rock9_Click);
            // 
            // woodBox
            // 
            this.woodBox.Image = global::Dinosaur2.Properties.Resources.woodbox;
            this.woodBox.Location = new System.Drawing.Point(273, 532);
            this.woodBox.Name = "woodBox";
            this.woodBox.Size = new System.Drawing.Size(136, 67);
            this.woodBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.woodBox.TabIndex = 27;
            this.woodBox.TabStop = false;
            this.woodBox.Tag = "WoodBox";
            // 
            // woodBox4
            // 
            this.woodBox4.Image = global::Dinosaur2.Properties.Resources.woodbox;
            this.woodBox4.Location = new System.Drawing.Point(341, 372);
            this.woodBox4.Name = "woodBox4";
            this.woodBox4.Size = new System.Drawing.Size(144, 67);
            this.woodBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.woodBox4.TabIndex = 25;
            this.woodBox4.TabStop = false;
            this.woodBox4.Tag = "WoodBox";
            // 
            // Cactus1
            // 
            this.Cactus1.Image = global::Dinosaur2.Properties.Resources.obstacle_2;
            this.Cactus1.Location = new System.Drawing.Point(579, 487);
            this.Cactus1.Name = "Cactus1";
            this.Cactus1.Size = new System.Drawing.Size(39, 39);
            this.Cactus1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cactus1.TabIndex = 12;
            this.Cactus1.TabStop = false;
            this.Cactus1.Tag = "doubleCactus";
            // 
            // Meteorite5
            // 
            this.Meteorite5.Image = global::Dinosaur2.Properties.Resources.meteorite;
            this.Meteorite5.Location = new System.Drawing.Point(311, 510);
            this.Meteorite5.Name = "Meteorite5";
            this.Meteorite5.Size = new System.Drawing.Size(24, 55);
            this.Meteorite5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Meteorite5.TabIndex = 34;
            this.Meteorite5.TabStop = false;
            // 
            // Meteorite6
            // 
            this.Meteorite6.Image = global::Dinosaur2.Properties.Resources.meteorite;
            this.Meteorite6.Location = new System.Drawing.Point(341, 532);
            this.Meteorite6.Name = "Meteorite6";
            this.Meteorite6.Size = new System.Drawing.Size(24, 55);
            this.Meteorite6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Meteorite6.TabIndex = 33;
            this.Meteorite6.TabStop = false;
            // 
            // Meteorite3
            // 
            this.Meteorite3.Image = global::Dinosaur2.Properties.Resources.meteorite;
            this.Meteorite3.Location = new System.Drawing.Point(491, 333);
            this.Meteorite3.Name = "Meteorite3";
            this.Meteorite3.Size = new System.Drawing.Size(24, 55);
            this.Meteorite3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Meteorite3.TabIndex = 32;
            this.Meteorite3.TabStop = false;
            // 
            // Meteorite4
            // 
            this.Meteorite4.Image = global::Dinosaur2.Properties.Resources.meteorite;
            this.Meteorite4.Location = new System.Drawing.Point(579, 242);
            this.Meteorite4.Name = "Meteorite4";
            this.Meteorite4.Size = new System.Drawing.Size(24, 55);
            this.Meteorite4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Meteorite4.TabIndex = 31;
            this.Meteorite4.TabStop = false;
            this.Meteorite4.Click += new System.EventHandler(this.Meteorite4_Click);
            // 
            // Meteorite2
            // 
            this.Meteorite2.Image = global::Dinosaur2.Properties.Resources.meteorite;
            this.Meteorite2.Location = new System.Drawing.Point(68, 532);
            this.Meteorite2.Name = "Meteorite2";
            this.Meteorite2.Size = new System.Drawing.Size(24, 55);
            this.Meteorite2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Meteorite2.TabIndex = 30;
            this.Meteorite2.TabStop = false;
            // 
            // Meteorite
            // 
            this.Meteorite.Image = global::Dinosaur2.Properties.Resources.meteorite;
            this.Meteorite.Location = new System.Drawing.Point(87, 532);
            this.Meteorite.Name = "Meteorite";
            this.Meteorite.Size = new System.Drawing.Size(24, 55);
            this.Meteorite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Meteorite.TabIndex = 29;
            this.Meteorite.TabStop = false;
            // 
            // woodBox6
            // 
            this.woodBox6.Image = global::Dinosaur2.Properties.Resources.woodbox;
            this.woodBox6.Location = new System.Drawing.Point(359, 372);
            this.woodBox6.Name = "woodBox6";
            this.woodBox6.Size = new System.Drawing.Size(68, 67);
            this.woodBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.woodBox6.TabIndex = 24;
            this.woodBox6.TabStop = false;
            this.woodBox6.Tag = "WoodBox";
            // 
            // woodBox5
            // 
            this.woodBox5.Image = global::Dinosaur2.Properties.Resources.woodbox;
            this.woodBox5.Location = new System.Drawing.Point(462, 491);
            this.woodBox5.Name = "woodBox5";
            this.woodBox5.Size = new System.Drawing.Size(68, 67);
            this.woodBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.woodBox5.TabIndex = 23;
            this.woodBox5.TabStop = false;
            this.woodBox5.Tag = "WoodBox";
            // 
            // woodBox2
            // 
            this.woodBox2.Image = global::Dinosaur2.Properties.Resources.woodbox;
            this.woodBox2.Location = new System.Drawing.Point(147, 532);
            this.woodBox2.Name = "woodBox2";
            this.woodBox2.Size = new System.Drawing.Size(68, 67);
            this.woodBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.woodBox2.TabIndex = 22;
            this.woodBox2.TabStop = false;
            this.woodBox2.Tag = "WoodBox";
            // 
            // woodBox3
            // 
            this.woodBox3.Image = global::Dinosaur2.Properties.Resources.woodbox;
            this.woodBox3.Location = new System.Drawing.Point(132, 255);
            this.woodBox3.Name = "woodBox3";
            this.woodBox3.Size = new System.Drawing.Size(157, 67);
            this.woodBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.woodBox3.TabIndex = 26;
            this.woodBox3.TabStop = false;
            this.woodBox3.Tag = "WoodBox";
            // 
            // Cactus6
            // 
            this.Cactus6.Image = global::Dinosaur2.Properties.Resources.obstacle_1;
            this.Cactus6.Location = new System.Drawing.Point(359, 532);
            this.Cactus6.Name = "Cactus6";
            this.Cactus6.Size = new System.Drawing.Size(21, 36);
            this.Cactus6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cactus6.TabIndex = 21;
            this.Cactus6.TabStop = false;
            this.Cactus6.Tag = "doubleCactus";
            // 
            // Cactus5
            // 
            this.Cactus5.Image = global::Dinosaur2.Properties.Resources.obstacle_2;
            this.Cactus5.Location = new System.Drawing.Point(341, 532);
            this.Cactus5.Name = "Cactus5";
            this.Cactus5.Size = new System.Drawing.Size(39, 39);
            this.Cactus5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cactus5.TabIndex = 20;
            this.Cactus5.TabStop = false;
            this.Cactus5.Tag = "doubleCactus";
            // 
            // Cactus4
            // 
            this.Cactus4.Image = global::Dinosaur2.Properties.Resources.obstacle_2;
            this.Cactus4.Location = new System.Drawing.Point(221, 532);
            this.Cactus4.Name = "Cactus4";
            this.Cactus4.Size = new System.Drawing.Size(39, 39);
            this.Cactus4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cactus4.TabIndex = 19;
            this.Cactus4.TabStop = false;
            this.Cactus4.Tag = "doubleCactus";
            // 
            // Cactus3
            // 
            this.Cactus3.Image = global::Dinosaur2.Properties.Resources.obstacle_1;
            this.Cactus3.Location = new System.Drawing.Point(18, 476);
            this.Cactus3.Name = "Cactus3";
            this.Cactus3.Size = new System.Drawing.Size(29, 50);
            this.Cactus3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cactus3.TabIndex = 18;
            this.Cactus3.TabStop = false;
            this.Cactus3.Tag = "doubleCactus";
            this.Cactus3.Click += new System.EventHandler(this.Cactus3_Click);
            // 
            // Cactus8
            // 
            this.Cactus8.Image = global::Dinosaur2.Properties.Resources.obstacle_2;
            this.Cactus8.Location = new System.Drawing.Point(399, 526);
            this.Cactus8.Name = "Cactus8";
            this.Cactus8.Size = new System.Drawing.Size(39, 39);
            this.Cactus8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cactus8.TabIndex = 17;
            this.Cactus8.TabStop = false;
            this.Cactus8.Tag = "doubleCactus";
            // 
            // Cactus12
            // 
            this.Cactus12.Image = global::Dinosaur2.Properties.Resources.obstacle_2;
            this.Cactus12.Location = new System.Drawing.Point(250, 532);
            this.Cactus12.Name = "Cactus12";
            this.Cactus12.Size = new System.Drawing.Size(39, 39);
            this.Cactus12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cactus12.TabIndex = 16;
            this.Cactus12.TabStop = false;
            this.Cactus12.Tag = "doubleCactus";
            // 
            // Cactus11
            // 
            this.Cactus11.Image = global::Dinosaur2.Properties.Resources.obstacle_2;
            this.Cactus11.Location = new System.Drawing.Point(191, 481);
            this.Cactus11.Name = "Cactus11";
            this.Cactus11.Size = new System.Drawing.Size(39, 39);
            this.Cactus11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cactus11.TabIndex = 15;
            this.Cactus11.TabStop = false;
            this.Cactus11.Tag = "doubleCactus";
            this.Cactus11.Click += new System.EventHandler(this.Cactus11_Click);
            // 
            // Cactus9
            // 
            this.Cactus9.Image = global::Dinosaur2.Properties.Resources.obstacle_2;
            this.Cactus9.Location = new System.Drawing.Point(491, 526);
            this.Cactus9.Name = "Cactus9";
            this.Cactus9.Size = new System.Drawing.Size(39, 39);
            this.Cactus9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cactus9.TabIndex = 14;
            this.Cactus9.TabStop = false;
            this.Cactus9.Tag = "doubleCactus";
            // 
            // Cactus2
            // 
            this.Cactus2.Image = global::Dinosaur2.Properties.Resources.obstacle_2;
            this.Cactus2.Location = new System.Drawing.Point(199, 532);
            this.Cactus2.Name = "Cactus2";
            this.Cactus2.Size = new System.Drawing.Size(39, 39);
            this.Cactus2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cactus2.TabIndex = 13;
            this.Cactus2.TabStop = false;
            this.Cactus2.Tag = "doubleCactus";
            // 
            // Trex
            // 
            this.Trex.Image = global::Dinosaur2.Properties.Resources.running;
            this.Trex.Location = new System.Drawing.Point(68, 491);
            this.Trex.Name = "Trex";
            this.Trex.Size = new System.Drawing.Size(32, 32);
            this.Trex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Trex.TabIndex = 11;
            this.Trex.TabStop = false;
            this.Trex.Click += new System.EventHandler(this.Trex_Click);
            // 
            // backgroundBottom
            // 
            this.backgroundBottom.Image = global::Dinosaur2.Properties.Resources.under_BG_gif;
            this.backgroundBottom.Location = new System.Drawing.Point(-1, 526);
            this.backgroundBottom.Name = "backgroundBottom";
            this.backgroundBottom.Size = new System.Drawing.Size(817, 49);
            this.backgroundBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backgroundBottom.TabIndex = 10;
            this.backgroundBottom.TabStop = false;
            // 
            // backgroundAbove
            // 
            this.backgroundAbove.Image = global::Dinosaur2.Properties.Resources.BG_above_gif;
            this.backgroundAbove.Location = new System.Drawing.Point(-1, 0);
            this.backgroundAbove.Name = "backgroundAbove";
            this.backgroundAbove.Size = new System.Drawing.Size(817, 526);
            this.backgroundAbove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backgroundAbove.TabIndex = 9;
            this.backgroundAbove.TabStop = false;
            // 
            // GamePlay_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 581);
            this.Controls.Add(this.rock1);
            this.Controls.Add(this.rock2);
            this.Controls.Add(this.rock7);
            this.Controls.Add(this.rock9);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.woodBox);
            this.Controls.Add(this.woodBox4);
            this.Controls.Add(this.Cactus1);
            this.Controls.Add(this.Meteorite5);
            this.Controls.Add(this.Meteorite6);
            this.Controls.Add(this.Meteorite3);
            this.Controls.Add(this.Meteorite4);
            this.Controls.Add(this.Meteorite2);
            this.Controls.Add(this.Meteorite);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.woodBox6);
            this.Controls.Add(this.woodBox5);
            this.Controls.Add(this.woodBox2);
            this.Controls.Add(this.woodBox3);
            this.Controls.Add(this.Cactus6);
            this.Controls.Add(this.Cactus5);
            this.Controls.Add(this.Cactus4);
            this.Controls.Add(this.Cactus3);
            this.Controls.Add(this.Cactus8);
            this.Controls.Add(this.Cactus12);
            this.Controls.Add(this.Cactus11);
            this.Controls.Add(this.Cactus9);
            this.Controls.Add(this.Cactus2);
            this.Controls.Add(this.Trex);
            this.Controls.Add(this.backgroundBottom);
            this.Controls.Add(this.backgroundAbove);
            this.Name = "GamePlay_Page";
            this.Text = "GamePlay_Page";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GamePlay_Page_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GamePlay_Page_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rock9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.woodBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.woodBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cactus1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Meteorite5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Meteorite6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Meteorite3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Meteorite4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Meteorite2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Meteorite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.woodBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.woodBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.woodBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.woodBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cactus6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cactus5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cactus4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cactus3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cactus8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cactus12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cactus11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cactus9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cactus2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundAbove)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox woodBox;
        private System.Windows.Forms.PictureBox woodBox4;
        private System.Windows.Forms.PictureBox Cactus1;
        private System.Windows.Forms.PictureBox Meteorite5;
        private System.Windows.Forms.PictureBox Meteorite6;
        private System.Windows.Forms.PictureBox Meteorite3;
        private System.Windows.Forms.PictureBox Meteorite4;
        private System.Windows.Forms.PictureBox Meteorite2;
        private System.Windows.Forms.PictureBox Meteorite;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.PictureBox woodBox6;
        private System.Windows.Forms.PictureBox woodBox5;
        private System.Windows.Forms.PictureBox woodBox2;
        private System.Windows.Forms.PictureBox woodBox3;
        private System.Windows.Forms.PictureBox Cactus6;
        private System.Windows.Forms.PictureBox Cactus5;
        private System.Windows.Forms.PictureBox Cactus4;
        private System.Windows.Forms.PictureBox Cactus3;
        private System.Windows.Forms.PictureBox Cactus8;
        private System.Windows.Forms.PictureBox Cactus12;
        private System.Windows.Forms.PictureBox Cactus11;
        private System.Windows.Forms.PictureBox Cactus9;
        private System.Windows.Forms.PictureBox Cactus2;
        private System.Windows.Forms.PictureBox Trex;
        private System.Windows.Forms.PictureBox backgroundBottom;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox backgroundAbove;
        private System.Windows.Forms.PictureBox rock9;
        private System.Windows.Forms.PictureBox rock7;
        private System.Windows.Forms.PictureBox rock2;
        private System.Windows.Forms.PictureBox rock1;
    }
}