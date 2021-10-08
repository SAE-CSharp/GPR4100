using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] numbers = { 10, 20, 30, 40, 50 };
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);
            Console.WriteLine(numbers[4]);
            Console.WriteLine(numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4]);

            Console.WriteLine("===============");
            Console.WriteLine(numbers[2]);
            numbers[2] = 100;
            Console.WriteLine(numbers[2]);
            Console.WriteLine("===============");

            int arrayNumber = numbers.Length;
            Console.WriteLine(arrayNumber);

            string[] cities = { "London", "Liverpool", "Stroud", "Paris" };

            Console.WriteLine(cities[0]);
            Console.WriteLine(cities[1]);
            Console.WriteLine(cities[2]);
            Console.WriteLine(cities[3]);
            Console.WriteLine(cities[0] + cities[1] + cities[2] + cities[3]);

            Console.WriteLine("===============");
            Console.WriteLine(cities[2]);
            cities[2] = "Vegas";
            Console.WriteLine(cities[2]);
            Console.WriteLine("===============");

            int arrayString = cities.Length;
            Console.WriteLine(arrayString);

            float[] myFloatArray = { 1.1f, 2.2f, 3.3f, 4.4f, 5.5f, 6.6f };

            Console.WriteLine("===============");
            int len = myFloatArray.Length;
            Console.WriteLine(myFloatArray[5]);
            Console.WriteLine(len);
            Console.WriteLine("===============");

            char[] grades = { 'A', 'B', 'C', 'D', 'F' };
            int gra = grades.Length;
            Console.WriteLine(grades[0]);
            Console.WriteLine(grades[1]);
            Console.WriteLine(grades[2]);
            Console.WriteLine(grades[3]);
            Console.WriteLine(grades[4]);
            Console.WriteLine("===============");
            Console.WriteLine(gra);
            Console.WriteLine("===============");

            int[] myArray = { 1, 2, 3, 4, 5, 6 };

            int[] array1 = new int[4];

            array1[0] = 100;
            array1[1] = 200;
            array1[2] = 300;
            array1[3] = 400;

            float[] arrayFloat = new float[5];

            arrayFloat[0] = 2.0f;
            arrayFloat[1] = 4.0f;
            arrayFloat[2] = 6.0f;
            arrayFloat[3] = 8.0f;
            arrayFloat[4] = 10.0f;

            Console.WriteLine(arrayFloat[0]);
            Console.WriteLine(arrayFloat[1]);
            Console.WriteLine(arrayFloat[2]);
            Console.WriteLine(arrayFloat[3]);
            Console.WriteLine(arrayFloat[4]);

            Console.WriteLine("==================");

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("The value of i is " + i);

                if (i == 5)
                {
                    break;
                }
            }*/

            /*int[] intArray = { 1, 2, 3, 4, 5, 6 };
            int arrLength = intArray.Length;

            for (int i=0; i< arrLength; i++)
            {

                Console.WriteLine("The value of i is: " + i + ". The Element is: " + intArray[i]);

            }

            string[] colors = { "red", "green", "blue", "yellow" };
            int arrayLength = colors.Length;

            Console.WriteLine("What if your Favourite Colour?");
            string options = Console.ReadLine();


            for (int i=0; i <= arrayLength; i++)
            {
                Console.WriteLine("The value of i is: " + i + ". The colour chosen is:" + colors[i]);

                if (options == colors[0])
                {
                    Console.WriteLine("Nice! We have the same favourite Colour.. RED!");
                    break;
                }
                if (options == colors[1])
                {
                    Console.WriteLine("Nice! Green is a nice colour!");
                    break;
                }
                if (options == colors[2])
                {
                    Console.WriteLine("Nice! Blue is a nice colour!");
                    break;
                }
                if (options == colors[3])
                {
                    Console.WriteLine("Nice! Yellow is a nice colour!");
                    break;
                }
                else
                {
                    Console.WriteLine("Unknown Format");
                    continue;
                }

                
            }*/

            int[] array5 = { 2, 4, 6, 8 };
            int len6 = array5.Length;

            for (int i = 0; i < len6; i++)
            {
                Console.WriteLine("The i is: " + i + ". The Element is: " + array5[i]);
            }

            int[] arr1 = new int[4];
            int len7 = arr1.Length;

            for(int i=0; i<len7;i++)
            {
                arr1[0] = i;
                Console.WriteLine("The i is: " + i);

            }


            int[,] intarr = new int[3, 2] { 
                { 3, 4 }, 
                { 3, 5 }, 
                { 5, 5 } 
            };

            for (int i=0; i<3; i++)
            {
                for (int j=0; j<2; j++)
                {
                    Console.WriteLine("The element is :" + intarr[i,j]);
                }
            }
        }
    }
}
