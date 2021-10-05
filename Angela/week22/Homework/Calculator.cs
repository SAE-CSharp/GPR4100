using System;

namespace CalculatorAngela
{
    class Program
    {
        static void Main(string[] args)
        {
            float number1, number2, result;
            string calculationType;
            char opp;
            Console.WriteLine("\t \t \t \t \t \t CALCULATOR");
            Console.WriteLine(" \t \t \t \t \t Choose your calculation type");
            Console.WriteLine("arithmetic\nodd\neven\nprime");
            calculationType = Console.ReadLine();
            if (calculationType == "arithmetic")
            {
                Console.WriteLine("Please enter your operator");
                opp = char.Parse(Console.ReadLine());
                Console.WriteLine("Please enter your first number");
                number1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Please enter your second number");
                number2 = float.Parse(Console.ReadLine());

                if (opp == '+')
                {
                    result = (number1 + number2);
                    Console.WriteLine("Your answer is" + result);

                }
                else if (opp == '-')
                {
                    result = (number1 - number2);
                    Console.WriteLine("Your answer is" + result);
                }
                else if (opp == '-')
                {
                    result = (number1 * number2);
                    Console.WriteLine("Your answer is" + result);
                }
                else if (opp == '/')
                {
                    result = (number1 - number2);
                    Console.WriteLine("Your answer is" + result);
                }
                else if (opp == '%')
                {
                    result = (number1 - number2);
                    Console.WriteLine("Your answer is" + result);
                }
                else
                {
                    Console.WriteLine("Invalid number/operation. Please close the calculator and open it again.");

                }
            }
            else if (calculationType == "even")
            {
                Console.WriteLine("Enter a number");
                number1 = Int32.Parse(Console.ReadLine());

                if (number1 % 2 == 0)
                {
                    Console.WriteLine("Number is an even number");
                }
                else
                {
                    Console.WriteLine("Number is not an even number");
                }
            }
            else if (calculationType == "odd")
            {
                Console.WriteLine("Enter a number");
                number1 = Int32.Parse(Console.ReadLine());

                if (number1 % 2 != 0)
                {
                    Console.WriteLine("is an odd number");
                }
            }
            else if (calculationType == "prime")
            {


                Console.WriteLine("Please enter your number:");
                int i, flag = 0;
                int anyNumber = int.Parse(Console.ReadLine());
                for (i = 2; i <= (anyNumber - 1); i++)
                {
                    if (anyNumber % i == 0)
                    {
                        Console.WriteLine(anyNumber + " Number is not a prime number");
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                {
                    if (anyNumber == 0 || anyNumber == 1)
                    {
                        Console.WriteLine(anyNumber + " Number is not a prime number");
                    }
                    else
                    {
                        Console.WriteLine(anyNumber + " Number is a prime number");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid number/operation. Please close the calculator and open it again.");
            }
        }
    }
}
