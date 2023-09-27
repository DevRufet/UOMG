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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox14.Text);
            double b = Convert.ToDouble(textBox13.Text);
            double c = Convert.ToDouble(textBox12.Text);
            double d = Convert.ToDouble(textBox11.Text);
            double f = Convert.ToDouble(textBox10.Text);
            double g = Convert.ToDouble(textBox9.Text);
            double h = Convert.ToDouble(textBox1.Text);
            double i = Convert.ToDouble(textBox5.Text);
            double j = Convert.ToDouble(textBox8.Text);
            double k = Convert.ToDouble(textBox7.Text);
            double l = Convert.ToDouble(textBox4.Text);
            double m = Convert.ToDouble(textBox3.Text);
            double n = Convert.ToDouble(textBox2.Text);
            double o = Convert.ToDouble(textBox6.Text);
            string cem = ((a * b + c * d + f * g + h * i + j * k + l * m+n*o) / (b + d + g + i + k + m+o)).ToString();
            MessageBox.Show(cem);
        }
    }
}
