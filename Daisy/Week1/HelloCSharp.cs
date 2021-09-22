
using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 24;
            string name = "Daisy";
            float drink = 1.5f;
            char litre = 'L';

            Console.WriteLine("my name is " + name + " I am " + age + " years old. I drink " + drink + " " + litre + " of san pellegrino");
           
            /******************************/

            int result;
            int x = 50, y = 10;
            result = (x + y);
            Console.WriteLine("Addition Operator: " + result);
            result = (x - y);
            Console.WriteLine("Subtraction Operator: " + result);
            result = (x * y);
            Console.WriteLine("Multiplication Operator: " + result);
            result = (x / y);
            Console.WriteLine("Division Operator: " + result);
            result = (x % y);
            Console.WriteLine("Modulo Operator: " + result);
            Console.WriteLine("Press Enter Key To Exit..");
            Console.ReadLine();


            
        }
    }
}
