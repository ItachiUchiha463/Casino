using Microsoft.VisualBasic;
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
    public partial class Profileend : Form
    {
        int balance=0;
        public Profileend()
        {
            InitializeComponent();
            int balance = int.Parse(File.ReadAllText("balance.txt"));
            label2.Text = $"{balance:F2}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = Interaction.InputBox("Введіть суму депозиту","Депозит","0");
            balance += int.Parse(name); 
            label2.Text = $"{balance:F2}";
            File.WriteAllText("balance.txt", balance.ToString());
            
        }
    }
}
