using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            int[] numbers = { 2, 50, 3, 60, 10 };

            numbers[0] = 22;
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);
            Console.WriteLine(numbers[4]);

            Console.WriteLine("___________________________________________");


            string[] cities = { "Liverpool", " Moscow", "Berlyn" };
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            Console.WriteLine("___________________________________________");

            string[] student = { "Brendon", "Josh", "Daisy", "Alex", "Tiernagh", "Aaron", "Dalton", "Tommy", "James" };
            Console.WriteLine(student[0]);
            Console.WriteLine(student[1]);
            Console.WriteLine(student[2]);
            Console.WriteLine(student[3]);
            Console.WriteLine(student[4]);
            Console.WriteLine(student[5]);
            Console.WriteLine(student[6]);
            Console.WriteLine(student[7]);
            Console.WriteLine(student[8]);

            string secondStudent = student[1];

            int[] books = new int[4];
            // the number of elements of the array is 4
            //the last index is 3(0-3)(position)

            books[0] = 3;
            books[1] = 6;
            books[2] = 5;
            books[3] = 10;

            int[] num = { 10, 20, 30, 40 };
            int arrayLength = num.Length;
            Console.WriteLine(arrayLength);

            int[] numbers2 = new int[3];

            //for-loop
            Console.WriteLine("_________________________________________________________");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("the value of i: " + i);
            }

            Console.WriteLine("_________________________________________________________");

            int[] myNumbers = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            int arraysLength = myNumbers.Length;
            for (int i = 0; i < arraysLength; i++)
            {
                Console.WriteLine("the index is: " + i + " and the element is: " + myNumbers[i]);
            }

            Console.WriteLine("_________________________________________________________");

            string[] students = { "Brendon", "Josh", "Daisy", "Alex", "Tiernagh", "Aaron", "Dalton", "Tommy", "James" };
            int arrLenght = students.Length;

            for (int i = 0; i < arrLenght; i++)
            {
                Console.WriteLine("the " + i + " student name is: " + students[i]);
            }

            Console.WriteLine("_________________________________________________________");

            float[] myfloat = { 2.3f, 1.2f, 4.5f, 6.5f, 4.5f, 3.7f, 6.5f, 2.6f, 1.4f };
            int arrLen = myfloat.Length;

            for (int i = 0; i < arrLen; i++)
            {
                Console.WriteLine("the index is:" + i + " and it's ponts are:" + myfloat[i]);
            }


            Console.WriteLine("_________________________________________________________");
            string[] campuses = { "Liverpool", "London", "Oxford", "Glasgow" };
            int arLength = campuses.Length;

            for (int i = 0; i < arLength; i++)
            {
                Console.WriteLine("the " + i + " campus is " + campuses[i]);

                if (i == 0)
                {
                    Console.WriteLine("Hello Liverppol");
                }
                if (i == 1)
                {
                    Console.WriteLine("Hello London");
                }
                if (i == 2)
                {
                    Console.WriteLine("Hello Oxford");
                }
                if (i == 3)
                {
                    Console.WriteLine("Hello Glasgow");
                }
            }

            Console.WriteLine("_________________________________________________________");

            string[] camp = { "Liverpool", "London", "Oxford", "Glasgow" };
            int arLength1 = camp.Length;

            for (int i = 0; i < arLength1; i++)
            {
               


                if (i == 1)
                {
                     //skipping the campus London just says hello london 
                    Console.WriteLine("Hello London");
                    continue;
                }
                Console.WriteLine("the " + i + " campus is " + camp[i]);





            }
        }
    }
}
