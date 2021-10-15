using System;

namespace wk.Homework
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] myArray = new int[6] { 1, 2, 3, 4, 5 ,6};

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine("the array elements are: " + myArray[i]);

            }

            int[,] twoDimensionalArray = new int[3, 2]
            {
                {6,5 },
                {10,5 },
                {11,0 }
            };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("the i = : "+i+" the j= : " +j+" the array elements are : " + twoDimensionalArray[i, j]);
                }
            }
            

            Random rand = new Random();
            Console.WriteLine(rand.Next());
            Console.WriteLine(rand.Next(5));
            Console.WriteLine(rand.Next(1, 9));
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(i);
            }

           
           

            

            

        }
    }
}
