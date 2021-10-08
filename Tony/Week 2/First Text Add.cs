using System;

namespace Text_Adventure_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Ice Hockey Quiz LVL 1" + "\n What is P.K Subban's Number?\n1.69 \n2.76");
            int option = Int32.Parse(Console.ReadLine());
            int score = 0;
            switch (option)
            {
                case 76:
                    score+=1;
                    Console.WriteLine("You got it right this time! Your score is now" + score);

                    break;

                case 69:
                    score-=1;
                    Console.WriteLine("You got it wrong");
                    Console.WriteLine("Your score is now " + score);
                    Console.WriteLine("Here is another question!:\n What is Conner McDavid's Jersy number? \n 1.30 \n 2.50\n 3.99");
                    option = Int32.Parse(Console.ReadLine());
                    if(option == 30 || option == 50 || option == 99)
                    {
                        score += 5;
                        Console.WriteLine("You got it right this time! Your score is now "+ score);
                    }

                    break;
                default:
                    Console.WriteLine("Invalid Answer");
                    break;





            }
            if (score >= 3)
            {
                Console.WriteLine("Welcome to level 2!");
                Console.WriteLine("What is the fastest Slapshot in NHL history(mph)? \n 1.100 \n2. 102 \n 3.105");
                option = Int32.Parse(Console.ReadLine());
                switch (option)
                {
                    case 100:
                       
                        score -= 1;
                        Console.WriteLine("You got it wrong");
                        Console.WriteLine("Your score is now " + score);
                        if (option == 100)
                        {
                            score -=1;
                            Console.WriteLine("You got it wrong this time! Your score is now " + score);
                        }

                        break;

                    case 102:
                        score -= 1;
                        Console.WriteLine("You got it wrong");
                        Console.WriteLine("Your score is now " + score);
                        if (option == 102)
                        {
                            score -= 1;
                            Console.WriteLine("You got it wrong this time! Your score is now " + score);
                        }
                        break;
                    case 105:
                        score += 1;
                        Console.WriteLine("You got it right!");
                        Console.WriteLine("Your score is now " + score);

                        break;

                    default:
                        Console.WriteLine("Invalid Answer");
                        break;

                }
                if (score >= 5)
                {
                    Console.WriteLine("Welcome to Lvl 3!");
                }
            }
        }
    }
}
