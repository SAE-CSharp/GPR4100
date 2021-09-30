using System;

namespace exe5_difficultyLevel
{
    class Program
    {
        enum difficulty { Easy, Medium, Hard };

        static void Main(string[] args)
        {

            Console.WriteLine("Enter your chosen level \n 1 = Easy \n 2 = Medium \n 3 = Hard");
            int level = Int32.Parse(Console.ReadLine());

            switch(level)
            {
                case 1:
                    Console.WriteLine("You want to choose the easy level?");
                    break;
                case 2:
                    Console.WriteLine("You want to choose the medium level?");
                    break;
                case 3:
                    Console.WriteLine("You want to choose the hard level?");
                    break;

                default:
                    Console.WriteLine("You must choose a level");
                    break;
            }
        }
    }
}
