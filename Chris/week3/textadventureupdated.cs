using System;

namespace textadventure
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            int answer;
            bool playeralive = true;

            if (playeralive == true)
            {
                Console.WriteLine("welcome to the game\nenter the number corresponding to the answer");
                Console.WriteLine("what is the second largest city in the uk?\n[1] Liverpool\n[2] Birmingham\n[3] Manchester");
                answer = Int32.Parse(Console.ReadLine());
                switch (answer)
                {
                    case 2:
                        Console.WriteLine("Correct!");
                        playeralive = true;
                        break;
                    default:
                        Console.WriteLine("Incorrect!");
                        playeralive = false;
                        break;
                }
                
            }
            if (playeralive == true)
            {
                Console.WriteLine("what is the largest country in the world?\n[1] Russia\n[2] Canada\n[3] USA");
                answer = Int32.Parse(Console.ReadLine());
                switch (answer)
                {
                    case 1:
                        Console.WriteLine("Correct");
                        playeralive = true;
                        break;
                    default:
                        Console.WriteLine("Incorrect!");
                        playeralive = false;
                        break;
                }

            }
            if (playeralive == true)
            {
                Console.WriteLine("The statue of liberty was a gift to the USA from which country?\n[1] Japan\n[2] France\n[3] UK");
                answer = Int32.Parse(Console.ReadLine());
                switch (answer)
                {
                    case 2:
                        Console.WriteLine("Correct!");
                        playeralive = true;
                        break;
                    default:
                        Console.WriteLine("Incorrect!");
                        playeralive = false;
                        break;
                }
            }
            if (playeralive == true)
            {
                Console.WriteLine("YOU WIN!");
            }
            else
            {
                Console.WriteLine("YOU LOSE!");
            }
            Console.WriteLine("Thanks for playing");
            Console.ReadLine();









        }

    }

}
