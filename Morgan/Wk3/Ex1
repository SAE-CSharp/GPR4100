using System;

namespace MCarpenter_Wk3_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first integer:");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter the second integer:");
            int b = Int32.Parse(Console.ReadLine());
            if ((a % b) == 0)
            {
                Console.WriteLine("\n" + a + " is evenly divisible by " + b + "\n");
            }
            else
            {
                Console.WriteLine("\n" + a + " is not evenly divisible by " + b);
                Console.WriteLine("The remainder of the division is " + (a % b) + "\n");
            }

            const float MILESTOKMRATE = 1.609f;

            Console.WriteLine("Input a distance in miles:");
            float dist = float.Parse(Console.ReadLine());
            float distConv = (float)Math.Round((dist * MILESTOKMRATE), 2);

            Console.WriteLine("\n" + dist + " miles = " + distConv + " km");
        }
    }
}
