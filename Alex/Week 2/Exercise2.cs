using System;

namespace IF_statements
{
    class Program
    {
        static void Main(string[] args)
        {

            string Yes;
            string No;
            string yes;
            string no;
            string y;
            string n;
            string Y;
            string N;
            string FullName;
            Console.WriteLine("Enter your full name");
            FullName = Console.ReadLine();
            Console.WriteLine("Your name is " + FullName);
            Console.WriteLine("are you sure " + FullName + " is your name?" );
            FullName = Console.ReadLine();

            Console.WriteLine("How old are you?");
            int Age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Are you sure your age is " + Age + "?");
            Console.ReadLine();

            Console.WriteLine("In miles, How far is your accommodation from the SAE Liverpool?");
            float distance = float.Parse(Console.ReadLine());
            Console.WriteLine("The distance is " + distance + "miles from SAE Liverpool, Correct?");
            Yes = Console.ReadLine();
            yes = Console.ReadLine();
            Y = Console.ReadLine();
            y = Console.ReadLine();

            Console.WriteLine("Thank you for your time");
