using System;

namespace Calculator_Homework
{
    class Program
    {

        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            char operation;
            Console.Write("Please enter the first number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter an operand (+, -, /, *, %): ");
            operation = char.Parse(Console.ReadLine());
            Console.Write("Please enter the second number: ");
            b = Convert.ToInt32(Console.ReadLine());

            if (operation == '+')
            {
                c = (a + b);
                Console.WriteLine(a + " + " + b + " = " + (c));
                Console.WriteLine("Is the number prime?:" + (GetYesNo(IsPrime(c))));
            }
            else if (operation == '-')
            {
                c = (a - b);
                Console.WriteLine(a + " - " + b + " = " + (c));
                Console.WriteLine("Is the number prime?:" + (GetYesNo(IsPrime(c))));
            }
            else if (operation == '/')
            {
                c = (a / b);
                Console.WriteLine(a + " / " + b + " = " + (c));
                Console.WriteLine("Is the number prime?:" + (GetYesNo(IsPrime(c))));
            }
            else if (operation == '*')
            {
                c = (a * b);
                Console.WriteLine(a + " * " + b + " = " + (c));
                Console.WriteLine("Is the number prime?:" + (GetYesNo(IsPrime(c))));
            }
            else if (operation == '%')
            {
                c = (a % b);
                Console.WriteLine(a + " % " + b + " = " + (c));
                Console.WriteLine("Is the number prime?:" + (GetYesNo(IsPrime(c))));

            }
            else
            {
                Console.Clear();

            }
        }

        public static bool IsPrime(int c)
        {
            if (c <= 1) return false;
            if (c == 2) return true;
            if (c % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(c));

            for (int i = 3; i <= boundary; i += 2)
                if (c % i == 0)
                    return false;

            return true;
        }
        public static string GetYesNo(bool IsPrime)
        {
            return IsPrime ? " Yes" : " No";
        }

    }
}
