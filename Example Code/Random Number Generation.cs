// This code example is intended to demonstrate how to set up and use random number generation in C# in
// a general way, so that it can be made use of anywhere it's needed in other code.

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
        // Make sure that it is within the curly brackets {} for "class Program", but NOT for
        // "static void Main()". The point to using this approach is consistency and reliability - it
        // ensures that the method won't generate the same number too many times in a row.

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
                Console.WriteLine(GenRanInt(rngMin, rngMax + 1));
            }
            // Generates a random number and prints it to the console as many times as the user requested
            // If you want the RNG to include the maximum value, you'll need to add 1 whne putting valued into the
            // method, as Next(int, int)
        }
    }
}
