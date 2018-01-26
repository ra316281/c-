using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class DemoEscapeSequences
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This line\tcontains two\ttabs");
            Console.WriteLine("This statement\ncontains a new line");
            Console.WriteLine("This statement sounds three alerts\a\a\a");
        }
    }
}
