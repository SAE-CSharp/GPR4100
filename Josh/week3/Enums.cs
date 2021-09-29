using System;

namespace Enumeration
{
    class Program
    {
        //enum level { Easy, Medium, Hard };

        enum months { jan, feb, mar, apr, may, jun, jul, aug, sep, oct, nov, dec}

        static void Main(string[] args)
        {
            string userInput;
            int elementValue;
            bool mainLoop = true;


            while (mainLoop)
            {

                /* Console.WriteLine("What level would you like to play? ( 1:Easy\t2:Medium\t3:Hard  )");

                 playerInput = Console.ReadLine();

                 if (playerInput == "1" || playerInput == "Easy")
                 {
                     Console.WriteLine("You have chosen " + level.Easy);
                     int elementValue = (int)level.Easy;
                     Console.WriteLine(elementValue + " is the position of \'Easy\' within the array \'level\'");
                 }
                 else if (playerInput == "2" || playerInput == "Medium")
                 {
                     Console.WriteLine("You have chosen " + level.Medium);
                     int elementValue = (int)level.Medium;
                     Console.WriteLine(elementValue + " is the position of \'Medium\' within the array \'level\'");
                 }
                 else if (playerInput == "3" || playerInput == "Hard")
                 {
                     Console.WriteLine("You have chosen " + level.Hard);
                     int elementValue = (int)level.Hard;
                     Console.WriteLine(elementValue + " is the position of \'Hard\' within the array \'level\'");
                 }
                 else
                 {
                     Console.WriteLine("Invalid input!");
                 }*/

                Console.WriteLine("Which month were you born? ");
                userInput = Console.ReadLine();
                userInput = userInput.ToLower();

                if (userInput == "jan" || userInput == "january")
                {
                    elementValue = ((int)months.jan)+1;
                    Console.WriteLine("Your birthday is in " + userInput + ", which is the " + elementValue + " month of the year.");
                }
                else if (userInput == "feb" || userInput == "febuary")
                {
                    elementValue = ((int)months.feb)+1;
                    Console.WriteLine("Your birthday is in " + userInput + ", which is the " + elementValue + " month of the year.");
                }
                else if (userInput == "mar" || userInput == "march")
                {
                    elementValue = ((int)months.mar)+1;
                    Console.WriteLine("Your birthday is in " + userInput + ", which is the " + elementValue + " month of the year.");
                }
                else if (userInput == "apr" || userInput == "april")
                {
                    elementValue = ((int)months.apr)+1;
                    Console.WriteLine("Your birthday is in " + userInput + ", which is the " + elementValue + " month of the year.");
                }
                else if (userInput == "may")
                {
                    elementValue = ((int)months.may)+1;
                    Console.WriteLine("Your birthday is in " + userInput + ", which is the " + elementValue + " month of the year.");
                }
                else if (userInput == "jun" || userInput == "june")
                {
                    elementValue = ((int)months.jun)+1;
                    Console.WriteLine("Your birthday is in " + userInput + ", which is the " + elementValue + " month of the year.");
                }
                else if (userInput == "jul" || userInput == "july")
                {
                    elementValue = ((int)months.jul)+1;
                    Console.WriteLine("Your birthday is in " + userInput + ", which is the " + elementValue + " month of the year.");
                }
                else if (userInput == "aug" || userInput == "august")
                {
                    elementValue = ((int)months.aug)+1;
                    Console.WriteLine("Your birthday is in " + userInput + ", which is the " + elementValue + " month of the year.");
                }
                else if (userInput == "sep" || userInput == "september")
                {
                    elementValue = ((int)months.sep)+1;
                    Console.WriteLine("Your birthday is in " + userInput + ", which is the " + elementValue + " month of the year.");
                }
                else if (userInput == "oct" || userInput == "october")
                {
                    elementValue = ((int)months.oct)+1;
                    Console.WriteLine("Your birthday is in " + userInput + ", which is the " + elementValue + " month of the year.");
                }
                else if (userInput == "nov" || userInput == "november")
                {
                    elementValue = ((int)months.nov) + 1;
                    Console.WriteLine("Your birthday is in " + userInput + ", which is the " + elementValue + " month of the year.");
                }
                else if (userInput == "dec" || userInput == "december")
                {
                    elementValue = ((int)months.dec)+1;
                    Console.WriteLine("Your birthday is in " + userInput + ", which is the " + elementValue + " month of the year.");
                }
                else
                {
                    Console.WriteLine("Invalid Input!");
                }
















                Console.WriteLine("Would you like to go again? (Y/N)");
                userInput = Console.ReadLine();
                userInput = userInput.ToUpper();

                if (userInput == "N" || userInput == "NO")
                {
                    mainLoop = false;
                    break;
                }
                else
                {
                    Console.WriteLine("\n");
                }
            }
            
        }
    }
}
