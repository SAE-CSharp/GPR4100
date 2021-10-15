using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            GetInfo(); // Gets Name and Age and Stores As String and Intager
            Console.WriteLine("|--------------------------------------------------|");
            GetNumbers(); // Gets Two Numbers and Stores As Intagers
            GetCubeOne(); // Gets One Number and Stores As Intager
            /*int b = Number(5, 10);*/
            GetSquare();
            Console.WriteLine("|--------------------------------------------------|");
            int A = Square(12);
            Console.WriteLine("A = " + A);
            int B = Square(A * 2);
            Console.WriteLine("B = " + B);
            int C = Square(B * A);
            Console.WriteLine("C = " + C);
            Console.WriteLine("|--------------------------------------------------|");
            int[] array1 = new int[4] { 11, 12, 13, 14};
            printArray(array1);
            string[] array2 = new string[4] {"Tom", "Toby", "Seb", "Abby" };
            stringArray(array2);

        }

        static void GetInfo()
        {
            string names; // String Variable
            Console.WriteLine("| Enter a name:");
            names = Console.ReadLine(); // Stores Result as String Variable
            Console.WriteLine("| Enter your age:");
            int age = Int32.Parse(Console.ReadLine()); // Declares Intager Variable and Stores Result as Intager Variable
            SayHello(names, age); // Runs Block Carrying over Variables as Perameters
        }

        static void SayHello(string name, int age) // Block Declaring Variables to carry from Parent Block
        {
            Console.WriteLine("| Hello There " + name + "! \n| Your age is: " + age);
        }

        static void GetNumbers()
        {
            Console.WriteLine("| Enter the First Number:");
            int ageX = Int32.Parse(Console.ReadLine()); // Declares Intager Variable and Stores Result as Intager Variable
            Console.WriteLine("| Enter the Second Number:");
            int ageY = Int32.Parse(Console.ReadLine()); // Declares Intager Variable and Stores Result as Intager Variable
            Numbers(ageX, ageY); // Runs Block Carrying over Variables as Perameters
        }

        static void Numbers(int x, int y)
        {
            int a = x + y; // Declaring Intager Variable to add paremeter variables carried from parent block
            Console.WriteLine("| The Result of adding X + Y = " + a);
        }

        static void GetCubeOne()
        {
            Console.WriteLine("|--------------------------------------------------|");
            Console.WriteLine("| Enter A Number to be Cubed:");
            int number = Int32.Parse(Console.ReadLine()); // Declares Intager Variable and Stores Result as Intager Variable
            CubeOne(number); // Runs Block Carrying over Variables as Perameters
        }
        static int CubeOne(int number)
        {
            int result = number * number * number; // Declaring Intager Variable to multiply paremeter variables carried from parent block
            Console.WriteLine("| The Cube of: " + number + " is = " + result);
            return result;
        }

        /*static int Number(int x, int y)
        {
            int a = x + y;
            Console.WriteLine("| The Result of adding X + Y = " + a);
            return a;
        }*/

        static void GetSquare()
        {
            Console.WriteLine("|--------------------------------------------------|");
            Console.WriteLine("| Enter A Number to be Squared:");
            int x = Int32.Parse(Console.ReadLine()); // Declares Intager Variable and Stores Result as Intager Variable
            Square(x); // Runs Block Carrying over Variables as Perameters
        }

        static int Square(int x)
        {
            int i = x * x; // Declaring Intager Variable to multiply paremeter variables carried from parent block
            Console.WriteLine("| The Cube of: " + x + " is = " + i);

            return i;
        }

        static void printArray(int[] newArray)
        {
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine("The Array Element is " + newArray[i]);
                break;
            }
        }

        static void stringArray(string[] newArray2)
        {
            for (int i = 0; i < newArray2.Length; i++)
            {
                Console.WriteLine("The Array Element is " + newArray2[i]);
                break;
            }
        }
    }
}
