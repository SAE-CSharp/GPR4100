using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("enter operator: ");
            string op = Console.ReadLine();

            Console.Write("enter a number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (op == "-")
            {
                Console.WriteLine(num1 - num1);
            }
            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else if (op == "%")
            {
                Console.WriteLine(num1 % num2);
            }
            else
            {
                Console.WriteLine("Error \nInvalid operator");
            }
            Console.WriteLine("*****************************");
            Console.WriteLine("Welcome the prime number checker!");
            Console.WriteLine("Number you want to check: ");
            int num;
            num = Convert.ToInt32(Console.ReadLine());
            int divisors = 0;

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    divisors++;
                }
                
                
            }

            if (divisors == 2)
            {
                Console.WriteLine("this is a prime number");
            }
            else
            {
                Console.WriteLine("this is not a prime number");
            }

            Console.WriteLine("****************");
            Console.WriteLine("welcome to even or odd!");
            int number, remainder;
            Console.WriteLine("number you want to check: ");
            number = Convert.ToInt32(Console.ReadLine());

            remainder = number % 2;
            if (remainder == 0)
                Console.WriteLine("this is a even number");
            else
                Console.WriteLine("this is a odd number");



            Console.ReadLine();
