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

            int scoretwo = 20;

            while (scoretwo > 1)
            {
                scoretwo--;

                if (scoretwo == 10)
                {
                    continue;
                }
                Console.WriteLine("Your Score is now: " + scoretwo);

            }


            Console.WriteLine("*******************************************");

            Console.WriteLine("Select an operation: \n1. Addition\n2. Subtraction\n3. Devision\n4. Multiplication");
            int selection = Int32.Parse(Console.ReadLine());

            while (selection != 1 && selection != 2 && selection != 3 && selection != 4)
            {
                Console.WriteLine("You have to select one option!");
                Console.WriteLine("Please select one of the following operations:");
                Console.WriteLine("1. Addition\n2. Subtraction\n3. Devision\n4. Multiplication");
                selection = Int32.Parse(Console.ReadLine());

            }

            Console.WriteLine("That's a good choice!");

            Console.WriteLine("Select a number between 1 and 5");
            int selection2 = Int32.Parse(Console.ReadLine());

            while (selection2 !>=6)
            {
                Console.WriteLine("You have to select one option!");
                Console.WriteLine("Please select one of the following numbers:");
                Console.WriteLine("1, 2, 3, 4, 5");
                selection2 = Int32.Parse(Console.ReadLine());

            }

            Console.WriteLine("That's a good number!");

        }

    }
}    

