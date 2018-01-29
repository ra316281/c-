using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class DemoVariables2
    {
        static void Main(string[] args)
        {
            int value1 = 43, value2 = 10, sum, diff, product, quotient, remainder;

            sum = value1 + value2;
            diff = value1 - value2;
            product = value1 * value2;
            quotient = value1 / value2;
            remainder = value1 % value2;
            //Console.WriteLine("The sum of {0} and {1] is {2}",value1, value2, sum);
            //Console.WriteLine("The difference between {0} and {1}" + "is {2}", value1, value2, diff);
            Console.WriteLine("The product of {0} and {1} is {2}",value1, value2, product);
            Console.WriteLine("{0} divided by {1} is {2}", value1, value2, quotient);
            Console.WriteLine("and the remainder is {0]", remainder);

        }
    }
}
