namespace Dinosaur2
{
    partial class winGamePage
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
            this.image = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BG = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BG)).BeginInit();
            this.SuspendLayout();
            // 
            // image
            // 
            this.image.Image = global::Dinosaur2.Properties.Resources.win;
            this.image.Location = new System.Drawing.Point(198, 124);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(300, 323);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 2;
            this.image.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Dinosaur2.Properties.Resources.under_BG_gif;
            this.pictureBox2.Location = new System.Drawing.Point(0, 497);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(719, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // BG
            // 
            this.BG.Image = global::Dinosaur2.Properties.Resources.game_background2;
            this.BG.Location = new System.Drawing.Point(0, 1);
            this.BG.Name = "BG";
            this.BG.Size = new System.Drawing.Size(719, 539);
            this.BG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BG.TabIndex = 0;
            this.BG.TabStop = false;
            // 
            // winGamePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 540);
            this.Controls.Add(this.image);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BG);
            this.Name = "winGamePage";
            this.Text = "winGamePage";
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox BG;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox image;
    }
}