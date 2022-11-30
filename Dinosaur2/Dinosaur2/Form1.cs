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
    public partial class DINOSAUR_GAME : Form
    {
        public DINOSAUR_GAME()
        {
            InitializeComponent();
        }

        private void btn_Play_MouseLeave(object sender, EventArgs e)
        {
            btn_Play.Image = Properties.Resources.play_Normal;
        }
        private void btn_Option_MouseLeave(object sender, EventArgs e)
        {
            btn_Option.Image = Properties.Resources.option_Normal;
        }

        private void btn_Quit_MouseHover(object sender, EventArgs e)
        {
            btn_Quit.Image = Properties.Resources.quit_Hover;
        }

        private void btn_Quit_MouseLeave(object sender, EventArgs e)
        {
            btn_Quit.Image = Properties.Resources.quit_Normal;
        }

        private void btn_Option_Click(object sender, EventArgs e)
        {
            Option_Page option = new Option_Page();
            option.ShowDialog();
        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            GamePlay_Page gameWindow = new GamePlay_Page();
            gameWindow.Show();
        }

        private void btn_Play_MouseHover_1(object sender, EventArgs e)
        {
            btn_Play.Image = Properties.Resources.play_Hover;
        }

        private void btn_Option_MouseHover(object sender, EventArgs e)
        {
            btn_Option.Image = Properties.Resources.option_Hover;
        }
    }
}
