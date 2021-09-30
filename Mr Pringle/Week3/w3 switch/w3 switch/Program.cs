using System;

namespace w3_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter colour");
            string colour = Console.ReadLine();
            switch (colour)
            {
                case "black":
                    Console.WriteLine("black colour");
                    break;
                case "red":
                    Console.WriteLine("red colour");
                    break;
                case "green":
                    Console.WriteLine("green colour");
                    break;
                default:
                    Console.WriteLine("Unknown Colour");
                    break;
            }


        }
    }
}
