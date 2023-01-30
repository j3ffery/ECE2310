using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECE2310_Hw_07
{
    
    class Employee
    {
        // data members
        private int employee_num;
        private string first;
        private string last;
        private int mounthly_sal;

        public Employee(int employee_number, string first_name, string last_name, int mounthly_salary)
        {
            employee_num = employee_number;
            first = first_name;
            last = last_name;
            mounthly_sal = mounthly_salary;

           
        }

        double Yearly_salary( int mounthly_salary)
        {
            return (mounthly_salary * 12);
        }

        public void Info_print()
        {
            Console.WriteLine("Employee Number: " + employee_num);
            Console.WriteLine("First Name: " + first);
            Console.WriteLine("Last Name: " + last);
            Console.WriteLine("Mouthly Salary: $" + mounthly_sal);
            Console.WriteLine("Yearly Salary: $" + Yearly_salary(mounthly_sal));
            Console.WriteLine();
        }
    }

    class Test
    {
        static void Main(string[] args)
        {
            
            Employee Employee1 = new Employee(1, "Bob", "Tan", 390);
            Employee Employee2 = new Employee(2, "Joe", "Tram", 345);
            Employee1.Info_print();
            Employee2.Info_print();
            Console.ReadKey();
        }
    }
    
    
}
