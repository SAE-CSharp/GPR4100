// This code example is intended to demonstrate how to set up and use a "primality test" in C# in
// a general way, so that it can be made use of anywhere it's needed in other code. Primality is
// quite simply whether or not an integer is a prime number.

using System;

namespace ExampleCode_Primality
{
    class Program
    {
        static void Main(string[] args)
        {
            // A boolean can be set up as a method/function to check multiple conditions.
            // This should not be done within a loop, as the method/function only needs
            // to be created once, and can then be reused throughout the program.
            
            bool IsPrime(int n)
            {
                if (n == 2 || n == 3)
                    return true;

                if (n <= 1 || n % 2 == 0 || n % 3 == 0)
                    return false;

                for (int i = 5; i * i <= n; i += 6)
                {
                    if (n % i == 0 || n % (i + 2) == 0)
                        return false;
                }

                return true;
            }

            // This boolean *is* the primality test - each condition it checks is a part of
            // determining whether the number is prime. The brackets after the name of the
            // boolean contain its "arguments" - the values that need to be entered when the
            // method/function is used so that it can run properly.

            // "return" is used when a method/function needs to output a value - it tells the
            // program what value to output, and when triggered it terminates the method, like
            // "break" terminates a loop. It can also be attached to a conditional statement
            // as the code to be executed when the statement's condition is satisfied. In this
            // case, the method/function needs to output "true" or "false", depending on
            // whether the input number is a prime, so each if statement has "return true;"
            // or "return false;" after it.

            Console.WriteLine("Please enter a positive integer.");
            int input = Int32.Parse(Console.ReadLine());

            bool checkResult = IsPrime(input);

            // This declares a new boolean *variable*, rather than a method/function, and then
            // uses the method/function we created to set its value, with the input the
            // program received from the user as the required argument.

            if (checkResult == true)
            {
                Console.WriteLine("\n" + input + " is prime");
            }
            else
            {
                Console.WriteLine("\n" + input + " is not prime");
            }

            // Having created a primality test, received an input from the user, and then set
            // the value of a variable as the result of using the test on the input, we can
            // now run our output depending on the variable's value. You don't have to do this,
            // though - you can use the result of the test in whatever way suits your program!
        }
    }
}
