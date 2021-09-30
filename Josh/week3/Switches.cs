using System;

namespace Levels
{
    class Program
    {
        enum difficulty { Easy=1, Medium=2, Hard=3 };

        static void Main(string[] args)
        {
            string userInput, level;
            int elementValue;
            bool mainLoop = true;


            while (mainLoop)
            {
                Console.WriteLine("What level would you like to play? ( A:Easy\tB:Medium\tC:Hard  )");
                userInput = Console.ReadLine();
                userInput = userInput.ToUpper();

                switch (userInput)
                {
                    case ("A"):

                        Console.WriteLine("easy");
                        break;

                    case ("B"):

                        Console.WriteLine("medium");
                        break;

                    case ("C"):

                        Console.WriteLine("hard");
                        break;

                    default:

                        Console.WriteLine("Invalid input!");
                        break;

                }
                    









                Console.WriteLine("Would you like to go again? (Y/N)");
                userInput = Console.ReadLine();
                userInput = userInput.ToUpper();

                if (userInput == "N" || userInput == "NO")
                {
                    mainLoop = false;
                    break;
                }
                else
                {
                    Console.WriteLine("\n");
                }
            }
        }
    }
}
