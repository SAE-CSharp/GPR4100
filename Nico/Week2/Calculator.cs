using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            float x;
            float y;
            int op;
            float result;

            Console.WriteLine("Input the first number:");
            x = float.Parse(Console.ReadLine());
            Console.WriteLine("Input the second number:");
            y = float.Parse(Console.ReadLine());
            Console.WriteLine("What operation would you like:\n1. Moltiplication\n2. Division\n3. Addition\n4. Subtraction");
            Console.WriteLine("****************************************************************************");
            op = Int32.Parse(Console.ReadLine());
            if (op == 1)
            {
                result = x * y;
                Console.WriteLine("****************************************************************************");
                Console.WriteLine(x+" * "+y+" = "+result);
            }
            else if (op == 2)
            {
                result = x / y;
                Console.WriteLine("****************************************************************************");
                Console.WriteLine(x + " / " + y + " = " + result);
            }
            else if (op == 3)
            {
                result = x + y;
                Console.WriteLine("****************************************************************************");
                Console.WriteLine(x + " + " + y + " = " + result);
            }
            else
            {
                result = x - y;
                Console.WriteLine("****************************************************************************");
                Console.WriteLine(x + " - " + y + " = " + result);
            }
                Console.WriteLine("****************************************************************************");

        }
    }
}
