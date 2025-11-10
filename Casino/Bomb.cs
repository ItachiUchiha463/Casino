using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Casino
{
    public partial class Bomb : Form
    {
        int balance, bet = 0;
        double multiplier = 1.0, crashPoint;
        bool isRunning = false;
        Random random = new Random();
        List<double> history = new List<double>(4);

        public Bomb()
        {
            InitializeComponent();
            pictureBox1.BackColor = Color.Transparent;

            LoadBalance();
            label2.Text = $"{balance:F2}";

            LoadHistory();
            UpdateBalance();
            refresh_bet();
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
            textBox2.Text = $"Ставка: {bet:F2}";
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

        private void SaveBalance() => File.WriteAllText("balance.txt", balance.ToString());

        private void UpdateBalance()
        {
            SaveBalance();
            label2.Text = $"{balance:F2}";
        }

        // Button1: "Зробити ставку" (button1_Click_1)
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (bet <= 0) { MessageBox.Show("Виберіть ставку!"); return; }
            if (isRunning) return;

            balance -= bet;
            UpdateBalance();

            crashPoint = 1.01 + random.NextDouble() * 9.99;
            multiplier = 1.0;
            isRunning = true;
            button1.Enabled = false;
            timer1.Start();
        }

        private void SaveHistory() => File.WriteAllLines("history.txt", history.Select(h => h.ToString()));

        private void AddToHistory(double coef)
        {
            history.Add(coef);
            if (history.Count > 50) history.RemoveAt(0);
            UpdateHistoryDisplay();
        }

        private void UpdateHistoryDisplay()
        {
            listBox1.Items.Clear();
            var last4 = history.TakeLast(4).ToList();
            foreach (var h in last4)
                listBox1.Items.Add($"{h:F2}x");
        }

        private void LoadHistory()
        {
            if (File.Exists("history.txt"))
            {
                var lines = File.ReadAllLines("history.txt");
                history = lines.Select(double.Parse).ToList();
                UpdateHistoryDisplay();
            }
        }

        private void EndRound(bool cashedOut)
        {
            timer1.Stop();
            isRunning = false;
            button1.Enabled = true;

            double coef = cashedOut ? multiplier : crashPoint;
            if (cashedOut)
            {
                int win = (int)(bet * multiplier);
                balance += win;
                MessageBox.Show($"Cash Out на {multiplier:F2}x! +{win}");
            }
            else
            {
                MessageBox.Show($"Краш на {crashPoint:F2}x! Втрачено {bet}");
            }

            AddToHistory(coef);
            bet = 0;
            refresh_bet();
            UpdateBalance();
            SaveHistory();
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
            bet += 250;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            multiplier += 0.1;
            label3.Text = $"{multiplier:F2}x";

            if (multiplier >= crashPoint)
            {
                EndRound(false);
            }
        }

        private void LoadBalance()
        {
            if (File.Exists("balance.txt"))
                balance = int.Parse(File.ReadAllText("balance.txt"));
            else
            {
                balance = 1000;
                SaveBalance();
            }
        }

        private void CashOut_Click(object sender, EventArgs e)
        {
            if (!isRunning) return;
            EndRound(true);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CashOut_Click(sender, e);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form1 form1Form = new Form1();

            // Показуємо її
            form1Form.Show();

            // (необов’язково) ховаємо головну форму Casino
            this.Close();
        }
    }
}