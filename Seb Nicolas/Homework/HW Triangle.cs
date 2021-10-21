using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            bool check = true;

            while (check)
            {

                Console.WriteLine("Please choose a number for the length of the triangle:");
                var playernum = Console.ReadLine();
                Console.WriteLine("----------------\n");

                if (int.TryParse(playernum, out num))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Not a valid number, try again!");
                    continue;
                }
            }

            int[] addArray = new int[num];

            for (int n = 0; n < addArray.Length; n++)
            {
                addArray[n] = num;
                num--;
            }

            Array.Sort(addArray);

            string[] subArray = Array.ConvertAll(addArray, down => down.ToString());

            add(addArray);
            sub(subArray);


            static void add(int[] addArray)
            {
                for (int counter = 0; counter < addArray.Length; counter++)
                {

                    for (int Number = 0; Number <= counter; Number++)
                    {
                        Console.Write(addArray[Number] + " ");
                    }

                    Console.WriteLine("\n");
                }
            }

            static void sub(string[] addArray)
            {
                for (int tri = 0; tri <= addArray.Length - 1; tri++)
                {
                    addArray[addArray.Length - (1 + tri)] = "";

                    for (int Number = 0; Number < addArray.Length; Number++)
                    {
                        Console.Write(addArray[Number] + " ");
                    }

                    Console.WriteLine("\n");
                }
            }

        }
    }
}
