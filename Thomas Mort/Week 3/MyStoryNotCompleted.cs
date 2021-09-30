using System;

namespace Narrative_path
{
    class Program
    {
        enum difficulty {Easy = 'A', Medium = 'B', Hard = 'C'};
        static void Main(string[] args)
        {
            Console.WriteLine("What difficulty is your story?");
            char level = char.Parse(Console.ReadLine());

            switch (level)
            {
                case (char)difficulty.Easy: //1
                    Console.WriteLine("The level you chose is Easy!");
                    break;
                case (char)difficulty.Medium: //2
                    Console.WriteLine("This is the medium level!");
                    break;
                case (char)difficulty.Hard: //3
                    Console.WriteLine("This is the hardest level!");
                    break;
                default:
                    Console.WriteLine("This wasn't a valid option...");
                    break;
            }

            string direction, house, sleep, quiz;
            int keypad, PlayerAnswer1, PlayerAnswer2;
            int score = 0;
            if (level == 'A')
            {
                Console.WriteLine("Welcome to the story. Will you be taking the Left or Right path of the woods? (Choose Left/Right)");
                direction = Console.ReadLine();
                if (direction == "Left")
                {
                    Console.WriteLine("Ooh, interesting.. You came across a house! Will you go inside it? (Choose Yes/No)");
                    house = Console.ReadLine();
                    if (house == "Yes")
                    {
                        Console.WriteLine("You entered the house. You look around, checking every room. You come across some nice food but get caught by a cannibal!)");
                        Console.WriteLine("You was eaten by the cannibal... im sorry!");
                    }
                    if (house == "No")
                    {
                        Console.WriteLine("You continued past the house, thinking about what is there.");
                        Console.WriteLine("It gets dark. Do you want to sleep?");
                        sleep = Console.ReadLine();
                        if (sleep == "Yes")
                        {
                            Console.WriteLine("You decided to sleep. You was eaten by wolves..");
                        }
                        if (sleep == "No")
                        {
                            Console.WriteLine("You continue walking and end up at a castle! Well done, you made it back home royalty ;)");
                        }
                }
                if (direction == "Right")
                    {
                        Console.WriteLine("You've taken the right path, This is a brighter path compared to the left.");
                        Console.WriteLine("As you continue down this path, you notice a keypad! Do you type 1 or 2?");
                        keypad = Int32.Parse(Console.ReadLine());
                        if (keypad == '1')
                        {
                            Console.WriteLine("You entered 1! The ground starts to rumble, opening up a bunker! However, the army arrives and takes you out!");
                            Console.WriteLine("You died. Game over!");
                        }
                        if (keypad == '2')
                        {
                            Console.WriteLine("You entered 2! You were given a quiz! Do you want to take it?");
                            quiz = Console.ReadLine();
                            if (quiz == "Yes")
                            {
                                Console.WriteLine("First question: What year was the Corona Virus Pandemic? 1 - 2020 2 - 1987 or 3- 9AD");
                                PlayerAnswer1 = Int32.Parse(Console.ReadLine());
                                if (PlayerAnswer1 == '1')
                                {
                                    score += 1;
                                    Console.WriteLine("Correct! Well done! Heres question 2: How many people worked on this adventure? 1- 5 2- 10 3- 1");
                                    PlayerAnswer2 = Int32.Parse(Console.ReadLine());
                                    if(PlayerAnswer2 == '3')
                                    {
                                        score += 1;
                                        Console.WriteLine("Well done! You passed my mini quiz!");
                                    }
                                    if (PlayerAnswer2 == '2')
                                    {
                                        Console.WriteLine("Um.. this is wrong.. There was only 1! Sorry!");
                                        score -= 1;
                                    }
                                    if (PlayerAnswer2 == '3')
                                    {
                                        Console.WriteLine("This is wrong.. I will now self destruct in 3.. 2-");
                                    }
                                if (PlayerAnswer1 == '2')
                                    {
                                        Console.WriteLine("This is incorrect.. This message will self destr-");
                                        Console.WriteLine("Game over..");
                                    }
                                if (PlayerAnswer1 == '3')
                                    {
                                        Console.WriteLine("This is incorrect.. This message will now shoot you down..");
                                        Console.WriteLine("Game Over");
                                    }
                            if (quiz == "No")
                                    {
                                        Console.WriteLine("You continue past the quiz, ignoring what might happen if you had done it. You arrive at your small town. /n Welcome back home, Baker.");
                                    }
                                }
                            }
                        }
                    }
                }
            }


        }
    }
}
