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
                Console.WriteLine("the result of num1 + num2 is" + (num1 + num2));
            }
            else if (opp == '-')
            {
                Console.WriteLine("the result of num1 - num2 is" + (num1 - num2));
            }
            else if (opp == '*')
            {
                Console.WriteLine("the result of num1 * num2 is" + (num1 * num2));
            }
            else if (opp == '/')
            {
                Console.WriteLine("the result of num1 / num2 is" + (num1 / num2));
            }
            else if (opp == '%')
            {
                Console.WriteLine("the result of num1 % num2 is" + (num1 % num2));
            }
            else
            {
                Console.WriteLine("invalid data");

            }

            int flag = 0, i = 0;
            int m = num1 / 2;
            for (i = 2; i <= m; i++)
            {
                if (num1 % i == 0)
                {
                    Console.WriteLine(num1+" is not a Prime number.");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.WriteLine(num1 + " is a Prime number.");
        }
    }
}
