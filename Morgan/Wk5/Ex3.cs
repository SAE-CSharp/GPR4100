using System;

namespace MCarpenter_Wk5_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int rngMin = 1;
            int rngMax = 30;

            Console.WriteLine("Enter the size of square of random numbers you want.\n Random numbers will be from 1 to 20.");
            int rngSquareSide = Int32.Parse(Console.ReadLine());

            Console.WriteLine("");

            string rngString;
            for (int i = 1; i <= rngSquareSide; i++)
            {
                for (int j = 1; j <= rngSquareSide; j++)
                {
                    rngString = Convert.ToString(rand.Next(rngMin, rngMax + 1));
                    if (rngString.Length == 1)
                    {
                        rngString = ("0" + rngString);
                    }
                    Console.Write(rngString + " ");
                }
                Console.Write("\n");
            }

            Console.WriteLine("");
        }
    }
}
