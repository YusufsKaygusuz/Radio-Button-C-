using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButton3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RB_Black_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            
            if(rb.Checked == true)
            {
                this.BackColor = Color.Black;
                this.ForeColor = Color.White;
            }

        }

        private void Rb_White_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_White.Checked == true)
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
            }
        }

        private void Rb_Blue_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_Blue.Checked == true)
            {
                this.BackColor = Color.AliceBlue;
                this.ForeColor = Color.Black;
            }
        }

        private void Rb_Green_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_Green.Checked == true)
            {
                this.BackColor = Color.DarkSeaGreen;
                this.ForeColor = Color.Black;
            }


        }
    }
}
