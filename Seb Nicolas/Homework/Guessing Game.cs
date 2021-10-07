using System;

namespace Gussing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ifguess = false;

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("================================================================");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nWelcome to Seb's Console Number Guessing Game\n");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("================================================================");


            Random rdm = new Random();
            int number = rdm.Next(1, 50);

            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\nGuess a number between 1 and 50: ");

                Console.ForegroundColor = ConsoleColor.White;
                int a = int.Parse(Console.ReadLine());

                if (a > number)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\n=====================");
                    Console.WriteLine("Guess a Lower number");
                    Console.WriteLine("====================");
                    
                }

                else if (a < number)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\n=====================");
                    Console.WriteLine("Guess a Higher number");
                    Console.WriteLine("=====================");
                    
                }

                else if (a == number)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n\n=================================");
                    Console.WriteLine("You Guessed the Number Correctly!");
                    Console.WriteLine("=================================");
                    break;
                    
                }
                Console.WriteLine();

            } while (ifguess == false);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Thank you for playing!");


        }
    }
}
