using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            string op;
            int result;

            Restart:

            Console.WriteLine("Input the first number:");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("What operation would you like:*,/,+,- or %");

            op = (Console.ReadLine());

            Console.WriteLine("Input the second number:");
            y = int.Parse(Console.ReadLine());

            if (op == "*")
            {
                result = x * y;
                Console.WriteLine("****************************************************************************");
                Console.WriteLine(x + " * " + y + " = " + result);
                //Odd or even?
                if (result % 2 == 0)
                {
                    Console.WriteLine("Number is even");
                }
                else
                {
                    Console.WriteLine("Number is odd");
                }
                //Is it a Prime Number?
                if (IsPrime(result))
                {
                    Console.WriteLine("It is a prime number");
                }
                else
                {
                    Console.WriteLine("It is not a prime number");
                }
                

            }
            else if (op == "/")
            {
                result = x / y;
                Console.WriteLine("****************************************************************************");
                Console.WriteLine(x + " / " + y + " = " + result);
                
                //Odd or even?
                if (result % 2 == 0)
                {
                    Console.WriteLine("Number is even");
                }
                else
                {
                    Console.WriteLine("Number is odd");
                }
                //Is it a Prime Number?
                if (IsPrime(result))
                {
                    Console.WriteLine("It is a prime number");
                }
                else
                {
                    Console.WriteLine("It is not a prime number");
                }
            }
            else if (op == "+")
            {
                result = x + y;
                Console.WriteLine("****************************************************************************");
                Console.WriteLine(x + " + " + y + " = " + result);
                
                //Odd or even?
                if (result % 2 == 0)
                {
                    Console.WriteLine("Number is even");
                }
                else
                {
                    Console.WriteLine("Number is odd");
                }
                //Is it a Prime Number?
                if (IsPrime(result))
                {
                    Console.WriteLine("It is a prime number");
                }
                else
                {
                    Console.WriteLine("It is not a prime number");
                }
            }
            else if (op == "%")
            {
                result = x % y;
                Console.WriteLine("****************************************************************************");
                Console.WriteLine(x + " % " + y + " = " + result);
                
                //Odd or even?
                if (result % 2 == 0)
                {
                    Console.WriteLine("Number is even");
                }
                else
                {
                    Console.WriteLine("Number is odd");
                }
                //Is it a Prime Number?
                if (IsPrime(result))
                {
                    Console.WriteLine("It is a prime number");
                }
                else
                {
                    Console.WriteLine("It is not a prime number");
                }
            }
            else if (op == "-")
            {
                result = x - y;
                Console.WriteLine("****************************************************************************");
                Console.WriteLine(x + " - " + y + " = " + result);
                
                //Odd or even?
                if (result % 2 == 0)
                {
                    Console.WriteLine("Number is even");
                }
                else
                {
                    Console.WriteLine("Number is odd");
                }
                //Is it a Prime Number?
                if (IsPrime(result))
                {
                    Console.WriteLine("It is a prime number");
                }
                else
                {
                    Console.WriteLine("It is not a prime number");
                }
            }

            else
            {
                Console.WriteLine("****************************************************************************");
                Console.WriteLine("Operation character not accepted, please repeat:");
                goto Restart;
            }
            static bool IsPrime(int result)
            {
                if (result <= 1) return false;
                if (result == 2) return true;
                if (result % 2 == 0) return false;

                int limit = (int)Math.Sqrt(result);

                for (int i = 3; i <= limit; i += 2)
                {
                    if (result % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
