
using System;

namespace Enumeration_Angela
{
    class Program
    {
        // create enumeration
        
        static void Main(string[] args)
        {

            int score = 0;
  
            Console.WriteLine("Welcome to my game! \n I am going to ask you some questions. What is the population of UK? \n 1. 68,328,470 \n 2. 72,324,360");
            int population = Int32.Parse(Console.ReadLine());
            switch (population)
            {
                case 1:
                    score += 1;
                    Console.WriteLine("Your answer is correct and your score now is " + score + " How about another question? What's the Capital City of Lithuania? \n 1. Kaunas \n 2. Vilnius");
                    int score1 = Int32.Parse(Console.ReadLine());
                    if (score == 1)
                    {

                        Console.WriteLine("Your answer is correct and your score now is" + score);
                        score += 2;
                    }
                    else
                    {
                        Console.WriteLine("Your answer is incorrect");
                    }

                    break;
                   

                case 2:
                    score -= -1;
                    Console.WriteLine("Your answer is not correct! How about if you answer another question and get bonus points? What's What's the Capital city of Lithuania? \n 1. Kaunas \n 2. Vilnius");
                    int score2 = Int32.Parse(Console.ReadLine());
                    if (score == 2)
                    {

                        Console.WriteLine("Your answer is correct and your score now is" + score);
                        score += 2;
                    }
                    else
                    {
                        Console.WriteLine("Your answer is incorrect");
                    }

                    break;


               
                

            }
            if (score > 3)
            {
                Console.WriteLine("well done, you're now in the medium level");
            }
        }   
    }
}

NOT FINISHED
