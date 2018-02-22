using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
// Program averages four numbers
using System.Console;
class DebugSix02
{
   static void Main()
   {
      int[] numbers = {12, 15, 22, 88};
      int x;
      double average;
      double total = 0;
       {
           Console.WriteLine("\nThe numbers are...");
       }
      
      for(x = 0; x < numbers.Length; ++x)
         Console.WriteLine("{0, 6}", numbers[x]);
         Console.WriteLine();   
   
      for(x = 0; x < numbers.Length; ++x)
      {
         total = numbers[x];
      }   
      average = total / numbers.Length;
      Console.WriteLine("The average is {0}");
   }
}
