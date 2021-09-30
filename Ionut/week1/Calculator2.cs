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
            int divisors = 0;
            int remainder;

            Console.WriteLine("Enter first number please: ");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number please: ");
            num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the operator please: ");
            opp = char.Parse(Console.ReadLine());
            if (opp == '+')
            {
                Console.WriteLine(" The result of num1+num2 is " + (num1 + num2));
            }
            else if (opp == '-')
            {
                Console.WriteLine("The result of num1-num2 is " + (num1 - num2));
            }
            else if (opp == '*')
            {
                Console.WriteLine("The result of num1*num2 is " + (num1 * num2));
            }
            else if (opp == '/')
            {
                Console.WriteLine("The result of num1/num2 is " + (num1 / num2));
            }
            else if (opp == '%')
            {
                Console.WriteLine("The result of num1%num2 is " + (num1 % num2));
            }
            
            
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("Check if a number is prime");
                num1 = Int32.Parse(Console.ReadLine());
            divisors = 0;
                for (int x = 1; x <= num1; x++)
                {
                    if (num1 % x == 0)
                    {
                    divisors++;
                    }
                }

                if (divisors == 2)
                {
                    Console.WriteLine(" Your number is prime");
                }
                else
                {
                    Console.WriteLine("your number is not prime");
                }
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("Check if your number is odd or even: ");
                num1 = Int32.Parse(Console.ReadLine());
                remainder = num1 % 2;

                if(remainder == 0)
                {
                    Console.WriteLine("Your number is even ");
                }
                 else
                 {
                    Console.WriteLine("Your number is odd ");
                 }
            
            

            
                         

        }
    }
}
