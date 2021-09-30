using System;

namespace w3_game_difficulty
{
    class Program
    {
        enum difficulty { Easy='A', Medium='B', Hard='C', Insane='D' };
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your game difficulty!\nA. Easy\nB. Medium\nC. Hard\nD. Insane");
            //int diffChoice = Convert.ToInt32(Console.ReadLine());
            //string diffChoice = Console.ReadLine();
            char diffChoice = Convert.ToChar(Console.ReadLine());


            switch (diffChoice)
            {
                case (char)difficulty.Easy:
                    Console.WriteLine("You've chosen the difficulty Easy");
                break;
                case (char)difficulty.Medium:
                    Console.WriteLine("You've chosen the difficulty Medium");
                break;
                case (char)difficulty.Hard:
                    Console.WriteLine("You've chosen the difficulty Hard");
                break;
                case (char)difficulty.Insane:
                    Console.WriteLine("You're completely insane to choose this!\n\t\tWHY????");
                break;
                default:
                    Console.WriteLine("Unkown difficulty chosen, please turn back and try again.");
                break;
            }
        }
    }
}
