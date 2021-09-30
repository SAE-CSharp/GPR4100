using System;

namespace Enum
{
    class Program
    {

        enum difficulty { Easy= 'A', Medium= 'B', Hard= 'C' };
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your game difficulty: \nA-Easy \nB-Medium \nC-Hard");
            //int level = Int32.Parse(Console.ReadLine());
            char level = char.Parse(Console.ReadLine());

            switch (level)
            {
                case (char)difficulty.Easy: //1
                    Console.WriteLine("The level you chose is Easy!");
                    break;
                case (char)difficulty.Medium: //2
                    Console.WriteLine("This is the medium level!");
                    break;
                case (char)difficulty.Hard: //3
                    Console.WriteLine("This is the hardest level!");
                    break;
                default:
                    Console.WriteLine("This wasn't a valid option...");
                    break;
            }

        }
    }
}
