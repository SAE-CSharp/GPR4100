using System;

namespace Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number!");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.Write("\n");
            }
            for (int i = n; i > 0; i--) // i dont know why but the numbers are printed in revers order and i dont know how to fix it, 
            {                           // but it works otherwise
                for (int j = i; j > 0; j--)
                {
                    Console.Write(j);
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
