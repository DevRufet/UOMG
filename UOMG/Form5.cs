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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox10.Text);
            double b = Convert.ToDouble(textBox9.Text);
            double c = Convert.ToDouble(textBox1.Text);
            double d = Convert.ToDouble(textBox5.Text);
            double f = Convert.ToDouble(textBox8.Text);
            double g = Convert.ToDouble(textBox7.Text);
            double h = Convert.ToDouble(textBox4.Text);
            double i = Convert.ToDouble(textBox3.Text);
            double j = Convert.ToDouble(textBox2.Text);
            double k = Convert.ToDouble(textBox6.Text);
            string cem = ((a * b + c * d + f * g + h * i+j*k) / (b + d + g + i+k)).ToString();
            MessageBox.Show(cem);
        }
    }
}
