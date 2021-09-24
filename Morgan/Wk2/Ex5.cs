using System;

namespace MCarpenter_Wk2_Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName, confirmName;
            userName = "";
            confirmName = "n";

            while (confirmName == "n")  {

                Console.WriteLine("Please enter your name:");
                userName = Console.ReadLine();

                Console.WriteLine("\nYou have entered: " + userName);
                Console.WriteLine("Is this your name? (y/n)");
                confirmName = Console.ReadLine();

            }

            Console.WriteLine("Welcome, " + userName);
        }
    }
}
