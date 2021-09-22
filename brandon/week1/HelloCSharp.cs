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
        }
    }
}
