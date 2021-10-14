using System;

namespace Methods
{
    class Program
    {
        //Methods must go inside a class
        // a static method will only accept anothe static method
        static void Method1(string type)
        {
            Console.WriteLine("This is a method it is very "+type);
        }

        static int Plus(int num, int num2)
        {
            int result = num + num2;
            return result;
        }

        static void Number()
        {
            Console.WriteLine("What is your name");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter a number");
            int number = Int32.Parse(Console.ReadLine());
            Console.WriteLine("You entered "+number+", didnt you, "+name);
            
        }

        static void Hello()
        {
            string[] Locations = new string[3] {"liverpool","glasgow","london" };
            Console.WriteLine("Hello Sae");
            Console.WriteLine("What campus do you go to?");
            string Location = Console.ReadLine();
            for (int i = 0; i < Locations.Length; i++)
            {
                if (Location.ToLower() == Locations[i])
                {
                    Console.WriteLine("Wow I also go to Sae " + Locations[i]);
                    return;
                }
                else
                {
                    Console.WriteLine("I don\'t know about that campus");
                    return;
                }
            }
        }

        //-----------------Main Method--------------------------------------------------------

        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int Value = Int32.Parse(Console.ReadLine());
            Console.WriteLine("enter another number");
            int Value2 = Int32.Parse(Console.ReadLine());
            int plus = Plus(Value,Value2);
            Console.WriteLine("the values added are " + plus);
            Method1("simple");
            Hello();
            Number();
        }
    }
}
