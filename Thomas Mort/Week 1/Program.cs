using System;

namespace OperatorsV2
{
    class Program
    {
        static void Main(string[] args) //main is the START POINT of the program.
        {
            int result;
            int x = 50, y = 10;
            result = (x + y);
            Console.WriteLine("Addition Operator:" + result);
            result = (x - y);
            Console.WriteLine("Subtraction Operator:" + result);
            result = (x * y);
            Console.WriteLine("Multiplication Operator:" + result);
            result = (x / y);
            Console.WriteLine("Division Operator:" + result);
            result = (x % y);
            Console.WriteLine("Modulo Operator:" + result); //remainder of the division

            Console.WriteLine("***************************************************");
            Console.WriteLine("***************************************************");

            int a = 17;
            int z = 13;

            Console.WriteLine("The result of int/int is:" + a / z);
            Console.WriteLine("The result of float/int is:" + (float)a / z);
            Console.WriteLine("The result of int/float is:" + a / (float)z);
            Console.WriteLine("The result of float/float is:" + (float)a / (float)z);

            Console.WriteLine("***************************************************");
            Console.WriteLine("***************************************************");
            int b = 5;
            b++; //a=6
            int c = 4;
            c--; //b=3
            Console.WriteLine("b++ equals:" +b);
            Console.WriteLine("c-- equals:" +c);

            Console.WriteLine("***************************************************");
            Console.WriteLine("***************************************************");

            int d = 10;
            d += 2; // d=d+2 similar to each other but shorter meaning more time to spend on other things.
            d -= 2; // d=d-2 
            d *= 2; // d=d*2
            d /= 2; // d=d/2


            Console.WriteLine("Press Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}
