using System;

namespace exeWhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            char again = 'y';
            while (again == 'y')
            {
                Console.WriteLine("\nI Played an exciting game");
                Console.WriteLine("\nDo you want to play again?(y/n):");

                again = char.Parse(Console.ReadLine());


            }
            Console.WriteLine("Ok,bye!");

            //*************************************************************
            int count = 15;
            while (count > 1)
            {

                count--;
                if (count == 7)
                {
                    continue;//easy way to simulate death
                }
                Console.WriteLine("Count is:" + count);
            }
            //***************
            int counter = 20;
            while (counter < 50)
            {
                counter++;
                if (counter == 13)
                {
                    break;
               
                }
                Console.WriteLine("\nCount is" + counter);
            }


        }
    }
}
