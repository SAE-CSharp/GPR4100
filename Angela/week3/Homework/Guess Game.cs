using System;

namespace Homework_week3
{
    class Program
    {
        static void Main(string[] args)
        {
            int favouriteNumber = 7;
            int counter = 3;
            Console.WriteLine("Hi, I would like you to guess my favourite number. \nYou will have 3 tries. Good luck! Here is one tip: \nIt is between 1 and 10 :D");
            
            while (counter > 0)
            {
                
                int guess = Int32.Parse(Console.ReadLine());
                counter--;
                if (guess == favouriteNumber) 
                {
                    Console.WriteLine("Well done, you've guessed it !");
                    break;
                }
                else if (guess < favouriteNumber)
                {
                    Console.WriteLine("Sorry, your guess is too low :P ");
                    Console.WriteLine("You have "+counter + " tries");
                    continue;
                    
                }
                else if (guess > favouriteNumber)
                {
                    Console.WriteLine("Sorry, your guess is too high :P");
                    Console.WriteLine("You have " + counter + " tries");
                    continue;
                }
                
                Console.WriteLine("Sorry, you did not guess, you have " + counter + " tries");

            }
            
        }
    }
}
