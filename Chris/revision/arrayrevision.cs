using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 40, 50 };
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);
            Console.WriteLine(numbers[4]);
            numbers[2] = 100;
            Console.WriteLine(numbers[0]);

            int arrayLength = numbers.Length;
            Console.WriteLine(arrayLength);
            Console.WriteLine("*******************");


            string[] cities = { "London", "Liverpool", "Leeds" };
            Console.WriteLine(cities[2]);
            cities[2] = "Manchester";
            Console.WriteLine(cities[2]);
            int arraysize = cities.Length;
            Console.WriteLine(arraysize);

            float[] myfloatarray = { 1.1f, 2.6f, 5.5f, 6.9f, 10.2f, 12.4f };
            int len = myfloatarray.Length;
            Console.WriteLine(myfloatarray[0]);
            Console.WriteLine(myfloatarray[1]);
            Console.WriteLine(myfloatarray[2]);
            Console.WriteLine(myfloatarray[3]);
            Console.WriteLine(myfloatarray[4]);
            Console.WriteLine(myfloatarray[5]);

            char[] grades = { 'A', 'B', 'C', 'D' };
            int leng = grades.Length;

            int[] myarray = { 20, 30, 40 };

            //another way to declare and specify the length of the array
            int[] array1 = new int[4];
            array1[0] = 33;
            array1[1] = 1;
            array1[2] = 60;
            array1[3] = 2;

            // create float array using the second way
            float[] array2 = new float[5];
            array2[0] = 1.1f;
            array2[1] = 2.2f;
            array2[2] = 3.3f;
            array2[3] = 4.4f;
            array2[4] = 5.5f;

            Console.WriteLine(array2[0]);
            Console.WriteLine(array2[1]);
            Console.WriteLine(array2[2]);
            Console.WriteLine(array2[3]);
            Console.WriteLine(array2[4]);
            Console.WriteLine("************************");
            for (int i = 0; i <= 10; i++)
            {
                //first loop i=0
                //second loop i=1
                //third loop i=2
                Console.WriteLine("the value of i is " + i);
                if (i == 5)
                {
                    break;
                }
            }

            int[] intarray = { 1, 3, 6, 7, 8, 9, 8, 10, 11, 112 };
            int intarrayLength = intarray.Length;

            for (int i = 0; i < intarrayLength; i++)
            {
                Console.WriteLine("the value of i is:" + i + " the element is: " + intarray[i]);
            }

            string[] colors = { "red", "green", "blue", "yellow" };
            int len3 = colors.Length;
            Console.WriteLine("emter your favorite color: ");
            string option = Console.ReadLine();

            for (int i = 0; i < len3; i++)
            {
                Console.WriteLine("the value of i is: " + i + " the element is: " + colors[i]);
                if (option == colors[i])
                {
                    Console.WriteLine("your favorite color is " + i);
                    break;
                }



            }

            string[] campus = { "liverpool", "london", "oxford", "glasgow" };
            int len4 = campus.Length;
            Console.WriteLine("what campus to you study at: ");
            string option1 = Console.ReadLine();
            for (int i = 0; i < len4; i++)
            {
                Console.WriteLine("the value of i is: " + i + " the element is: " + campus[i]);
                if (option1 == campus[i])
                {
                    Console.WriteLine("you study at " + i);
                    break;
                }
            }

            int[] arr1 = new int[4];
            int len5 = arr1.Length;

            for (int i = 0; i < len5; i++)
            {
                arr1[i] = i;
                Console.WriteLine("the i is: " + i + " and the element is: " + arr1[i]);
            }
            int[,] twodimentional =
            {
                {2,5 },
                {0,10},
                {10,6 }
            };
             //nested for loop
             for (int i = 0;i < 3; i++)//rows
            {
                for (int j=0;j<2;j++)
                {
                    Console.WriteLine("the element is " + twodimentional[i, j]);
                }
            }
            
             
            




        }  
    }
}
