using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECE2310_HW7_Q1
{
    class Program
    {
        public static int[] score = new int[26] { 20, 30, 53, 62, 85, 64, 72, 100, 56, 0, 4, 68, 95, 35, 65, 55, 22, 33, 78, 65, 12, 32, 45, 68, 75, 13 };
        static void search(int find)
        {
            int j = 0;
            for(int i = 0; i < 26; i++)
            {
                if (score[i] == find)
                {
                    Console.WriteLine("Student #" + i + " earned " + score[i] + "%");
                    j++;
                }
            }
            if (j == 0)
            {
                Console.WriteLine("None of the students earned " + find + "%");
            }
        }
        static void Main(string[] args)
        {
            int output;
            string input;
            input = Console.ReadLine();
            int.TryParse(input, out output);
            search(output);
            Console.ReadLine();

        }
    }
}
