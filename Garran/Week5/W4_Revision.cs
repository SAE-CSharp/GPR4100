using System;

namespace W4_Revision
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an int array with 6 elements
            // for loop to display the array's elements

         /*   int[] myArray = new int[4] { 1, 2, 3, 4 };

            for (int i = 0;i<myArray.Length;i++)
            {
                Console.WriteLine("The array elements are: " + myArray[i]);
            }*/

            //Create a 2D dimensional array with 3 rows and 2 columns
            //Each element in the 2D dimensional array is an array
            int[,] twoDimensionalArray = new int[3, 2] {
                {5, 6 }, // = 0 Represents the firsrt row in the 2D array
                {10, 0 }, // = 1 Represents the second row in the 2D array
                {11, 3 } // = 2
            
            };

            // Nested for loop

            //Outer loop
            for (int i = 0;i<3;i++)
            {
                for (int j=0;j<2;j++)
                {
                    Console.WriteLine("The i = : " + i + " the j = " + j + " the array elements are: " + twoDimensionalArray[i, j]);
                }
            }
        }
    }
}
