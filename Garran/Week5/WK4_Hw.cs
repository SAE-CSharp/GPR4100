using System;

namespace Wk4_Hw
{
    class Program
    { // enumerator represents the players names.
        enum players_names { Tom=1, Fred, Mark, lee };
        static void Main(string[] args)
        {
            // array represents the array scores
            int leeVal = (int)players_names.lee;
            Console.WriteLine(leeVal);
            int[] scores = new int[(int)players_names.lee];
            int arrayLength = scores.Length;

            Console.WriteLine("//**************LeaderBoard**********//");
            Console.WriteLine("//player 1//=============// " + 0);
            Console.WriteLine("//player 2//=============// " + 0);
            Console.WriteLine("//player 3//=============// " + 0);
            Console.WriteLine("//player 4//=============// " + 0);

            int first_player_score;
            int second_player_score;
            int third_player_score;
            int fourth_player_score;

            for (int i=0; i <arrayLength;i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("Enter the first score: ");
                    //first_player_score = Convert.ToInt32(Console.ReadLine()); //first way
                    first_player_score = Int32.Parse(Console.ReadLine()); //second way
                    scores[0] = first_player_score;

                    Console.WriteLine("Enter the second score: ");
                    second_player_score = Int32.Parse(Console.ReadLine());
                    scores[1] = second_player_score;

                    Console.WriteLine("Enter the third score: ");
                    third_player_score = Int32.Parse(Console.ReadLine());
                    scores[2] = third_player_score;

                    Console.WriteLine("Enter the fourth score: ");
                    fourth_player_score = Int32.Parse(Console.ReadLine());
                    scores[3] = fourth_player_score;


                    Console.WriteLine("//**************LeaderBoard**********//");
                    Console.WriteLine("//player 1//=============// " + scores[0]);
                    Console.WriteLine("//player 2//=============// " + scores[1]);
                    Console.WriteLine("//player 3//=============// " + scores[2]);
                    Console.WriteLine("//player 4//=============// " + scores[3]);
                }
            }
        }
    }
}
