using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECE2310_Hw05
{
    class Program
    {
        
        public static void add()
        {
            int size_of_array = 26;
            string[] Name = new string[size_of_array];
            string Grade;
            int temp;
            int[] Score = new int[size_of_array];

            for (int i = 0; i < size_of_array; i++) // recording of all name and grade
            {
                Console.WriteLine("What is the name of the student and what grade did they get?");
                Name[i] = Console.ReadLine();
                Grade = Console.ReadLine();
                while (int.TryParse(Grade, out temp) == false)
                {
                    Console.WriteLine("Invalide input");
                    Grade = Console.ReadLine();
                }
                Score[i] = temp;

            }

            int total = 0, avg;
            for (int i = 0; i < size_of_array; i++) // find total of score
            {
                total = Score[i] + total;
            }
            avg = total / size_of_array;

            int highest_grade = 0, amount_above_avg = 0;
            string Name_high = "bob";
            for (int i = 0; i < size_of_array; i++) // finding highest grade, students above avarage grade
            {
                if (Score[i] > highest_grade)
                {
                    highest_grade = Score[i];
                    Name_high = Name[i];
                }

                if (Score[i] >= avg)
                {
                    amount_above_avg++;
                }
            }

            Console.WriteLine(String.Format("{0,-10} {1,-10}", "Name", "Score"));
            for (int i = 0; i < size_of_array; i++)
            {
                Console.WriteLine(String.Format("{0,-10} {1,-10}", Name[i], Score[i]));
            }

            Console.WriteLine(Name_high + " has the highest score " + highest_grade + " in the class.");
            Console.WriteLine("The average score of the class is " + avg);
            Console.WriteLine(amount_above_avg + " students are above average score.");
        }

        public static void search()
        {

        }
        
        static void Main(string[] args)
        {
            string inputstring;
            int input = 0;

            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1) add students");
            Console.WriteLine("2) search");
            Console.WriteLine("3) end program");
            inputstring = Console.ReadLine();
            int.TryParse(inputstring, out input);

            switch (input)
            {
                case 1:
                    add(); 
                    break;

                case 2:
                    search();
                    break;

                case 3:
                    Environment.Exit(0);
                    break;

            }
                Console.ReadLine();
        }
    }
}
