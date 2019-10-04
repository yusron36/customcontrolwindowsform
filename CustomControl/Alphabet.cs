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
    public partial class Alphabet : UserControl
    {
        public string Value
        {
            get
            {
                return this.metroTextBox1.Text;
            }
            set
            {
                this.metroTextBox1.Text = value;
            }
        }

        public int MaxLength
        {
            get
            {
                return this.metroTextBox1.MaxLength;
            }
            set
            {
                this.metroTextBox1.MaxLength = value;
            }
        }

        public bool ReadOnly
        {
            get
            {
                return this.metroTextBox1.ReadOnly;
            }
            set
            {
                this.metroTextBox1.ReadOnly = value;
            }
        }

        public Alphabet()
        {
            InitializeComponent();
        }

        private void metroTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
