using System;

namespace exe2DArray
{
    class Program
    {
        static void Main(string[] args)
        {/*remove this to activate code
            int[,] intArray = new int[3, 2]

               { 
                {2,4 },//first element=0
                {5,6 },//second element=1
                {10,12 }//third element=2
               };


                
        
            Console.WriteLine(intArray[0, 0]);
            Console.WriteLine(intArray[0, 1]);
            Console.WriteLine(intArray[1, 1]);
            Console.WriteLine(intArray[2, 1]);
            Console.WriteLine(intArray[2, 0]);


            Console.ReadLine();

            for(int r = 0; r < 3; r++)//outer loop for rows
            {
                for(int c=0;c<2;c++)//inner loop for columns
                {
                    Console.WriteLine(intArray[r, c]);
                }
            }
            Console.ReadLine();
            remove this to activate code*/


            int[,] newArray = new int[2, 2]

               {
                {3,6 },//first element=0
                {4,8 }//second element=1
                
               };

            for (int i = 0; i < 2; i++)//outer loop for rows
            {
                for (int j = 0; j < 2; j++)//inner loop for columns
                {
                   
                    Console.WriteLine("i= " + i + " j= "+ j + " Element is: " + newArray[i, j]);
                    

                }
            }
        }
    }
}
