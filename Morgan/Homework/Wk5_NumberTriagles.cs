using System;

namespace MCarpenter_Wk5_NumberTriangles
{
    class Program
    {
        // Prints a number sequence from 1 to given max value on a single line
        
        static void NumLine(int length)
        {
            for (int n = 1; n <= length; n++)
            {
                Console.Write(n + " ");
            }
            Console.Write("\n");
        }
        
        // Increments/decrements a counter each time it's run in an oscillating pattern
            // Arrays used to allow handling of multiple such counts within a program

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
            // Takes user input for the peak size of the number triangle(s)
            
            Console.WriteLine("Please enter a peak value for a number triangle.");
            int inputVal = Int32.Parse(Console.ReadLine());

            // Takes user input for the number of peaks to be printed

            Console.WriteLine("\nHow many peaks do you want?");
            int numPeaks = Int32.Parse(Console.ReadLine());

            // For neatness

            Console.WriteLine();
            
            // Sets initialising values for the oscillating counter
                // Could just as easily start from any point in the sequence
                // Or start in either direction

            int[] countTrack = {inputVal, 1, 1};

            // Calculates how many times the for loop needs to run based on peak height and count

            int loopLen = (2 * numPeaks * (inputVal - 1)) + 1;

            // Executes the custom methods the number of times required for the requested output

            for (int i = 0; i < loopLen; i++)
            {
                NumLine(countTrack[1]);
                countTrack = CountUpDown(countTrack);
            }

            // Also for neatness

            Console.WriteLine();
        }
    }
}
