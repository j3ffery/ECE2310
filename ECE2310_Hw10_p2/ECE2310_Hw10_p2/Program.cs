using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECE2310_Hw10_p2
{
    class BankAccount
    {
        protected string Name = "Jhon Doe";
        protected double Ammount = 400000;
        protected string ID = "2546853218";

    }

    class Checking : BankAccount
    {
        private string CardNum = "4568 3335 7566 4583";

        public override string ToString()
        {
            return "Name: " + Name + " CardNum: "+ CardNum + " Amount: " + Ammount ;
        }
    }

    class Saving : BankAccount
    {
        private string SerialNo = "10002005423";

        public override string ToString()
        {
            return "Name: " + Name + " SerialNo: " + SerialNo;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Checking A = new Checking();
            Saving B = new Saving();

            Console.WriteLine(A.ToString());
            Console.WriteLine(B.ToString());

            Console.ReadKey();
            
        }
    }
}
