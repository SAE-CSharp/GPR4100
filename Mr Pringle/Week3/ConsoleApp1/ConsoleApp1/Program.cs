using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter an Integer");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The reminder is:" + a % b + "\n");
            if ((a % b)== 0)
            {
                Console.WriteLine("a is evenly devisible by b");
            }
            else
            {
                Console.WriteLine("a is not devisable by b");
            }
        }
    }
}
