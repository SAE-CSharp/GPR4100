using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creative_Narrative___A_Simple_Maze_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Welcome, player. Welcome to my simple maze game.");
            Console.WriteLine("This is the first game that I have createad using C#, so please be nice  :)");

            Console.WriteLine("What would you like your username to be?");
            string username = Console.ReadLine();
            Console.WriteLine(username + " will be your username.");

            int score = 0;

            Console.WriteLine("START");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("You can go one of four ways. Enter \'w\' to move forward, \'s\' to move back, \'a\' to move left and \'d\' to move right.");
            char move1 = Convert.ToChar(Console.ReadLine());

            switch (move1)
            {
                case 'w':
                    Console.WriteLine(username + " got impaled by spikes.");
                    Console.WriteLine("");
                    Console.WriteLine("YOU DIED");
                    Console.WriteLine("");

                    score = score - 1;
                    Console.WriteLine("Your total score for this run is " + score + ".");
                    break;

                case 's':
                    Console.WriteLine(username + " walks backwards and is presented with two ways: left or right.");
                    Console.WriteLine("Which way will " + username + " go?");

                    score = score + 2;

                    char move2 = Convert.ToChar(Console.ReadLine());

                    if (move2 == 'a')
                    {
                        Console.WriteLine("The floor opens up, revealing as massive pit of lava below. " + username + " falls, burning to");
                        Console.WriteLine("death in the boiling pool of magma.");
                        Console.WriteLine("");
                        Console.WriteLine("YOU DIED");
                        Console.WriteLine("");

                        score = score - 1;
                        Console.WriteLine("Your total score for this run is " + score + ".");
                    }

                    else if (move2 == 'd')
                    {
                        Console.WriteLine(username + " talks the corridor to the right, and is presented with either going right or");
                        Console.WriteLine("forwards. What will they chose????????????");

                        score = score + 2;
                    }

                    break;

                case 'a':
                    Console.WriteLine(username + " sets off the sensors in the corridor, and hundreds of arrows sprint towards " + username);
                    Console.WriteLine("and kill him withing seconds.");
                    Console.WriteLine("");
                    Console.WriteLine("YOU DIED");
                    Console.WriteLine("");
                    break;

                case 'd':
                    Console.WriteLine(username + " turns right and walks down the hallway. " + username + " is presented with two ways");
                    Console.WriteLine("to go; forwards or left. Which way will " + username + " go?");
                    break;

                default:
                    Console.WriteLine("u stoopid");
                    break;
            }


            Console.ReadLine();
        }
    }
}
