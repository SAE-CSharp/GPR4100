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
            int res = AddNumbers(3, 5); //result
            Console.WriteLine("the recieved number is " + res);
            int result2 = AddNumbers2();
            int result3 = result2 + 20; //not working
            Console.WriteLine("The result is " + result2);
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
        static int AddNumbers(int x, int y)
        {
            int result = x + y;
            return result;
        }

        static int AddNumbers2()
        {
            Console.WriteLine("What is a value?");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is b value?");
            int b = Convert.ToInt32(Console.ReadLine());
            int result2 = a + b;
            return result2;
            
        }
    }
}
