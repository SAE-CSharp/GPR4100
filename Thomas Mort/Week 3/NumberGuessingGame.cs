using System;

namespace Number_Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumberAnswer;
            int Guess1, Guess2, Guess3;


            Random randm = new Random();
            NumberAnswer = randm.Next(1, 100);

            Console.WriteLine("What is your first guess between 1-100?");
            Guess1 = Int32.Parse(Console.ReadLine());
            if (Guess1 == NumberAnswer)
            {
                Console.WriteLine("Well done! You got it on the first go!");
            }
            else if (Guess1 > NumberAnswer)
            {
                Console.WriteLine("Your answer of " + Guess1 + " Is higher than the answer! Try again!");
                Guess2 = Int32.Parse(Console.ReadLine());
                if (Guess2 == NumberAnswer)
                {
                    Console.WriteLine("Your answer is right! Well done!");
                }
                else if (Guess2 > NumberAnswer)
                {
                    Console.WriteLine("Your answer of " + Guess2 + " Is higher than the answer again.. Try again though!");
                    Guess3 = Int32.Parse(Console.ReadLine());
                    if (Guess3 == NumberAnswer)
                    {
                        Console.WriteLine("This is right! Well done!");
                    }
                    else if (Guess3 > NumberAnswer)
                    {
                        Console.WriteLine("This is still too high, im sorry..");
                    }
                    else if (Guess3 < NumberAnswer)
                    {
                        Console.WriteLine("This answer was too low.. Sorry!");
                        Console.WriteLine("\n The real answer was" + NumberAnswer);
                    }
                }
            }
            else if (Guess1 < NumberAnswer)
            {
                Console.WriteLine("Your answer of " + Guess1 + " Is lower than the answer! Try again!");
                Guess2 = Int32.Parse(Console.ReadLine());
                if (Guess2 == NumberAnswer)
                {
                    Console.WriteLine("Your answer is right! Well done!");
                }
                else if (Guess2 > NumberAnswer)
                {
                    Console.WriteLine("Your answer of " + Guess2 + " Is higher than the answer again.. Try again though!");
                    Guess3 = Int32.Parse(Console.ReadLine());
                    if (Guess3 == NumberAnswer)
                    {
                        Console.WriteLine("This is right! Well done!");
                    }
                    else if (Guess3 > NumberAnswer)
                    {
                        Console.WriteLine("This is still too high, im sorry..");
                    }
                    else if (Guess3 < NumberAnswer)
                    {
                        Console.WriteLine("This answer was too low.. Sorry!");
                        Console.WriteLine("\n The real answer was" + NumberAnswer);
                    }
                }
            }
        }
    }
}
