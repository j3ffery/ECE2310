using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECE2310_Hw10
{
    class Student 
    {
        private string first_name;
        private string last_name;
        private GraduateStudent GS;
        private UnderGraduate UG;

        public Student(string first, string last, string inst, string deg)
        {
            first_name = first;
            last_name = last;
            GS = new GraduateStudent(inst, deg);
        }

        public Student(string first, string last, string stand)
        {
            first_name = first;
            last_name = last;
            UG = new UnderGraduate(stand);
        }


        public string ToString(string s)
        {
            return first_name + " " + last_name + " " + GS.ToString();
        }
        public override string ToString()
        {
            return first_name + " " +  last_name + " " + UG.ToString();
        }

    }

    class GraduateStudent
    {
        private string institution;
        private string degree;

        public GraduateStudent(string inst, string deg)
        {
            institution = inst;
            degree = deg;
        }

        public override string ToString()
        {
            return institution + " " + degree;
        }
    }

    class UnderGraduate
    {
        private string standing;

        public UnderGraduate(string stand)
        {
            standing = stand;
        }

        public override string ToString()
        {
            return standing;
        }
    }
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Student Jeff_Tan = new Student("Jeff","Tan","Sophomore"); 
            Student Jhon_Doe = new Student("Jhon", "Doe", "CPP","B.A.");

            Console.WriteLine(Jeff_Tan.ToString());
            Console.WriteLine(Jhon_Doe.ToString("s"));

            Console.ReadKey();

        }
    }
}
