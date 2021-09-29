using System;

namespace calculatorv3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            string calcType;
            char opp;

            Console.WriteLine("Enter your calculation Type:");
            Console.WriteLine("| arithmetic | even | odd | prime");
            calcType = Console.ReadLine();
            if (calcType == "arithmetic")
            {
                Console.WriteLine("Enter your operator");
                opp = char.Parse(Console.ReadLine());
                Console.WriteLine("Enter the first number");
                num1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second number");
                num2 = Int32.Parse(Console.ReadLine());

                if (opp == '+')
                {
                    Console.WriteLine("the answer is: " + (num1 + num2));

                }
                else if (opp == '-')
                {
                    Console.WriteLine("the answer is: " + (num1 - num2));

                }
                else if (opp == '*')
                {
                    Console.WriteLine("the answer is: " + (num1 * num2));

                }
                else if (opp == '/')
                {
                    Console.WriteLine("the answer is: " + (num1 / num2));

                }
                else
                {
                    Console.WriteLine("Invalid number");

                }
            }

            else if (calcType == "even")
            {
                Console.WriteLine("Enter a number");
                num1 = Int32.Parse(Console.ReadLine());

                if (num1 % 2 == 0)
                {
                    Console.WriteLine("is an even number");
                }


            }
            else if (calcType == "odd")
            {
                Console.WriteLine("Enter a number");
                num1 = Int32.Parse(Console.ReadLine());

                if (num1 % 2 != 0)
                {
                    Console.WriteLine("is an odd number");
                }

            }
            
            // another way to work with prime number
            if (calcType == "prime")
            {
                Console.WriteLine("Enter your number");
                num1 = Int32.Parse(Console.ReadLine());
            
                if (IsPrime(num1))
                {
                    Console.WriteLine("It is prime");
                }
                else
                {
                    Console.WriteLine("It is not prime");
                }

            }

        }

        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
    }

    
} 
