using System;

namespace GuessingGame
{
    class Program                                       // REVISION NOTES: Research how to check the validity of the datatype of inputted data
    {

        static void Main(string[] args)
        {
            Random randm = new Random();
            int randomNumber, userInput = 100, i = 0;

            randomNumber = randm.Next(1, 11);

            Console.WriteLine("You have 3 attempts to guess the chosen number between 1 and 10.\nWhat is your 1st guess?");

            while (i < 3 && userInput != randomNumber)
            {
                i++;
                userInput = Int32.Parse(Console.ReadLine());

                if (userInput != randomNumber)
                {
                    Console.WriteLine("Your guess was incorrect!");

                    if (i == 3)
                    {
                        Console.WriteLine("You are out of attempts.");
                        break;
                    }
                    else if (userInput < randomNumber)
                    {
                        Console.Write("My number is higher than yours.\nTry again\n");
                        continue;
                    }
                    else if (userInput > randomNumber)
                    {
                        Console.Write("My number is lower than yours.\nTry again\n");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Congrats you guessed correctly!");
                    break;
                }
            }
            Console.WriteLine("The number was " + randomNumber);
        }
    }
}
