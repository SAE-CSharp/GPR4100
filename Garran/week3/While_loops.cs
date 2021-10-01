using System;

namespace While_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Enter a score between 1 and 9 ");
             int score = Int32.Parse(Console.ReadLine());

             while (score < 9)
             {
                 score++;
                 Console.WriteLine("Your score is: " + score);
             }*/

            int score = 5;

            while (score >= 5)
            {
                score++;
           
                if (score == 5)
                {
                    continue;
                }
                Console.WriteLine("your score is " + score);
            }

          /*  Console.WriteLine("select one operations\n 1. Addition\n 2.Subtraction\n 3. Division");
            int Selection = Int32.Parse(Console.ReadLine());

            while (Selection ! == 1 && Selection ! = 2 && Selection ! = 3);
            {
                Console.WriteLine("You have to select one option!");
                Console.WriteLine("please select one operation?" + "1.Addition \n 2. submission\n 3. division");
                Selection = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("Thats good you made a selection" + Selection);*/


        }
    }
}
