using System;

namespace MCarpenter_Wk2_calculatorv2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare input and output variables
            float inputA, inputB, output;
            int input;
            char inputOp, restartCheck;
            bool oddCheck, primeCheck;

            // Boolean function that checks whether a number put into it is prime
            bool IsPrime(int n)
            {
                if (n == 2 || n == 3)
                    return true;
                // Returns that the input is prime if equal to 2 or 3

                if (n <= 1 || n % 2 == 0 || n % 3 == 0)
                    return false;
                // Returns that the input is NOT prime if equal to 1, or divisible by 2 or 3

                for (int i = 5; i * i <= n; i += 6)
                {
                    if (n % i == 0 || n % (i + 2) == 0)
                        return false;
                }
                // Runs an simple but optimised primality test to check if the input is divisible by certain
                // numbers between 5 and the square root of the input, and returns that the input is NOT prime
                // if it is divisible by any of the numbers checked

                return true;
                // Returns that the input is prime if none of the othe conditions are fulfilled
            }

            Console.WriteLine("Welcome, user.\n");
            
        start:

            Console.WriteLine("Please select the function you would like to use:\n  [1] Perform a calculation\n  [2] Check a number's properties");


        fSel:
            
            int funcSelect = Int32.Parse(Console.ReadLine());

            if (funcSelect == 1)
            {
                Console.WriteLine("");
                goto calculation;
            }
            else if (funcSelect == 2)
            {
                Console.WriteLine("");
                goto properties;
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Error: invalid input - please enter the number of a listed function\n");
                goto fSel;
            }


        calculation:
          
            // Request the first user input (floating-point number)
            Console.WriteLine("Please input your first operand:");
            inputA = float.Parse(Console.ReadLine());

            // Request the second user input (operator character)
            Console.WriteLine("\nOperator options:");
            Console.WriteLine("  [+] Addition");
            Console.WriteLine("  [-] Subtraction");
            Console.WriteLine("  [*] Multiplication");
            Console.WriteLine("  [/] Division");
            Console.WriteLine("  [%] Modulo");
            Console.WriteLine("Please input your operator:");
            inputOp = Char.Parse(Console.ReadLine());

            // Request the third user input (floating-point number)
            Console.WriteLine("\nPlease input your second operand:");
            inputB = float.Parse(Console.ReadLine());

            // If/else structure to use the operator input by the user
            if (inputOp == '+')
            {
                // Execute the desired operation
                output = inputA + inputB;
                output = MathF.Round(output, 2);
                // Print the result to the console
                Console.WriteLine("\n" + inputA + " + " + inputB + " = " + output);
            }
            else if (inputOp == '-')
            {
                output = inputA - inputB;
                output = MathF.Round(output, 2);
                Console.WriteLine("\n" + inputA + " - " + inputB + " = " + output);
            }
            else if (inputOp == '*')
            {
                output = inputA * inputB;
                output = MathF.Round(output, 2);
                Console.WriteLine("\n" + inputA + " * " + inputB + " = " + output);
            }
            else if (inputOp == '/')
            {
                output = inputA / inputB;
                output = MathF.Round(output, 2);
                Console.WriteLine("\n" + inputA + " / " + inputB + " = " + output);
            }
            else if (inputOp == '%')
            {
                output = inputA % inputB;
                output = MathF.Round(output, 2);
                Console.WriteLine("\n" + inputA + " % " + inputB + " = " + output);
            }
            else
            {
                // Else statement used in the event of an invalid operator - returns to the start of user input
                Console.WriteLine("\nError: invalid input given - restarting\n\n");
                goto start;
            }

            goto restart;


        properties:

            // Request the user input (integer)
            Console.WriteLine("Please input an integer:");
            input = Int32.Parse(Console.ReadLine());

            if (input % 2 == 0)
            {
                Console.WriteLine("\n" + input + " is even.");
            }
            else
            {
                primeCheck = IsPrime(input);
                // Runs the user input variable through the boolean function, and stores the result in a new variable

                if (primeCheck == true)
                {
                    Console.WriteLine("\n" + input + " is odd, and is prime.");
                }
                else
                {
                    Console.WriteLine("\n" + input + " is odd, but is not prime.");
                }
            }

            goto restart;


        restart:

            Console.WriteLine("\nWould you like to use the calculator again? (y/n)");

            restartCheck = Char.Parse(Console.ReadLine());
            if (restartCheck == 'y')
            {
                Console.WriteLine("");
                goto start;
            }

            Console.WriteLine("\nThank you for using this calculator.");
        } 
    }
}
