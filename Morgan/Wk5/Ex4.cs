using System;

namespace MCarpenter_Wk5_Ex4
{
    class Program
    {
        static void SayHi(string name)
        {
            Console.WriteLine("Greetings, " + name + "!\n");
        }
        
        static void TellCampus()
        {
            Console.WriteLine("You are at SAE London.\n");
        }

        static void CheckDivis3(int num)
        {
            Console.WriteLine(num + " divided by 3 is " + (num - (num % 3)) / 3);
            if (num % 3 == 0)
            {
                Console.WriteLine("");
                return;
            }
            Console.WriteLine("(with a remainder of " + (num % 3) + ")\n");
        }

        static int AddSub(int a, int b, char op)
        {
            if (op == '+')
            {
                return a + b;
            }
            else if (op == '-')
            {
                return a - b;
            }
            else
            { 
                return 0;
            } 
        }

        static int Square(int x)
        {
            return x * x;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name.");
            string userName = Console.ReadLine();
            Console.WriteLine("");
            
            SayHi(userName);
            TellCampus();

            CheckDivis3(7);
            CheckDivis3(14);
            CheckDivis3(9);

            Console.WriteLine("Enter an integer.");
            int aIn = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter + or -.");
            char opIn = Char.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter another integer.");
            int bIn = Int32.Parse(Console.ReadLine());

            Console.WriteLine("");

            int calcOut = AddSub(aIn, bIn, opIn);
            Console.WriteLine(aIn + " " + opIn + " " + bIn + " = " + calcOut + "\n");

            Console.WriteLine(aIn + "^2 is " + Square(aIn) + "\n");
            Console.WriteLine(bIn + "^2 is " + Square(bIn) + "\n");
        }
    }
}
