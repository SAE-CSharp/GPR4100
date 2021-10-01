using System;

namespace textAdventure1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the text adventure game. welcome to level 1!. Don't be scared these are general questions." + "\n what is the biggest country in the world?\n 1. Russia \n 2. Canada ");
            int option = Int32.Parse(Console.ReadLine());
            int score = 0;
            switch (option)
            {
                case 1:

                    score += 1;
                    Console.WriteLine("Well done, you did great. your score now is: " + score + "\n Try out level 2!!!\n");
                    break;

                case 2:

                    score -= 1;
                    Console.WriteLine("your score now is: " + score);
                    Console.WriteLine("Incorrect answer, how about you try again with another question there will be a bonus point if correct" + "\n what is the population of Russia? \n 1. 130 million \n 2. 130 million \n 3. 144.1 million");
                    option = Int32.Parse(Console.ReadLine());
                    if (option == 3)
                    {
                        score += 2;
                        Console.WriteLine("Well done you got the bonus point, your score now is : " + score);
                    }
                    if(option == 1)
                    {
                        score -= 1;
                        Console.WriteLine("Incorrect answer, restart the game");
                    }
                    if(option == 2)
                    {
                        score -= 1;
                        Console.WriteLine("incorrect answer, restart the game");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid data");
                    break;

                case 3:
                    if (score >= 3)
                    {
                        Console.WriteLine("You are in second level in the game!!");
                    }
                    break;
            }
        }
    }
}
