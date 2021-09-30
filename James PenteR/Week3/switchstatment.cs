using System;

namespace exe5difflevel
{
    class Program
    {
        enum difficulty { Easy=1, Medium=2, Hard=3};
        static void Main(string[] args)
        {
            Console.WriteLine("Select your level difficulty\n 1.Easy \n 2.Medium \n 3.Hard");
            int gamelevel = Int32.Parse(Console.ReadLine());

            switch(gamelevel)
            {
                case (int)difficulty.Easy:
                    Console.WriteLine("you have chosen the easy way out");
                    break;

                case (int)difficulty.Medium:
                    Console.WriteLine("you have chosen an intermediate difficulty");
                    break;

                case (int)difficulty.Hard:
                    Console.WriteLine("you have chosen the hardest path!");
                    break;

            }


        }
    }
}

