using System;

namespace Enumeration
{
    class Program
    {
        //Create Enumeration
        enum Level { Easy, Medium, Hard};

        static void Main(string[] args)
        {
            Console.WriteLine("Which Level would you like to play?\n1. Easy\n2. Medium\n3. Hard\n\nUse the Numbers, this is cases sensitive.");
            int levelChoice = Convert.ToInt32(Console.ReadLine());
            if (levelChoice == 1)
            {
                Console.WriteLine("You have chosen "+Level.Easy+"\nAre you scared or new?");
                //the value of the level element
                int eleValue = (int)Level.Easy;
                Console.WriteLine("The Value of the Easy Level is "+eleValue);


            }
            else if (levelChoice == 2)
            {
                Console.WriteLine("You have chosen "+Level.Medium+"\nYou've got some experiance but not much.");
                int eleValue = (int)Level.Medium;
                Console.WriteLine("The Value of the Medium Level is " + eleValue);
            }
            else if (levelChoice == 3)
            {
                Console.WriteLine("You have chosen "+Level.Hard+"\nYou're a pro gamer.");
                int eleValue = (int)Level.Hard;
                Console.WriteLine("The Value of the Hard Level is " + eleValue);
            }
            else
            {
                Console.WriteLine("Error 404:\nUsers Brain could not be found!");
            }
        }
    }
}
