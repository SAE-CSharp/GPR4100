// TASK 5.1: CHOOSE YOUR PATH
    // Create a program that allows the user to input a number in
    // order to make a choice out of a number of narrative options.
    // Your program must include the following methods:
    // + Switch statements including: case, default, break
    // + If or If else statements
    // - Integer, character, boolean and string data types
    // + Cast conversion (Parse)
    // + Console out and console in

using System;

namespace MCarpenter_textAdventure1
{
    class Program
    {
        static void Main(string[] args)
        {
            int action;
            bool playerAlive = true;

            Console.WriteLine("Welcome to my text adventure game!\nYou will have a series of obstacles, and must choose what to do to pass them.");

            Console.WriteLine("You enter a winding corridor, and the first obstacle you encounter is a pit.");
            Console.WriteLine("  [1] Try to jump across\n  [2] Swing on a rope hanging from the ceiling\n  [3] Use handholds in the wall to climb over");
        input1:
            action = Int32.Parse(Console.ReadLine());

            switch (action)
            {
                case 1:
                    Console.WriteLine("\nThe pit is wider than it looked, and you don't quite make it across.");
                    playerAlive = false;
                    break;
                case 2:
                    Console.WriteLine("\nYou make it safely across the pit!");
                    playerAlive = true;
                    break;
                case 3:
                    Console.WriteLine("\nThe wall is wet and slippery, and you lose your grip while trying to climb over.");
                    playerAlive = false;
                    break;
                default:
                    Console.WriteLine("Please enter a valid option.");
                    goto input1;
            }

            if (playerAlive == true)
            {
            Console.WriteLine("Beyond the pit, you enter a room, and a door closes behind you. There is a door on the other side of the room, and a lever on either side of the door.");
            Console.WriteLine("  [1] Pull the lever on the left\n  [2] Pull the lever on the right");
        input2:
            action = Int32.Parse(Console.ReadLine());

            switch (action)
            {
                case 1:
                    Console.WriteLine("\nThe door opens, allowing you to continue!.");
                    playerAlive = true;
                    break;
                case 2:
                    Console.WriteLine("\nThe ceiling begins to descend. What do you do?");
                    Console.WriteLine("  [1] Reset the lever\n  [2] Pull the other lever");
                    action = Int32.Parse(Console.ReadLine());
                    if (action == 1)
                    {
                        Console.WriteLine("\nThe ceiling goes back up again, allowing you to pull the other lever and open the door!");
                        playerAlive = true;
                    }
                    else
                    {
                        Console.WriteLine("\nThe ceiling descends even faster, crushing you underneath.");
                        playerAlive = false;
                    }
                    break;
                default:
                    Console.WriteLine("Please enter a valid option.");
                    goto input2;
            }
            }


            if (playerAlive == true)
            {
                Console.WriteLine("\nCongratulations! You made it to the end.");
            }
            else
            {
                Console.WriteLine("\nGame over :(");
            }

            Console.WriteLine("\nThis game is a work in progress, and will be added to at a later date. Thank you for playing!");
        }
    }
}
