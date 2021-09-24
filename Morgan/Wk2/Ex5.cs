using System;

namespace MCarpenter_Wk2_Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName, cnfName, cnfAge;
            int userAge;
            userName = "";
            cnfName = "n";
            userAge = 0;
            cnfAge = "n";

            while (cnfName == "n") {

                Console.WriteLine("Please enter your name:");
                userName = Console.ReadLine();

                Console.WriteLine("\nYou have entered: " + userName + ". Is this your name? (y/n)");
                cnfName = Console.ReadLine();

                Console.WriteLine("");
            }

            Console.WriteLine("Welcome, " + userName + "!\n");

            while (cnfAge == "n") {

                Console.WriteLine("Please enter your age:");
                userAge = Int32.Parse(Console.ReadLine());

                Console.WriteLine("\nYou have entered: " + userAge + ". Is this your age? (y/n)");
                cnfAge = Console.ReadLine();

                Console.WriteLine("");
            }

            Console.WriteLine(userName + " is " + userAge + " years old.");
        }
    }
}
