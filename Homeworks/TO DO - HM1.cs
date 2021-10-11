Homework 1 -  Is it even, odd or prime?

Build upon your existing calculator so it can determine whether a number is even, odd or prime.
In addition to the existing methods, your program must include:
• Modulus operator
• String data types(Calculation Type)


Submit your code as a repository post on GitHub under github.com/SAE-CSharp/Yourname/Week2/calculatorv2.cs
/***********************************************************************************************************/
  using System;

namespace Task2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2; //operands
            char opp;  //operator
            string CalcType;

            Console.WriteLine("choose your calculation type");
            Console.WriteLine("| arithmetic | even | odd | prime |");
            CalcType = Console.ReadLine();
            
            

            if (CalcType == "arithmetic") 
            {
                Console.WriteLine("Enter your first number:");
                num1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter your second number:");
                num2 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Choose your operator");
                opp = char.Parse(Console.ReadLine());

                if (opp == '+')
                {
                    Console.WriteLine("the result of num1 + num2 is :" + (num1 + num2));

                }
                else if (opp == '-')
                {
                    Console.WriteLine("the result of num1 - num2 is :" + (num1 - num2));

                }
                else if (opp == '*')
                {
                    Console.WriteLine("the result of num1 * num2 is :" + (num1 * num2));

                }
                else if (opp == '+')
                {
                    Console.WriteLine("the result of num1 +num2 is :" + (num1 / num2));

                }
                else if (opp == '/')
                {
                    Console.WriteLine("the result of num1 / num2 is :" + (num1 + num2));

                }
                else
                {
                    Console.WriteLine("invalid number");
                }
            }

            if (CalcType == "even")
            {

                Console.WriteLine("Enter your number:");

                num1 = Int32.Parse(Console.ReadLine());

                if (num1 % 2 == 0)
                {
                    Console.WriteLine("first number is an even number");

                }


            }

            if (CalcType == "odd")
            {

                Console.WriteLine("Enter your number:");
                num1 = Int32.Parse(Console.ReadLine());
                if (num1 % 2 != 0)
                {
                    Console.WriteLine("first number is an odd number");
                }

            }
            if (CalcType == "prime") //A prime number is a number that can only be divided by itself and 1 without remainders, (2, 3, 5, 7, 11, 13, 17, 19)
            {
                Console.WriteLine("Enter your number:");
                num1 = Int32.Parse(Console.ReadLine());

                for (int i = 2; i < num1 - 1; i++)
                {
                    if (i % num1 == 0)
                    {
                        Console.WriteLine(num1+" is not prime number");

                    }
                    else
                    {
                        Console.WriteLine(num1+" is aprime number");
                    }

                }



            }
        }
    }
}

                  

