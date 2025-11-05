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
        int balance, bet = 0;
        public Bomb()
        {
            InitializeComponent();
            pictureBox1.BackColor = Color.Transparent;

            balance = int.Parse(File.ReadAllText("balance.txt"));
            label2.Text = $"{balance:F2}";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            bmp.MakeTransparent(Color.White);
            pictureBox1.Image = bmp;
        }
        private void refresh_bet()
        {
            textBox1.Text = bet.ToString("F2");
        }
        private bool CheckLegitOfBet(int a)
        {
            if (bet + a > balance)
            {
                MessageBox.Show("Недостатньо коштів на балансі");
                return true;
            }
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CheckLegitOfBet(50))
                return;
            bet += 50;
            refresh_bet();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CheckLegitOfBet(100))
                return;
            bet += 100;
            refresh_bet();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (CheckLegitOfBet(200))
                return;
            bet += 200;
            refresh_bet();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (CheckLegitOfBet(500))
                return;
            bet += 500;
            refresh_bet();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bet = balance;
            refresh_bet();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bet = 0;
            refresh_bet();
        }
    }
}
