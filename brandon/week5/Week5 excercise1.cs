using System;

namespace Week5_excercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] NewArray = new int[4] {1,2,3,4 };
            int Len = NewArray.Length;

            Console.WriteLine("----------1dArray----------------");
            Console.WriteLine();

            for(int i = 0; i < Len; i++)
            {
                Console.WriteLine(NewArray[i]);
            }

            Console.WriteLine();
            Console.WriteLine("----------2dArray---------------");
            Console.WriteLine();

            int[,] NewArray2 = new int[3,3] {
            {12, 23, 34},
            {45, 56,67 },
            {78,89,90}};

            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(NewArray2[i, j]);
                }
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();

        }
    }
}
