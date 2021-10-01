using System;

namespace switch_statement
{
    class Program
    {
        enum colors { Red, Green, Blue, Yellow };
        static void Main(string[] args)
        {


            Console.WriteLine("enter your favourite color\n A.Red \n B.Green \n C.Blue \n D.Yellow");
            char favColor = char.Parse(Console.ReadLine());

            switch (favColor)
            {
                case 'A':
                    Console.WriteLine("your favourite color is "+colors.Red);
                    break;

                case 'B':
                    Console.WriteLine("your favourite color is " + colors.Green);
                    break;

                case 'C':
                    Console.WriteLine("your favourite color is " + colors.Blue);
                    break;

                case 'D':
                    Console.WriteLine("your favourite color is " + colors.Yellow);
                    break;

                default:
                    Console.WriteLine("unknown color");
                    break;

            }
        }
    }
}
