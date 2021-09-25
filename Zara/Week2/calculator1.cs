using System;

namespace calculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            char opp;
            Console.WriteLine("Enter first number plz?");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number plz?");
            num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the operator(+, -, *, /, %) plz?");
            opp = char.Parse(Console.ReadLine());
            if (opp =='+')
            {
                Console.WriteLine("the result of num1+num2 is "+(num1+num2));

            }
           else if (opp == '-')
            {
                Console.WriteLine("the result of num1-num2 is " + (num1 - num2));

            }
            else if (opp == '*')
            {
                Console.WriteLine("the result of num1*num2 is " + (num1 * num2));

            }
           else if (opp == '/')
            {
                Console.WriteLine("the result of num1/num2 is " + (num1 / num2));

            }
            else if (opp == '%')
            {
                Console.WriteLine("the result of num1%num2 is " + (num1 % num2));

            }
            else
            {
                Console.WriteLine("invalid data");

            }




        }
    }
}
