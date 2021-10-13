using System;

namespace ConsoleApp9
{
    class Program
    {
        enum playerNames { Player1 = 1, Player2, Player3, Player4, Player5}; //Player 1 has value of 1, player 5 has value of 5.
        static void Main(string[] args)
        { 
            int ArrayLen = (int)playerNames.Player5; // First way to do it. Makes a variable called Player5Val
            int[] playerScores = new int[(int)playerNames.Player5]; // or Player5Val];  Second way to do it
            int First_PlayerScore, Second_PlayerScore, Third_PlayerScore, Fourth_PlayerScore, Fifth_PlayerScore;
            Console.WriteLine("*************Leaderboard!*************");
            Console.WriteLine("Player 1: " + 0);
            Console.WriteLine("Player 2: " + 0);
            Console.WriteLine("Player 3: " + 0);
            Console.WriteLine("Player 4: " + 0);
            Console.WriteLine("Player 5: " + 0);
            for (int i = 0; i<ArrayLen; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("What is the first players score?");
                    First_PlayerScore = Int32.Parse(Console.ReadLine()); // Convert.ToInt32((Console.ReadLine());
                    playerScores[0] = First_PlayerScore;
                    Console.WriteLine("*************Leaderboard!*************");
                    Console.WriteLine("Player 1: " + playerScores[0]);
                    Console.WriteLine("Player 2: " + 0);
                    Console.WriteLine("Player 3: " + 0);
                    Console.WriteLine("Player 4: " + 0);
                    Console.WriteLine("Player 5: " + 0);
                }
                if (i == 1)
                {
                    Console.WriteLine("What is the Second players score?");
                    Second_PlayerScore = Int32.Parse(Console.ReadLine());
                    playerScores[1] = Second_PlayerScore;
                    Console.WriteLine("*************Leaderboard!*************");
                    Console.WriteLine("Player 1: " + playerScores[0]);
                    Console.WriteLine("Player 2: " + playerScores[1]);
                    Console.WriteLine("Player 3: " + 0);
                    Console.WriteLine("Player 4: " + 0);
                    Console.WriteLine("Player 5: " + 0);
                }
                if (i == 2)
                {
                    Console.WriteLine("What is the Third players score?");
                    Third_PlayerScore = Int32.Parse(Console.ReadLine());
                    playerScores[2] = Third_PlayerScore;
                    Console.WriteLine("*************Leaderboard!*************");
                    Console.WriteLine("Player 1: " + playerScores[0]);
                    Console.WriteLine("Player 2: " + playerScores[1]);
                    Console.WriteLine("Player 3: " + playerScores[2]);
                    Console.WriteLine("Player 4: " + 0);
                    Console.WriteLine("Player 5: " + 0);
                }
                if (i == 3)
                {
                    Console.WriteLine("What is the Fourth players score?");
                    Fourth_PlayerScore = Int32.Parse(Console.ReadLine());
                    playerScores[3] = Fourth_PlayerScore;
                    Console.WriteLine("*************Leaderboard!*************");
                    Console.WriteLine("Player 1: " + playerScores[0]);
                    Console.WriteLine("Player 2: " + playerScores[1]);
                    Console.WriteLine("Player 3: " + playerScores[2]);
                    Console.WriteLine("Player 4: " + playerScores[3]);
                    Console.WriteLine("Player 5: " + 0);
                }
                if (i == 4)
                {
                    Console.WriteLine("What is the Fifth players score?");
                    Fifth_PlayerScore = Int32.Parse(Console.ReadLine());
                    playerScores[4] = Fifth_PlayerScore;
                    Console.WriteLine("*************Leaderboard!*************");
                    Console.WriteLine("Player 1: " + playerScores[0]);
                    Console.WriteLine("Player 2: " + playerScores[1]);
                    Console.WriteLine("Player 3: " + playerScores[2]);
                    Console.WriteLine("Player 4: " + playerScores[3]);
                    Console.WriteLine("Player 5: " + playerScores[4]);
                }
            }
        }
    }
}
