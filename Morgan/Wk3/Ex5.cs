using System;

namespace MCarpenter_Wk3_Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int counter = 0;
            while (counter < 10)
            {
                counter++;
                Console.WriteLine(counter);
            }
            Console.WriteLine("");
            counter = 20;
            while (counter > 0)
            {
                Console.WriteLine(counter);
                if (counter == 10)
                {
                    break;
                }
                counter--;
            }
            Console.WriteLine("");
            while (counter > 0)
            {
                counter--;
                if (counter == 4)
                {
                    continue;
                }
                Console.WriteLine(counter);
            }
            Console.WriteLine("");*/

            int selection = 0;
            while (!(selection >= 1 && selection <= 4))
            {
                Console.WriteLine("Please select an option:\n  [1] Option 1\n  [2] Option 2\n  [3] Option 3\n  [4] Option 4");
                selection = Int32.Parse(Console.ReadLine());
                if (selection >= 1 && selection <= 4)
                {
                    break;
                }
                Console.Clear();
                Console.WriteLine("Error: invalid selection.\n");
            }
            Console.WriteLine("\nYou have selected Option " + selection);



            Console.WriteLine("");
        }
    }
}
