using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args) // main method, program starts from here
        {
            //method is a block of code that contains a series of statements to perform particular operations. Methods must be declared in class by specifying the required parameters.
            //methods are sub-routines that split code into manageable portions with each routine performing a specific task
            SayHello("Tom");
            SayHello("Josh");
            SayHello("Alex");
            Console.WriteLine("*************************************************");
            SayHelloSAE();
            Console.WriteLine("*************************************************");
            NameAndNumber("Tom", 18);
            Console.WriteLine("*************************************************");
            Console.WriteLine("*************************************************");
            string colour;
            Console.WriteLine("What is your fave colour?");
            colour = Console.ReadLine();
            Colour(colour);
            Console.WriteLine("*************************************************");
            Console.WriteLine("*************************************************");
            int result = AddNumbers(10, 15);
            Console.WriteLine("The result is: " + result);
            Console.WriteLine("*************************************************");
            Console.WriteLine("*************************************************");
            int p, t;
            Console.WriteLine("Give me your first number.");
            p = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Give me your second number");
            t = Int32.Parse(Console.ReadLine());
            int res = AskAddNumbers(p, t);
            Console.WriteLine("Your result is " + res);
        }
        static void SayHello(string name) //this is how to make a new method
        {
            Console.WriteLine("Hello! " + name);
        }
        static void SayHelloSAE() //public means that anyone can access this method from your applications. There are public, protected and private access modifiers.
                                                  // VOID MEANS NO DATATYPE IN A FUNCTION
        {
            Console.WriteLine("Hello SAE!");
        }

        static void Number(int number)
        {
            Console.WriteLine("Your number is "+ number);
        }

        static void NameAndNumber(string PN, int N)
        {
            Console.WriteLine("My Name Is: " + PN + " And my age is: "+ N);
        }

        static void Colour(string colour)
        {
            Console.WriteLine("My fave colour is: "+ colour);
        }

        static int AddNumbers(int x, int y)
        {
            int result = x + y;
            return result;
        }

        static int AskAddNumbers(int p, int t)
        {
            int res = p + t;
            return res;
        }
    }
}
