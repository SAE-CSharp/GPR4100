using System;

namespace Adventure_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to text adventure game level1 where your journey begins!" + "After leaving your home to start your adventure you come to a fork in the road, which way do you go?\n A.left \n B.right");
            Console.WriteLine("Your health is 10");
            char option = char.Parse(Console.ReadLine());
            int health = 5;
           
            switch (option)
            {

                case 'A':

                    
                    Console.WriteLine("you continue on your journey down the left path and find a delcious apple to eat while you walk further down the path and find a tavern.");
                    Console.WriteLine("your health is now 10");
                    health += 5;

                    if (health >= 10)
                    

                        Console.WriteLine("you are now standing infront of the tavern, what do you do?\n A.enter \n B.continue on your journey.");

                        switch (option)
                        {

                            case 'A':
                                
                                Console.WriteLine("you enter the tarven and find it full of bandits they attack you as you try to leave. you were injured while escaping the tarven and dont survive.");
                                Console.WriteLine("GAME OVER");
                                health -= 10;

                            break;

                            case 'B':
                                
                                Console.WriteLine("you continue on your journey without entering the tarven. further down the road you come across a lovely stream and stop for a rest and a quick drink.");
                                Console.WriteLine("your health is now 12");
                                health += 2;

                            break;
                        }

                       

                        break;


                case 'B':
                    
                    Console.WriteLine("you contiue down the right path untill you find a deadend so you turn around and head back to the fork in the road, on your way back you are attacked by a ferral dog and dont survive.");
                    Console.WriteLine("GAME OVER");
                    health -= 5;

                    break;

            }

                if (health >= 12)

                {

                    Console.WriteLine("well done you have finished level1");

                }
            }
        }
    }
}
