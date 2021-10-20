using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            int counter = 4;
            while (counter > 0)
            {
                // Entering the value of the variable n
                Console.Write("Enter the value of variable n:  ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine();
                // Printing the upper part of the triangle
                for (int i = 1; i <= n; i++)
                {
                    PrintLine(1, i);
                }
                // Printing the bottom part of the triangle
                // that is under the longest line
                for (int line = n - 1; line >= 1; line--)
                {
                    PrintLine(1, line);
                }

                counter--;
            }


        }
        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}


