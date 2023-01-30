using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW01_ECE2310
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles = 0, kilometer = 0;
            Console.WriteLine("Miles to kilometer");
            Console.Write("Miles: ");
            miles =Convert.ToDouble(Console.ReadLine());
            kilometer = miles * 1.60934;
            Console.WriteLine(Convert.ToString(miles)+ " miles = "+ Convert.ToString(kilometer)+ "kilometers");
            Console.ReadKey();
        }
    }
}
