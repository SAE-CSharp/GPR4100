using System;

namespace Leaderboard_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int Score ;
            int pos = 1;
            // declares a single dimensional array with space for 5 elements
            int[] Leaderboard = new int[5];

            // sets up a for loop that will run through the length of the Leaderboard array 
            for(int i=0 ; i < Leaderboard.Length ; i++)
            {
                Console.WriteLine("Please enter the score for the player");
                Score = Int32.Parse(Console.ReadLine());
                // sets the current element of the leaderboard array to the score entered by the user
                Leaderboard[i] = Score;
                Console.WriteLine("Your Score is " + Leaderboard[i]);
                // sorting the array before the updated scores are shown
                Array.Sort(Leaderboard);
                Array.Reverse(Leaderboard);
                // setting up anotherfor loop that will show the user the updated Leaderboard
                for (int l = 0; l < Leaderboard.Length; l++)
                {
                    Console.WriteLine("Highscore "+pos+"\'s score was "+Leaderboard[l]);
                    pos++;
                }
                // resetting the pos variable to stop logic error
                pos = 1;
            }


            Console.Write("press any button to exit the program ");
            Console.ReadLine();
        }
    }
}
