using System;

namespace HomeworkWeek5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Jay!");
            Tri1();
            Tri2();
        }





        static void Tri1()
        {
            Console.WriteLine("Choose a number");
            int row, col, noofrow;
            noofrow = Int32.Parse(Console.ReadLine());
            for (row = 1; row <= noofrow; row++)
            {
                for (col = 1; col <= row; col++)
                {
                    Console.Write(row + " ");

                }
                Console.WriteLine();
            }
        }
        static void Tri2()
        {
            Console.WriteLine("Choose a number");
            int row, col, noofrow;
            noofrow = Int32.Parse(Console.ReadLine());
            for (row = 1; row <= noofrow; row++)
            {
                for (col = 1; col <= row; col++)
                {
                    Console.Write(row + " ");

                }
                Console.WriteLine();
            }
        }
    }
}
