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
            Console.WriteLine("Modulus:\nWhen x is " + x + " and y is " + y + ", the modulus of x and y is " + mod + ".\n");
        }
    }
}
