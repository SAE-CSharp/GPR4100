using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a score between '1' and '9'");
            int score = Int32.Parse(Console.ReadLine());

            if (score <= 9)
                while (score < 10)
                {
                    score++;
                    Console.WriteLine("Your Score is now: " + score);

                }
            else
            {
                Console.WriteLine("Sorry that number is too great!");
            }

            Console.WriteLine("*******************************************");

            Console.WriteLine("Please enter a score between '2' and '20'");
            int scoretwo = Int32.Parse(Console.ReadLine());

            if (scoretwo <= 20)
            while (scoretwo > 1)
            {
                score--;
                Console.WriteLine("Your Score is now: " + scoretwo);

            }

            else
            {
                Console.WriteLine("Sorry that number is too great!");
            }
        }

        }
    }

