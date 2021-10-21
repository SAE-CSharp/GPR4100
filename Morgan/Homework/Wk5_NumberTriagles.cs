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

            Console.WriteLine("\nHow many peaks do you want?");
            int numPeaks = Int32.Parse(Console.ReadLine());

            Console.WriteLine();
            
            int counter = 1;
            int modifier = 1;
            int[] countTrack = {inputVal, counter, modifier};

            int loopLen = (2 * numPeaks * (inputVal - 1)) + 1;

            for (int i = 0; i < loopLen; i++)
            {
                NumLine(countTrack[1]);
                countTrack = CountUpDown(countTrack);
            }

            Console.WriteLine();
        }
    }
}
