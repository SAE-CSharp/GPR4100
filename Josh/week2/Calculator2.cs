using System;

namespace Calculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            string calculationType;
            float x, y, i, result = 0, flag = 0;
            char op;


            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
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
                Console.WriteLine("Enter a value:");                            
                x = int.Parse(Console.ReadLine());
                                                                                
                for (i = 2; i <= (x - 1); i++)                                  //loop to check if the input by every value of i from 2 to one below the input
                {
                    if (x % i == 0)                                             //If at any point the modulus calculation gives a result of 0 (i.e.doesn't give a remainder)
                    {
                        Console.WriteLine(x + " is not a prime number");        //...Then the number cannot be prime
                        flag = 1;                                               //alter the flag value so the the programme can identify that it has gone down this path
                        break;
                    }
                }
                if (flag == 0)                                                  //If the loop completes and the flag has not been changed then no condition has been met to
                {                                                               //      show that the input is not prime then...
                    if (x == 0)
                    {
                        Console.WriteLine(x + " is not a prime number"); //Both 0 and 1 are not prime numbers but will not meet the condition to alter the flag therfore need
                    }                                                    //...their own path
                    else if (x == 1)
                    {
                        Console.WriteLine(x + " is not a prime number");
                    }
                    else
                    {
                        Console.WriteLine(x + " is a prime number");            //       ...the number must be prime
                    }
                }
            }



            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }
    }
}
