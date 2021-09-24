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
                Console.WriteLine("\n" + intInputA + " is not divisible by " + intInputB + "\n");
            }

            int intLarger = 0;
            if (intInputA > intInputB)
            {
                Console.WriteLine(intInputA + " is the larger integer.");
                intLarger = intInputA;
            }
            else if (intInputA < intInputB)
            {
                Console.WriteLine(intInputB + " is the larger integer");
                intLarger = intInputB;
            }
            else
            {
                Console.WriteLine("The two integers are equal");
            }

            if (intLarger > 50)
            {
                Console.WriteLine("The larger integer is greater than 50");
            }
            else if (intLarger > 40)
            {
                Console.WriteLine("The larger integer is greater than 40");
            }
            else if (intLarger > 30)
            {
                Console.WriteLine("The larger integer is greater than 30");
            }
            else if (intLarger > 20)
            {
                Console.WriteLine("The larger integer is greater than 20");
            }
            else if (intLarger > 10)
            {
                Console.WriteLine("The larger integer is greater than 10");
            }
            else if (intLarger > 0)
            {
                Console.WriteLine("The larger integer is greater than 0");
            }
            else
            {
                Console.WriteLine("Neither integer is greater than 0");
            }
        }
    }
}
