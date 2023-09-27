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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b= Convert.ToDouble(textBox5.Text);
            double c= Convert.ToDouble(textBox4.Text);
            double d= Convert.ToDouble(textBox3.Text);
            double f= Convert.ToDouble(textBox2.Text);
            double g= Convert.ToDouble(textBox6.Text);
            string cem=((a*b+c*d+f*g)/(b+d+g)).ToString();
            MessageBox.Show(cem);
        }
    }
}
