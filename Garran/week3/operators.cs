using System;

namespace ConsoleApp2
{
    class Program
    {
        enum Colours { Red, Green, Blue, yellow }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your favourite colour" + "\n 1.Red \n 2.Green\n 3.Blue \n 4.yellow");
            int favColour = Int32.Parse(Console.ReadLine());

            switch (favColour)
            {
                case 1:

                    Console.WriteLine("your favourite colour is " + Colours.Red);
                    break;
               
                case 2:

                    Console.WriteLine("your favourite colour is " + Colours.Green);
                    break;

                case 3:

                    Console.WriteLine("your favourite colour is " + Colours.Blue);
                    break;

                case 4:

                    Console.WriteLine("your favourite colour is " + Colours.yellow);
                    break;
                default:
                    Console.WriteLine("unknown colour");
                    break;
            }
        }
    }
}
