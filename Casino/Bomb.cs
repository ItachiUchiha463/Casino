using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casino
{
    public partial class Bomb : Form
    {
        public Bomb()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            bmp.MakeTransparent(Color.White); // робимо білий фон прозорим
            pictureBox1.Image = bmp;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
