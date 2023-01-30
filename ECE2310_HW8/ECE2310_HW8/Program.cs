using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECE2310_HW8
{
    class Employee
    {
        public int EmployeeNumber = 0;
        public string FirstName = "Jhon";
        public string LastName = "Doe";
        public double TotalSales = 0.00;

        public void Print()
        {
            Console.WriteLine("Employee Number: " + EmployeeNumber);
            Console.WriteLine("First Name: " + FirstName);
            Console.WriteLine("Last Name: " + LastName);
            Console.WriteLine("Total Sales: " + TotalSales);
        }
        public void TakeHomePay()
        {
            double TakeHomePay = 0.00;
            double Pay = 0.00;
         
            Pay = TotalSales * 0.09;
            TakeHomePay = Pay - (Pay * 0.18 + Pay * 0.10 + Pay * 0.06);
            Console.WriteLine("The take home pay after taxes is: $" + TakeHomePay);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee Mike = new Employee();
            Mike.EmployeeNumber = 1;
            Mike.FirstName = "Mike";
            Mike.LastName = "Tram";
            Mike.TotalSales = 60385;
            Mike.Print();
            Mike.TakeHomePay();

            Console.ReadKey();
        }
    }
}
