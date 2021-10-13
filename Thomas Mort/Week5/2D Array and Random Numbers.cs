using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] intarr = new int[3, 2]{
            {9,4 }, //first row =0
            {3,9 }, //second row = 1
            {9,0 }, //third row = 2
        };

            Console.WriteLine(intarr[0, 0]);
            Console.WriteLine(intarr[0, 1]);
            Console.WriteLine(intarr[1, 0]);
            Console.WriteLine(intarr[1, 1]);
            Console.WriteLine(intarr[2, 0]);
            Console.WriteLine(intarr[2, 1]);

            Console.WriteLine("******************************************");
            int[,] arr = new int[3, 2]
            {
                {2,7 },
                {3,9 },
                {10,23 }
            };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    //Console.WriteLine(arr[i, j]);
                    Console.WriteLine("i= " + i + " j= " + j + " element is: " + arr[i, j]);
                }
            }
            Console.WriteLine("***********************************************************************************");
            int[,] D2Ar = new int[2, 2]
            {
            {3,6 },
            {9,10 }
            };
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("i= " + i + " J=" + j + " and the element is: " + D2Ar[i, j]);
                }
            }
            Console.WriteLine("***********************************************************************************");
            Random rand = new Random();
            Console.WriteLine(rand.Next(10, 14178)); // any int between them two
            Console.WriteLine(rand.Next()); //any number between -2 quadrillion and 2 quadrillion
            Console.WriteLine(rand.Next(100)); // anything less than that number
            Console.WriteLine(rand.NextDouble()); // anything between 0-1. for example, 0.5986747
        }
    }
}
