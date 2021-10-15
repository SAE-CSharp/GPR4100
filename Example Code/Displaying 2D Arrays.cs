// This code example is intended to demonstrate how to display the elements of a 2D array in a 2D layout,
// rather than displaying every element on a new line, and doing so neatly.

using System;

namespace ExampleCode_Displaying_2D_Arrays
{
    class Program
    {
        private static readonly Random getrandom = new Random();

        public static int GenRanInt(int min, int max)
        {
            lock (getrandom)
            {
                return getrandom.Next(min, max);
            }
        }

        // For an explanation of the code for random number generation, check out the relevant example
        // code file in the same folder as this!

        static void Main(string[] args)
        {
            // First off, we need the 2D array we're going to display. For now, we'll just use an integer
            // array that we can then fill with numbers, in this case 1-40 in order.

            int[,] num1to40 = new int[5, 8]
            {
                {1, 2, 3, 4, 5, 6, 7, 8},
                {9, 10, 11, 12, 13, 14, 15, 16},
                {17, 18, 19, 20, 21, 22, 23, 24},
                {25, 26, 27, 19, 29, 30, 31, 31},
                {33, 34, 35, 36, 37, 38, 39, 40},
            };

            // This array has 5 rows and 8 columns, which you could also describe as a height of 5 and a
            // width of 8. We could write the following code with those values "hard coded", but since
            // generalised code is typically more useful, we can read the width and height of the array
            // and assign those values to variables instead. To get that information from a 2D array,
            // we use the "GetLength" method, putting the index of the relevant dimension in the brackets.
            // Since the height is the first value, it has an index of 0, and the width has an index of 1.

            int arrayHeight = num1to40.GetLength(0);
            int arrayWidth = num1to40.GetLength(1);

            // Now we can use nested for loops to display the elements of the array. The first (outer)
            // loop will handle the rows, and the second (inner) loop will handle the columns. Make sure
            // to use a different local variable for the second loop!

            for (int i = 0; i < arrayHeight; i++)
            {
                for (int j = 0; j < arrayWidth; j++)
                {
                    // We want to display all the values from each row of the array on the same line, and
                    // for that, we can use "Console.Write()" rather than "Console.WriteLine()", as it
                    // doesn't write to a new line. Make sure to add a space afterwards so the numbers
                    // are separated.

                    Console.Write(num1to40[i, j] + " ");

                    // In order to space everything neatly, we can check how many digits the number has,
                    // and if it has fewer than 2 (i.e. if it's less than 10) we can add an extra space to
                    // keep the spacing even.

                    if (num1to40[i, j] < 10)
                    {
                        Console.Write(" ");
                    }
                }

                // When the second loop finishes, we've reached the end of a row, so we need to make sure
                // to start a new line.

                Console.Write("\n");
            }

            Console.WriteLine("");

            // That's only one method of spacing things - we can also make the numbers 1-9 display as
            // 01-09. To do that, we can use a similar method to what we just did, but we can also convert
            // the elements of the array to strings before displaying them. Rather than checking the value
            // of the element, we can then check its length directly using String.Length(). I'll also
            // display the array's elements in descending order this time.

            string intToString;
            for (int i = (arrayHeight - 1); i >= 0; i--)
            {
                for (int j = (arrayWidth- 1); j >= 0; j--)
                {
                    intToString = Convert.ToString(num1to40[i, j]);

                    if (intToString.Length == 1)
                    {
                        intToString = ("0" + intToString);
                    }

                    Console.Write(intToString + " ");
                }

                Console.Write("\n");
            }

            Console.WriteLine("");
        }
    }
}
