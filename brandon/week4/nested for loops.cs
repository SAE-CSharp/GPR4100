using System;

namespace Week4_homework_excercise
{
    class Program
    {
        enum player_names { Jack = 1, Brandon, John, Mark };
        static void Main(string[] args)
        {
            int first_player_score, second_player_score, third_player_score, fourth_player_score;
            int MarkVal = (int)player_names.Mark;
            int[] player_scores = new int[MarkVal];

            int arrayLen = player_scores.Length;
            Console.WriteLine("-------------//LeaderBoard//--------------");
            Console.WriteLine("Player 1//============//"+0);
            Console.WriteLine("Player 2//============//" + 0);
            Console.WriteLine("Player 3//============//" + 0);
            Console.WriteLine("Player 4//============//" + 0);

            for (int i = 0; i<arrayLen; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("Enter the first score");
                    first_player_score = Convert.ToInt32(Console.ReadLine());
                    player_scores[0] = first_player_score;
                    Array.Sort(player_scores);
                    Array.Reverse(player_scores);

                    Console.WriteLine("-------------//LeaderBoard//--------------");
                    Console.WriteLine("Player 1//============//" + player_scores[0]);
                    Console.WriteLine("Player 2//============//" + 0);
                    Console.WriteLine("Player 3//============//" + 0);
                    Console.WriteLine("Player 4//============//" + 0);

                }
                if (i == 1)
                {
                    Console.WriteLine("Enter the first score");
                  /*second_player_score = Convert.ToInt32(Console.ReadLine());*/
                    second_player_score = Int32.Parse(Console.ReadLine());
                    player_scores[1] = second_player_score;
                    Array.Sort(player_scores);
                    Array.Reverse(player_scores);

                    Console.WriteLine("-------------//LeaderBoard//--------------");
                    Console.WriteLine("Player 1//============//" + player_scores[0]);
                    Console.WriteLine("Player 2//============//" + player_scores[1]);
                    Console.WriteLine("Player 3//============//" + 0);
                    Console.WriteLine("Player 4//============//" + 0);

                }
                if (i == 2)
                {
                    Console.WriteLine("Enter the first score");
                    third_player_score = Convert.ToInt32(Console.ReadLine());
                    player_scores[2] = third_player_score;
                    Array.Sort(player_scores);
                    Array.Reverse(player_scores);

                    Console.WriteLine("-------------//LeaderBoard//--------------");
                    Console.WriteLine("Player 1//============//" + player_scores[0]);
                    Console.WriteLine("Player 2//============//" + player_scores[1]);
                    Console.WriteLine("Player 3//============//" + player_scores[2]);
                    Console.WriteLine("Player 4//============//" + 0);

                }
                if (i == 3)
                {
                    Console.WriteLine("Enter the first score");
                    fourth_player_score = Convert.ToInt32(Console.ReadLine());
                    player_scores[3] = fourth_player_score;
                    Array.Sort(player_scores);
                    Array.Reverse(player_scores);

                    Console.WriteLine("-------------//LeaderBoard//--------------");
                    Console.WriteLine("Player 1//============//" + player_scores[0]);
                    Console.WriteLine("Player 2//============//" + player_scores[1]);
                    Console.WriteLine("Player 3//============//" + player_scores[2]);
                    Console.WriteLine("Player 4//============//" + player_scores[3]);

                }
            }
        }
    }
}
