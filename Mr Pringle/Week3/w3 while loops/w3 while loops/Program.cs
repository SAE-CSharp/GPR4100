
using System;

namespace w3_while_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 20;
            while (count > 10)
            {
                count++;
                Console.WriteLine("Count is: " + count);
                if (count > 40)
                {
                    break;
                }

                
            }

            while (count > 0)
            {
                count--;
                
                if (count == 2)
                {
                    continue;
                }

                Console.WriteLine("Count is: " + count);

                if (count == 0)
                {
                    break;
                }
            }




            char again = 'Y';

            while (again == 'Y')
            {
                Console.WriteLine("\n**Played an exciting game**\n" +
                    "Do you want to play again? Y/N");
                again = Convert.ToChar(Console.ReadLine());



            }
            Console.WriteLine("\nOkay, Bye.");


        }
    }
}
