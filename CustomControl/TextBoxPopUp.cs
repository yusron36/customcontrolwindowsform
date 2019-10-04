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
    public partial class TextBoxPopUp : UserControl
    {

        public event EventHandler btnClick;
        public string Value
        {
            get
            {
                return this.textBox1.Text;
            }

            set
            {
                this.textBox1.Text = Value;
            }
        }

        public TextBoxPopUp()
        {
            InitializeComponent();
        }

        public void btn_Click(object sender, EventArgs e)
        {
            if(this.btnClick != null)
                this.btnClick(sender, e);
        }
    }
}
