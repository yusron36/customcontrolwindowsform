using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControl
{
    public partial class MyCurrency : UserControl
    {
        public string Value
        {
            get
            {
                return this.metroTextBox1.Text = this.metroTextBox1.Text.Replace(".", "").Replace(",", "");
            }
            set
            {
                this.metroTextBox1.Text = value;
            }
        }
        public MyCurrency()
        {
            InitializeComponent();
        }

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            else
            {
            }
        }

        private void metroTextBox1_Enter(object sender, EventArgs e)
        {
            this.metroTextBox1.Text = this.metroTextBox1.Text.Replace(".", "").Replace(",", "");
        }

        private void metroTextBox1_Leave(object sender, EventArgs e)
        {
            decimal number;

            if (Decimal.TryParse(this.metroTextBox1.Text.Replace(",", ""), out number))
            {
                //number /= 1;
            }

            if (number >= 10)
            {
                this.metroTextBox1.Text = number.ToString("0,0");
            }
        }

    }
}
