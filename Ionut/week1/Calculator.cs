using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            char opp;
            Console.WriteLine("Enter first number please: ");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number please: ");
            num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the operator please: ");
            opp = char.Parse(Console.ReadLine());
            if (opp =='+')
            {
                Console.WriteLine(" The result of num1+num2 is " +(num1 + num2));
            }
            else if (opp=='-')
            {
                Console.WriteLine("The result of num1-num2 is " + (num1 - num2));
            }
            else if (opp =='*')
            {
                Console.WriteLine("The result of num1*num2 is " + (num1 * num2));
            }
            else if(opp=='/')
            {
                Console.WriteLine("The result of num1/num2 is " + (num1 / num2));
            }
            else
            {
                Console.WriteLine("End of calculator");
            }
        }
    }
}
