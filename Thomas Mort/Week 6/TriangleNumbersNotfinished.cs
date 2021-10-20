using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, j;
            Console.WriteLine("Choose your number: ");
            int count = Int32.Parse(Console.ReadLine());
            for (j = 0; j <= count; j++)
            {
                for (n = 1; n <= count; n++)
                {
                    Console.WriteLine(n);
                }
                Console.WriteLine("\n");
            }
        }
