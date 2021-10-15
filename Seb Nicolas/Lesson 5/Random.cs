using System;

namespace Random
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random(); // create an instance of the class: Random

            Console.WriteLine(rand.Next(100));  // Return positive number less than 100

            Console.WriteLine(rand.Next(5)); // Return positive number less than 5

            Console.WriteLine(rand.Next(8)); // Return positive number less than 8

            Console.WriteLine(rand.Next(1, 8)); // Return value that includes the minimum be excludes the max
        }
    }
}
