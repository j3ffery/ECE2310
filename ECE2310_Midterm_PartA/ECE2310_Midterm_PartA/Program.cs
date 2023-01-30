using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECE2310_Midterm_PartA
{
    class Program
    {
        static void Seperate(int number)
        {
            int[] num = new int[5] { 0, 0, 0, 0, 0 };
            
            num[0] = (number - (number % 10000)) /10000;
            num[1] = (number - (number % 1000)- (number - (number % 10000))) / 1000;
            num[2] = (number - (number % 100)- (number - (number % 1000))) / 100;
            num[3] = (number - (number % 10) - (number - (number % 100))) / 10;
            num[4] = (number - (number % 1)- (number - (number % 10))) / 1;
            Console.WriteLine(num[0] + "," + num[1] + "," + num[2] + "," + num[3] + "," + num[4]);
        }
        static void Main(string[] args)
        {
            Seperate(25864);
            Console.ReadKey();
        }
    }
}
