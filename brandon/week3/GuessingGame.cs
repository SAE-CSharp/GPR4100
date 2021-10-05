using System;

namespace RandomNumGuess
{
    enum DIFF {EASY =1, MEDIUM = 2, HARD = 3}
    class Program
    {
        static void Main(string[] args)
        {
            int TurnCount = 0, Guess = 0;
            Random Num = new Random(); // Creates an instance of the Random class
            int Value = Num.Next(0,11); // generates a random number from 1 to 10
            bool Found = false;
            Console.WriteLine("Welcome, This is a random number guessing game\nWe will generate a number from 1 to 10"); 
            Console.WriteLine("you will  then have to guess it within the given number of turns");
            Console.WriteLine("Please enter the difficulty you\'d like to play on\nType \nType\'1\' for EASY\nType \'2\' for MEDIUM\nType \'3\' for HARD");
            int Difficulty = Int32.Parse(Console.ReadLine());

            switch (Difficulty)
            {
                case (int)DIFF.EASY:
                    TurnCount = 9;
                    Console.WriteLine("You have selected " + DIFF.EASY + " You will have " + TurnCount + " guesses");
                    break;

                case (int)DIFF.MEDIUM:
                    TurnCount = 6;
                    Console.WriteLine("You have selected " + DIFF.MEDIUM + " You will have" + TurnCount + " guesses");
                    break;

                case (int)DIFF.HARD:
                    TurnCount = 3;
                    Console.WriteLine("You have selected " + DIFF.HARD + " You will have " + TurnCount + " guesses");
                    break;

            }

                while (TurnCount != 0 && Found == false)
                {
                    Console.WriteLine("Please make your guess");
                    Guess = Int32.Parse(Console.ReadLine());
                    if (Guess == Value)
                    {
                        Console.WriteLine("Correct");
                        Found = true;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect, please guess again");
                        TurnCount -= 1;
                        Console.WriteLine("you have " + TurnCount + " guesses left");
                    }
                }

                if (Found == false)
                {
                    Console.WriteLine("Sorry, you fail");
                    Console.WriteLine("The number was " + Value);
                }
                else
                {
                    Console.WriteLine("Well done");
                }
            

            Console.ReadLine();
        }
    }
}
