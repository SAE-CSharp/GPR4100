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
            int guesscount = 0;
            int guesslimit = 4;
            bool outofguesses = false;

            while ( !outofguesses)
            {
                Console.Write("Guess a number between 1 and 50: ");
                string num = Console.ReadLine();
                int i = int.Parse(num);

                if (i > winningnum && guesscount<guesslimit)
                {
                    Console.WriteLine("guess lower");
                    guesscount++;
                }
                else if (i < winningnum && guesscount<guesslimit)
                {
                    Console.WriteLine("guess higher");
                    guesscount++;
                }
                else if (i == winningnum)
                {
                    
                    win = true;
                    break;
                    
                }
                else
                {
                    outofguesses = true;
                }
                
            }
            if (outofguesses)
            {
                Console.WriteLine("YOU LOSE!");
            }
            else
            {
                Console.WriteLine("YOU WIN!");
            }













        }

    }

}
