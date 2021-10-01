using System;
using System.Threading;

namespace Text_Adventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("****************************************************************");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Welcome to Seb's Console Application Text Adventure Game");
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("****************************************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("================================================================");

            Console.WriteLine("Seb: Hello there! I'm looking for an accomplice to go on a journey into the amazon forest. \nAnswer questions along the way and gain points, are you interested?");
            {
                var counter = 0;
                for (int i = 0; i < 50; i++)
                {
                    switch (counter % 4)
                    {
                        case 0: Console.Write("/"); break;
                        case 1: Console.Write("-"); break;
                        case 2: Console.Write("\\"); break;
                        case 3: Console.Write("|"); break;
                    }
                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                    counter++;
                    Thread.Sleep(100);
                }
            }
            Console.WriteLine("Respond with either 'yes' or 'no'.");
            string response = Console.ReadLine();
            if (response == "yes")
            {
                Console.WriteLine("Seb: Ah amazing! - Thank you!- Ok, we leave tomorrow, I've packed the essentials- \nAre you able to guess how many estimated different species of bird live the amazon?");
                
                var counter = 0;
                for (int i = 0; i < 50; i++)
                {
                    switch (counter % 4)
                    {
                        case 0: Console.Write("/"); break;
                        case 1: Console.Write("-"); break;
                        case 2: Console.Write("\\"); break;
                        case 3: Console.Write("|"); break;
                    }
                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                    counter++;
                    Thread.Sleep(50);
                }
            
            Console.WriteLine("1. 500 \n2. 800 \n3. 1300");
                int score = 0;
                int bird = Int32.Parse(Console.ReadLine());

                switch (bird)
                {
                    case 1:
                        Console.WriteLine("Seb: Sorry that is wrong, it's actually estimated to have 1,300 different species of bird... AINT THAT CRAZY!");
                        break;
                    case 2:
                        Console.WriteLine("Seb: Sorry that is wrong, it's actually estimated to have 1,300 different species of bird... AINT THAT CRAZY!");
                        break;
                    case 3:
                        Console.WriteLine("Seb: Yes!! it's crazy right!");
                        Console.WriteLine("You gained a point! " + (score + 1));
                        break;
                    case 500:
                        Console.WriteLine("Seb: Sorry that is wrong, it's actually estimated to have 1,300 different species of bird... AINT THAT CRAZY!");
                        break;
                    case 800:
                        Console.WriteLine("Seb: Sorry that is wrong, it's actually estimated to have 1,300 different species of bird... AINT THAT CRAZY!");
                        break;
                    case 1300:
                        Console.WriteLine("Seb: Yes!! it's crazy right!");
                        Console.WriteLine("You gained a point! " + (score + 1));
                        break;
                    default:
                        Console.WriteLine("Sorry that isn't a number");
                        break;

                }

                Console.WriteLine("Seb: And to think that 10,000 Square miles a year of that rainforest is being destroyed :/ ");
            
                for (int i = 0; i < 50; i++)
                {
                    switch (counter % 4)
                    {
                        case 0: Console.Write("/"); break;
                        case 1: Console.Write("-"); break;
                        case 2: Console.Write("\\"); break;
                        case 3: Console.Write("|"); break;
                    }
                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                    counter++;
                    Thread.Sleep(50);
                }

                Console.WriteLine("Seb: Alright I'll see you in the morning!");
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("****************************************************************");
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                for (int i = 0; i < 50; i++)
                {
                    switch (counter % 4)
                    {
                        case 0: Console.Write("/"); break;
                        case 1: Console.Write("-"); break;
                        case 2: Console.Write("\\"); break;
                        case 3: Console.Write("|"); break;
                    }
                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                    counter++;
                    Thread.Sleep(100);
                }
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("****************************************************************");
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;

                Console.WriteLine("Seb: Good Morning!!! - Are you ready for our trip?");
                for (int i = 0; i < 50; i++)
                {
                    switch (counter % 4)
                    {
                        case 0: Console.Write("/"); break;
                        case 1: Console.Write("-"); break;
                        case 2: Console.Write("\\"); break;
                        case 3: Console.Write("|"); break;
                    }
                    Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                    counter++;
                    Thread.Sleep(50);
                }
                Console.WriteLine("Respond with either 'yes' or 'no'.");
                string responsetwo = Console.ReadLine();
                if (responsetwo == "yes")
                {
                    Console.WriteLine("Seb: LETS GOOO!");
                }

                else if (response == "no")
                {
                    Console.WriteLine("Seb: Oh. You change your mind?");
                    for (int i = 0; i < 50; i++)
                    {
                        switch (counter % 4)
                        {
                            case 0: Console.Write("/"); break;
                            case 1: Console.Write("-"); break;
                            case 2: Console.Write("\\"); break;
                            case 3: Console.Write("|"); break;
                        }
                        Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                        counter++;
                        Thread.Sleep(30);
                    }
                    Console.WriteLine("Respond with either 'yes' or 'no'.");
                    string responsethree = Console.ReadLine();
                    if (responsethree == "yes")
                    {
                        Console.WriteLine("Seb: oh okay, i'll go on my own.");
                    }

                    else if (response == "no")
                    {
                        Console.WriteLine("Seb: Ok then. Lets GOOOO!");
                    }
                }
            }
           

            else if (response == "no")
            {
                Console.WriteLine("Seb: Oh. well, Sorry for bothering you :/");
            }
        }
    }
}
