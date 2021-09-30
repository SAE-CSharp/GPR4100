using System;

namespace creativityExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            int score = 0;

            Console.WriteLine("I'm going to ask some questions, please answer as best you can" +
                "\n What is the population of Brazil? \n 1 = 211 Million \n or \n 2 = 86 Million");

            int population = Int32.Parse(Console.ReadLine());

            switch (population)
            {
                case 1:
                    score += 1;
                    Console.WriteLine("Your answer is correct");
                    break;

                case 2:
                    score -= 1;
                    Console.WriteLine("Your answer is incorrect. What is the capital of Brazil");
                    break;
            }
            
            Console.WriteLine("What is the capital of Brazil? \n 1 = Brasilia \n 2 = Rio De Janeiro  ");
            int capital = Int32.Parse(Console.ReadLine());

            switch (capital)
            {
                case 1:
                    score += 1;
                    Console.WriteLine("Your answer is correct, your score is " + score);
                    break;

                case 2:
                    score -= 1;
                    Console.WriteLine("Your answer is incorrect, one last try.. When does Brazil's summer time begin? \n 1 = June \n 2 = December \n 3 = UK Winter time");

                    int summer = Int32.Parse(Console.ReadLine());
                    if (summer == 2 || summer == 3)
                    {
                        score += 1;
                        Console.WriteLine("Correct answer, you get a bonus point, your score is now " + score);
                    }
                    else
                    {
                        Console.WriteLine("Sorry, maybe next time.");
                    }

                    break;
            }
                    Console.WriteLine("How much land mass in Brazil is farmland? 1 = 2.1 Million acres \n 2 = 80 Million acres \n 3 = 2.1 billion acres");
                    int farmland = Int32.Parse(Console.ReadLine());

                    switch (farmland)
                    {
                        case 1:
                            score -= 1;
                            Console.WriteLine("Incorrect, your score is " + score);
                            break;

                        case 2:
                            score -= 1;
                            Console.WriteLine("Incorrect, your score is " + score);
                            break;

                        case 3:
                            score += 1;
                            Console.WriteLine("Correct! Your score is " + score);
                            break;

                    }
            }



               
               
       
            }



 
    }
