using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.AREA_OF_A_RECTANGLE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double A;
            double H;
            double L;
            double P;

            L = Convert.ToDouble(textBox1.Text);
            H = Convert.ToDouble(textBox2.Text);
         

            A = L * H;
            P = 2 * (L + H);
            textBox3.Text = A.ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double A;
            double H;
            double L;
            double P;

            L = Convert.ToDouble(textBox1.Text);
            H = Convert.ToDouble(textBox2.Text);

            A = L * H;
            P = 2 * (L + H);

            textBox4.Text = P.ToString();

        }
    }
}
