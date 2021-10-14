using System;

namespace Leaderboard
{
    class Program
    {
        enum userNames { player1 = 1, player2 = 2, player3 =3, player4 =4, player5 =5 };
        static void Main(string[] args)
        {
            int ArrayLen = (int)userNames.player5;

            int[] playerscores = new int[(int)userNames.player5];

            int player1score, player2score, player3score, player4score, player5score;
            Console.WriteLine("-Leaderboard-");
            Console.WriteLine("player 1: " + 0);
            Console.WriteLine("player 2: " + 0);
            Console.WriteLine("player 3: " + 0);
            Console.WriteLine("player 4: " + 0);
            Console.WriteLine("player 5: " + 0);
            for (int i = 0; i < ArrayLen; i++)
            {
                if (i == 0)
                {
                    Console.Write("enter score : ");
                    player1score = Int32.Parse(Console.ReadLine()); 
                    playerscores[0] = player1score;
                    Console.WriteLine("-Leaderboard-");
                    Console.WriteLine("player 1: " + playerscores[0]);
                    Console.WriteLine("player 2: " + 0);
                    Console.WriteLine("player 3: " + 0);
                    Console.WriteLine("player 4: " + 0);
                    Console.WriteLine("player 5: " + 0);
                }
                if (i == 1)
                {
                    Console.Write("enter score: ");
                    player2score = Int32.Parse(Console.ReadLine());
                    playerscores[1] = player2score;
                    Console.WriteLine("-Leaderboard-");
                    Console.WriteLine("player 1: " + playerscores[0]);
                    Console.WriteLine("player 2: " + playerscores[1]);
                    Console.WriteLine("player 3: " + 0);
                    Console.WriteLine("player 4: " + 0);
                    Console.WriteLine("player 5: " + 0);
                }
                if (i == 2)
                {
                    Console.Write("enter score: ");
                    player3score = Int32.Parse(Console.ReadLine());
                    playerscores[2] = player3score;
                    Console.WriteLine("-Leaderboard-");
                    Console.WriteLine("player 1: " + playerscores[0]);
                    Console.WriteLine("player 2: " + playerscores[1]);
                    Console.WriteLine("player 3: " + playerscores[2]);
                    Console.WriteLine("player 4: " + 0);
                    Console.WriteLine("player 5: " + 0);
                }
                if (i == 3)
                {
                    Console.Write("enter score: ");
                    player4score = Int32.Parse(Console.ReadLine());
                    playerscores[3] = player4score;
                    Console.WriteLine("-Leaderboard-");
                    Console.WriteLine("player 1: " + playerscores[0]);
                    Console.WriteLine("player 2: " + playerscores[1]);
                    Console.WriteLine("player 3: " + playerscores[2]);
                    Console.WriteLine("player 4: " + playerscores[3]);
                    Console.WriteLine("Player 5: " + 0);
                }
                if (i== 4)
                {
                    Console.Write("enter score: ");
                    player5score = Int32.Parse(Console.ReadLine());
                    playerscores[4] = player5score;
                    Console.WriteLine("-Leaderboard-");
                    Console.WriteLine("player 1: " + playerscores[0]);
                    Console.WriteLine("player 2: " + playerscores[1]);
                    Console.WriteLine("player 3: " + playerscores[2]);
                    Console.WriteLine("player 4: " + playerscores[3]);
                    Console.WriteLine("player 5: " + playerscores[4]);
                }

            }
            Console.ReadLine();
            
        }
    }
}
