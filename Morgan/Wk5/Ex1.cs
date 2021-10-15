using System;

namespace MCarpenter_Wk5_Ex1
{
    class Program
    {
        // The indices of an enumeration can be set to start from 1 by setting
        // the index of the first value to 1 - the rest will increase by 1
        // from there.
        
        enum players {Tom = 1, Alex, Steph, Lee};
        
        static void Main(string[] args)
        {
            // int index_Lee = (int)players.Lee;
            int playerCount = Enum.GetValues(typeof(players)).Length;

            int[] scores = new int[playerCount];

            for (int i = 1; i <= playerCount; i++)
            {
                Console.WriteLine("Please enter " + (players)i + "'s score.");
                // scores[i - 1] = Convert.ToInt32(Console.ReadLine());
                scores[i - 1] = Int32.Parse(Console.ReadLine());
                Console.WriteLine("");
            }

                Console.WriteLine("\n| >> Leaderboard <<");
            for (int i = 1; i <= playerCount; i++)
            {
                Console.WriteLine("| Player " + i + ": " + (players)i + " - " + scores[i - 1]);
            }

            Console.WriteLine("");
        }
    }
}
