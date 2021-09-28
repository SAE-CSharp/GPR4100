using System;


namespace CalculatorV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type the type of calculation you wish to perform:");
            Console.WriteLine("Type \'Standard\'to perform a standard calculation\nType \'Identifier\' to use the prime number identifier");
            string CalcType = Console.ReadLine();
            if (CalcType == "Standard")
            {
                Console.WriteLine("Please enter the first number for the calculation");
                float num1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the second number");
                float num2 = float.Parse(Console.ReadLine());
                Console.WriteLine("plaese specify what operation you want to carry out");
                char Operator = char.Parse(Console.ReadLine());
                if (Operator == '+')
                {
                    float result = num1 + num2;
                    Console.WriteLine(num1 + "" + Operator + "" + num2 + "=" + result);
                }
                else if (Operator == '-')
                {
                    float result = num1 - num2;
                    Console.WriteLine(num1 + "" + Operator + "" + num2 + "=" + result);
                }
                else if (Operator == '/')
                {
                    float result = num1 / num2;
                    Console.WriteLine(num1 + "" + Operator + "" + num2 + "=" + result);
                }
                else if (Operator == '*')
                {
                    float result = num1 * num2;
                    Console.WriteLine(num1 + "" + Operator + "" + num2 + "=" + result);
                }
                else if (Operator == '%')
                {
                    float result = num1 % num2;
                    Console.WriteLine(num1 + "" + Operator + "" + num2 + "=" + result);
                }
                else
                {
                    Console.WriteLine("That Command is not recognised");
                }
            }
            else if (CalcType == "Identifier")
            {
                bool even = false, odd = false;
                int count = 0;
                Console.WriteLine("Please enter the number you wish to identify");
                float num = float.Parse(Console.ReadLine());
                if (num == 2)
                {
                    Console.WriteLine("2 is even\n2 is a prime number");
                }
                else if (num == 0)
                {
                    Console.WriteLine("0 is a rational number\nit is not odd, even or prime");
                }
                else if (num % 2 == 0)
                {
                    even = true;
                    Console.WriteLine(num + " is even");
                }
                else
                {
                    odd = true;
                    Console.WriteLine(num + " is 0dd");
                }
                for(int i = 2; i<num/2; i++)
                {
                    if(num % i == 0)
                    {
                        count = 1;
                    }
                    if(count == 1)
                    {
                        Console.WriteLine(num+" is not a prime number");
                    }
                    else
                    {
                        Console.WriteLine(num+" is a prime number");
                    }
                }

            }
            else
            {
                Console.WriteLine("That is an invalid command");
            }
            
            Console.WriteLine("\n****************\nPlease press enter to exit the program\n*****************");
            Console.ReadLine();

        }
    }
}
