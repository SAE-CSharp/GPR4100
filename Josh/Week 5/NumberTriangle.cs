using System;

namespace numberTriangle
{
    class Program
    {
        static void FirstHalf(int[] arA)
        {
            for (int i = 0; i < arA.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(arA[j] + "  ");
                }
                Console.Write("\n");
            }
        }

        static void SecondHalf(string[] arA)
        {
            for (int i = 0; i <= arA.Length - 1; i++)
            {
                arA[arA.Length - (1 + i)] = "";
                for (int j = 0; j < arA.Length; j++)
                {
                    Console.Write(arA[j] + "  ");
                }
                Console.Write("\n");
            }
        }

        static void Main(string[] args)
        {
            int n = 0;
            bool mainLoop = true;

            while (mainLoop)
            {
                Console.WriteLine("Enter a number:");
                var userInput = Console.ReadLine();
                Console.WriteLine("\n");

                if (int.TryParse(userInput, out n))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nInvalid input");
                    continue;
                }
            }

            int[] arA = new int[n];

            for (int i = 0; i < arA.Length; i++)
            {
                arA[i] = n;
                n--;
            }
            Array.Sort(arA);

            string[] STRarA = Array.ConvertAll(arA, ele => ele.ToString());

            FirstHalf(arA);
            SecondHalf(STRarA);
        }
    }
}
