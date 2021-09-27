using System;

namespace Calculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            string calculationType;
            float x, y, result = 0;
            char op;

            Console.WriteLine("Enter A, B or C (respectively) for the type of calulation you would like to use (Arithmatic, Even/odd, Prime):");
            calculationType = Console.ReadLine();

            if (calculationType == "A")
            {
                Console.WriteLine("Enter first value: ");
                x = float.Parse(Console.ReadLine());


                Console.WriteLine("Enter second value: ");
                y = float.Parse(Console.ReadLine());


                Console.WriteLine("What would you like to do with these numbers. (+ - * or / )");
                op = char.Parse(Console.ReadLine());

                if (op == '+')
                {
                    result = x + y;
                }
                else if (op == '-')
                {
                    result = x - y;
                }
                else if (op == '*')
                {
                    result = x * y;
                }
                else if (op == '/')
                {
                    result = x / y;
                }
                else
                {
                    Console.WriteLine("Invalid input entered!");
                }
                Console.WriteLine(x + " " + op + " " + y + " = " + result);
            }

            else if (calculationType == "B")
            {
                Console.WriteLine("Enter your value: ");
                x = float.Parse(Console.ReadLine());
                result = x % 2;

                if (result == 0)
                {
                    Console.WriteLine(x + " is an even number!");
                }
                else
                {
                    Console.WriteLine(x + " is an odd number!");
                }
            }

            else if (calculationType == "C")
            {
                int x, i, flag=0;
                Console.WriteLine("Enter a value:");
                x = int.Parse(Console.ReadLine());

                for (i = 0; i == (x - 1);)
                {
                    i++;
                    if (x % i == 0)
                    {
                        flag = 1;
                        Console.WriteLine(x + " is not a prime number");
                        break;
                    }
                }
                if (flag == 0)
                {
                    Console.WriteLine(x + " is a prime number");
                }  
             else
             {
                Console.WriteLine("Input Invalid");
             }
                
                
            }
        }
    }
}
