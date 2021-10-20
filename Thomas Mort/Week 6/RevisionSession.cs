using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args) //this is the main method.
        {
            //position of the elements always starts at 0
            //an interger array
            // I declare my variable to the array.
            int[] MyArray = new int[5] { 20, 30, 40, 50, 60 }; // new int means its specificing the size of the array. the { means that you're adding elements to it } [ means thats how big it is]
            Console.WriteLine(MyArray[0]);
            Console.WriteLine(MyArray[0] + " " + MyArray[1]);
            Console.WriteLine(MyArray[0] + " " + MyArray[1] + " " + MyArray[2]);
            Console.WriteLine(MyArray[0] + " " + MyArray[1] + " " + MyArray[2] + " " + MyArray[3]);
            Console.WriteLine(MyArray[0] + " " + MyArray[1] + " " + MyArray[2] + " " + MyArray[3] + " " + MyArray[4]);
            Console.WriteLine(MyArray[0] + " " + MyArray[1] + " " + MyArray[2] + " " + MyArray[3]);
            Console.WriteLine(MyArray[0] + " " + MyArray[1] + " " + MyArray[2]);
            Console.WriteLine(MyArray[0] + " " + MyArray[1]);
            Console.WriteLine(MyArray[0]);

            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("**************************************************************************************************************");
            int[] SecondArray = new int[5] { 10, 20, 30, 40, 50 };
            int length = SecondArray.Length;
            //using for loop to display the elements
            //for loops start with (initialisation; condition; repetition)
            for (int i=0; i<length; i++)
            {
                if (i == 0)
                {
                    SecondArray[0] = 405;
                    Console.WriteLine("Hello " + SecondArray[0]);
                }

                if (i == 1)
                {
                    Console.WriteLine("Hello " + SecondArray[1]);
                }

                if (i == 2)
                {
                    Console.WriteLine("Hello " + SecondArray[2]);
                }

                if (i == 3)
                {
                    Console.WriteLine("Hello " + SecondArray[3]);
                }

                if (i == 4)
                {
                    Console.WriteLine("Hello " + SecondArray[4]);
                }
                Console.WriteLine("The Value of I is: " + i + " The element of I is: " +SecondArray[i]);
            }
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("**************************************************************************************************************");
            //a string array
            string[] cities = new string[3] { "London", "Manchester", "Liverpool" };
            int len = cities.Length;
            //displaying cities using a for loop
            for (int i = 0; i < len; i++)
            {
                if (i == 2)
                {
                    cities[2] = "Glasgow";
                }
                Console.WriteLine("Cities: " + cities[i]);
            }
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("**************************************************************************************************************");

            //2D Array!
            int[,] twoarr = new int[3, 2]
            {
                {10,15 },
                {7,9 },
                {3,2 }
            };
            for (int i = 0; i <3; i++)
            {
                for (int j=0; j<2; j++)
                {
                    Console.WriteLine(twoarr[i,j]);
                }
            }
             
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("**************************************************************************************************************");

            Console.WriteLine("Enter the size of your array:");
            int length1 = Convert.ToInt32(Console.ReadLine());
            int[] AskArray = new int[length1];

            for (int i=0; i <length1; i++)
            {
                AskArray[i] = i; // the element and index will be the same
                if (i == 2)
                {
                    AskArray[2] = 1304;
                }
                Console.WriteLine(i); // will print the number i is equal to.
            }
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("**************************************************************************************************************");
            square(1, 2);
        }

        static void square(int num1, int num2)
        {
            Console.WriteLine("Give me your first number: ");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Give me your second Number: ");
            num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\nSo, " + num1 + " times " + num2 + " is equal to: " + num1 * num2);
        }
    }
}
