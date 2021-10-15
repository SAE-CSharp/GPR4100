using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            /*int[] myArray = new int[4] { 1, 2, 3, 4 };

            for (int i=0; i<myArray.Length; i++)
            {
                Console.WriteLine("The Array Elements Are: " + myArray[i]);
            }*/

            int[,] twoDimentionalArray = new int[3, 2]
            {
                {6,9 },
                {4,6 },
                {2,3 }
            };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j <2; j++)
                {
                    Console.WriteLine("The i =" + i + " and the j =" + j + " The Array Elements are: " + twoDimentionalArray[i, j]);
                }
            }
        }
    }
}
