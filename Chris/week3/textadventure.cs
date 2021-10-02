using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int decision;
            bool playeralive = true;

            Console.WriteLine("welcome to surviving the wild!\nchoose the best option to ensure your survival!");
            Console.WriteLine("you enecounter a wild tiger! what do you do?");
            Console.WriteLine(" [1] run for your life\n [2] look at it while slowly backing away");

        input1:
            decision = Int32.Parse(Console.ReadLine());
            switch (decision)
            {
                case 1:
                    Console.WriteLine("bad idea, turning your back on a tiger is showing your vunerable");
                    playeralive = false;
                    break;
                case 2:
                    Console.WriteLine("this is the best decision! you live to see another day!");
                    playeralive = true;
                    break;
                default:
                    Console.WriteLine("ERROR");
                    goto input1;

                    Console.ReadLine();

























            }

        }
    }
}
