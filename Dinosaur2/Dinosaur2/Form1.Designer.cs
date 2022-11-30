namespace Dinosaur2
{
    partial class DINOSAUR_GAME
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
            this.btn_Quit = new System.Windows.Forms.PictureBox();
            this.btn_Option = new System.Windows.Forms.PictureBox();
            this.btn_Play = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Quit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Option)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Quit
            // 
            this.btn_Quit.BackgroundImage = global::Dinosaur2.Properties.Resources.BG;
            this.btn_Quit.Image = global::Dinosaur2.Properties.Resources.quit_Normal;
            this.btn_Quit.Location = new System.Drawing.Point(312, 410);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(153, 66);
            this.btn_Quit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Quit.TabIndex = 1;
            this.btn_Quit.TabStop = false;
            this.btn_Quit.Click += new System.EventHandler(this.btn_Quit_Click);
            this.btn_Quit.MouseLeave += new System.EventHandler(this.btn_Quit_MouseLeave);
            this.btn_Quit.MouseHover += new System.EventHandler(this.btn_Quit_MouseHover);
            // 
            // btn_Option
            // 
            this.btn_Option.BackgroundImage = global::Dinosaur2.Properties.Resources.BG;
            this.btn_Option.Image = global::Dinosaur2.Properties.Resources.option_Normal;
            this.btn_Option.Location = new System.Drawing.Point(312, 289);
            this.btn_Option.Name = "btn_Option";
            this.btn_Option.Size = new System.Drawing.Size(153, 67);
            this.btn_Option.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Option.TabIndex = 1;
            this.btn_Option.TabStop = false;
            this.btn_Option.Click += new System.EventHandler(this.btn_Option_Click);
            this.btn_Option.MouseLeave += new System.EventHandler(this.btn_Option_MouseLeave);
            this.btn_Option.MouseHover += new System.EventHandler(this.btn_Option_MouseHover);
            // 
            // btn_Play
            // 
            this.btn_Play.BackgroundImage = global::Dinosaur2.Properties.Resources.BG;
            this.btn_Play.Image = global::Dinosaur2.Properties.Resources.play_Normal;
            this.btn_Play.Location = new System.Drawing.Point(312, 174);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(153, 65);
            this.btn_Play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_Play.TabIndex = 1;
            this.btn_Play.TabStop = false;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            this.btn_Play.MouseLeave += new System.EventHandler(this.btn_Play_MouseLeave);
            this.btn_Play.MouseHover += new System.EventHandler(this.btn_Play_MouseHover_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dinosaur2.Properties.Resources.BG;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(806, 577);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // DINOSAUR_GAME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 577);
            this.Controls.Add(this.btn_Quit);
            this.Controls.Add(this.btn_Option);
            this.Controls.Add(this.btn_Play);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DINOSAUR_GAME";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.btn_Quit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Option)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox btn_Play;
        private System.Windows.Forms.PictureBox btn_Option;
        private System.Windows.Forms.PictureBox btn_Quit;
    }
}

