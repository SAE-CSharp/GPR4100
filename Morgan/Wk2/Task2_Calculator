// TASK AIMS
// Allow the user to input operands and an operator, and display the result

using System;

namespace MCarpenter_Wk2_CalculatorTask
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare the input and output variables
            float inputA, inputB;
            char inputOp;
            float output;

            /* This comment block is part of an incomplete experiment
            char[] operatorChars = { "+", "-", "*", "/", "%" };
            string inputCalc;
            string inputSecA;
            string inputSecB;
            string inputSecC*/

            // Create a hook for goto
            inputStart:

            // Request the first user input (floating-point number)
            Console.WriteLine("Input your first operand:");
            inputA = float.Parse(Console.ReadLine());

            // Request the second user input (operator character)
            Console.WriteLine("\nOperator options: +, -, *, /, %\nInput your operator:");
            inputOp = Char.Parse(Console.ReadLine());

            // Request the third user input (floating-point number)
            Console.WriteLine("\nInput your second operand:");
            inputB = float.Parse(Console.ReadLine());

            // If/else structure to use the operator input by the user
            if (inputOp == '+')
            {
                // Execute the desired operation
                output = inputA + inputB;
                output = MathF.Round(output, 2);
                // Print the result to the console
                Console.WriteLine("\nResult = " + output);
            }
            else if (inputOp == '-')
            {
                output = inputA - inputB;
                output = MathF.Round(output, 2);
                Console.WriteLine("\nResult = " + output);
            }
            else if (inputOp == '*')
            {
                output = inputA * inputB;
                output = MathF.Round(output, 2);
                Console.WriteLine("\nResult = " + output);
            }
            else if (inputOp == '/')
            {
                output = inputA / inputB;
                output = MathF.Round(output, 2);
                Console.WriteLine("\nResult = " + output);
            }
            else if (inputOp == '%')
            {
                output = inputA % inputB;
                output = MathF.Round(output, 2);
                Console.WriteLine("\nResult = " + output);
            }
            else
            {
                // Else statement used in the event of an invalid operator - returns to the start of user input
                Console.WriteLine("\nError: invalid operator - please try again\n\n");
                goto inputStart;
            }

        }
    }
}
