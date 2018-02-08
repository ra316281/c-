using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock
{
    class Program
    {
        static void Main(string[] args)
        {
            //user chooses 1= rock 2= scissors 3= paper
            //random number generator to result in a 1,2, or 3
            //we need a random number generator
            //if (rock == scissors)
            //{lblResult = rock wins }

            //step 1: create a random number generator that display a result of 1, 2 or 3
            //step 2: user enters a number 
            // step 3: making if statments
            string userString;
            int userGuess;
            int theRandomNumber;
            int rock = 1;
            int scissors = 2;
            int paper = 3;
            int score = 0;
            Random randomNumber = new Random();
            theRandomNumber = randomNumber.Next(1, 4);


            do
            {
                Console.WriteLine("Choose 1 = rock 2 = scissors 3 = paper!");
                userString = Console.ReadLine();
                userGuess = Convert.ToInt32(userString);
                if (theRandomNumber == 1)//rock
                {
                    if (userGuess == 1)
                        Console.WriteLine("Tie");
                    if (userGuess == 2)
                        Console.WriteLine("Lose");
                    if (userGuess == 3)
                    {
                        Console.WriteLine("Win");
                        score = score + 1;
                    }
                }
                if (theRandomNumber == 2)
                {
                    if (userGuess == 1)
                    {
                        Console.WriteLine("Win");
                        score = score + 1;
                    }
                        
                    if (userGuess == 2)
                        Console.WriteLine("Tie");
                    if (userGuess == 3)
                        Console.WriteLine("Lose");
                }
                if (theRandomNumber ==3)
                {
                    if (userGuess == 1)
                        Console.WriteLine("Lose");
                    if (userGuess == 2)
                    {
                        Console.WriteLine("Win");
                        score = score + 1;
                    }
                    
                    if (userGuess == 3)
                        Console.WriteLine("Tie");
                }
            


            }while(score != 5);
            



            



            
        }
    }
}
