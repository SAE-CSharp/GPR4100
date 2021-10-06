using System;

namespace GuessingGame
{
    class Program                                      
    {

        static void Main(string[] args)
        {
            Random randm = new Random();
            int randomNumber, usersNumber = 100, i = 0;
            var userInput = "";
            bool mainLoop = true;

            randomNumber = randm.Next(1, 11);

            Console.WriteLine("You have 3 attempts to guess the chosen number between 1 and 10.\n");
            while (mainLoop)
            {
                while (i < 3 && usersNumber != randomNumber)
                {
                    Console.WriteLine("What is your guess?");
                    userInput = Console.ReadLine();

                    //Validation (lines 24-27)
                    if (int.TryParse(userInput, out usersNumber))
                    {
                        if (usersNumber > 0 && usersNumber < 10)
                        {
                            //main code
                            i++;

                            if (usersNumber != randomNumber)
                            {
                                Console.WriteLine("\nYour guess was incorrect!");

                                if (i == 3)
                                {
                                    Console.WriteLine("\nYou are out of attempts.");
                                    break;
                                }
                                else if (usersNumber < randomNumber)
                                {
                                    Console.Write("My number is higher than yours.\n\nTry again\n");
                                    continue;
                                }
                                else if (usersNumber > randomNumber)
                                {
                                    Console.Write("My number is lower than yours.\n\nTry again\n");
                                    continue;
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nCongrats you guessed correctly!");
                                break;
                            }

                        }
                        else
                        {
                            Console.WriteLine("\nInvalid input");
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid input");
                        continue;
                    }
                }
                Console.WriteLine("\nThe number was " + randomNumber);





                //Repeat loop stuff
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("Would you like to go again? (Y/N)");
                userInput = Console.ReadLine().ToUpper();


                if (userInput == "N" || userInput == "NO")
                {
                    mainLoop = false;
                    break;
                }
                else
                {
                    Console.WriteLine("\n");
                    usersNumber = 100;
                    userInput = "";
                    i = 0;
                    continue;
                }
            }

        }
    }
}
