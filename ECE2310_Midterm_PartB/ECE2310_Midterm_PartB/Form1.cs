using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECE2310_Midterm_PartB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static int[] num = new int[5] { 0, 0, 0, 0, 0 };


        private void Seperate(int times)
        {
            var rand = new Random();
            for (int i = 0; i < times; i++)
            {
                int number = rand.Next(0, 10000);

                num[0] = (number - (number % 10000)) / 10000;
                num[1] = (number - (number % 1000) - (number - (number % 10000))) / 1000;
                num[2] = (number - (number % 100) - (number - (number % 1000))) / 100;
                num[3] = (number - (number % 10) - (number - (number % 100))) / 10;
                num[4] = (number - (number % 1) - (number - (number % 10))) / 1;
                int sum = num[0] + num[1] + num[2] + num[3] + num[4];
                textBox2.Text += string.Format("{0,-10} {1,-10}",
                number , num[0] + " + " + num[1] + " + " + num[2] + " + " + num[3] + " + " + num[4] + " = " + sum  + "\r\n");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Seperate(3);
            

        }
    }
}
