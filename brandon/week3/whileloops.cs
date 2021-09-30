using System;

namespace week3_while_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int Count = 0;
            int count = 10;
            char again = 'y';
            while (again == 'y')
            {
                Console.WriteLine("bruh");
                Console.WriteLine("do you want to do this again\n(y/n)");
                again = char.Parse(Console.ReadLine());
                Count += 1;
                if (Count == 3)
                {
                    Console.WriteLine("bruh");
                    break;
                }
            }

            Console.WriteLine("oof\n");
            Console.WriteLine(Count);

            while (count>1)
            {
                count--;
                if(count == 3)
                {
                    continue;

                }
                Console.WriteLine("count is " + count);

            }
            int Counter = 20;
            while (Counter < 40)
            {
                Console.WriteLine(Counter);
                Counter++;
                if (Counter==40) 
                {
                    break;
                }
                Console.WriteLine(Counter);
            }

            
        }
    }
}
