using System;

namespace ConsoleApp1
{
    class Program
    {
        private static object console;

        enum difficulty { Easy, Normal, Hard };

        enum months { jan, feb, mar, apr};

        enum metal { zinc=100, magnesium=200, gold=500, copper=10};

        static void Main(string[] args)
        {
            Console.WriteLine("enter your level!");
            level = Console.ReadLine();
            if (level == "easy")
            {
                int easy = (int)difficulty.Easy;

                Console.WriteLine("your level is easy");
            }

            {
                Console.WriteLine(" enter your favorite month!" + "\n 1.jan \n 2.feb \n 3. mar \n 4. apr")
                    int month = Int32.Parse(Console.ReadLine())
                    if (month == 1)
                {
                    Console.WriteLine(" your favourite month is " + jan)

                }
                else if (month == 2)
                {
                    Console.WriteLine(" your favourite month is " + feb)

                }
                else if (month == 3)
                {
                    Console.WriteLine(" your favourite month is" + mar)
                }
                if (month == 4)
                {
                    Console.WriteLine("your favourite month is" + apr)
                }
                else
                {
                    Console.WriteLine(" ");
                }

                Console.WriteLine("*************");

                Console.WriteLine("enter your favourite game \n 1. supermario");
                bool game = false;
                int gameName = Int32.Parse(Console.ReadLine());
                if (!game) {
                    Console.WriteLine("enter your favourite game please");
                }
                else
                {
                    Console.WriteLine("that is great your have choosen supermario");
                }
            }
            Console.WriteLine("enter yourfavourite color:\n 1.red 2.blue\n 3.green");
            int colors = Int32.Parse(Console.ReadLine());
            if (colors == 1 || colors == 2)
            {
                Console.WriteLine("wow this is my favourite color");
            }
            else
            {
                Console.WriteLine("i also like this color");
            }

            int zinc = (int)metal.zinc;
            Console.WriteLine(zinc);
            int magnessium = (int)metal.magnesium;
            Console.WriteLine(magnessium);
            int gold = (int)metal.gold
            Console.WriteLine(gold);
            int copper = (int)metal.copper
            Console.WriteLine(copper);
        }
}
