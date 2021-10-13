using System;

namespace exeRandNums
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine(rand.Next(1,99));
            Console.WriteLine(rand.NextDouble());
            //Console.WriteLine(rand.NextBytes());

        }
    }
}
