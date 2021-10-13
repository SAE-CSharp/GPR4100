using System;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int ranNum = rand.Next();

            Console.WriteLine(ranNum);
            Console.WriteLine(rand.Next(5));
            Console.WriteLine(rand.Next(1,10));
            Console.WriteLine(rand.NextDouble());
        //    Console.WriteLine(rand.NextBytes());

        }
    }
}
