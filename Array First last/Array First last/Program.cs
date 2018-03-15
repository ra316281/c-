using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_First_last
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
          //  String userChoice;
            int numChoice;

            Console.Write("Choose 1 for first to last\n2 for last to first \n and 3 for average >>> ");
            numChoice = Convert.ToInt32(Console.ReadLine());

            if (numChoice == 1)
            {
                for (int x = 0; x < 8; x = x + 1)
                {
                    Console.Write(numbers[x] +" ");
                }
            }
            if (numChoice == 2)
            {
                for (int x = 0; x > 8; x = x + 2)
                {
                    Console.Write(numbers[x] +" ");
                }
            }
            if (numChoice == 3)
            { 
                for (int x = 0; x == 8; x = x + 3)
                {
                    Console.Write(numbers[x] + " ");
                }
            }
        }
    }
}
