using System;

namespace methods2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*SayHello("Logan", 21); // argument
            SayHello("Jeff", 23);
            SayHello("Rex", 26);
            SayHello("Atlas", 31);
            SayHello("John", 29);
            SayHello("Drake", 24);
            SAE();*/
            /*getinfo();*/
            /*AddTwoNumbers(3, 5);
            int z = AddTwoNumber(5, 8);
            int a = square(12);
            Console.WriteLine("A = " + a);
            int b = square(a * 2);
            Console.WriteLine("B = " + b);
            int c = square(b * a);
            Console.WriteLine("C = " + c);*/

            /*int[] array1 = new int[4];
            printarray(array1);*/

            string[] myarray=new string[3] { "logan", "Jeff", "Jhon" };
            PrintStringArray(myarray);



        }

        /*static void SayHello(string name, int age) // parameters
        {

            Console.WriteLine("Hello " + name + " your age is " + age);

        }

        static void SAE()
        {

            Console.WriteLine("Hello SAE");

        }*/

        /*static void getinfo()
        {

            Console.WriteLine("Enter your name plz: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age plz: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello " + name + " your age is " + age);

        }*//*

        static void AddTwoNumbers(int x, int y)
        {

            int z = x + y;
            Console.WriteLine("The result of adding X+Y is: " + z);

        }

        static int AddTwoNumber(int x, int y)
        {

            int z = x + y;

            return z;

        }

        static int Cube1(int number)
        {
            int result = number * number * number;

            return result;
        }

        static int square(int x)
        {

            int i = x * x;
            return i;

        }*/

        /*static void printarray(int[] newarray)
        {

            for (int i = 0; i < newarray.Length; i++)
            {

                Console.WriteLine("the array element is " + newarray[i]);

            }

        }*/

        static void PrintStringArray(string [] name)
        {

            for (int i = 0; i < name.Length; i++)
            {

                Console.WriteLine("Hello And Welcome " + name[i]);

            }


        }










    }



}
