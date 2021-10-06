using System;

namespace CodeExamples_RNG
{
    class Program
    {
        // ----------------------------------------------------- //
        
        private static readonly Random getrandom = new Random();

        public static int GenRanInt(int min, int max)
        {
            lock (getrandom)
            {
                return getrandom.Next(min, max);
            }
        }

        // ----------------------------------------------------- //

        // The code between the lines is the important part for allowing you to generate random numbers.
        // Make sure that it is within the curly brackets {} for "class Program", but NOT for "static void Main()"

        static void Main(string[] args)
        {
            // The following code is just to demonstrate how to use this method of random number generation

            Console.WriteLine("Enter the lower end of the range for a random number");
            int rngMin = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter the upper end of the range for a random number");
            int rngMax = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter how many numbers you want to generate:");
            int rngCount = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nGenerating " + rngCount + " random numbers from " + rngMin + " to " + rngMax + ".\n");
            // Repeats the information entered to the user

            for (int i = 0; i < rngCount; i++)
            {
                Console.WriteLine(GenRanInt(rngMin, rngMax));
            }
            // Generates a random number and prints it to the console as many times as the user requested
        }
    }
}
