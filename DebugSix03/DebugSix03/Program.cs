using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugSix03
// Finds whether a book dealer carries a requested book
using System;
using System.Console;
class DebugSix03
{
   static void Main()
   {
      String[] books = {"Catch-22", "Harry Potter", "Programming Using C#", "Rich Dad, Poor Dad","The Deep", "Wizard of Oz"};
      int x;
      string entryString;
       int enterBook;
      Console.WriteLine("What book are you looking for? ");
      entryString = Console.ReadLine();
      enterBook = Convert.ToInt32(entryString);
      x  = Array.BinarySearch(books, enterBook);
      if(x < 0)
         Console.WriteLine("{0} not found", entryString);                      
      else
         Console.WriteLine("Yes, we carry {0}", entryString);   
   }
}
