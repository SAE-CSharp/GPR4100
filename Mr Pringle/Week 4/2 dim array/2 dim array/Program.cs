using System;

namespace _2_dim_array
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////////////////////////////
            ///Two Dimentional Array
            int[,] intarr = new int[3, 2] //3 tall, 2 wide (2D Array)
            {
                {4,5},  //first element = 0
                {6,0},  //second element =1
                {3,1}  //third element = 2

            };

            Console.Write(intarr[0, 0]+", "); // will display 4 
            Console.WriteLine(intarr[0, 1]); // will display 5
            Console.Write(intarr[1, 0]+", "); // will display 6
            Console.WriteLine(intarr[1, 1]); // will display 0
            Console.Write(intarr[2, 0]+", "); // will display 3
            Console.WriteLine(intarr[2, 1]); // will display 1

            Console.WriteLine("//////");

            int[,] intarray = new int[2, 2]
            {
                {15,20 },
                {40,69 }
            };

            Console.Write(intarray[0, 0] + ", ");
            Console.WriteLine(intarray[0, 1]);
            Console.Write(intarray[1, 0] + ", ");
            Console.WriteLine(intarray[1, 1]);

            ////////////////////////////////////////////////////////////
            Console.WriteLine("//////////////////////////");
            //Nested for loop
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("i = " + i + " j = " + j + " element is: " + intarr[i, j]);
                    //Console.WriteLine(intarr[i, j]);
                }
            }

            Console.WriteLine("//////////////////////////");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("i = " + i + " j = " + j + " element is: " + intarray[i, j]);
                    //Console.WriteLine(intarr[i, j]);
                }
            }



        }
    }
}
