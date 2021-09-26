using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            char operation;
            Console.Write("Please enter the first number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter an operand (+, -, /, *): ");
            operation = char.Parse(Console.ReadLine());
            Console.Write("Please enter the second number: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (operation == '+')
            {
                Console.WriteLine(a + " + " + b + " = " + (a + b));
            }
            else if (operation == '-')
            {
                Console.WriteLine(a + " - " + b + " = " + (a - b));
            }
            else if (operation == '/')
            {
                Console.WriteLine(a + " / " + b + " = " + (a / b));
            }
            else if (operation == '*')
            {
                Console.WriteLine(a + " * " + b + " = " + (a * b));
            }
            else
            {
                Console.Clear();

            }
        }
    }
}
