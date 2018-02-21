using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class fizz
    {
        static void Main(string[] args)
        {
            string numberguessed;
            string stringStop;
            string num3 = "Fizz";
            string num5 = "Buzz";
            string num7 = "Woof";
            string num15 = "FizzBuzz";
            const int Num3 = 3, Num5 = 5, Num7 = 7;
            int number;
           
           


      

            do 
            {
                 Console.WriteLine("Enter an integer!");
                numberguessed = Console.ReadLine();
                number = Convert.ToInt32(numberguessed);

                if (number/3 == 0 || number%3 == 0)
                {
                    Console.WriteLine("{0}", num3);
                }
                
                if (number == Num5)
                {
                    Console.WriteLine("{0}", num5);
                }

                if (number == Num7)
                {
                    Console.WriteLine("{0}",num7);
                }

                if (number / Num3 == Num3)
                {
                    Console.WriteLine("{0}", num3);
                }

                if (number == Num6)
                {
                    Console.WriteLine("{0}", num3);
                }

                if (number == Num10)
                {
                    Console.WriteLine("{0}", num5);
                }

                if (number == Num12)
                {
                    Console.WriteLine("{0}", num3);
                }

                if (number == Num14)
                {
                    Console.WriteLine("{0}", num7);
                }

                if (number == Num15)
                {
                    Console.WriteLine("{0}", num15);
                }
                Console.WriteLine("Enter an integer!");
                stringStop = Console.ReadLine();
               
            }while( stringStop != "stop" );
        }
    }
}
