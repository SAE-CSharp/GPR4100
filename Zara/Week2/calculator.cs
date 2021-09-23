using System;

namespace Calculater
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            char opp;

            Console.WriteLine("Enter the num1");
            num1 = Int32.Parse(Console.ReadLine());
            num2 = Int32.Parse(Console.ReadLine());
            opp = char.Parse(Console.ReadLine());
            if (opp =='+')
            {
                Console.WriteLine("the answer is: "+ (num1+num2));

            }
            else if (opp == '-')
            {
                Console.WriteLine("the answer is: " + (num1 - num2));

            }
            else if (opp == '*')
            {
                Console.WriteLine("the answer is: " + (num1 * num2));

            }
            else if (opp == '/')
            {
                Console.WriteLine("the answer is: " + (num1 / num2));

            }
            else
            {
                Console.WriteLine("Invalid number");

            }

        }
    }
}
