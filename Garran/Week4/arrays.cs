using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 40, 50 };
            Console.WriteLine(numbers[1]); //20
            Console.WriteLine(numbers[3]); //40
            Console.WriteLine(numbers[2]); //30
            Console.WriteLine(numbers[4]); //50

            Console.WriteLine(numbers[2]); //30
            numbers[2] = 100;
            Console.WriteLine(numbers[2]); //100

            int arrayLength = numbers.Length;
            Console.WriteLine(arrayLength);



            string[] cities = { "London", "Liverpool", "Leeds" };
            Console.WriteLine(cities[1]);

            Console.WriteLine(cities[2]); //Leeds
            cities[2] = "Manchester";
            Console.WriteLine(cities[2]); //Manchester
            int arralength = numbers.Length;

            float[] myfloatArray = { 1.1f, 2.6f, 5.5f, 6.9f, 10.2f, 12.4f };

            int len = myfloatArray.Length;
            Console.WriteLine(myfloatArray[5]);

            char[] grade = { 'A', 'B', 'C', 'D' };
            int leng = grade.Length;

            int[] myarray = { 20, 30, 40 };

            // another way to declare and specify the size/length of the array

            int[] array1 = new int[4];
            array1[0] = 30;
            array1[1] = 1;
            array1[2] = 60;
            array1[3] = 2;

            /*// Create float array using the second way
            float[] pos = new float[5];

            pos[0] = 1.9f;
            pos[1] = 3.4f;
            pos[2] = 4.3f;
            pos[3] = 6.7f;
            pos[4] = 9.3f;
            pos[5] = 7.2f;


            Console.WriteLine(pos[0]);
            Console.WriteLine(pos[1]);
            Console.WriteLine(pos[2]);
            Console.WriteLine(pos[3]);
            Console.WriteLine(pos[4]);
            Console.WriteLine(pos[5]);*/

            Console.WriteLine("******************************************");

            for (int i = 0; i < 10; i++)
            {
                //Fist loop i = 0 
                // 2nd loop i = 1
                // thrid loop i = 2
                Console.WriteLine("The value of i is : " + i);

                if (i == 5)
                {
                    break;
                }
            }
            int[] intArray = { 1, 3, 6, 7, 8, 9, 8, 10, 11, 112 };
            int arrlength = intArray.Length;

            for (int i = 0; i < arrlength; i++)
            {
                Console.WriteLine("The value of i is : " + i + "The element is: " + intArray[i]);
            }

            string[] colors = { "red", "green", "blue", "yellow" };

            int len3 = colors.Length;
            Console.WriteLine("Enter your favourite colour : ");
            string option = Console.ReadLine();

            for (int i = 0; i < len3; i++)
            {
                Console.WriteLine("The value of i is " + i + " The colour is: " + colors[i]);

                if (option == colors[1])
                {
                    Console.WriteLine("VERY GOOD, your favourite colour is red");
                    break;
                }
            }

            // the array starts from position 0
            int[] array5 = { 2, 4, 5, 6 };
            int len6 = array5.Length;

            for (int i = 0; i < len6; i++)
            {
                Console.WriteLine("the i is: " + i + "the element is : " + array5[i]);
            }

            int[] arr1 = new int[4];
            int len7 = arr1.Length;


            for (int i = 0; i < len7; i++)
            {

                arr1[0] = i;
                Console.WriteLine("the i is: " + i + " and the array element is:" + arr1[i]);
            }

            int[,] twoDiamentional = {
            {2,5 },
            {0,10 },
            {10,6 }

            };

            for(int i = 0; i < 3; i++) //Rows
            {
                for(int j = 0; j < 2; j++)
                {
                    Console.WriteLine("The element is " + twoDiamentional[i, j]);
                }
            }
        }
    
    }
}
