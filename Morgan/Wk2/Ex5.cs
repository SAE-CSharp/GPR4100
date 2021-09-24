using System;

namespace MCarpenter_Wk2_Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName, userUni, confirmYN;
            userName = "";
            userUni = "";
            confirmYN = "n";
            int userAge = 0;
            float userDist = 0.0f;

            while (confirmYN == "n") {

                Console.WriteLine("Please enter your name:");
                userName = Console.ReadLine();

                Console.WriteLine("\nYou have entered: " + userName + ". Is this your name? (y/n)");
                confirmYN = Console.ReadLine();

                Console.WriteLine("");
            };
            confirmYN = "n";

            /*Console.WriteLine("Welcome, " + userName + "!\n");*/

            while (confirmYN == "n") {

                Console.WriteLine("Please enter your age:");
                userAge = Int32.Parse(Console.ReadLine());

                Console.WriteLine("\nYou have entered: " + userAge + ". Is this your age? (y/n)");
                confirmYN = Console.ReadLine();

                Console.WriteLine("");
            };
            confirmYN = "n";

            /*Console.WriteLine(userName + " is " + userAge + " years old.");*/

            while (confirmYN == "n")
            {

                Console.WriteLine("Please enter the university you are attending:");
                userUni = Console.ReadLine();

                Console.WriteLine("\nYou have entered: " + userUni + ". Is this correct? (y/n)");
                confirmYN = Console.ReadLine();

                Console.WriteLine("");
            };
            confirmYN = "n";

            while (confirmYN == "n")
            {

                Console.WriteLine("Please enter the distance you live from your university, in miles:");
                userDist = float.Parse(Console.ReadLine());

                Console.WriteLine("\nYou have entered: " + userDist + ". Is this correct? (y/n)");
                confirmYN = Console.ReadLine();

                Console.WriteLine("");
            };
            confirmYN = "n";

            Console.WriteLine("-- USER INFORMATION --\n");
            
            Console.WriteLine("Name:\n  " + userName + "\n");
            Console.WriteLine("Age:\n  " + userAge + "\n");
            Console.WriteLine("University:\n  " + userUni + "\n");
            Console.WriteLine("Distance from home to uni:\n  " + userDist + " miles\n");

            Console.WriteLine("-- MISC INFORMATION --\n");
            
            Char firstLetter = Char.Parse(userName.Substring(0, 1));
            Console.WriteLine("First letter of your name:\n  " + firstLetter);
        }
    }
}
