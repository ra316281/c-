using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class InteractiveAddition
    {
        static void Main(string[] args)
        {
            string name, firstString, secondString;
            int first, second, sum;
            Console.WriteLine("Enter your name...");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0}! Enter the first integer...", name);
            firstString = Console.ReadLine();
            first = Convert.ToInt32(firstString);
            Console.WriteLine("Enter the second integer...");
            secondString = Console.ReadLine();
            second = Convert.ToInt32(secondString);
            sum = first + second;
            Console.WriteLine("{0}, the sum of {1} and {2} is {3}", name, first, second, sum);
        }
    }
}
