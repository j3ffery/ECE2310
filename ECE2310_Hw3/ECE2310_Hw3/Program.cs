using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECE2310_Hw3
{
    class Program
    {
        static void Main(string[] args)
        {
            int shape;
            Console.WriteLine("What is your shape: 1.circle 2.rectangle 3.cylinder (type the number)");

            string input = Console.ReadLine();
            bool success = int.TryParse(input, out shape);
            
            while (shape < 1 || shape > 3)
            {
                Console.WriteLine("Enter the number for your shape: ");
                input = Console.ReadLine();
                success = int.TryParse(input, out shape);
            }
            double radius, hight, width;
            double circle, rectangle, cylinder;
            switch (shape)
            {
                case 1:
                    Console.WriteLine("what is the radius of your circle");
                    radius = Convert.ToDouble(Console.ReadLine());
                    circle = 3.14 * radius * radius;
                    circle = Math.Round(circle, 3);
                    Console.WriteLine(circle);
                    break;

                case 2:
                    Console.WriteLine("what is the hight of your rectangle");
                    hight = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("what is the width of your rectangle");
                    width = Convert.ToDouble(Console.ReadLine());
                    rectangle = hight* width;
                    rectangle = Math.Round(rectangle, 3);
                    Console.WriteLine(rectangle);
                    break;

                case 3:
                    Console.WriteLine("what is the radius of your cylinder");
                    radius = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("what is the hight of your cylinder");
                    hight = Convert.ToDouble(Console.ReadLine());
                    cylinder = 3.14 * radius * radius * hight;
                    cylinder = Math.Round(cylinder, 3);
                    Console.WriteLine(cylinder);
                    break;
            }

            {
                /*
                 int grade = 0, letter = 0;

                 Console.WriteLine("Please enter Grade ");

                 string input = Console.ReadLine();
                 bool success = int.TryParse(input, out grade);

                 if (grade >= 90)
                 {
                     letter = 1;
                 }

                 else if (grade >= 80 & grade < 90)
                 {
                     letter = 2;
                 }

                 else if (grade >= 70 & grade < 80)
                 {
                     letter = 3;
                 }

                 else if (grade >= 60 & grade < 70)
                 {
                     letter = 4;
                 }

                 else if (grade > 0 & grade < 60)
                 {
                     letter = 5;
                 }

                 else if (grade <= 0 || grade > 100)
                 {
                     letter = 6;
                 }

                 switch (letter)
                 {
                     case 1:
                         Console.WriteLine("A");
                         break;
                     case 2:
                         Console.WriteLine("B");
                         break;
                     case 3:
                         Console.WriteLine("C");
                         break;
                     case 4:
                         Console.WriteLine("D");
                         break;
                     case 5:
                         Console.WriteLine("F");
                         break;
                     case 6:
                         Console.WriteLine("Enter a value between 0 and 100");
                         break;
            */
            }// p2
            
            Console.ReadKey();
             
        }
    }
}

