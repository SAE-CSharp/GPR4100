using System;

namespace HomeworkGUESSINGgame2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("Guessing Game.");
            Console.WriteLine("I am thinking of a number between 1 and 100. You NEED to guess the Number, You have 5 attepmts.");
            int num = Convert.ToInt32(Console.ReadLine());

            bool result = false;
            Random rnd = new Random();
            int randomnum = rnd.Next(1, 100);
            int turns = 5;

            while (turns != 0)
            {
                if (num == randomnum)
                {
                    result = true;
                    Console.WriteLine("Well done! Your guess was " + result + ".");
                    break;
                }

                else if (num != randomnum)
                {
                    if (turns == 1)
                    {
                        Console.WriteLine("You have run out of Guesses the number was " + randomnum);
                        Console.WriteLine("Press enter to exit");
                        Console.ReadLine();
                        break;
                    }

                    else
                    {
                        turns = turns - 1;
                        result = false;
                        if (num < randomnum)
                        {
                            Console.WriteLine("Your Guess is lower than the chosen number ");
                        }
                        else
                        {
                            Console.WriteLine("Your guess is higher than the chosen number");
                        }
                        Console.WriteLine("Either you're just unlucky or your really bad, either way your guess was " + result);
                        Console.WriteLine("Try again, Just enter another number");
                        num = Convert.ToInt32(Console.ReadLine());
                    }
                }

            }
        }
    }
}
