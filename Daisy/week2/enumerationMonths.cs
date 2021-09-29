using System;

namespace EnumerationMonths
{
    class Program
    {
        enum Months { January, February, March, April, May, June, July, August, September, October, November, December };
        
        static void Main(string[] args)
        {
            int birthMonth;

            Console.WriteLine("Which month is your birthday? Enter alphabetical value, e.g. A for Jan");
            birthMonth = char.Parse(Console.ReadLine());


            if (birthMonth == 'A' || birthMonth == 1)  
            { 
                Console.WriteLine("Your birthday is in " + Months.January);
                    int eleValue = (int)Months.January;
                Console.WriteLine("The value of your month is " + eleValue);
            }
            else if (birthMonth == 'B')
            {
                Console.WriteLine("Your birthday is in " + Months.February);
                int eleValue = (int)Months.February;
                Console.WriteLine("The value of your month is " + eleValue);
            }
            else if (birthMonth == 'C')
            {
                Console.WriteLine("Your birthday is in " + Months.March);
                int eleValue = (int)Months.March;
                Console.WriteLine("The value of your month is " + eleValue);
            }
            else if (birthMonth == 'D')
            {
                Console.WriteLine("Your birthday is in " + Months.April);
                int eleValue = (int)Months.April;
                Console.WriteLine("The value of your month is " + eleValue);
            }
            else if (birthMonth == 'E')
            {
                Console.WriteLine("Your birthday is in " + Months.May);
                int eleValue = (int)Months.May;
                Console.WriteLine("The value of your month is " + eleValue);
            }
            else if (birthMonth == 'F')
            {
                Console.WriteLine("Your birthday is in " + Months.June);
                int eleValue = (int)Months.June;
                Console.WriteLine("The value of your month is " + eleValue);
            }
            else if (birthMonth == 'G')
            {
                Console.WriteLine("Your birthday is in " + Months.July);
                int eleValue = (int)Months.July;
                Console.WriteLine("The value of your month is " + eleValue);
            }
            else if (birthMonth == 'H')
            {
                Console.WriteLine("Your birthday is in " + Months.August);
                int eleValue = (int)Months.August;
                Console.WriteLine("The value of your month is " + eleValue);
            }
            else if (birthMonth == 'I')
            {
                Console.WriteLine("Your birthday is in " + Months.September);
                int eleValue = (int)Months.September;
                Console.WriteLine("The value of your month is " + eleValue);
            }
            else if (birthMonth == 'J')
            {
                Console.WriteLine("Your birthday is in " + Months.October);
                int eleValue = (int)Months.October;
                Console.WriteLine("The value of your month is " + eleValue);
            }
            else if (birthMonth == 'K')
            {
                Console.WriteLine("Your birthday is in " + Months.November);
                int eleValue = (int)Months.November;
                Console.WriteLine("The value of your month is " + eleValue);
            }
            else if (birthMonth == 'L')
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
}
