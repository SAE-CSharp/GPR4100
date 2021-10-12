using System;

namespace MCarpenter_Wk4_Leaderboard_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxIndex = 4;

            int[] lBoard_scores = new int[maxIndex + 1];
            string[] lBoard_names = new string[maxIndex + 1];

            int scoreNew = 0, scoreCheck = 0, newPos = 6;
            string nameNew = "";

            while (true)

            {
                scoreNew = 0;
                scoreCheck = 0;
                newPos = maxIndex + 2;

                Console.WriteLine("Please input your name.");
                nameNew = Console.ReadLine();

                Console.WriteLine("");

                Console.WriteLine("Please input your score.\n(To exit, enter a score of 0.)");
                scoreNew = Int32.Parse(Console.ReadLine());

                if (scoreNew <= 0)
                { break; }

                Console.WriteLine("\n");

                for (int i = maxIndex; scoreNew >= scoreCheck; i--)
                {
                    scoreCheck = lBoard_scores[i];
                    if (scoreCheck > scoreNew)
                    {
                        newPos = (i + 1);
                    }

                    if (i == 0 && scoreCheck < scoreNew)
                    {
                        newPos = 0;
                        break;
                    }
                }

                for (int i = maxIndex; i > newPos; i--)
                {
                    lBoard_scores[i] = lBoard_scores[i - 1];
                    lBoard_names[i] = lBoard_names[i - 1];
                }

                if (newPos < lBoard_scores.Length)
                {
                    lBoard_scores[newPos] = scoreNew;
                    lBoard_names[newPos] = nameNew;
                }

                Console.Clear();
                Console.WriteLine("New score: " + scoreNew + "\n");
                Console.WriteLine("| -- LEADERBOARD --\n|");
                for (int i = 0; i < 5; i++)
                {
                    if (lBoard_scores[i] > 0)
                    {
                        Console.WriteLine("| " + (i + 1) + ": " + lBoard_names[i] + "\t" + lBoard_scores[i]);
                    }
                }

                Console.WriteLine("\n");

            }
        }
    }
}
