using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week7
{
    public partial class Form3 : Form
    {
        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetValueForText1 = textBox1.Text;
            SetValueForText2 = textBox2.Text;
            if(Form3.SetValueForText1==Form1.SetValueForText1 && Form3.SetValueForText2 == Form1.SetValueForText2)
            {
                Form4 frm4 = new Form4();
                frm4.Show();
            }
            else
            {
                textBox1.Text = " ";
                textBox2.Text = " ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
        }
    }
}
