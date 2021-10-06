using System;

namespace MCarpenter_Wk3_NumGuessingGame
{
    class Program
    {
        private static readonly Random getrandom = new Random();

        public static int GenRanInt(int min, int max)
        {
            lock (getrandom)
            {
                return getrandom.Next(min, max);
            }
        }

        static void Main(string[] args)
        {
            /*int rangeMin = Int32.Parse(Console.ReadLine());
            int rangeMax = Int32.Parse(Console.ReadLine());
            int rangeSize = rangeMax - rangeMin + 1;

            for (int i = 0; i < (rangeSize * 2); i++)
            {
                Console.WriteLine(GetRanInt(rangeMin, rangeMax));
            }*/
            //The code in the above comment block was to test the behaviour of random number generation in C#

            int difficulty = 0, rangeMax;

        start:
            Console.Clear();

            Console.WriteLine("Welcome to my number guessing game! To begin, please pick a difficulty:\n  [1] Standard (1-20)\n  [2] Increased (1-30)\n  [3] High (1-50)");
            while (difficulty < 1 || difficulty > 3)
            {
                difficulty = Int32.Parse(Console.ReadLine());
                if (difficulty >= 1 && difficulty <= 3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Error: invalid selection - please try again\n\nTo begin, please pick a difficulty:\n  [1] Standard (1-20)\n  [2] Increased (1-30)\n  [3] Highest (1-50)");
                }
            }

            switch (difficulty)
            {
                case 1:
                    rangeMax = 20;
                    Console.Write("\nYou have selected Standard difficulty.");
                    break;

                case 2:
                    rangeMax = 30;
                    Console.Write("\nYou have selected Increased difficulty.");
                    break;

                case 3:
                    rangeMax = 50;
                    Console.Write("\nYou have selected Highest difficulty.");
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Error: unknown error. Restarting.");
                    goto start;
            }
            Console.Write(" The number you are guessing is from 1 to " + rangeMax + " (inclusive). You have 5 guesses.\n");

            int numToGuess = GenRanInt(1, rangeMax);
            int numGuessed = 0;
            int guessCount = 0;
            int guessesLeft = 5;
            string guessOrdinal = "";

            while (numGuessed != numToGuess)
            {
                switch (guessCount)
                {
                    case 0:
                        guessOrdinal = "first";
                        break;

                    case 1:
                        guessOrdinal = "second";
                        break;

                    case 2:
                        guessOrdinal = "third";
                        break;

                    case 3:
                        guessOrdinal = "fourth";
                        break;

                    case 4:
                        guessOrdinal = "final";
                        break;

                    default:
                        guessOrdinal = "INVALID";
                        break;
                }
                

                if (guessCount < 5)
                {
                    Console.WriteLine("Please enter your " + guessOrdinal + " guess.");
                    numGuessed = Int32.Parse(Console.ReadLine());
                    guessCount++;
                    guessesLeft--;
                }

                Console.Clear();
                Console.WriteLine("Your " + guessOrdinal + " guess was " + numGuessed + ".");

                if (numGuessed > numToGuess)
                {
                    Console.WriteLine("\nIncorrect - " + numGuessed + " is higher than the number to guess.\nGuesses remaining: " + guessesLeft + "\n");
                }
                else if (numGuessed < numToGuess)
                {
                    Console.WriteLine("\nIncorrect - " + numGuessed + " is lower than the number to guess.\nGuesses remaining: " + guessesLeft + "\n");
                }
            }

            if (numGuessed == numToGuess)
            {
                Console.WriteLine("\nCongratulations! You guessed the number!\n");
            }
            else
            {
                Console.WriteLine("\nYou are out of guesses. The number to guess was: ");
            }

            char restartConfirm = ' ';

            while(!(restartConfirm == 'y' || restartConfirm == 'n'))
            {
                Console.WriteLine("\nWould you like to play again? (y/n)");
                restartConfirm = Char.Parse(Console.ReadLine());
                if (restartConfirm == 'Y')
                {
                    restartConfirm = 'y';
                    break;
                }
                else if (restartConfirm == 'N')
                {
                    restartConfirm = 'n';
                    break;
                }

                Console.Clear();
                Console.WriteLine("Error: invalid input");
            }

            if (restartConfirm == 'y')
            {
                goto start;
            }
        }
    }
}
