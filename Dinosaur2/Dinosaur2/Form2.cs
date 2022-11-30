using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dinosaur2
{
    public partial class Option_Page : Form
    {
        public Option_Page()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            GamePlay_Page.wplayer.controls.play();
            btn_Sound.Image = Properties.Resources.sound_on;
            GamePlay_Page.wplayer.settings.volume = trackBar1.Value;
            if (trackBar1.Value == 0)
            {
                btn_Sound.Image = Properties.Resources.sound_off;
            }
        }

        private void btn_sound_Click(object sender, EventArgs e)
        {

        }
    }
}

