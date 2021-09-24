using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 7;
            int y = 4;
            int addition = x + y;
            int subtraction = x - y;
            int multiplication = x * y;
            int division = x / y;
            int modulus = x % y;
            int input;


            Console.WriteLine("Addition " + addition);
            Console.WriteLine("Subtraction " + subtraction);
            Console.WriteLine("multiplication " + multiplication);
            Console.WriteLine("division " + ((float)x / y));
            Console.WriteLine("division " + (x / (float)y));
            Console.WriteLine("division " + ((float)x / (float)y));
            Console.WriteLine("Modulus " + modulus);

            input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You have typed: " + input);

        }
    }
}
