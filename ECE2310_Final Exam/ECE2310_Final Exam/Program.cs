using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECE2310_Final_Exam
{
    abstract class GraphObject
    {
        protected double area;
        protected double perimeter;

        public GraphObject()
        {
            area = cal_area();
            perimeter = cal_perimeter();
        }

        public abstract double cal_area();
        public abstract double cal_perimeter();

        public override string ToString()
        {
            return base.ToString();
        }
    }
    
    class RightTriangle : GraphObject
    {
        private int height;
        private int bas;

        public RightTriangle(int h, int b)
        {
            height = h;
            bas = b;
        }

        public override double cal_area()
        {
            return area = (height * bas * 0.5);
        }
        public override double cal_perimeter()
        {
            return perimeter = (Math.Sqrt(Math.Pow(height, 2) + Math.Pow(bas, 2)) + bas + height);
        }
        public override string ToString()
        {
            return "A triangle, height = " + height+ ", base = " + bas + ", area = " + area + ", perimeter = " + perimeter;
        }
    }

    class Square : GraphObject
    {
        private int segment;

        public Square(int s)
        {
            segment = s;
        }

        public override double cal_area() 
        {
            return area = Math.Pow(segment,2);
        }
        public override double cal_perimeter()
        {
            return perimeter = segment * 4;
        }
        public override string ToString()
        {
            return "A square, segment = " + segment + ", area = " + area + ", perimeter = " + perimeter;
        }
    }

    class Utilities
    {
        public static void FindLargest(double[] a, double[] p)
        {
            double Amax = a[0];
            int Aplace = 0;
            double Pmax = p[0];
            int Pplace = 0;

            for (int i = 0; i < 4; i++)
            {
                if (Pmax < p[i])
                {
                    Pmax = p[i];
                    Pplace = i + 1;
                }

                if (Amax < a[i])
                {
                    Amax = a[i];
                    Aplace = i + 1;
                }
            }
            Console.WriteLine("#" + Aplace + " object has the largest area of " + Amax);
            Console.WriteLine("#" + Pplace + " object has the largest Perimeter of " + Pmax);
        }

        static public int Max(params int[] ints)
        {
            var maxInt = int.MinValue;
            foreach (var number in ints)
            {
                if (number > maxInt)
                {
                    maxInt = number;
                }
            }
            return maxInt;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            GraphObject[] obj = new GraphObject[4];

            obj[0] = new RightTriangle(6, 8);
            obj[1] = new Square(8);
            obj[2] = new RightTriangle(5, 15);
            obj[3] = new Square(7);

            double[] A = new double[0];
            double[] P = new double[0];
            for (int i = 0; i < 4; i++)
            {
                obj[i].cal_perimeter();
                obj[i].cal_area();
                A = A.Concat(new double[] { obj[i].cal_area() }).ToArray();
                P = P.Concat(new double[] { obj[i].cal_perimeter() }).ToArray();
                Console.WriteLine("#" + (i + 1) + " object : " + obj[i].ToString());
            }
            Console.WriteLine();
            
            Utilities.FindLargest(A,P);

            {/*
            double Amax = obj[0].cal_area();
            int Aplace = 0;
            double Pmax = obj[0].cal_perimeter();
            int Pplace = 0;

            for (int i = 0; i < 4; i++)
            {
                if (Pmax < obj[i].cal_perimeter())
                {
                    Pmax = obj[i].cal_perimeter();
                    Pplace = i + 1;
                }
                
                if (Amax < obj[i].cal_area())
                {
                    Amax = obj[i].cal_area();
                    Aplace = i + 1;
                }
            }
            Console.WriteLine("#" + Aplace + " object has the largest area of " + Amax);
            Console.WriteLine("#" + Pplace + " object has the largest Perimeter of " + Pmax);
            */
            }

            Console.ReadKey();
        }
    }
}
