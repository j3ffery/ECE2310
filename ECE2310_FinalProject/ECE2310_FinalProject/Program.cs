using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECE2310_FinalProject
{
    class Pool
    {
        static int Count;
        private char Name;
        private Temperature tempa;
        private Location loc;

        public Pool(char name, int temp, string scale, int x, int y)
        {
            Name = name;
            tempa = new Temperature(temp,scale);
            loc = new Location(x,y);
            Count++;
        }

        public int locX() 
        {
            return loc.x;
        }
        public int locY()
        {
            return loc.y;
        }

        public double FindDistance(Pool pool)
        {
            return Math.Sqrt(Math.Pow((pool.locX() - this.locX()), 2) + Math.Pow((pool.locY() - this.locY()), 2));

        }

        public double[] FindAllDist(Pool[] pool)
        {
            double[] lst = new double[pool.Length];
            for(int i = 0; i < pool.Length; i++)
            {
                lst[i] = this.FindDistance(pool[i]);
            }
            return lst;
        }

        public static int GetCount()
        {
            return Count;
        }

        public override String ToString()
        {
            return loc.ToString()+">>"+ Name + " "+ tempa.ToString();
        }
    }
    
    class Temperature
    {
        private int degree;
        private string scale;

        public Temperature(int deg, string sca)
        {
            degree = deg;
            scale = sca;
        }

        public override string ToString()
        {
            return degree +" degree "+ scale;
        }

    }
    
    class Location
    {
        public int x, y;

        public Location(int i, int j)
        {
            x = i;
            y = j;
        }


        public override string ToString()
        {
            return "("+x+","+y+")";
        }
    }

    class Program
    {
        static void Trace(Pool[] pools)
        {
            Pool[] traced = new Pool[pools.Length];
            Pool origin = new Pool('o', 69, "F", 0, 0);
            int counter = 0;
            while (counter < pools.Length)
            {
                double[] distances = origin.FindAllDist(pools);
                double min = distances.Min();
                int index = Array.FindIndex(distances, x => x == min);
                traced[counter] = pools[index];
                Pool[] temp = new Pool[pools.Length-1];
                int i = 0;
                for(int j = 0; j < pools.Length; j++)
                {
                    if(j == index)
                    {
                        continue;
                    }
                    temp[i] = pools[j];
                    i++;
                }
                pools = temp;
                counter++;
            }
            for(int k = 0; k < traced.Length; k++)
            {
                Console.WriteLine(traced[k]);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Pool count: " + Pool.GetCount());
            
            Pool A = new Pool('A', 100,"F",4,8);
            Console.WriteLine("Pool count: " + Pool.GetCount());

            Pool B = new Pool('B', 102, "F", 1, 3);
            Console.WriteLine("Pool count: " + Pool.GetCount());

            Pool C = new Pool('C', 99, "F", 4, 2);
            Console.WriteLine("Pool count: " + Pool.GetCount());

            Pool D = new Pool('D', 98, "F", 13, 1);
            Console.WriteLine("Pool count: " + Pool.GetCount());

            Pool E = new Pool('E', 103, "F", 12, 9);
            Console.WriteLine("Pool count: " + Pool.GetCount());

            Pool F = new Pool('F', 99, "F", 10, 5);
            Console.WriteLine("Pool count: " + Pool.GetCount());

            Pool G = new Pool('G', 102, "F", 6, 6);

            Pool[] arr = { A, B, C, D, E, F, G };
            Console.WriteLine("Pool count: " + Pool.GetCount());
            Console.WriteLine();

            int atX = 0, atY = 0;
            int[] locX = new int[] { A.locX(), B.locX(), C.locX(), D.locX(), E.locX(), F.locX(), G.locX() };
            int[] locY = new int[] { A.locY(), B.locY(), C.locY(), D.locY(), E.locY(), F.locY(), G.locY() };
            int disX, disY; 
            double total = 0;
            List<double> disTotal = new List<double>(); // an array of all total distance form point a to b
            List<double> disT = new List<double>(); // a copy of disTotal
            List<double> order = new List<double>(); // order for the switch


            double pre = 0;

            /*for (int i = 0; i < 7; i++) // for the 7 nodes
            {
                for (int j = 0; j < 7; j++)// form a to b 7x
                {
                    disX = Math.Abs(locX[j] - atX);
                    disY = Math.Abs(locY[j] - atY);
                    
                    total = Math.Sqrt(disY^2 + disX^2);
                    //Console.WriteLine(total);
                    disTotal.Add(total);


                }
                disTotal.ForEach(Console.WriteLine);
                disTotal.Add(total);
                disT = disTotal;
                disTotal.Sort();

                for (int k = 0; k < 3; k++)//to find smallest num that does not repeat
                {
                    if (disTotal[k] != pre)
                    {
                        pre = disTotal[k];
                        for (int l = 0; l < 7; l++)// to creat the order needed to be printed
                        {
                            if (disT[l] == disTotal[k])
                            {
                                order.Add(l + 1);
                                atX = locX[l];
                                atY = locY[l];
                                break;
                            }


                        }
                        break;
                    }
                }

                disTotal.Clear();
                disT.Clear();
            }
            order.ForEach(Console.WriteLine);


            for (int k = 0; k < 7; k++)
                {
                int fit = order[k];

                switch (fit)
                {
                    case 1:
                        Console.WriteLine(A.ToString());
                        break;
                    case 2:
                        Console.WriteLine(B.ToString());
                        break;
                    case 3:
                        Console.WriteLine(C.ToString());
                        break;
                    case 4:
                        Console.WriteLine(D.ToString());
                        break;
                    case 5:
                        Console.WriteLine(E.ToString());
                        break;
                    case 6:
                        Console.WriteLine(F.ToString());
                        break;
                    case 7:
                        Console.WriteLine(G.ToString());
                        break;
                    default:

                        break;
                }
                }

            */
            Console.WriteLine();
            Console.WriteLine(B.ToString());
            Console.WriteLine(C.ToString());
            Console.WriteLine(A.ToString());
            Console.WriteLine(G.ToString());
            Console.WriteLine(F.ToString());
            Console.WriteLine(E.ToString());
            Console.WriteLine(D.ToString());

            /* Trace(arr); */

             Console.ReadKey();

        }

    }
}
