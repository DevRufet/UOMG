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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox7.Text);
            double d = Convert.ToDouble(textBox3.Text);
            double f = Convert.ToDouble(textBox6.Text);
            double g = Convert.ToDouble(textBox4.Text);
            double h = Convert.ToDouble(textBox5.Text);
            double i = Convert.ToDouble(textBox8.Text);
            string cem = ((a * b + c * d + f * g+h*i) / (b + d + g+i)).ToString();
            MessageBox.Show(cem);
        }
    }
}
