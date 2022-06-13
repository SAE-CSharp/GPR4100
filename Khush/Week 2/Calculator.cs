using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            char opp;
            Console.WriteLine("enter first no.");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("enter second no.");
            num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("enter the operator");

            opp = char.Parse(Console.ReadLine());
            if (opp == '+')
            {
                Console.WriteLine("the result of num1 + num2 is"+ (num1+num2));
            }
            else if (opp == '-')
            {
                Console.WriteLine("the result of num1 - num2 is" +(num1 + num2));
            }
            else if (opp == '*')
            {
                Console.WriteLine("the result of num1 * num2 is" +(num1 + num2));
            }
            else if (opp == '/')
            {
                Console.WriteLine("the result of num1 / num2 is" +(num1 + num2));
            }
            else
            {
                Console.WriteLine("invalid data");

            }
        }
    }
}
