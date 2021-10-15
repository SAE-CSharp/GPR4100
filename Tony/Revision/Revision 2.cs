using System;

namespace W4_revison
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] myarray = new int[6] { 1, 2, 3, 4, 5, 6 };

            for (int i=0; i<myarray.Length; i++)
            {
                Console.WriteLine("The array elements are " + myarray[i]);
            }

            int[,] twoDimensionalarray = new int[3, 2]{

                {5,6 },
                {1,3 },
                {6,2 }
            };
            //nested for loop

            //outer loop

            for (int i=0;i<3;i++){



                for (int j=0;j<2;j++)
                {
                    Console.WriteLine("the i =:"+i+"and the j =:"+j+ "array elements are: " + twoDimensionalarray[i, j]);
                }
            }
            
        }
    }
}
