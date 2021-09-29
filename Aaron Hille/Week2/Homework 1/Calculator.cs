using System;

namespace A_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================================================================================================================");
            Console.WriteLine("");
            Console.WriteLine(">>>>> PROGRAMMING A WORKING CALCULATOR <<<<<");
            Console.WriteLine("");

            Console.WriteLine("Would you like to use a standard calculator, or find out wethere your input is an odd number or an even number?");
            Console.WriteLine("For the standard calculator, please enter \'A\'.");
            Console.WriteLine("For odd/even checking, please enter \'B\'.");
            Console.WriteLine("For prime checking, please enter \'C\'.");
            char which = Convert.ToChar(Console.ReadLine());

            if (which == 'A')
            {
                float num1, num2, result;
                char op;

                Console.WriteLine("Welcome to the Calculator program.");
                Console.WriteLine("Please input your first number.");
                num1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Please input your second number.");
                num2 = float.Parse(Console.ReadLine());

                Console.WriteLine("What Operation would you like to use?");
                Console.WriteLine("Enter \'+\' for addition.");
                Console.WriteLine("Enter \'-\' for subtraction.");
                Console.WriteLine("Enter \'*\' for multiplication.");
                Console.WriteLine("Enter \'/\' for division.");
                Console.WriteLine("Enter \'%\' for modulus.");
                op = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("");

                if (op == '+')
                {
                    result = num1 + num2;
                    Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + result + ".");

                }
                else if (op == '-')
                {
                    result = num1 - num2;
                    Console.WriteLine("The result of " + num1 + " minus " + num2 + " is " + result + ".");
                }

                else if (op == '*')
                {
                    result = num1 * num2;
                    Console.WriteLine("The result of " + num1 + " multiplied by " + num2 + " is " + result + ".");
                }

                else if (op == '/')
                {
                    result = num1 / num2;
                    Console.WriteLine("The result of " + num1 + " divided by " + num2 + " is " + result + ".");
                }

                else if (op == '%')
                {
                    result = num1 % num2;
                    Console.WriteLine("The result of " + num1 + " mod " + num2 + " is " + result + ".");
                }

                else
                {
                    Console.WriteLine("That is an invalid input. Please restart the program.");
                }
            }

            else if (which == 'B')
            {
                Console.WriteLine("Enter a number please.");
                int num3 = Convert.ToInt32(Console.ReadLine());

                if ((num3 % 2) == 0)
                {
                    Console.WriteLine("The number " + num3 + " is an even number.");
                }

                else if ((num3 % 2) != 0)
                {
                    Console.WriteLine("The number " + " is an odd number.");
                }
            }

            else if (which == 'C')
            {
                //Console.WriteLine("This part of the program is currently undergoing maintenance.");
                //Console.WriteLine("Apologies, it will be up and running as soon as possible.");
                //Console.WriteLine("");
                //Console.WriteLine("");
                //Console.WriteLine("");
                //Console.WriteLine("");
                //Console.WriteLine("");
                //Console.WriteLine("     :)");

                Console.WriteLine("Enter a value:");
                int i, flag = 0;
                int numm = int.Parse(Console.ReadLine());
                for (i = 2; i <= (numm - 1); i++)                                  
                {
                    if (numm % i == 0)                                             
                    {
                        Console.WriteLine(numm + " is not a prime number");       
                        flag = 1;                                               
                        break;
                    }
                }
                if (flag == 0)                                                  
                {                                                               
                    if (numm == 0 || numm == 1)
                    {
                        Console.WriteLine(numm + " is not a prime number"); 
                    }                                                    
                    else
                    {
                        Console.WriteLine(numm + " is a prime number");            
                    }
                }
            }

            else
            {
                Console.WriteLine("That is an invalid input. Please restart the program.");
            }
        }
    }
}
