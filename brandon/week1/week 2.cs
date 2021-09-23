using System;

namespace excercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = "";
            Console.WriteLine("Enter your name");
            Name = Console.ReadLine();
            Console.WriteLine("wow, your parents had no imagination did they, " + Name + "?\ndon\'t you want to change it?");
            Name = Console.ReadLine();
            Console.WriteLine("Well, " + Name +", how old are you?");
            int Age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Wow, "+ Age +", and you dont think thats kind of old?");
            Console.WriteLine("how far away do you live?");
            float Distance = float.Parse(Console.ReadLine());
            Console.WriteLine(Distance+" what? "+Distance+" miles or kilometers?");
            Console.WriteLine("What was the first letter of your name again ?");
            char Name1 = char.Parse(Console.ReadLine());
            Console.WriteLine(Name1+"?, what kind of name starts with a "+Name1+"?");

            Console.WriteLine("******************************");

        }   
    }
}
