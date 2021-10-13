using System;

namespace five_player_quiz
{
    class Program
    {
        enum players {p1 = 0 , p2 = 0, p3 = 0, p4 = 0, p5 = 0};
        static void Main(string[] args)
        {
            Console.WriteLine("Quiz Time!!\nThe players are labeled 1-5 so don't forget yours.");
            int[] playScores = new int[5];
            int arLength = playScores.Length;
            int scoreP1 = 0;
            int scoreP2 = 0;
            int scoreP3 = 0;
            int scoreP4 = 0;
            int scoreP5 = 0;
            for (int i = 0; i < arLength; i++)
            {
                Console.WriteLine("Question 1:\nWhat is 8 in binary?\nA. 1000\nB. 0100\nC. 0010\nD. 0001");

                if (i == 0)
                {                
                    Console.WriteLine("Player 1 Enter answer:");
                    string p1q1 = Console.ReadLine();
                    i++;
                    if (p1q1 == "A")
                    {
                        scoreP1++;
                    }
                }
                if (i == 1)
                {
                    Console.WriteLine("Player 2 Enter answer:");
                    string p2q1 = Console.ReadLine();
                    i++;
                    if (p2q1 == "A")
                    {
                        scoreP2++;
                    }
                }
                if (i == 2)
                {
                    Console.WriteLine("Player 3 Enter answer:");
                    string p3q1 = Console.ReadLine();
                    i++;
                    if (p3q1 == "A")
                    {
                        scoreP3++;
                    }
                }
                if (i == 3)
                {
                    Console.WriteLine("Player 4 Enter answer:");
                    string p4q1 = Console.ReadLine();
                    i++;
                    if (p4q1 == "A")
                    {
                        scoreP4++;
                    }
                }
                if (i == 4)
                {
                    Console.WriteLine("Player 5 Enter answer:");
                    string p5q1 = Console.ReadLine();
                    i++;
                    if (p5q1 == "A")
                    {
                        scoreP5++;
                    }
                }
                if (i == 5)
                {
                    Console.WriteLine("The Score are as follows\nPlayer 1 has " + scoreP1 + " points.\n" +
                        "Player 2 has " + scoreP2 + " points.\nPlayer 3 has " + scoreP3 + " points.\n" +
                        "Player 4 has " + scoreP4 + " points.\nPlayer 5 has " + scoreP5 + " points.");
                    i++;
                }
                if (i == 6)
                {
                    Console.WriteLine("Question 2:\nWhat is the captial of Deutschland?\nA. Zürich\nB. Stuttgart\nC. Berlin\nD. Luxembourg");
                    Console.WriteLine("Player 1 Enter answer:");
                    string p1q2 = Console.ReadLine();
                    i++;
                    if (p1q2 == "C")
                    {
                        scoreP1++;
                    }
                }
                if (i == 7)
                {
                    Console.WriteLine("Player 2 Enter answer:");
                    string p2q2 = Console.ReadLine();
                    i++;
                    if (p2q2 == "C")
                    {
                        scoreP2++;
                    }
                }
                if (i == 8)
                {
                    Console.WriteLine("Player 3 Enter answer:");
                    string p3q2 = Console.ReadLine();
                    i++;
                    if (p3q2 == "C")
                    {
                        scoreP3++;
                    }
                }
                if (i == 9)
                {
                    Console.WriteLine("Player 4 Enter answer:");
                    string p4q2 = Console.ReadLine();
                    i++;
                    if (p4q2 == "C")
                    {
                        scoreP4++;
                    }
                }
                if (i == 10)
                {
                    Console.WriteLine("Player 5 Enter answer:");
                    string p5q2 = Console.ReadLine();
                    i++;
                    if (p5q2 == "C")
                    {
                        scoreP5++;
                    }
                }
                if (i == 11)
                {
                    Console.WriteLine("The Score are as follows\nPlayer 1 has " + scoreP1 + " points.\n" +
                        "Player 2 has " + scoreP2 + " points.\nPlayer 3 has " + scoreP3 + " points.\n" +
                        "Player 4 has " + scoreP4 + " points.\nPlayer 5 has " + scoreP5 + " points.");
                    i++;
                }
                break;
            }

        }
    }
}
