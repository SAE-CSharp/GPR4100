 class Program
    {
        enum player {player1, player2, player3, player4, player5};
        static void Main(string[] args)
        {
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
             else if ( playernum == 3)
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
