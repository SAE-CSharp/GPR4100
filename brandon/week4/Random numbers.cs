using System;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            //will return any random number
            Console.WriteLine(rand.Next());
            // will return a number between 1 and 10(it will include the minimum value but exclude the maximum)
            Console.WriteLine(rand.Next(1, 11));
            // will return any posotive integer lower than 5
            Console.WriteLine(rand.Next(5));
            // will return a random floating point number between 0 and 1(will always be less than 1)
            Console.WriteLine(rand.NextDouble());
            //
            Byte[] byteArr = new byte[3];


        }
    }
}
