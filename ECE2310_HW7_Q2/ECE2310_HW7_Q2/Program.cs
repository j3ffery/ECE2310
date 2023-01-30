using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECE2310_HW7_Q2
{
    class Program
    {
        public static int intergerPower(int Base, int exponent)
        {
            int result = Base;
            for ( int i = 0; i < exponent - 1; i++)
            {
                result = result * Base;
            }
            return result;
        }
        static void Main(string[] args)
        {
            int result = intergerPower(2, 10);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
