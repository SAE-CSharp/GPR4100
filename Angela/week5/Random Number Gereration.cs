using System;

namespace RandomNumberGeneration
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Console.WriteLine(rand.Next());
            Console.WriteLine(rand.Next(5));
            Console.WriteLine(rand.Next(1,11));
            Console.WriteLine(rand.NextDouble());
            //Console.WriteLine(rand.NextBytes()); not really usefull
        }
    }
}
