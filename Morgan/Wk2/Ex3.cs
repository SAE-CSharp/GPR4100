using System;

namespace MCarpenter_Wk2_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, add, sub, mlt, mod;
            x = 15;
            y = 4;
            add = x + y;
            sub = x - y;
            mlt = x * y;
            mod = x % y;

            Console.WriteLine("Addition:\nWhen x is " + x + " and y is " + y + ", the result of x + y is " + add + ".\n");
            Console.WriteLine("Subtraction:\nWhen x is " + x + " and y is " + y + ", the result of x - y is " + sub + ".\n");
            Console.WriteLine("Multiplication:\nWhen x is " + x + " and y is " + y + ", the result of x * y is " + mlt + ".\n");
            Console.WriteLine("Modulo:\nWhen x is " + x + " and y is " + y + ", the modulo of x and y is " + mod + ".\n");

            float divA = (float)x / y;
            float divB = x / (float)y;
            float divC = (float)x / (float)y;

            Console.WriteLine("Division:\nWhen x is " + x + " and y is " + y + ", the result of (float)x / y is " + divA + ".");
            Console.WriteLine("When x is " + x + " and y is " + y + ", the result of x / (float)y is " + divB + ".");
            Console.WriteLine("When x is " + x + " and y is " + y + ", the result of (float)x / (float)y is " + divC + ".\n");
        }
    }
}
