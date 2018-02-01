using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace highNum_Lownum
{
    class Program
    {
        static void Main(string[] args)
        {
            const int theNumber = 10;
            string usernum;
            int userg;
            Console.WriteLine("Choose a number between 1 amd 20");
            usernum = Console.ReadLine();
            userg = Convert.ToInt32(usernum);
            if (userg > theNumber)
            {
                Console.WriteLine("The number you selected was too high");
            }
            else if (userg < theNumber)
            {
                Console.WriteLine("The number you selected was too low");
            }
            else if (userg == theNumber)
                Console.WriteLine("The number you selected is correct");

            



            //Choose a number between 1 and 20
            //The number you selected was too high
            //The number you selected was too low
            //The number you selected is correct


        }
    }
}
