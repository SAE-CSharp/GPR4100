
using System;

namespace format_output
{
    class Program
    {
        static void Main(string[] args)
        {
            //formatted output
            string str = "Hello World";
            //normal print
            Console.WriteLine(str);
            //through formatting strig print
            Console.WriteLine("{0}", str);


            string name = "John";
            int age = 18;
            string town = "Seattle";
            Console.WriteLine("{0} is {1} years old from {2}!\n", name, age, town);
            //0 is name, 1 is age and 2 is town
            // this is determind by the order in the Console.WriteLine line
        }
    }
}
