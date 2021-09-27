using System;

/*Homework 1 - Is it even, odd or prime?

Build upon your existing calculator so it can determine whether a number is even, odd or prime.
In addition to the existing methods, your program must include:
• Modulus operator
• String data types(Calculation Type)*/




namespace Calculator_odd_even_prime_homework_week_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            float firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the type of calculation youd like to do.");
            string cal = Console.ReadLine();
            Console.WriteLine("Enter the second number");
            float secNum = Convert.ToInt32(Console.ReadLine());

            if (cal == "*")
            {
                float timesAns = firstNum * secNum;
                Console.WriteLine("The Answer is " + timesAns);
            }
            else if (cal == "/")
            {
                float devideAns = firstNum / secNum;
                Console.WriteLine("The Answer is " + devideAns);
            }
            else if (cal == "+")
            {
                float addAns = firstNum + secNum;
                Console.WriteLine("The Answer is " + addAns);
            }
            else if (cal == "-")
            {
                float minusAns = firstNum - secNum;
                Console.WriteLine("The Answer is " + minusAns);
            }
            else if (cal == "%")
            {
                float perAns = firstNum % secNum;
                Console.WriteLine("The Answer is " + perAns);
            }
            else
            {
                Console.WriteLine("Error 404:\nUsers Brain not found");
            }

            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();

            int OPE;
            
            Console.WriteLine("PLease enter a whole number so the system can decer if its odd, even, or a prime number.");
            OPE = int.Parse(Console.ReadLine());

            if (OPE % 2 == 0)
            {
                Console.Write("The Number " + OPE + " is an even number.");
                if (IsPrime(OPE))
                {
                    Console.WriteLine("\nIt is also prime.");
                }
                else
                {
                    Console.WriteLine("\nThis number is not prime.");
                }
            }
            else if (OPE % 1 == 0)
            {
                Console.WriteLine("The Number " + OPE + " is an odd number.");
                if (IsPrime(OPE))
                {
                    Console.WriteLine("\nIt is also prime.");
                }
                else
                {
                    Console.WriteLine("\nThis number is not prime.");
                }
            }
            else
            {
                Console.WriteLine("Error 404:\nUsers Brain not found");
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
            // Source for IsPrime:
            // https://stackoverflow.com/questions/15743192/check-if-number-is-prime-number
        }
    }
}
