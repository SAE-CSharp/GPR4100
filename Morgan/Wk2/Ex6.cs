using System;

namespace MCarpenter_Wk2_Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer:");
            int intInputA = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("\nEnter a second integer:");
            int intInputB = Int32.Parse(Console.ReadLine());

            float compMod = (float)intInputA % intInputB;
            if (compMod == 0)
            {
                Console.WriteLine("\n" + intInputA + " is divisible by " + intInputB);
            }
            else
            {
                Console.WriteLine("\n" + intInputA + " is not divisible by " + intInputB);
            }
        }
    }
}
