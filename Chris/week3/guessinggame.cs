using System;

namespace guessinggame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random n = new Random();
            int winningnum = n.Next(0, 50);
            bool win = false;

            do
            {
                Console.Write("Guess a number between 1 and 50: ");
                string num = Console.ReadLine();
                int i = int.Parse(num);

                if (i > winningnum)
                {
                    Console.WriteLine("guess lower");
                }
                else if (i < winningnum)
                {
                    Console.WriteLine("guess higher");
                }
                else if (i == winningnum)
                {
                    Console.WriteLine("YOU WIN!");
                    win = true;
                }
                Console.WriteLine();
            } while (win == false);
            Console.WriteLine("thanks for playing");


            
            
            
                
            

        }

    }

}
