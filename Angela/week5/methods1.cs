using System;

namespace methods1
{
    class Program
    {
        //void means no data type
        static void Main(string[] args)
        {
            Sayhello("James", 5);
            Sayhello("Tom", 6);
            Greeting();
            MyName("Jurgita", 30);
            GetImfo();
        }

        static void Sayhello(string name, int num)
        {
            Console.WriteLine("Hello World" +name +" " +num);
        }
        
        static void Greeting()
        {
            Console.WriteLine("Welcome to SAE");
        }

        static void MyName(string myname, int age)
        {
            Console.WriteLine("What is my name?");
            Console.WriteLine("Hello, my name is " + myname + " and I am " + age + " years old");
        }
        // or 
        static void GetImfo()
        {
            Console.WriteLine("What is my name?");
            string name2 = Console.ReadLine();
            Console.WriteLine("What is my age?");
            int myage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, my name is " + name2 + " and I am " + myage + " years old");
        }
    }
}
