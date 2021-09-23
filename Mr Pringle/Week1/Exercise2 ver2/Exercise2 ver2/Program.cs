using System;

namespace Exercise2_ver2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Name.");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Second Name.");
            string secondName = Console.ReadLine();
            Console.WriteLine("Hello " + firstName + " " + secondName+".\nHow old are you?");
            int age = Convert.ToInt32(Console.ReadLine());
            string fullName = firstName +" "+ secondName;
            Console.WriteLine("what is the approximate distance from your home to the city in miles?");
            double distance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hello " + fullName + " you have entered that you are " + age + " years old.\nYou have stated that you travle approximatly "+distance+" miles to get to the city from your home");
            char[] charArray = firstName.ToCharArray();
            char firstLetter = charArray[0];
            Console.WriteLine("Your first enitial is "+firstLetter);


        }
    }
}
