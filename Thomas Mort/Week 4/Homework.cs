using System;

namespace ConsoleApp3
{
    class Program
    {
        enum player { Player1, Player2, Player3, Player4, Player5 };
        static void Main(string[] args)
        {
            int AmtOfPlayers = 0;
            int[] playerScore = new int[5];
            Console.WriteLine("How many players are there?");
            AmtOfPlayers = Int32.Parse(Console.ReadLine());
            if (AmtOfPlayers == 2)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("\nPlease enter the score for player One");
                    playerScore[0] = Int32.Parse(Console.ReadLine());
                    Console.WriteLine(player.Player1 + " scored " + playerScore[0]);
                    Console.WriteLine("\nPlease enter the score for player Two");
                    playerScore[1] = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("\n       Leaderboard:      \n");
                    Console.WriteLine(player.Player1 + " scored " + playerScore[0] + "! \n" + player.Player2 + " scored " + playerScore[1] + "!");

                    break;
                }
            }
            else if (AmtOfPlayers == 3)
            {

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("\nPlease enter the score for player One");
                    playerScore[0] = Int32.Parse(Console.ReadLine());
                    Console.WriteLine(player.Player1 + " scored " + playerScore[0]);
                    Console.WriteLine("\nPlease enter the score for player Two");
                    playerScore[1] = Int32.Parse(Console.ReadLine());
                    Console.WriteLine(player.Player1 + " scored " + playerScore[0] + "! \n" + player.Player2 + " scored " + playerScore[1] + "!");
                    Console.WriteLine("\nPlease enter the score for player Three");
                    playerScore[2] = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("\n       Leaderboard:      \n");
                    Console.WriteLine(player.Player1 + " scored " + playerScore[0] + "! \n" + player.Player2 + " scored " + playerScore[1] + "! \n" + player.Player3 + " scored " + playerScore[2] + "!");

                    break;
                }
            }
            else if (AmtOfPlayers == 4)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("\nPlease enter the score for player One");
                    playerScore[0] = Int32.Parse(Console.ReadLine());
                    Console.WriteLine(player.Player1 + " scored " + playerScore[0]);
                    Console.WriteLine("\nPlease enter the score for player Two");
                    playerScore[1] = Int32.Parse(Console.ReadLine());
                    Console.WriteLine(player.Player1 + " scored " + playerScore[0] + "! \n" + player.Player2 + " scored " + playerScore[1] + "!");
                    Console.WriteLine("\nPlease enter the score for player Three");
                    playerScore[2] = Int32.Parse(Console.ReadLine());
                    Console.WriteLine(player.Player1 + " scored " + playerScore[0] + "! \n" + player.Player2 + " scored " + playerScore[1] + "! \n" + player.Player3 + " scored " + playerScore[2] + "!");
                    Console.WriteLine("\nPlease enter the score for player Four");
                    playerScore[3] = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("\n       Leaderboard:      \n");
                    Console.WriteLine(player.Player1 + " scored " + playerScore[0] + "! \n" + player.Player2 + " scored " + playerScore[1] + "! \n" + player.Player3 + " scored " + playerScore[2] + "! \n" + player.Player4 + " scored " + playerScore[3] + "!");
                    break;
                }
            }
            else if (AmtOfPlayers == 5)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Please enter the score for player One");
                    playerScore[0] = Int32.Parse(Console.ReadLine());
                    Console.WriteLine(player.Player1 + " scored " + playerScore[0]);
                    Console.WriteLine("\nPlease enter the score for player Two");
                    playerScore[1] = Int32.Parse(Console.ReadLine());
                    Console.WriteLine(player.Player1 + " scored " + playerScore[0] + "! \n" + player.Player2 + " scored " + playerScore[1] + "!");
                    Console.WriteLine("\nPlease enter the score for player Three");
                    playerScore[2] = Int32.Parse(Console.ReadLine());
                    Console.WriteLine(player.Player1 + " scored " + playerScore[0] + "! \n" + player.Player2 + " scored " + playerScore[1] + "! \n" + player.Player3 + " scored " + playerScore[2] + "!");
                    Console.WriteLine("\nPlease enter the score for player Four");
                    playerScore[3] = Int32.Parse(Console.ReadLine());
                    Console.WriteLine(player.Player1 + " scored " + playerScore[0] + "! \n" + player.Player2 + " scored " + playerScore[1] + "! \n" + player.Player3 + " scored " + playerScore[2] + "! \n" + player.Player4 + " scored " + playerScore[3] + "!");
                    Console.WriteLine("\nPlease enter the score for player Five");
                    playerScore[4] = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("\n       Leaderboard:      \n");
                    Console.WriteLine(player.Player1 + " scored " + playerScore[0] + "! \n" + player.Player2 + " scored " + playerScore[1] + "! \n" + player.Player3 + " scored " + playerScore[2] + "! \n" + player.Player4 + " scored " + playerScore[3] + "! \n" + player.Player5 + " scored " + playerScore[4] + "!");
                    break;
                }
            }
            else
            {
                Console.WriteLine("That was invalid... pick between 2 and 5.");
            }
        }
    }
}
