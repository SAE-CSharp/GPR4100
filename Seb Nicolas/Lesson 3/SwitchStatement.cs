using System;

namespace SwitchStatement
{
    class Program
    {

        enum colours { Red, Green, Blue, Yellow };
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your favourite colour:" +
                 "\nA. Red \nB. Green \nC. Blue \nD. Yellow");

            char favColour = Char.Parse(Console.ReadLine());

            switch(favColour)
            {
                case 'A':
                    Console.WriteLine("Your favourite colour is: " + colours.Red);
                    break;
                case 'B':
                    Console.WriteLine("Your favourite colour is: " + colours.Green);
                    break;
                case 'C':
                    Console.WriteLine("Your favourite colour is: " + colours.Blue);
                    break;
                case 'D':
                    Console.WriteLine("Your favourite colour is: " + colours.Yellow);
                    break;
                default:
                    Console.WriteLine("Unknown Colour");
                    break;

            }
        }
    }
}
