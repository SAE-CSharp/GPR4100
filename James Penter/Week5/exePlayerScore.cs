using System;

namespace exePlayerscore
{
    class Program
    {enum player_names
        {
            Steph = 1,
            Tom,
            Dan,
            Jack
        };

        static void Main(string[] args)
        {
            int jackVal = (int)player_names.Jack;
            int[] player_scores = new int[jackVal];
            int first_player_score;
            int second_player_score;
            int third_player_score;
            int fourth_player_score;

            int arraylength = player_scores.Length;
            Console.WriteLine("//========Leaderboard============//");
            Console.WriteLine("//Player1 ============//"+0);
            Console.WriteLine("//Player2 ============//"+0);
            Console.WriteLine("//Player3============//"+0);
            Console.WriteLine("//Player4============//"+0);

            for (int i = 0; i < arraylength; i++) 
            {
                if (i== 0)
                    {
                    Console.WriteLine("Choose the first player score: ");
                    first_player_score = Int32.Parse(Console.ReadLine());
                    player_scores[0] = first_player_score;

                    Console.WriteLine("//========Leaderboard============//");
                    Console.WriteLine("//Player1 ============//" + player_scores[0]);
                    if (i == 1)
                        continue;
                    {
                        Console.WriteLine("Choose the second player score: ");
                        second_player_score = Int32.Parse(Console.ReadLine());
                        player_scores[0] = second_player_score;
                        Console.WriteLine("//Player2 ============//"+ player_scores[0]);
                        
                    }
                    if (i == 2)
                        continue;
                    {
                        Console.WriteLine("Choose the third player score: ");
                        third_player_score = Int32.Parse(Console.ReadLine());
                        player_scores[0] = third_player_score;
                        Console.WriteLine("//Player3 ============//" + player_scores[0]);
                        
                    }
                    if (i == 3)
                        continue;
                    {
                        Console.WriteLine("Choose the fourth player score: ");
                        fourth_player_score = Int32.Parse(Console.ReadLine());
                        player_scores[0] = fourth_player_score;
                        Console.WriteLine("//Player4 ============//" + player_scores[0]);
                        Console.WriteLine("//========Leaderboard============//\nSo the scores for each player are:\n" + "Player1:" + first_player_score + "\n" + "Player2:" + second_player_score + "\n" + "Player3:" + third_player_score + "\n" + "Player4:" + fourth_player_score);
                        break;
                    }
                    
                   





                }
            }


        }
    }
}
