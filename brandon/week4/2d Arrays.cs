using System;

namespace _2d_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaring a 2d array
            // add a comma in the initial square brackets
            // the two numbers define the number of rows and columns
            int[,] intarr = new int[3, 2] {
            {2,4 },//first row = 0
            {34,56 },//second row = 1
            {789,123}//third row = 2
            
            };

            int[,] exampleArr = new int[2, 2]{
            {1,2 },
            {3,4 },
            };
            // nested for loop to read through the 2d array
            //outer loop
            for (int i = 0; i < 2; i++)
            {
                //inner loop
                for (int j = 0; j < 2; j++)
                {
                    // displaying elements from the 2d array
                    // square brackets specify the rown and column that should be used
                    Console.WriteLine("Example array--------"+exampleArr[i, j]);
                }
            } 

            // nested for loop to read through the 2d array
            //outer loop
            for(int i = 0; i < 3; i++)
            {
                //inner loop
                for(int j = 0; j < 2; j++)
                {
                    // displaying elements from the 2d array
                    // square brackets specify the rown and column that should be used
                    Console.WriteLine(intarr[i, j]);
                }
            }
            int[,] nARR = new int[2, 2]{
            {1,12 },
            {2,24 }
            };

            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j<2; j++)
                {
                    Console.WriteLine("i="+i+" j="+j+" element = "+ nARR[i, j]);
                }
            }


        }
    }
}
