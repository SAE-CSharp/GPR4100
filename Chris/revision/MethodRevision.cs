using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Sayhello("Tom", 20);// argument
            Getinfo();

            Addtwonumber(3, 5);
            int z = Addtwonum(3, 8);
            int a = z + 15;
            Sayhello("Tom", z);
            int A = Square(12);
            Console.WriteLine("A = " + A);
            int B = Square(A * 2);
            Console.WriteLine("B = " + A);
            int C = Square(B * A);
            Console.WriteLine("C = " + C);
            int[] array1 = new int[3] { 2, 4, 5 };
            printarray(array1);
            string[] myArray = new string[3] { "Mark", "Chris", "Don" };
            printStringArray(myArray);
            

        }










        static void Sayhello(string name, int age)//parameters
        {

            Console.WriteLine("Hello " + name + " You are " + age);
        }
        static void Getinfo()
        {
            Console.WriteLine("enter your name: ");
            string name = (Console.ReadLine());
            Console.WriteLine("enter your age: ");
            int age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Hello " + name + " You are " + age);
        }
        static void Addtwonumber(int x, int y)
        {
            int z = x + y;
            Console.WriteLine("the result of x+y is: " + z);
        }

        static int Addtwonum(int x, int y)
        {
            int z = x + y;
            return z;
        }
        static int Square(int x)
        {

            return x * x;
        }

        static int Squared(int x)
        {
            int i = x * x * x;
            return i;// return x * x

        }
        static void printarray(int[] newarray)
        {
            for (int i = 0; i < newarray.Length; i++)
            {
                Console.WriteLine("The array alement is " + newarray[i]);
            }
        }
        static void printStringArray(String [] stringarray)
        {
            for (int i = 0; i < stringarray.Length; i++)
            {
                Console.WriteLine("Hello " + stringarray[i]);
            }
        }
        
    }
}
