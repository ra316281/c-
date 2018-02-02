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
          
            string usernum;
            int userg;
            int theNumber;
            int score = 0;
            Random randNumber = new Random();
            theNumber = randNumber.Next(1, 21);//that means 1-20


            do
            {
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
                    Console.WriteLine("The number you selected is correct ");
                //++score;
                score = score + 1;
                Console.WriteLine("score is "+score);
            } while (score != 5 || theNumber != userg);




            //Choose a number between 1 and 20
            //The number you selected was too high
            //The number you selected was too low
            //The number you selected is correct


        }
    }
}
