using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM.Control
{
    public partial class KeyBoard : UserControl
    {
        public KeyBoard()
        {
            InitializeComponent();
        }

        private void KeyBoard_Load(object sender, EventArgs e)
        {
            amount.Text = "";
        }

        private void One_Click(object sender, EventArgs e)
        {
            amount.Text += "1";
        }

        private void Two_Click(object sender, EventArgs e)
        {
            amount.Text += "2";
        }

        private void Three_Click(object sender, EventArgs e)
        {
            amount.Text += "3";
        }

        private void Four_Click(object sender, EventArgs e)
        {
            amount.Text += "4";
        }

        private void Five_Click(object sender, EventArgs e)
        {
            amount.Text += "5";
        }

        private void Six_Click(object sender, EventArgs e)
        {
            amount.Text += "6";
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            amount.Text += "7";
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            amount.Text += "8";
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            amount.Text += "9";
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            amount.Text += "0";
        }

        private void Zerozero_Click(object sender, EventArgs e)
        {
            amount.Text += "00";
        }

        private void Backspace_Click(object sender, EventArgs e)
        {
            if (amount.Text.Length > 0)
            {
                amount.Text = amount.Text.Substring(0, amount.Text.Length - 1);
            }
        }
        public float GetAmount()
        {
            return Convert.ToSingle(amount.Text);
        }
    }
}
