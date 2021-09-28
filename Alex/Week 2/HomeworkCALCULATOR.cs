    //creating a calculator

            float num1, num2, answer;
            float result;
            int i;
            string PrimeFound;
            PrimeFound = "yes";

           
            string yes;
           

            answer = 0;
            char opp;

            Console.WriteLine("please enter an operation from the following, +, -, *, /, % ");
            Console.WriteLine("+ is for addition");
            Console.WriteLine("- is for subtraction");
            Console.WriteLine("* is for multiplication");
            Console.WriteLine("/ is for division");
            Console.WriteLine("% is for modulus");

            opp = Char.Parse(Console.ReadLine());
            if (opp == '+')
            {
                Console.WriteLine("Please enter the first number");
                num1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the second number");
                num2 = float.Parse(Console.ReadLine());
                answer = num1 + num2;
                Console.WriteLine("your Answer is " + answer);
            }

            else if (opp == '-')
            {
                Console.WriteLine("Please enter the first number");
                num1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the second number");
                num2 = float.Parse(Console.ReadLine());
                answer = num1 - num2;
                Console.WriteLine("your Answer is " + answer);
            }

            else if (opp == '*')
            {
                Console.WriteLine("Please enter the first number");
                num1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the second number");
                num2 = float.Parse(Console.ReadLine());
                answer = num1 * num2;
                Console.WriteLine("your Answer is " + answer);
            }

            else if (opp == '/')
            {
                Console.WriteLine("Please enter the first number");
                num1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the second number");
                num2 = float.Parse(Console.ReadLine());
                answer = num1 / num2;
                Console.WriteLine("your Answer is " + answer);
            }

            else if (opp == '%')
            {
                Console.WriteLine("Please enter the first number");
                num1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the second number");
                num2 = float.Parse(Console.ReadLine());
                answer = num1 % num2;
                Console.WriteLine("your Answer is " + answer);
            }

            else
            {
                Console.WriteLine("Please enter a proper operation");

            }


            Console.WriteLine("do you want to detect even, odd and prime numbers?");
            Console.WriteLine("Yes or No");
            yes = Console.ReadLine();

            answer = (Int32)answer;

            if (yes == "yes")
            {
                result = (float)answer % 2;

                if (result == 0)
                {
                    Console.WriteLine("Your number is even");
                    for (i = 2; i <= (answer - 1); i++)
                    {
                        if (answer % i == 0)
                        {
                            Console.WriteLine("your number is not a prime number either");
                            PrimeFound = "No";
                            break;
                        }



                    }


                }
                else
                {
                    Console.WriteLine("Your number is odd");
                    for (i = 2; i <= (answer - 1); i++)
                    {
                        if (answer % i == 0)
                        {
                            Console.WriteLine("your number is not a prime number either");
                            PrimeFound = "No";
                            break;
                        }



                    }
                    if (PrimeFound == "yes")
                    {
                        if (answer == 0)
                        {
                            Console.WriteLine("your number is not a prime number either");
                        }
                        else if (answer == 1)
                        {
                            Console.WriteLine("your number is not a prime number either");
                        }
                        else
                        {
                            Console.WriteLine("Your number is a prime number");
                        }
                    }
                }

            }


            else if ( yes == "Yes")
            {
                result = (float)answer % 2;

                if (result == 0)
                {
                    Console.WriteLine("Your number is even");

                }
                else
                {
                    Console.WriteLine("Your number is odd");
                    for (i = 2; i <= (answer - 1); i++)
                    {
                        if (answer % i == 0)
                        {
                            Console.WriteLine("your number is not a prime number either");
                            PrimeFound = "No";
                            break;
                        }



                    }
                    if (PrimeFound == "yes")
                    {
                        if (answer == 0)
                        {
                            Console.WriteLine("your number is not a prime number either");
                        }
                        else if (answer == 1)
                        {
                            Console.WriteLine("your number is not a prime number either");
                        }
                        else
                        {
                            Console.WriteLine("Your number is a prime number");
                        }

                    }
                }

            }
            else
            {
                Console.WriteLine("thank you, press enter to exit");
            }
        }

            
        
    }
}
