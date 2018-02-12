using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string cheesePizza = "$10.00";
            string chocolatePizza = "$14.50";
            string potatoPizza = "$12.20";
            string miniApplePie = "$5.00";
            string water = "$2.00";
            string pop = "$2.99";
            const double Tax_Rate = 0.07;
            double orderPrice;
            double total;
            double cheesePizzaPrice = 10.00;
            double chocolatePizzaPrice = 14.50;
            double potatoPizzaPrice = 12.20;
            double miniApplePiePrice = 5.00;
            double waterPrice = 2.00;
            double popPrice = 2.99;


            {
                Console.WriteLine("Cheese Pizza {0}", cheesePizza);
                Console.WriteLine("Chocolate Pizza {0}", chocolatePizza);
                Console.WriteLine("Potato Pizza {0}", potatoPizza);
                Console.WriteLine("Mini Apple Pie {0}", miniApplePie);
                Console.WriteLine("Water {0}", water);
                Console.WriteLine("Pop {0}", pop);

                Console.WriteLine("");

                Console.WriteLine("Enter your name...");
                name = Console.ReadLine();

                Console.WriteLine("");

                Console.WriteLine("{0} write your order here please...", name);
                

               

            }

            
            
       }
    }
}
