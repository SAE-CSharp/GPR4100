class Program
    {
        enum player { player1=1, player2, player3, player4, player5 };
        static void Main(string[] args)
        {
            // 1st way of making a leaderboard 
            int Player1val = (int)player.player5;
            int[] playerscore = new int[Player1val];
            int firstplayerscore;
            int secondplayerscore;
            int thirdplayerscore;
            int forthplayerscore;
            int fifthplayerscore;
            int arraylen = playerscore.Length;
            Console.WriteLine(Player1val);

            Console.WriteLine("****LEADERBOARD****");
            Console.WriteLine("| Player 1 scored " + 0);
            Console.WriteLine("| Player 2 scored " + 0);
            Console.WriteLine("| Player 3 scored " + 0);
            Console.WriteLine("| Player 4 scored " + 0);
            Console.WriteLine("| Player 5 scored " + 0);

            for (int i = 0; i < arraylen; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("choose the first player score");
                    firstplayerscore = Int32.Parse(Console.ReadLine());
                    playerscore[0] = firstplayerscore;

                    Console.WriteLine("****LEADERBOARD****");
                    Console.WriteLine("| Player 1 scored " + playerscore[0]);
                    Console.WriteLine("| Player 2 scored " + 0);
                    Console.WriteLine("| Player 3 scored " + 0);
                    Console.WriteLine("| Player 4 scored " + 0);
                    Console.WriteLine("| Player 5 scored " + 0);
                }
                else if (i == 1)
                {
                    Console.WriteLine("choose the second player score");
                    secondplayerscore = Int32.Parse(Console.ReadLine());
                    playerscore[1] = secondplayerscore;

                    Console.WriteLine("****LEADERBOARD****");
                    Console.WriteLine("| Player 1 scored " + playerscore [0]);
                    Console.WriteLine("| Player 2 scored " + playerscore [1]);
                    Console.WriteLine("| Player 3 scored " + 0);
                    Console.WriteLine("| Player 4 scored " + 0);
                    Console.WriteLine("| Player 5 scored " + 0);
                }
                else if (i == 2)
                {
                
                        Console.WriteLine("choose the third player score");
                        thirdplayerscore = Int32.Parse(Console.ReadLine());
                        playerscore[2] = thirdplayerscore;

                        Console.WriteLine("****LEADERBOARD****");
                        Console.WriteLine("| Player 1 scored " + playerscore[0]);
                        Console.WriteLine("| Player 2 scored " + playerscore[1]);
                        Console.WriteLine("| Player 3 scored " + playerscore[2]);
                        Console.WriteLine("| Player 4 scored " + 0);
                        Console.WriteLine("| Player 5 scored " + 0);
                    
                }
                else if (i == 3)
                {

                    Console.WriteLine("choose the forth player score");
                    forthplayerscore = Int32.Parse(Console.ReadLine());
                    playerscore[3] = forthplayerscore;

                    Console.WriteLine("****LEADERBOARD****");
                    Console.WriteLine("| Player 1 scored " + playerscore[0]);
                    Console.WriteLine("| Player 2 scored " + playerscore[1]);
                    Console.WriteLine("| Player 3 scored " + playerscore[2]);
                    Console.WriteLine("| Player 4 scored " + playerscore[3]);
                    Console.WriteLine("| Player 5 scored " + 0);

                }
                else if (i == 4)
                {

                    Console.WriteLine("choose the fifth player score");
                    fifthplayerscore = Int32.Parse(Console.ReadLine());
                    playerscore[4] = fifthplayerscore;

                    Console.WriteLine("****LEADERBOARD****");
                    Console.WriteLine("| Player 1 scored " + playerscore[0]);
                    Console.WriteLine("| Player 2 scored " + playerscore[1]);
                    Console.WriteLine("| Player 3 scored " + playerscore[2]);
                    Console.WriteLine("| Player 4 scored " + playerscore[3]);
                    Console.WriteLine("| Player 5 scored " + playerscore[4]);

                }

            }
            




             // 2nd different way of many a leaderboard
             int playernum = 0;
             int[] playerScore = new int[5];
             Console.WriteLine("Please enter the number of players...");
             Console.WriteLine("Minimun players = 2, maximum players = 5");
             playernum = Int32.Parse(Console.ReadLine());
             if (playernum == 2)
             {
                 for (int count = 0; count < 5; count++)
                 {
                     Console.WriteLine("What score did each player get? Enter a value between 0 and 100");
                     Console.WriteLine("Please enter the score for player One");
                     playerScore[0] = Int32.Parse(Console.ReadLine());
                     Console.WriteLine("***LEADERBOARD***");
                     Console.WriteLine(player.player1 + " scored " + playerScore[0]);
                     Console.WriteLine("           ");
                     Console.WriteLine("Please enter the score for player Two");
                     playerScore[1] = Int32.Parse(Console.ReadLine());
                     Console.WriteLine("***LEADERBOARD***");
                     Console.WriteLine(player.player1 + " scored " + playerScore[0] + " \n" + player.player2 + " scored " + playerScore[1]);

                     break;
                 }

             }
             else if (playernum == 3)
             {
                 for (int count = 0; count < 5; count++)
                 {
                     Console.WriteLine("What score did each player get? Enter a value between 0 and 100");
                     Console.WriteLine("Please enter the score for player One");
                     playerScore[0] = Int32.Parse(Console.ReadLine());
                     Console.WriteLine("***LEADERBOARD***");
                     Console.WriteLine(player.player1 + " scored " + playerScore[0]);
                     Console.WriteLine("           ");
                     Console.WriteLine("Please enter the score for player Two");
                     playerScore[1] = Int32.Parse(Console.ReadLine());
                     Console.WriteLine("***LEADERBOARD***");
                     Console.WriteLine(player.player1 + " scored " + playerScore[0] + " \n" + player.player2 + " scored " + playerScore[1]);
                     Console.WriteLine("           ");
                     Console.WriteLine("Please enter the score for player Three");
                     playerScore[2] = Int32.Parse(Console.ReadLine());
                     Console.WriteLine("***LEADERBOARD***");
                     Console.WriteLine(player.player1 + " scored " + playerScore[0] + " \n" + player.player2 + " scored " + playerScore[1] + " \n" + player.player3 + " scored " + playerScore[2]);

                     break;
                 }


             }
             else if (playernum == 4)
             {
                 for (int count = 0; count < 5; count++)
                 {
                     Console.WriteLine("What score did each player get? Enter a value between 0 and 100");
                     Console.WriteLine("Please enter the score for player One");
                     playerScore[0] = Int32.Parse(Console.ReadLine());
                     Console.WriteLine("***LEADERBOARD***");
                     Console.WriteLine(player.player1 + " scored " + playerScore[0]);
                     Console.WriteLine("           ");
                     Console.WriteLine("Please enter the score for player Two");
                     playerScore[1] = Int32.Parse(Console.ReadLine());
                     Console.WriteLine("***LEADERBOARD***");
                     Console.WriteLine(player.player1 + " scored " + playerScore[0] + " \n" + player.player2 + " scored " + playerScore[1]);
                     Console.WriteLine("           ");
                     Console.WriteLine("Please enter the score for player Three");
                     playerScore[2] = Int32.Parse(Console.ReadLine());
                     Console.WriteLine("***LEADERBOARD***");
                     Console.WriteLine(player.player1 + " scored " + playerScore[0] + " \n" + player.player2 + " scored " + playerScore[1] + " \n" + player.player3 + " scored " + playerScore[2]);
                     Console.WriteLine("           ");
                     Console.WriteLine("Please enter the score for player Four");
                     playerScore[3] = Int32.Parse(Console.ReadLine());
                     Console.WriteLine("***LEADERBOARD***");
                     Console.WriteLine(player.player1 + " scored " + playerScore[0] + " \n" + player.player2 + " scored " + playerScore[1] + " \n" + player.player3 + " scored " + playerScore[2] + " \n" + player.player4 + " scored " + playerScore[3]);

                     break;
                 }


             }
             else if (playernum == 5)
             {

                 for (int count = 0; count < 5; count++)
                 {
                     Console.WriteLine("What score did each player get? Enter a value between 0 and 100");
                     Console.WriteLine("Please enter the score for player One");
                     playerScore[0] = Int32.Parse(Console.ReadLine());
                     Console.WriteLine("***LEADERBOARD***");
                     Console.WriteLine(player.player1 + " scored " + playerScore[0]);
                     Console.WriteLine("           ");
                     Console.WriteLine("Please enter the score for player Two");
                     playerScore[1] = Int32.Parse(Console.ReadLine());
                     Console.WriteLine("***LEADERBOARD***");
                     Console.WriteLine(player.player1 + " scored " + playerScore[0] + " \n" + player.player2 + " scored " + playerScore[1]);
                     Console.WriteLine("           ");
                     Console.WriteLine("Please enter the score for player Three");
                     playerScore[2] = Int32.Parse(Console.ReadLine());
                     Console.WriteLine("***LEADERBOARD***");
                     Console.WriteLine(player.player1 + " scored " + playerScore[0] + " \n" + player.player2 + " scored " + playerScore[1] + " \n" + player.player3 + " scored " + playerScore[2]);
                     Console.WriteLine("           ");
                     Console.WriteLine("Please enter the score for player Four");
                     playerScore[3] = Int32.Parse(Console.ReadLine());
                     Console.WriteLine("***LEADERBOARD***");
                     Console.WriteLine(player.player1 + " scored " + playerScore[0] + " \n" + player.player2 + " scored " + playerScore[1] + " \n" + player.player3 + " scored " + playerScore[2] + " \n" + player.player4 + " scored " + playerScore[3]);
                     Console.WriteLine("           ");
                     Console.WriteLine("Please enter the score for player Five");
                     playerScore[4] = Int32.Parse(Console.ReadLine());
                     Console.WriteLine("***LEADERBOARD***");
                     Console.WriteLine(player.player1 + " scored " + playerScore[0] + " \n" + player.player2 + " scored " + playerScore[1] + " \n" + player.player3 + " scored " + playerScore[2] + " \n" + player.player4 + " scored " + playerScore[3] + " \n" + player.player5 + " scored " + playerScore[4]);

                     break;
                 }

             }
             else
             {
                 Console.WriteLine("That is not a valid entry, please chose the ammount of players from 2 to 5");



             } 




        }
    }
