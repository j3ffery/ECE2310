using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECE2310_Hw03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sales = 0.00, profit = 0.00;
            sales = Convert.ToDouble(textBox1.Text);
            if (sales < 1000.01)
            {
                profit = sales * 0.03;
                textBox2.Text = "$" + Convert.ToString( Math.Round(sales,2));
                textBox3.Text = "3%";
                textBox4.Text = "$" + Convert.ToString(Math.Round(profit,2));
            }
            else if(sales > 1000 & sales < 5000.01)
            {
                profit = sales * 0.035;
                textBox2.Text = "$" + Convert.ToString(Math.Round(sales, 2));
                textBox3.Text = "3.5%";
                textBox4.Text = "$" + Convert.ToString(Math.Round(profit, 2));
            }
            else if (sales > 5000 & sales < 10000.01)
            {
                profit = sales * 0.04;
                textBox2.Text = "$" + Convert.ToString(Math.Round(sales, 2));
                textBox3.Text = "4%";
                textBox4.Text = "$" + Convert.ToString(Math.Round(profit, 2));
            }
            else
            {
                profit = sales * 0.045;
                textBox2.Text = "$" + Convert.ToString(Math.Round(sales, 2));
                textBox3.Text = "4.5%";
                textBox4.Text = "$" + Convert.ToString(Math.Round(profit, 2));
            }
        }
    }
}
