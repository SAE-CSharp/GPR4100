using System;

namespace EXC2
{
    class Program
    {
        static void Main(string[] args)
        {

            string fullName;//assigning fullname 
            
            Console.WriteLine("What is your full name?");//asking for user input 
            fullName = Console.ReadLine();//storing users answer
            Console.WriteLine("So your name is: " + fullName);//asking user name is correct
            Console.WriteLine("How about another name?...");//exit prompt
            fullName = Console.ReadLine();
            Console.WriteLine("How old are you?");
            int Age = Int32.Parse(Console.ReadLine());//conversion needed as ALL user input is string
            Console.WriteLine("Your age is..." + Age);
            Console.WriteLine("How far do you travel to work?");
            float distance = float.Parse(Console.ReadLine());
            Console.WriteLine("The distance you travel is..." + distance);
            Console.WriteLine("Press any key to close!");







        }
    }
}
