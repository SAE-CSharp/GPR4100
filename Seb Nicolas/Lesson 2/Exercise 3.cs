using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {

            string fullName;
            int age;
            float distance;
            char institute;

            Console.WriteLine("Hello! Please enter your name:");
            fullName = Console.ReadLine();
            Console.WriteLine("Hello there " + fullName);
            Console.WriteLine("Wait.. Are you sure you want to be called " + fullName + "?");
            Console.WriteLine("Just to be sure, Enter your name again:");
            fullName = Console.ReadLine();
            Console.WriteLine("Cool. Hello there " + fullName);
            Console.WriteLine("So... How old are you?");
            age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nice! I am also " + age + " years old! haha");
            Console.WriteLine("***********************************************");
            Console.WriteLine("What's the first letter of your Institute's name?");
            institute = char.Parse(Console.ReadLine());
            Console.WriteLine("The First letter of the institute is: " + institute);
            Console.WriteLine("***********************************************");
            Console.WriteLine("How far do you live from your university?");
            distance = float.Parse(Console.ReadLine());
            Console.WriteLine(distance + "miles?!?!?! WOAH! That's alotta damage!");
            Console.WriteLine("***********************************************");
            Console.WriteLine("Summery of Information Submitted:");
            Console.WriteLine("Name: " + fullName);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Institute Char: " + institute);
            Console.WriteLine("Distance: " + distance);

        }
    }
}
