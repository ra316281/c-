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
            string OrderName, strPizzaString;
            string answerUser;
            double UserAnswer;
            double orderNumber;                                           
            double numOrdered;
            int userAnswerEnd;
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


            
                Console.WriteLine("1 for Cheese Pizza {0}", cheesePizza);
                Console.WriteLine("2 for Chocolate Pizza {0}", chocolatePizza);
                Console.WriteLine("3 for Potato Pizza {0}", potatoPizza);
                Console.WriteLine("4 for Mini Apple Pie {0}", miniApplePie);
                Console.WriteLine("5 for Water {0}", water);
                Console.WriteLine("6 for Pop {0}", pop);

                Console.WriteLine("");

               
                do
                {
                    Console.WriteLine("What would you like to order?");
                    OrderName = Console.ReadLine();
                    orderNumber = Convert.ToInt32(OrderName);
                    if (orderNumber == 1)
                    {
                        Console.WriteLine("You ordered a Cheese Pizza how many do you want?");
                        strPizzaString = Console.ReadLine();
                        numOrdered = Convert.ToInt32(strPizzaString);

                        total = numOrdered * cheesePizzaPrice;
                        Console.WriteLine("The amount of Cheese Pizza that you ordered is {0} and the total price is {1}", numOrdered, total);
                    }

                    if (orderNumber == 2)
                    {
                        Console.WriteLine("You ordered a Chocolate Pizza how many do you want?");
                        strPizzaString = Console.ReadLine();
                        numOrdered = Convert.ToInt32(strPizzaString);

                        total = numOrdered * chocolatePizzaPrice;
                        Console.WriteLine("The amount of Chocolate Pizza that you ordered is {0} and the total price is {1}", numOrdered, total);
                    }

                    if (orderNumber == 3)
                    {
                        Console.WriteLine("You ordered a Potato Pizza how many do you want?");
                        strPizzaString = Console.ReadLine();
                        numOrdered = Convert.ToInt32(strPizzaString);

                        total = numOrdered * potatoPizzaPrice;
                        Console.WriteLine("The amount of Potato Pizza that you ordered is {0} and the total price is {1}", numOrdered, total);
                    }
                    if (orderNumber == 4)
                    {
                        Console.WriteLine("You ordered a Mini Apple Pie how many do you want?");
                        strPizzaString = Console.ReadLine();
                        numOrdered = Convert.ToInt32(strPizzaString);

                        total = numOrdered * miniApplePiePrice;
                        Console.WriteLine("The amount of Mini Apple Pie that you ordered is {0} and the total price is {1}", numOrdered, total);
                    }
                    if (orderNumber == 5)
                    {
                        Console.WriteLine("You ordered Water how many do you want?");
                        strPizzaString = Console.ReadLine();
                        numOrdered = Convert.ToInt32(strPizzaString);

                        total = numOrdered * waterPrice;
                        Console.WriteLine("The amount of Water that you ordered is {0} and the total price is {1}", numOrdered, total);
                    }
                    if (orderNumber == 6)
                    {
                        Console.WriteLine("You ordered Pop how many do you want?");
                        strPizzaString = Console.ReadLine();
                        numOrdered = Convert.ToInt32(strPizzaString);

                        total = numOrdered * potatoPizzaPrice;
                        Console.WriteLine("The amount of Pop that you ordered is {0} and the total price is {1}", numOrdered, total);
                    }
                    Console.WriteLine("Would you like total order anything else? yes or 7 for no!");
                    answerUser = Console.ReadLine();
                    userAnswerEnd = Convert.ToInt32(answerUser);

                   }
                while (userAnswerEnd != 7);
                {
                    Console.WriteLine("Thanks for ordering from Pizza House, hope you have a good rest of your day! The amount that you ordered is {0}, and your total is {1}", total);
                }
               
                
                
            //    Console.WriteLine("You ordered a " + orderNumber);

                
                

               

            

            
            
       }
    }
}
