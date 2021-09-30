using System;

namespace Week3_excercise4
{
    class Program
    {
        enum LevelDiff {EASY = 1, MEDIUM = 2, HARD = 3 };
        static void Main(string[] args)
        {
            Console.WriteLine("Enter you preffered difficulty\nA.EASY\nB.MEDIUM\nC.HARD");
/*            int Lvl = Int32.Parse(Console.ReadLine());*/
              Char Level = Char.Parse(Console.ReadLine());

            switch (Level)
            {

               case 'A':
                    Console.WriteLine("You have selected "+LevelDiff.EASY+" difficulty");
                    break;

                case 'B':
                    Console.WriteLine("You have selected "+LevelDiff.MEDIUM+" difficulty");
                    break;
                case 'C':
                    Console.WriteLine("You have selected "+LevelDiff.HARD+" difficulty");
                    break;

                default:
                    Console.WriteLine("That is not a real difficulty");
                    break;

            }
        }
    }
}
