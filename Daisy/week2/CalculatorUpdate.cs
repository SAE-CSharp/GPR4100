using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            char opp;
            string calculationType;
            float x, result;

            Console.WriteLine("What type of calculation would you like to do? for mathematical equation enter A," +
                " for odd/even finder enter B or for prime number enter C..");
            calculationType = Console.ReadLine();

            if (calculationType == "A")
            {
                Console.WriteLine("Enter the first number");
                num1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter the mathematical operator");
                opp = char.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second number");
                num2 = Int32.Parse(Console.ReadLine());


                if (opp == '+')
                {
                    Console.WriteLine("The answer is " + (num1 + num2));
                }
                else if (opp == '-')
                {
                    Console.WriteLine("The answer is " + (num1 - num2));
                }
                else if (opp == '*')
                {
                    Console.WriteLine("The answer is " + (num1 * num2));
                }
                else if (opp == '/')
                {
                    Console.WriteLine("The answer is " + (num1 / num2));
                }
                else if (opp == '%')
                {
                    Console.WriteLine("The answer is " + (num1 % num2));
                }
                else
                {
                    Console.WriteLine("invalid");
                }
            }

            else if (calculationType == "B")
            {
                Console.WriteLine("Enter a value");
                x = float.Parse(Console.ReadLine());
                result = x % 2;

                if (result == 0)
                {
                    Console.WriteLine(x + " The number is even");
                }

                else
                {
                    Console.WriteLine(x + " The number is odd");
                }

            }

            else if (calculationType == "C")
            {

            }
        }
    }
}
