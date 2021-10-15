using System;

namespace HW4
{
    class Program
    {
        enum player_names { Tony = 1, Seb, Jeff, Javier }; //enum players names
        static void Main(string[] args)
        {
            int JavVal = (int)player_names.Javier;
            Console.WriteLine(JavVal);
            int[] scores = new int[(int)player_names.Javier];
            int arraylength = scores.Length;

            //int arraylength = score.length;

            Console.WriteLine("//====================Leaderboard======================//");
            Console.WriteLine("//Player 1 ================================//");
            Console.WriteLine("//Player 2 ================================//");
            Console.WriteLine("//Player 3 ================================//");
            Console.WriteLine("//Player 4 ================================//");

            int first_playerscore;
            int second_playerscore;
            int third_playerscore;
            int fourth_playerscore;

            for (int i = 0; i < arraylength; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("Enter the first score!");
                    first_playerscore = Convert.ToInt32(Console.ReadLine());
                    scores[0] = first_playerscore;
                    Console.WriteLine("//====================Leaderboard======================//");
                    Console.WriteLine("//Player 1 ================================// " + scores[0]);
                    Console.WriteLine("//Player 2 ================================// " + 0);
                    Console.WriteLine("//Player 3 ================================// " + 0);
                    Console.WriteLine("//Player 4 ================================// " + 0);
                }
                else if (i == 1)
                {
                    Console.WriteLine("Enter the second score!");
                    second_playerscore = Convert.ToInt32(Console.ReadLine());
                    scores[1] = second_playerscore;
                    Console.WriteLine("//====================Leaderboard======================//");
                    Console.WriteLine("//Player 1 ================================// " + scores[0]);
                    Console.WriteLine("//Player 2 ================================// " + scores[1]);
                    Console.WriteLine("//Player 3 ================================// " + 0);
                    Console.WriteLine("//Player 4 ================================// " + 0);
                }
                else if (i == 2)
                {
                    Console.WriteLine("Enter the second score!");
                    third_playerscore = Convert.ToInt32(Console.ReadLine());
                    scores[2] = third_playerscore;
                    Console.WriteLine("//====================Leaderboard======================//");
                    Console.WriteLine("//Player 1 ================================// " + scores[0]);
                    Console.WriteLine("//Player 2 ================================// " + scores[1]);
                    Console.WriteLine("//Player 3 ================================// " + scores[2]);
                    Console.WriteLine("//Player 4 ================================// " + 0);
                }
                else if (i == 3)
                {
                    Console.WriteLine("Enter the second score!");
                    fourth_playerscore = Convert.ToInt32(Console.ReadLine());
                    scores[3] = fourth_playerscore;
                    Console.WriteLine("//====================Leaderboard======================//");
                    Console.WriteLine("//Player 1 ================================// " + scores[0]);
                    Console.WriteLine("//Player 2 ================================// " + scores[1]);
                    Console.WriteLine("//Player 3 ================================// " + scores[2]);
                    Console.WriteLine("//Player 4 ================================// " + scores[3]);

                }
                else
                {
                    Console.WriteLine("Thanks for inputting");
                }

            }

        }
