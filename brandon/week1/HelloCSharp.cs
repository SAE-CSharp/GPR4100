//Csharp thing
using System;

namespace excorcise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = "Bruh";
            int Age = 18;
            float time = 12.5f;
            float time2 = 07.00f;
            char f = 'f';
            char i = 'i';
            char n = 'n';
            Console.WriteLine("Hello my name is "+Name+"\n I\'m "+Age+"\n The time is probably not \t"+time);
            Console.WriteLine("who are you?");
            string peopleName = Console.ReadLine();
            Console.WriteLine("Hello "+peopleName+"\n\t\twhy did i wake up at "+time2+"\t\t\t\teverything hurts");
            Console.WriteLine(f+" "+i+" "+n);

            int result;
            int x = 10;
            int y = 20;
            result = (x + y);
            Console.WriteLine("x + y is " + result);
            result = (x - y); // result value can be changed without being declared agfain it has already been declared before, just not given a value
            Console.WriteLine("X minus Y is " + result);
            result = (x * y);
            Console.WriteLine("x * y is " + result);
            result = (x / y);
            Console.WriteLine("X/Y is "+ result);
            result = (x % y);
            Console.WriteLine("X mod Y is " + result);
            x--; // decrementing the value of x by one, must be done seperately as it is affecting the value of a variable
            y++; // incrimenting the value of y by one
            result = (x + y);
            Console.WriteLine("(x-1) + (y+1) is " + result);
        
        }
    }
}
