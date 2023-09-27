using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UOMG
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox16.Text);
            double b = Convert.ToDouble(textBox15.Text);
            double c = Convert.ToDouble(textBox14.Text);
            double d = Convert.ToDouble(textBox13.Text);
            double f = Convert.ToDouble(textBox12.Text);
            double g = Convert.ToDouble(textBox11.Text);
            double h = Convert.ToDouble(textBox10.Text);
            double i = Convert.ToDouble(textBox9.Text);
            double j = Convert.ToDouble(textBox1.Text);
            double k = Convert.ToDouble(textBox5.Text);
            double l = Convert.ToDouble(textBox8.Text);
            double m = Convert.ToDouble(textBox7.Text);
            double n = Convert.ToDouble(textBox4.Text);
            double o = Convert.ToDouble(textBox3.Text);
            double p = Convert.ToDouble(textBox2.Text);
            double q = Convert.ToDouble(textBox6.Text);
            string cem = ((a * b + c * d + f * g + h * i + j * k + l * m + n * o+p*q) / (b + d + g + i + k + m + o+q)).ToString();
            MessageBox.Show(cem);
        }
    }
}
