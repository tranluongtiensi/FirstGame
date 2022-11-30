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
    public partial class winGamePage : Form
    {
        public winGamePage()
        {
            InitializeComponent();
            BG.Controls.Add(image);
            image.BackColor = Color.Transparent;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
