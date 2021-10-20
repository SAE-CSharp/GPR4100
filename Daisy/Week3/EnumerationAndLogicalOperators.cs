using System;

namespace EnumerationMonths
{
    class Program
    {
        enum Months { January, February, March, April, May, June, July, August, September, October, November, December };
        
        static void Main(string[] args)
        {
            string birthMonth;
            

            Console.WriteLine("Which month is your birthday? Enter alphabetical or numerical value, e.g. A or 1 for Jan");
            birthMonth = (Console.ReadLine());


            if (birthMonth == "A" || birthMonth == "a" || birthMonth == "1")  
            { 
                Console.WriteLine("Your birthday is in " + Months.January);
                    int eleValue = (int)Months.January;
                Console.WriteLine("The value of your month is " + eleValue);
            }
            else if (birthMonth == "B" || birthMonth == "b" || birthMonth == "2")
            {
                Console.WriteLine("Your birthday is in " + Months.February);
                int eleValue = (int)Months.February;
                Console.WriteLine("The value of your month is " + eleValue);
            }
            else if (birthMonth == "C" || birthMonth == "c" || birthMonth == "3")
            {
                Console.WriteLine("Your birthday is in " + Months.March);
                int eleValue = (int)Months.March;
                Console.WriteLine("The value of your month is " + eleValue);
            }
            else if (birthMonth == "D" || birthMonth == "d" || birthMonth == "4")
            {
                Console.WriteLine("Your birthday is in " + Months.April);
                int eleValue = (int)Months.April;
                Console.WriteLine("The value of your month is " + eleValue);
            }
            else if (birthMonth == "E" || birthMonth == "e" || birthMonth == "5")
            {
                Console.WriteLine("Your birthday is in " + Months.May);
                int eleValue = (int)Months.May;
                Console.WriteLine("The value of your month is " + eleValue);
            }
            else if (birthMonth == "F" || birthMonth == "f" || birthMonth == "6")
            {
                Console.WriteLine("Your birthday is in " + Months.June);
                int eleValue = (int)Months.June;
                Console.WriteLine("The value of your month is " + eleValue);
            }
            else if (birthMonth == "G" || birthMonth == "g" || birthMonth == "7")
            {
                Console.WriteLine("Your birthday is in " + Months.July);
                int eleValue = (int)Months.July;
                Console.WriteLine("The value of your month is " + eleValue);
            }
            else if (birthMonth == "H" || birthMonth == "h" || birthMonth == "8")
            {
                Console.WriteLine("Your birthday is in " + Months.August);
                int eleValue = (int)Months.August;
                Console.WriteLine("The value of your month is " + eleValue);
            }
            else if (birthMonth == "I" || birthMonth == "i" || birthMonth == "9")
            {
                Console.WriteLine("Your birthday is in " + Months.September);
                int eleValue = (int)Months.September;
                Console.WriteLine("The value of your month is " + eleValue);
            }
            else if (birthMonth == "J" || birthMonth == "j" || birthMonth == "10")
            {
                Console.WriteLine("Your birthday is in " + Months.October);
                int eleValue = (int)Months.October;
                Console.WriteLine("The value of your month is " + eleValue);
            }
            else if (birthMonth == "K" || birthMonth == "k" || birthMonth == "11")
            {
                Console.WriteLine("Your birthday is in " + Months.November);
                int eleValue = (int)Months.November;
                Console.WriteLine("The value of your month is " + eleValue);
            }
            else if (birthMonth == "L" || birthMonth == "l" || birthMonth == "12")
            {
                Console.WriteLine("Your birthday is in " + Months.December);
                int eleValue = (int)Months.December;
                Console.WriteLine("The value of your month is " + eleValue);
            }

            else
            {
                Console.WriteLine("OK cool");
            }
        }
    }
