using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            float a1;
            float a2;
            int op;
            float answer;



            Console.WriteLine("Welcome to the Best Calculator");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Please enter your first number:");
            a1 = float.Parse(Console.ReadLine());
            Console.WriteLine("You first number  is " + a1);
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Please enter your second number:");
            a2 = float.Parse(Console.ReadLine());
            Console.WriteLine("You second number  is " + a2);
            Console.WriteLine("---------------------------------");
        opppick:
            Console.WriteLine("Please pick a operation:");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Multiplication");
            Console.WriteLine("3. Subtraction");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Modulus");
            Console.WriteLine("6. Prime Checker");
            Console.WriteLine("---------------------------------");
            op = Int32.Parse(Console.ReadLine());

            if (op == 1)
            {
                answer = a1 + a2;
                Console.WriteLine("---------------------------------");
                Console.WriteLine(a1 + " + " + a2 + " = " + answer);
            }
            else if (op == 6) 
            {
                answer = a1 + a2;
                
                int pnumber;
                pnumber = Int32.Parse(Console.ReadLine());
                int divisors = 0;
                for (int i = 1; i <= pnumber; i++)
                {
                    if (pnumber % i == 0)
                    {
                        divisors++;
                    }

                }

                if (divisors == 2)
                {
                    Console.WriteLine("The entered number is prime");
                }
                else
                {
                    Console.WriteLine("The entered number is  not prime");
                }
                Console.ReadLine();


            }

            else if (op == 2)
            {
                answer = a1 * a2;
                Console.WriteLine("---------------------------------");
                Console.WriteLine(a1 + " * " + a2 + " = " + answer);
            }

            else if (op == 3)
            {
                answer = a1 - a2;
                Console.WriteLine("---------------------------------");
                Console.WriteLine(a1 + " - " + a2 + " = " + answer);

            }
            else if (op == 4)
            {
                answer = a1 / a2;
                Console.WriteLine("---------------------------------");
                Console.WriteLine(a1 + " / " + a2 + " = " + answer);

            }

            else if (op == 5)
            {
                answer = a1 % a2;
                Console.WriteLine("---------------------------------");
                Console.WriteLine(a1 + " % " + a2 + " = " + answer);

                if (answer % 2 == 0)
                {
                    Console.WriteLine("Your number is even");
                    Console.WriteLine("---------------------------------");
                }

                else
                {
                    Console.WriteLine("Your number is odd");
                    Console.WriteLine("---------------------------------");
                }
             
 
            }
            else
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("This is a wrong entry please enter a correct number!");
                goto opppick; //thanks Morgan for this


            }

            
        }

    }
    
}
