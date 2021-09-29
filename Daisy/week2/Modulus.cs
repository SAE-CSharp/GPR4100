using System;

namespace Week2Modulus
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Enter an integer");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter another integer");
            b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("The remainder is " + a % b + "\n");
            if ((a % b) == 0)
            {
                Console.WriteLine("a is evenly devisible by b");
            }
            else
            {
                Console.WriteLine("a is not evenly divisible by b");
            }

        }
    }
}
