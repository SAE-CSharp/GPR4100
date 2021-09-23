using System;

namespace excercise_2
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Please enter the first number for the calculation");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            float num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("plaese specify what operation you want to carry out");
            char Operator = char.Parse(Console.ReadLine());
            if (Operator == '+')
            {
                float result = num1 + num2;
                Console.WriteLine(num1 + "" + Operator + "" +num2+"="+result);
            }
            else if (Operator == '-')
            {
                float result = num1 - num2;
                Console.WriteLine(num1 + "" + Operator + "" + num2 + "=" + result);
            }
            else if (Operator == '/')
            {
                float result = num1 / num2;
                Console.WriteLine(num1 + "" + Operator + "" + num2 + "=" + result);
            }
            else if (Operator == '*')
            {
                float result = num1 * num2;
                Console.WriteLine(num1 + "" + Operator + "" + num2 + "=" + result);
            }
            else if (Operator == '%')
            {
                float result = num1 % num2;
                Console.WriteLine(num1 + "" + Operator + "" + num2 + "=" + result);
            }
            else
            {
                Console.WriteLine("That Command is not recognised");
            }


        }   
    }
}
