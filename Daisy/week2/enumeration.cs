using System;

namespace Enumeration
{
    class Program
    {
        // create enumeration
        enum Level {Easy, Medium, Hard}; 

        static void Main(string[] args)
        {
            int gameLevel;
          
           
            Console.WriteLine("What level would you like to play? \n 1 = Easy \n 2 = Medium \n 3 = Hard");
            gameLevel = Int32.Parse(Console.ReadLine());

            if (gameLevel == 1)
            {
                Console.WriteLine("You want to play the " +Level.Easy + " level?");
                //the value of the level element
                int eleValue = (int)Level.Easy; //ele at the start of value means element value.
                Console.WriteLine("The value of the easy level is " + eleValue);
            }
            else if (gameLevel == 2)
            {
                Console.WriteLine("You want to play the " + Level.Medium + " level?");
                int eleValue = (int)Level.Medium;
                Console.WriteLine("The value of the medium level is " + eleValue);
            }
            else if (gameLevel == 3)
            {
                Console.WriteLine("You want to play the " + Level.Hard + " level?");
                int eleValue = (int)Level.Hard;
                Console.WriteLine("The value of the hard level is " + eleValue);
            }
            else
            {
                Console.WriteLine("No Worries.");
            }

        }
    }
}
