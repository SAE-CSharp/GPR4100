using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            World("Seb ", 18);// argument
            Getinfo();

            string[] names = { "James", "Oliver", "Steve", "Jeff" };
            arraything(names);
            int z = AddTwoNumber(5, 8);
            int a = z + 15;
            int A = sqaure(12);
            Console.WriteLine("A= " + A);
            int B = sqaure(A * 2);
            Console.WriteLine("A= " + B);
            int C = sqaure(A * B);
            Console.WriteLine("C=" + C);
            




        }

        static void World(string name, int age)//parameter
        {
            Console.WriteLine("Hello " + name + " you age is " + age);
        }

        static void Getinfo()
        {
            Console.WriteLine("Enter your name please");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age please");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello " + name + " and you are " + age + " years old");

        }

        static void AddTwoNumbers(int x, int y) {
            int z = x + y;
            Console.WriteLine("The result of adding x and y is: " + z);


        }
        static int AddTwoNumber(int x, int y)
        {
            int z = x + y;
            return z;
        }

        static int sqaure(int x)
        {
            int i = x * x;

            return i;// return x * x
        }

        static void printarray(int[] newarray)
        {
            for(int i = 0; i< newarray.Length; i++)
            {
                Console.WriteLine("The array element is " + newarray[i]);
            }



        }
    
        static void arraything(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("The array element is " + names[i]);
            }
        }


    }
}
