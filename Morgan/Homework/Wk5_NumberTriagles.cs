using System;

namespace MCarpenter_Wk5_NumberTriangles
{
    class Program
    {
        static void NumLine(int length)
        {
            for (int n = 1; n <= length; n++)
            {
                Console.Write(n + " ");
            }
            Console.Write("\n");
        }
        
        static int[] CountUpDown(int[] arrayIn)
        {
            int[] arrayOut = new int[3];

            arrayOut[1] = arrayIn[1] + arrayIn[2];

            if (arrayIn[1] + arrayIn[2] == 1)
            {
                arrayOut[2] = 1;
            }
            else if (arrayIn[1] + arrayIn[2] == arrayIn[0])
            {
                arrayOut[2] = -1;
            }
            else
            {
                arrayOut[2] = arrayIn[2];
            }

            arrayOut[0] = arrayIn[0];
            return arrayOut;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a peak value for a number triangle.");
            int inputVal = Int32.Parse(Console.ReadLine());

            Console.WriteLine();
            
            int counter = 1;
            int modifier = 1;
            int[] printTrack = {inputVal, counter, modifier};

            for (int i = 0; i < (2 * inputVal) - 1; i++)
            {
                NumLine(printTrack[1]);
                printTrack = CountUpDown(printTrack);
            }

            Console.WriteLine();
        }
    }
}
