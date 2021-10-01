using System;

namespace while_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter score between 1 and 20");
            int score = Int32.Parse(Console.ReadLine());

            while(score < 10)
            {
                score++;
                Console.WriteLine("your score is "+score);
                {
                    break;
                }
            }

            score = 20;

            while (score>1)
            {

                score--;
                if(score == 10)
                {
                    continue;
                }
                Console.WriteLine("your score is " + score);
            }

            Console.WriteLine("select one oprations\n 1.Addition\n 2.Subtraction\n 3.Division ");
            int Selection = Int32.Parse(Console.ReadLine());

            while (Selection !=1 && Selection !=2 && Selection !=3)
            {
                Console.WriteLine("you have to pick one selection ");
                Console.WriteLine("please pick one of the following selections\n 1.Addition\n 2.Subtraction\n 3.Division ");
                Selection = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("that's good you picked a selection "+Selection);

            }
        }
    }
}
