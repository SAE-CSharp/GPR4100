using System;

namespace Higher_or_Lower_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Random num = new Random();
            int ranNum = num.Next(100, 150);
            //the following is to allow debugging
            //Console.WriteLine("The Random Number is: " + ranNum);

            int guessAmount = 5;
            Console.WriteLine("Let's play a game of Higher or Lower.\nEnter your first Guess, you only get 5!\n" +
                "I'll give you a hint the range is 100 - 150.");
            int guess = Convert.ToInt32(Console.ReadLine());


            while (guessAmount > 0)
            {
                if (guess > ranNum)
                {
                    guessAmount--;
                    Console.WriteLine("That's higher.\nRemaining guesses = "+guessAmount);
                    if (guessAmount > 0)
                    {
                        Console.WriteLine("Enter next guess!");
                        guess = Convert.ToInt32(Console.ReadLine());
                    }
                    continue;
                }
                else if (guess < ranNum)
                {
                    guessAmount--;
                    Console.WriteLine("That's lower.\nRemaining guesses = " + guessAmount);
                    if (guessAmount > 0)
                    {
                        Console.WriteLine("Enter next guess!");
                        guess = Convert.ToInt32(Console.ReadLine());
                    }
                    continue;
                }
                else if (guess == ranNum)
                {
                    guessAmount--;
                    Console.WriteLine("That's Correct!\nYou had "+guessAmount+" guesses left!");
                    break;
                }
            }

            if (guess == ranNum)
            {
                Console.WriteLine("Now that's game over. But you WON!");
            }
            else if (guess != ranNum)
            {
                Console.WriteLine("Now that's game over, you've lost.\nBetter luck next time.");
            }
            Console.ReadLine();
        }
    }
}
