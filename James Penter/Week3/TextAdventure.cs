using System;

namespace exe5difflevel
{
    class Program
    {
        enum difficulty { Easy=1, Medium=2, Hard=3};
        enum type { Action=4, RPG=5, Simulation=6};
        static void Main(string[] args)
        {
            Console.WriteLine("Select your level difficulty.\n 1.Easy \n 2.Medium \n 3.Hard");
            int gamelevel = Int32.Parse(Console.ReadLine());
            
            
            int score = 0;

            switch (gamelevel)
            {
                case (int)difficulty.Easy:
                    Console.WriteLine("you have chosen the easy way out");
                    break;

                case (int)difficulty.Medium:
                    Console.WriteLine("you have chosen an intermediate difficulty");
                    break;

                case (int)difficulty.Hard:
                    Console.WriteLine("you have chosen the hardest path!");
                    break;


            }
            Console.WriteLine("Select the genre. \n 4.Action \n 5.RPG \n 6.Simulation");
            int genre = Int32.Parse(Console.ReadLine());
            switch (genre)
            {
                case (int)type.Action:
                    Console.WriteLine("You have chosen action");
                    break;

                case (int)type.RPG:
                    Console.WriteLine("You have chosen RPG");
                    break;

                case (int)type.Simulation:
                    Console.WriteLine("You have chosen simulation");
                    break;
            }
            Console.WriteLine("Before we start this game let me ask you a simple question to test your intelligence.\n If answered correctly you can start the game with a bonus point but if answered incorrectly you will start the game on a negative tally\nWhat is the population of Greenland?\n 1.56,000 \n 2.560,000");
            int population = Int32.Parse(Console.ReadLine());
            switch (population)
            {
                case 1:
                    score += 1;
                    Console.WriteLine("You have chosen correctly, your current score is now..." + score++);
                    break;
                case 2:
                    score -= 1;
                    Console.WriteLine("You have chosen incorrectly, your current score is now..." + score--);
                    break;




            }
                
            
                
            

                    
            



        }
    }
}
