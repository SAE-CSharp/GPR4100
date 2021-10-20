using System;

namespace Leaderboard__quiz_homework_done_properly_
{
    class Program
    {
        enum playerName 
        { 
            Steph=1, //1
            Tom, //2
            Dan, //3
            Jack //4
        };
        static void Main(string[] args)
        {
            int arrayLength = (int)playerName.Jack;
            int[] playerScores = new int[arrayLength];
            //int[] playerScores = new int[(int)playerName.Jack];
            int player1Score;
            int player2Score;
            int player3Score;
            int player4Score;
            int arrayLen = playerScores.Length;
            Console.WriteLine("~ ~ LEADERBOARD ~ ~");
            Console.WriteLine("~ ~ Player 1 ~ ~  = " + 0);
            Console.WriteLine("~ ~ Player 2 ~ ~  = " + 0);
            Console.WriteLine("~ ~ Player 3 ~ ~  = " + 0);
            Console.WriteLine("~ ~ Player 4 ~ ~  = " + 0);


            for (int i = 0; i < arrayLen; i++)
            {

                if (i == 0)
                {
                    Console.Write("Enter Player 1's Score: ");
                    player1Score = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n");
                    playerScores[i] = player1Score;
                }
                if(i == 1)
                {
                    Console.Write("Enter Player 2's Score: ");
                    player2Score = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n");
                    playerScores[i] = player2Score;
                }
                if (i == 2)
                {
                    Console.Write("Enter Player 3's Score: ");
                    player3Score = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n");
                    playerScores[i] = player3Score;
                }
                if (i == 3)
                {
                    Console.Write("Enter Player 4's Score: ");
                    player4Score = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n");
                    playerScores[i] = player4Score;
                }
                Console.WriteLine("~ ~ ~ ~ ~ ~ ~ ~ ~ ~");
                Console.WriteLine("~ ~ LEADERBOARD ~ ~");
                Console.WriteLine("~ ~ OPEN ~ ~");
                Console.WriteLine("~ ~ Player 1 ~ ~  = " + playerScores[0]);
                Console.WriteLine("~ ~ Player 2 ~ ~  = " + playerScores[1]);
                Console.WriteLine("~ ~ Player 3 ~ ~  = " + playerScores[2]);
                Console.WriteLine("~ ~ Player 4 ~ ~  = " + playerScores[3]);
                Console.WriteLine("~ ~ LEADERBOARD ~ ~");
                Console.WriteLine("~ ~ CLOSED ~ ~");
                Console.WriteLine("~ ~ ~ ~ ~ ~ ~ ~ ~ ~");

            }


        }
    }
}
