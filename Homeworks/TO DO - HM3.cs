Homework 3
Create a program which allows the user to input player scores up to 5 players and displays a updated leader board after each input.
Your program must incorporate the following methods:
•	Array
•	Enumerator
•	For Loop
Submit your code as a repository post on GitHub under github.com/SAE-CSharp/GPR4100


Solution:


using System;

namespace Homework_3
{
    class Program
    {

        enum Player_names { Steph=1, Tom, Ash, Dan };
        static void Main(string[] args)
        {
            //int enumlength =Enum.GetValues(typeof(player_score)).Length;
            int[] arrScore = new int[(int)Player_names.Dan];
            int len1 = arrScore.Length;
            
           /* Console.WriteLine(len1);
            Console.WriteLine(first_player);*/
            int first_player_score;
            int second_player_score;
            int third_player_score;
            int fourth_player_score;
            
            Console.WriteLine("//=============LeaderBoard==================//");
            Console.WriteLine("//player 1//==========// " + 0);
            Console.WriteLine("//player 2//==========// " + 0);
            Console.WriteLine("//player 3//==========// " + 0);
            Console.WriteLine("//player 4//==========// " + 0);

            for (int i=0;i<len1;i++) {
                
                if (i==0)
                {
                    Console.Write("Enter the first player score: ");
                    first_player_score = Convert.ToInt32(Console.ReadLine());
                    arrScore[0] = first_player_score;
                    Console.WriteLine("//=============LeaderBoard==================//");
                    Console.WriteLine("//player 1//==========// " + arrScore[0]);
                    Console.WriteLine("//player 2//==========// " + 0);
                    Console.WriteLine("//player 3//==========// " + 0);
                    Console.WriteLine("//player 4//==========// " + 0);

                }
                if (i == 1)
                {
                    Console.Write("Enter the first player score: ");
                    second_player_score = Convert.ToInt32(Console.ReadLine());
                    arrScore[1] = second_player_score;
                    Console.WriteLine("//=============LeaderBoard==================//");
                    Console.WriteLine("//player 1//==========// " + arrScore[0]);
                    Console.WriteLine("//player 2//==========// " + arrScore[1]);
                    Console.WriteLine("//player 3//==========// " + 0);
                    Console.WriteLine("//player 4//==========// " + 0);

                }
                if (i == 2)
                {
                    Console.Write("Enter the first player score: ");
                    third_player_score = Convert.ToInt32(Console.ReadLine());
                    arrScore[2] = third_player_score;
                    Console.WriteLine("//=============LeaderBoard==================//");
                    Console.WriteLine("//player 1//==========// " + arrScore[0]);
                    Console.WriteLine("//player 2//==========// " + arrScore[1]);
                    Console.WriteLine("//player 3//==========// " + arrScore[2]);
                    Console.WriteLine("//player 4//==========// " + 0);

                }
                if (i == 3)
                {
                    Console.Write("Enter the first player score: ");
                    fourth_player_score = Convert.ToInt32(Console.ReadLine());
                    arrScore[3] = fourth_player_score;
                    Console.WriteLine("//=============LeaderBoard==================//");
                    Console.WriteLine("//player 1//==========// " + arrScore[0]);
                    Console.WriteLine("//player 2//==========// " + arrScore[1]);
                    Console.WriteLine("//player 3//==========// " + arrScore[2]);
                    Console.WriteLine("//player 4//==========// " + arrScore[3]);

                }
                

            }



        }
    }
}

