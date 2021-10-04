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

            bool result = false;

            int turns = 3;

            while (turns != 0)
            {
                if (num == 12)
                {
                    result = true;
                    Console.WriteLine("Well done! Your guess was " + result + ".");
                    break;
                }

                else if (num != 12)
                {
                    turns = turns - 1;
                    result = false;
                    Console.WriteLine(result);
                    Console.WriteLine("Nice try, but your guess was " + result + ". Try again. You have " + turns + " turn(s) left.");
                    num = Convert.ToInt32(Console.ReadLine());
                }
            }


            Console.ReadLine();
        }
    }
}
