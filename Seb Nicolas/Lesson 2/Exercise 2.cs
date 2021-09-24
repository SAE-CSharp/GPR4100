using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {

            /* \' \" \\ \n \t */

            string myName = "Seb";
            string myInstitute = "SAE London";
            int myAge = 18;
            string myTown = "Burgess Hill";
            int instituteMiles = 68;

            Console.WriteLine("My Name Is " + myName);
            Console.WriteLine("I'm a student at " + myInstitute + ". I am " + myAge + " years old.");
            Console.WriteLine("I Live in " + myTown + " which is " + instituteMiles + " miles away from " + myInstitute);
            Console.WriteLine("My Hobbies are; Playing the Piano, Playing Video Games, and Coding");
            Console.WriteLine("My Folder Location is: C:\\Users\\Admin\\Exercise2.cs");

            int x = 50, y = 20;
            int resultA = x + y;
            // + Addition
            Console.WriteLine("\n The Result of X + Y Operation is " + (x + y));
            // - Subtration
            Console.WriteLine("\n The Result of X - Y Operation is " + (x - y));
            // / Devision
            Console.WriteLine("\n The Result of X / Y Operation is " + (x / y));
            // * Multiply
            Console.WriteLine("\n The Result of X * Y Operation is " + (x * y));
            // % Modulus
            Console.WriteLine("\n The Result of X % Y Operation is " + (x % y));

            Console.WriteLine("***************************************************************");

            int a = 7, b = 4;
            int resultB = a + b;
            Console.WriteLine("The Result of x / y =" + (x / y));
            Console.WriteLine("The Result of x / y =" + ((float)x / y));
            Console.WriteLine("The Result of x / y =" + (x / (float)y));

            Console.WriteLine("***************************************************************");

            int c = 5, d = 4;
            Console.WriteLine("The incrament of c is " + (c++));
            Console.WriteLine("The incrament of d is " + (d++));
            Console.WriteLine("The decrament of c is " + (c--));
            Console.WriteLine("The decrament of d is " + (d--));

            Console.WriteLine("***************************************************************");

            int f = 1, g = 3;

            f += 5; // f = f+5
            g -= 2; // g = g-2

        }
    }
}
