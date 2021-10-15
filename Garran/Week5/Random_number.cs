using System;

namespace Random_number
{
    class Program
    {
        static void Main(string[] args)
        {
            //Use the random class

            Random rand = new Random(); // Create an instance of class Random


            Console.WriteLine(rand.Next());
            // Return a positive number less than 5 
            Console.WriteLine(rand.Next(5));

            // Return value that is included the min number but excluded the max
            Console.WriteLine(rand.Next(1, 9));
        }
    }
}
