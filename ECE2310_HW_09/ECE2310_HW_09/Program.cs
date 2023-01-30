using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECE2310_HW_09
{
    class Milk
    {
        private double unit_price;
        private int quantity;

        public Milk()
        {
            unit_price = 0;
            quantity = 0;
        }

        public Milk (double milk_unit_price, int milk_quantity)
        {
            unit_price = milk_unit_price;
            quantity = milk_quantity;
        }
        
        public double total_price()
        {
            return unit_price * quantity;
        }

        public override string ToString()
        {
            return "Milk\t$" + unit_price+ "\t" + quantity + "\r";
        }
    }
    class Bread
    {
        private double unit_price;
        private int quantity;

        public Bread(double bread_unit_price, int bread_quantity)
        {
            unit_price = bread_unit_price;
            quantity = bread_quantity;
        }

        public double total_price()
        {
            return unit_price * quantity;
        }
        
        public override string ToString()
        {
            return "Bread\t$" + unit_price + "\t" + quantity + "\r";
        }
    }
    class Eggs
    {
        private double unit_price;
        private int quantity;

        public Eggs(double eggs_unit_price, int eggs_quantity)
        {

            unit_price = eggs_unit_price;
            quantity = eggs_quantity;
        }

        public double total_price()
        {
            return unit_price * quantity;
        }

        public override string ToString()
        {
            return "Eggs\t$" + unit_price + "\t" + quantity + "\r";
        }
    }
    class Grocery
    {
        private Milk my_milk;
        private Bread my_bread;
        private Eggs my_eggs;

        public Grocery(Milk my_milk, Bread my_bread, Eggs my_eggs)
        {
            this.my_milk = my_milk;
            this.my_bread = my_bread;
            this.my_eggs = my_eggs;
        }

        public void expense()
        {
            Console.WriteLine("Milk total: $" + my_milk.total_price());
            Console.WriteLine("Bread total: $" + my_bread.total_price());
            Console.WriteLine("Eggs total: $" + my_eggs.total_price());
            Console.WriteLine();
            Console.WriteLine("Total: $" + (my_milk.total_price() + my_bread.total_price() + my_eggs.total_price()));
        }

        public override string ToString()
        {
            Console.WriteLine("Item\tPrice\tQuantity");
            Console.WriteLine(my_milk.ToString());
            Console.WriteLine(my_bread.ToString());
            return my_eggs.ToString();
            
            
        }
    }

    class Driver
    {
        public static void Main(string[] args)
        {

            Milk milk = new Milk(4.75,1);
            Bread bread = new Bread(2.50, 2);
            Eggs eggs = new Eggs(4.00, 3);
            Grocery grocery = new Grocery(milk, bread, eggs);
            Console.WriteLine(grocery.ToString());
            Console.WriteLine();
            grocery.expense();
            Console.ReadLine();


        }
    }
}
