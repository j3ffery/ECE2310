using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECE2310_HW7_Q3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_calculate_Click(object sender, EventArgs e)
        {
            double sales, commission, tax = 0, contribution = 0, social = 0, net = 0;
            double.TryParse(textBox2.Text , out sales);
            
            if (sales > 0)
            {
                commission = sales * 0.07;
                tax = commission * 0.18;
                contribution = commission * 0.15;
                social = commission * 0.09;
                net = commission - (tax + contribution + social);

                textBox3.Text = Convert.ToString(tax);
                textBox4.Text = Convert.ToString(contribution);
                textBox5.Text = Convert.ToString(social);
                label9.Text = Convert.ToString(net);
            }
            else
            {
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }

            
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            label9.Text = "";
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
