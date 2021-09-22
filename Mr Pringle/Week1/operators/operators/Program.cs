using System;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            Console.WriteLine("Enter First Number");
            int X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int Y = Convert.ToInt32(Console.ReadLine());
            int x = X, y = Y;
            result = (X + Y);
            Console.WriteLine("Addition Operator\t" + result+"\n");
            result = (X - Y);
            Console.WriteLine("Subtraction Operator\t" + result+"\n");
            result = (X * Y);
            Console.WriteLine("Multiplcation Operator\t" + result+"\n");
            result = (X / Y);
            Console.WriteLine("Division Operator\t"+result+"\n");
            result = (X % Y);
            Console.WriteLine("Modulo Operator\t" + result+"\n");
            X++;
            Console.WriteLine("Incrimented X++ First Number\t" + X + "\n");
            Y++;
            Console.WriteLine("Incrimented Second Number\t" + Y + "\n");
            X--;
            Console.WriteLine("Decrimented First Number\t" + X + "\n");
            Y--;
            Console.WriteLine("Decrimented Second Number\t" + Y + "\n\n\n");
            Console.WriteLine("The following lines refers to X/Y as the data type they are in the line\nX being the first number entered and Y being the second.");
            Console.WriteLine("The result of int/int is\t" + X / Y + "\n");
            Console.WriteLine("The result of float/int is\t" + (float)X / Y + "\n");
            Console.WriteLine("The result of int/float is\t" + X / (float)Y + "\n");
            Console.WriteLine("The result of float/float is\t" + (float)X / (float)Y + "\n\n\n");
/*            
            Console.WriteLine("The result of First number with an addition of 10" + (x += 10));
            Console.WriteLine("The result of First numver with a negative of 10" + (x -= 10));
            Console.WriteLine("The result of Second number with an addition of 10" + (y += 10));
            Console.WriteLine("The result of Second numver with a negative of 10" + (y -= 10));
*/
            Console.WriteLine("\n\nPress Enter key twice to exit...");
            Console.ReadLine();
        }
    }
}
