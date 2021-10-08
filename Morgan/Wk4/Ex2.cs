using System;

namespace MCarpenter_Wk4_Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            // An array variable can be used to store multiple pieces of data
            // of the same type.

            int[] numbers = {10, 20, 30, 40, 50};
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);
            Console.WriteLine(numbers[4]);

            Console.WriteLine("");

            // Arrays can use any data types normal variables can, and each
            // element of an array can be assigned a new value in the same way
            // as a normal variable.

            string[] cities = {"London", "Liverpool", "Leeds"};
            Console.WriteLine(cities[2]);
            cities[2] = "Oxford";
            Console.WriteLine(cities[2]);

            int len = cities.Length;

            Console.WriteLine("");

            float[] floatSetA = {3.1f, 1.44f, 10.7f, 8.2f, 0.83f, 16.0f};

            int i = 0;
            while (i < floatSetA.Length)
            {
                Console.WriteLine(floatSetA[i]);
                i++;
            }

            // An array can be declared without elements, as long as the size is specificed:

            int[] blankArray = new int[4]; // This array can hold 4 elements.

            float[] floatSetB = new float[8];

            Console.WriteLine("\nEnter a floating point number.");
            floatSetB[0] = float.Parse(Console.ReadLine());
            for (i = 1; i < floatSetB.Length; i++)
            {
                floatSetB[i] = floatSetB[0] * (i + 1);
            }

            Console.WriteLine("");

            for (i = 0; i < floatSetB.Length; i++)
            {
                Console.WriteLine(floatSetB[i]);
            }

            Console.WriteLine("\nWhich of these is your favourite colour?\n  [1] Red\n  [2] Green\n  [3] Blue\n  [4] Yellow");
            int favColour = Int32.Parse(Console.ReadLine()) - 1;

            string[] colours = { "Red", "Green", "Blue", "Yellow" };

            Console.WriteLine("\nSearching...\n");

            for (i = 0; i < colours.Length; i++)
            {
                Console.WriteLine(colours[i]);
                if (i == favColour)
                {
                    Console.WriteLine("\nAh, there's your preferred colour - " + colours[i] + "!\n");
                    break;
                }
            }
        }
    }
}
