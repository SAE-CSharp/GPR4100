using System;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("Welcome to the Guessing Game.");
            Console.WriteLine("I am thinking of a number between 1 and 20. What is it? You have three tries total.");
            int num = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();
            int nummy = rnd.Next(1, 20);

            bool result = false;

            int turns = 3;

            while (turns != 0)
            {
                if (num == nummy)
                {
                    result = true;
                    Console.WriteLine("Well done! Your guess was " + result + ".");
                    break;
                }

                else if (num != nummy)
                {
                    turns = turns - 1;
                    result = false;
                    Console.WriteLine("Nice try, but your guess was " + result + ".");
                    if (num < nummy)
                    {
                        Console.WriteLine("Your guess is lower than the number I am thinking of.");
                    }

                    else if (num > nummy)
                    {
                        Console.WriteLine("Your guess is higher than the number I am thinking of.");
                    }

                    Console.WriteLine("Try again. You have " + turns + " turn(s) left.");
                    if (turns != 0)
                    {
                        num = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
            if (turns == 0)
            {
                Console.WriteLine("The number I was thinking of was " + nummy + ".");
            }


            Console.ReadLine();
        }
    }
}
