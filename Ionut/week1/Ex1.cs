using System;

namespace exe2
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "Ionut";
            string institute = "SAE";
            float distance = 39.3f;
            int Age = 29;

            Console.WriteLine("My name is " + myName);
            Console.WriteLine("I\'m a student at " + institute + " and I\'m " + Age + "years old \n studying \"GPR4100\" ");
            Console.WriteLine("I live in Reading \t which is " + distance + " miles away from " + institute );
            
        }
    }
}
