using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dinosaur2
{

    public partial class GamePlay_Page : Form
    {
        bool goRight, goLeft;
        int gravity = 14;
        int force;
        bool jump;
        int jumpTimes = 2;
        double clock = 0;
        public GamePlay_Page()
        {
            InitializeComponent();
            wplayer.URL = ("Trap ed.wav");
            wplayer.controls.play();
            axWindowsMediaPlayer1.Hide();
            backgroundAbove.Controls.Add(Trex);
            Trex.BackColor = Color.Transparent;
            backgroundAbove.Controls.Add(Cactus2);
            Cactus2.BackColor = Color.Transparent;
            backgroundAbove.Controls.Add(Cactus3);
            Cactus3.BackColor = Color.Transparent;
            backgroundAbove.Controls.Add(Cactus4);
            Cactus4.BackColor = Color.Transparent;
            backgroundAbove.Controls.Add(Cactus5);
            Cactus5.BackColor = Color.Transparent;
            backgroundAbove.Controls.Add(Cactus6);
            Cactus6.BackColor = Color.Transparent;
            backgroundAbove.Controls.Add(woodBox);
            woodBox.BackColor = Color.Transparent;
            backgroundAbove.Controls.Add(Cactus1);
            Cactus1.BackColor = Color.Transparent;
            backgroundAbove.Controls.Add(Cactus8);
            Cactus8.BackColor = Color.Transparent;
            backgroundAbove.Controls.Add(Cactus9);
            Cactus9.BackColor = Color.Transparent;
            backgroundAbove.Controls.Add(Cactus11);
            Cactus11.BackColor = Color.Transparent;
            backgroundAbove.Controls.Add(Cactus12);
            Cactus12.BackColor = Color.Transparent;
            backgroundAbove.Controls.Add(woodBox3);
            woodBox3.BackColor = Color.Transparent;
            backgroundAbove.Controls.Add(woodBox2);
            woodBox2.BackColor = Color.Transparent;
            backgroundAbove.Controls.Add(woodBox4);
            woodBox4.BackColor = Color.Transparent;
            backgroundAbove.Controls.Add(woodBox5);
            woodBox5.BackColor = Color.Transparent;
            backgroundAbove.Controls.Add(woodBox6);
            woodBox6.BackColor = Color.Transparent;
            backgroundAbove.Controls.Add(Time);
            Time.BackColor = Color.Transparent;
            backgroundAbove.Controls.Add(Meteorite);
            Meteorite.BackColor = Color.Transparent;
            backgroundAbove.Controls.Add(Meteorite2);
            Meteorite2.BackColor = Color.Transparent;
            backgroundAbove.Controls.Add(Meteorite3);
            Meteorite3.BackColor = Color.Transparent;
            backgroundAbove.Controls.Add(Meteorite4);
            Meteorite4.BackColor = Color.Transparent;
            backgroundAbove.Controls.Add(Meteorite5);
            Meteorite5.BackColor = Color.Transparent;
            backgroundAbove.Controls.Add(Meteorite6);
            Meteorite6.BackColor = Color.Transparent;
            backgroundAbove.Controls.Add(rock1);
            rock1.BackColor = Color.Transparent;
            backgroundAbove.Controls.Add(rock2);
            rock2.BackColor = Color.Transparent;
            backgroundAbove.Controls.Add(rock7);
            rock7.BackColor = Color.Transparent;
            backgroundAbove.Controls.Add(rock9);
            rock9.BackColor = Color.Transparent;
            Time.Hide();
        }
        public static WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

        private void gamePage(object sender, EventArgs e)
        {

        }
        private void GamePlay_Page_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                goRight = true;
                Trex.Image = Properties.Resources.running;
            }
            if (e.KeyCode == Keys.A)
            {
                goLeft = true;
                Trex.Image = Properties.Resources.running2;
            }
            if (e.KeyCode == Keys.W && jumpTimes > 0)
            {
                jump = true;
                force = gravity;
                jumpTimes -= 1;

            }

        }
        private void gameT(object sender, EventArgs e)
        {
            if (goRight == true && Trex.Right < 600)
            {
                Trex.Left += 5;
            }
            if (goLeft == true && Trex.Left > 10)
            {
                Trex.Left -= 5;
            }

            if (jump == true)
            {
                Trex.Top -= force;
                force -= 1;
            }
            if (Trex.Top + Trex.Height >= backgroundAbove.Height)
            {
                Trex.Top = backgroundAbove.Height - Trex.Height;
                jump = false;
            }
            else
            {
                Trex.Top += 3;
            }
            if (Trex.Top + Trex.Height == backgroundAbove.Height)
            {
                jumpTimes = 2;
            }
            //woodbox 1

            //top collision
            if (Trex.Left + Trex.Width > woodBox.Left && Trex.Left + Trex.Width < woodBox.Left + woodBox.Width + Trex.Width && Trex.Top + Trex.Height >= woodBox.Top && Trex.Top < woodBox.Top)
            {
                jump = false;
                force = 0;
                Trex.Top = woodBox.Location.Y - Trex.Height;
                jumpTimes = 2;
            }
            //bottom collision
            if (Trex.Left + Trex.Width > woodBox.Left && Trex.Left + Trex.Width < woodBox.Left + woodBox.Width + Trex.Width && Trex.Top - woodBox.Bottom <= 10 && Trex.Top - woodBox.Top > -10)
            {
                force = -1;
            }
            //simple fall
            if (!(Trex.Left + Trex.Width > woodBox.Left && Trex.Left + Trex.Width < woodBox.Left + woodBox.Width + Trex.Width) && Trex.Top + Trex.Height >= woodBox.Top && Trex.Top < woodBox.Top)
            {
                jump = true;
            }
            //woodbox 2

            //top collision
            if (Trex.Left + Trex.Width > woodBox2.Left && Trex.Left + Trex.Width < woodBox2.Left + woodBox2.Width + Trex.Width && Trex.Top + Trex.Height >= woodBox2.Top && Trex.Top < woodBox2.Top)
            {
                jump = false;
                force = 0;
                Trex.Top = woodBox2.Location.Y - Trex.Height;
                jumpTimes = 2;
            }
            //bottom collision
            if (Trex.Left + Trex.Width > woodBox2.Left && Trex.Left + Trex.Width < woodBox2.Left + woodBox2.Width + Trex.Width && Trex.Top - woodBox2.Bottom <= 10 && Trex.Top - woodBox2.Top > -10)
            {
                force = -1;
            }
            //simple fall
            if (!(Trex.Left + Trex.Width > woodBox2.Left && Trex.Left + Trex.Width < woodBox2.Left + woodBox2.Width + Trex.Width) && Trex.Top + Trex.Height >= woodBox2.Top && Trex.Top < woodBox2.Top)
            {
                jump = true;
            }
            //woodbox3
            //top collision
            if (Trex.Left + Trex.Width > woodBox3.Left && Trex.Left + Trex.Width < woodBox3.Left + woodBox3.Width + Trex.Width && Trex.Top + Trex.Height >= woodBox3.Top && Trex.Top < woodBox3.Top)
            {
                jump = false;
                force = 0;
                Trex.Top = woodBox3.Location.Y - Trex.Height;
                jumpTimes = 2;
            }
            //bottom collision
            if (Trex.Left + Trex.Width > woodBox3.Left && Trex.Left + Trex.Width < woodBox3.Left + woodBox3.Width + Trex.Width && Trex.Top - woodBox3.Bottom <= 10 && Trex.Top - woodBox3.Top > -10)
            {
                force = -1;
            }
            //simple fall
            if (!(Trex.Left + Trex.Width > woodBox3.Left && Trex.Left + Trex.Width < woodBox3.Left + woodBox3.Width + Trex.Width) && Trex.Top + Trex.Height >= woodBox3.Top && Trex.Top < woodBox3.Top)
            {
                jump = true;
            }
            //woodBox4
            //top collision
            if (Trex.Left + Trex.Width > woodBox4.Left && Trex.Left + Trex.Width < woodBox4.Left + woodBox4.Width + Trex.Width && Trex.Top + Trex.Height >= woodBox4.Top && Trex.Top < woodBox4.Top)
            {
                jump = false;
                force = 0;
                Trex.Top = woodBox4.Location.Y - Trex.Height;
                jumpTimes = 2;
            }
            //bottom collision
            if (Trex.Left + Trex.Width > woodBox4.Left && Trex.Left + Trex.Width < woodBox4.Left + woodBox4.Width + Trex.Width && Trex.Top - woodBox4.Bottom <= 10 && Trex.Top - woodBox4.Top > -10)
            {
                force = -1;
            }
            //simple fall
            if (!(Trex.Left + Trex.Width > woodBox4.Left && Trex.Left + Trex.Width < woodBox4.Left + woodBox4.Width + Trex.Width) && Trex.Top + Trex.Height >= woodBox4.Top && Trex.Top < woodBox4.Top)
            {
                jump = true;
            }

            //woodbox5
            //top collision
            if (Trex.Left + Trex.Width > woodBox5.Left && Trex.Left + Trex.Width < woodBox5.Left + woodBox5.Width + Trex.Width && Trex.Top + Trex.Height >= woodBox5.Top && Trex.Top < woodBox5.Top)
            {
                jump = false;
                force = 0;
                Trex.Top = woodBox5.Location.Y - Trex.Height;
                jumpTimes = 2;
            }
            //bottom collision
            if (Trex.Left + Trex.Width > woodBox5.Left && Trex.Left + Trex.Width < woodBox5.Left + woodBox5.Width + Trex.Width && Trex.Top - woodBox5.Bottom <= 10 && Trex.Top - woodBox5.Top > -10)
            {
                force = -1;
            }
            //simple fall
            if (!(Trex.Left + Trex.Width > woodBox5.Left && Trex.Left + Trex.Width < woodBox5.Left + woodBox5.Width + Trex.Width) && Trex.Top + Trex.Height >= woodBox5.Top && Trex.Top < woodBox5.Top)
            {
                jump = true;
            }
            //woodbox6
            //top collision
            if (Trex.Left + Trex.Width > woodBox6.Left && Trex.Left + Trex.Width < woodBox6.Left + woodBox6.Width + Trex.Width && Trex.Top + Trex.Height >= woodBox6.Top && Trex.Top < woodBox6.Top)
            {
                jump = false;
                force = 0;
                Trex.Top = woodBox6.Location.Y - Trex.Height;
                jumpTimes = 2;
            }
            //bottom collision
            if (Trex.Left + Trex.Width > woodBox6.Left && Trex.Left + Trex.Width < woodBox6.Left + woodBox6.Width + Trex.Width && Trex.Top - woodBox6.Bottom <= 10 && Trex.Top - woodBox6.Top > -10)
            {
                force = -1;
            }
            //simple fall
            if (!(Trex.Left + Trex.Width > woodBox6.Left && Trex.Left + Trex.Width < woodBox6.Left + woodBox6.Width + Trex.Width) && Trex.Top + Trex.Height >= woodBox6.Top && Trex.Top < woodBox6.Top)
            {
                jump = true;
            }
            //Cactus1
            if (Trex.Bounds.IntersectsWith(Cactus1.Bounds))
            {
                if (goRight == true)
                {
                    Trex.Image = Properties.Resources.dead;
                }
                if (goLeft == true)
                {
                    Trex.Image = Properties.Resources.deadLeft;
                }
                endGame();
            }
            //Cactus2
            if (Trex.Bounds.IntersectsWith(Cactus2.Bounds))
            {
                if (goRight == true)
                {
                    Trex.Image = Properties.Resources.dead;
                }
                if (goLeft == true)
                {
                    Trex.Image = Properties.Resources.deadLeft;
                }
                endGame();
            }
            //Cactus3
            if (Trex.Bounds.IntersectsWith(Cactus3.Bounds))
            {
                if (goRight == true)
                {
                    Trex.Image = Properties.Resources.dead;
                }
                if (goLeft == true)
                {
                    Trex.Image = Properties.Resources.deadLeft;
                }
                endGame();
            }
            //Cactus4
            if (Trex.Bounds.IntersectsWith(Cactus4.Bounds))
            {
                if (goRight == true)
                {
                    Trex.Image = Properties.Resources.dead;
                }
                if (goLeft == true)
                {
                    Trex.Image = Properties.Resources.deadLeft;
                }
                endGame();
            }
            //Cactus5
            if (Trex.Bounds.IntersectsWith(Cactus5.Bounds))
            {
                if (goRight == true)
                {
                    Trex.Image = Properties.Resources.dead;
                }
                if (goLeft == true)
                {
                    Trex.Image = Properties.Resources.deadLeft;
                }
                endGame();
            }
            //Cactus6
            if (Trex.Bounds.IntersectsWith(Cactus6.Bounds))
            {
                if (goRight == true)
                {
                    Trex.Image = Properties.Resources.dead;
                }
                if (goLeft == true)
                {
                    Trex.Image = Properties.Resources.deadLeft;
                }
                endGame();
            }
            //Cactus8
            if (Trex.Bounds.IntersectsWith(Cactus8.Bounds))
            {
                if (goRight == true)
                {
                    Trex.Image = Properties.Resources.dead;
                }
                if (goLeft == true)
                {
                    Trex.Image = Properties.Resources.deadLeft;
                }
                endGame();
            }
            //Cactus9
            if (Trex.Bounds.IntersectsWith(Cactus9.Bounds))
            {
                if (goRight == true)
                {
                    Trex.Image = Properties.Resources.dead;
                }
                if (goLeft == true)
                {
                    Trex.Image = Properties.Resources.deadLeft;
                }
                endGame();
            }
            //Cactus11
            if (Trex.Bounds.IntersectsWith(Cactus11.Bounds))
            {
                if (goRight == true)
                {
                    Trex.Image = Properties.Resources.dead;
                }
                if (goLeft == true)
                {
                    Trex.Image = Properties.Resources.deadLeft;
                }
                endGame();
            }
            //Cactus12
            if (Trex.Bounds.IntersectsWith(Cactus12.Bounds))
            {
                if (goRight == true)
                {
                    Trex.Image = Properties.Resources.dead;
                }
                if (goLeft == true)
                {
                    Trex.Image = Properties.Resources.deadLeft;
                }
                endGame();
            }

            if (!(Trex.Left + Trex.Width > woodBox.Left && Trex.Left + Trex.Width < woodBox.Left + woodBox.Width + Trex.Width) && Trex.Top + Trex.Height >= woodBox.Top && Trex.Top < woodBox.Top)
            {
                jump = true;
            }

        }



        private void GamePlay_Page_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D) { goRight = false; }
            if (e.KeyCode == Keys.A) { goLeft = false; }
        }

        public void Clock_Tick(object sender, EventArgs e)
        {
            Time.Text = clock.ToString();
            clock++;
            /* if (clock==1)
             {
                 Cactus3.Top -= Cactus3.Height;

             }
             if(clock==2)
             {
                 Cactus2.Top = woodBox3.Top - Cactus2.Height;
             }*/

        }

        private void Cactus1_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (clock == 3)
            {
                Meteorite2.Top += 150;
            }
        }

        private void Cactus11_Click(object sender, EventArgs e)
        {

        }

        private void rock9_Click(object sender, EventArgs e)
        {

        }

        private void rock7_Click(object sender, EventArgs e)
        {

        }

        private void Cactus3_Click(object sender, EventArgs e)
        {

        }

        private void Meteorite4_Click(object sender, EventArgs e)
        {

        }

        private void Trex_Click(object sender, EventArgs e)
        {

        }

        private void endGame()
        {
            timer1.Stop();
            /*endGame_Page loseWindow = new endGame_Page();
            loseWindow.Show();
            */
        }
    }
}
