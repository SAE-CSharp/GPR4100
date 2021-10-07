using System;

namespace Prime_number
{
    class Program
    {
        static void Main(string[] args)
        {
        //a prime number is a number that is divisible only by itself and 1
            //"2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47"
            int res = 0; 
                bool flag = false;
            Console.Write("Enter the Number to check Prime: ");
            int num = int.Parse(Console.ReadLine());
            res = num / 2;
            for (int i = 2; i <= res; i++)
            {
                if (num % i == 0)
                {
                    Console.Write("Number is not Prime.");
                    flag = true;
                    break;
                }
            }
            if (flag == false)
                Console.Write("Number is Prime.");
        }
    }
}
