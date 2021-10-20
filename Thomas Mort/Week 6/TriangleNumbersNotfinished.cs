using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number would you like to use?");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= count; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.WriteLine(j);
                }
                Console.WriteLine("\n");
            }
        }
    }
}
