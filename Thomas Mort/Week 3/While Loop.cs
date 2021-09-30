using System;

namespace While_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
/*            char again = 'y';
            while (again == 'y')
            {
                Console.WriteLine("\nYou have played a game!");
                Console.WriteLine("\nDo you want to play another one? (y/n)");

                again = Char.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nOkay thank you for playing!");
*/
            int count = 1;
            while (count < 100)
            {
                count++;
                if (count == 48)
                {
                    continue;
                }

                Console.WriteLine(count);
            }

        }
    }
}
