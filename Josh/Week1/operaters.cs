using System;

namespace EX2
{
    class Program
    {
        static void Main(string[] args)                                                 //Program starts here!!!!!!!!!
        {
            int x = 50, y = 10, result;
            result = (x + y);
            Console.WriteLine("Addition operater: " + result);
            result = (x - y);
            Console.WriteLine("Subtration operater: " + result);
            result = (x * y);
            Console.WriteLine("Multiplier operater: " + result);
            result = (x / y);
            Console.WriteLine("Division operater: " + result);                          //gives division with no remainders/franctions
            result = (x % y);                                                           //gives u the remainder of a division
            Console.WriteLine("Modulo operater: " + result);

            Console.WriteLine("###########################################################################################################");

            x = 7;
            y = 4;
            Console.WriteLine("the result of int/int is: " + x/y);
            Console.WriteLine("the result of float/int is: " + (float)x / y);
            Console.WriteLine("the result of int/float is: " + x / (float)y);
            Console.WriteLine("the result of float/float is: " + (float)x / (float)y);  //adding float gives the result of a division with a decimal

            Console.WriteLine("###########################################################################################################");

            x++;                                                                        //adds 1 top value of x
            y--;                                                                        //subracts 1 from y
            Console.WriteLine(x + "\t" + y);

            Console.WriteLine("###########################################################################################################");

            x += 2;                                                                      //Adds 2 to value of x
            x -= 2;
            y *= 2;
            y /= 2;

            Console.WriteLine("Press Enter Key to Exit. ");
            Console.ReadLine();        
        }
    }
}
