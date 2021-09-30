using System;

namespace Month_Enumeration
{
    class Program
    {
        enum Month { Filler, Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the corralating number to the month of your birth:");
            Console.WriteLine("A or 1. January\nB or 2. Febuary\nC or 3. March\nD or 4. April\n.E or 5. May\nF or 6. June\nG or 7. July\nH or 8. August\nI or 9. September\nJ or 10. October\nK or 11. November\nL or 12. December\n\n");
            string monthChoice = Console.ReadLine(); 
            //int monthChoice1 = Convert.ToInt32(Console.ReadLine());
            
            if (monthChoice == "A" || monthChoice == "1")
            {
                Console.WriteLine("You can said you were born in " + Month.Jan+"uary");
                int eveMonth = (int)Month.Jan;
                Console.WriteLine("The value of the month is " + eveMonth);
            }
            else if (monthChoice == "B" || monthChoice == "2")
            {
                Console.WriteLine("You can said you were born in " + Month.Feb+"uary");
                int eveMonth = (int)Month.Feb;
                Console.WriteLine("The value of the month is " + eveMonth);
            }
            else if (monthChoice == "C" || monthChoice == "4")
            {
                Console.WriteLine("You can said you were born in " + Month.Mar+"ch");
                int eveMonth = (int)Month.Mar;
                Console.WriteLine("The value of the month is " + eveMonth);
            }
            else if (monthChoice == "D" || monthChoice == "4")
            {
                Console.WriteLine("You can said you were born in " + Month.Apr+"il");
                int eveMonth = (int)Month.Apr;
                Console.WriteLine("The value of the month is " + eveMonth);
            }
            else if (monthChoice == "E" || monthChoice == "5")
            {
                Console.WriteLine("You can said you were born in " + Month.May);
                int eveMonth = (int)Month.May;
                Console.WriteLine("The value of the month is " + eveMonth);
            }
            else if (monthChoice == "F" || monthChoice == "6")
            {
                Console.WriteLine("You can said you were born in " + Month.Jun+"e");
                int eveMonth = (int)Month.Jun;
                Console.WriteLine("The value of the month is " + eveMonth);
            }
            else if (monthChoice == "G" || monthChoice == "7")
            {
                Console.WriteLine("You can said you were born in " + Month.Jul+"y");
                int eveMonth = (int)Month.Jul;
                Console.WriteLine("The value of the month is " + eveMonth);
            }
            else if (monthChoice == "H" || monthChoice == "8")
            {
                Console.WriteLine("You can said you were born in " + Month.Aug+"ust");
                int eveMonth = (int)Month.Aug;
                Console.WriteLine("The value of the month is " + eveMonth);
            }
            else if (monthChoice == "I" || monthChoice == "9")
            {
                Console.WriteLine("You can said you were born in " + Month.Sep+"tember");
                int eveMonth = (int)Month.Sep;
                Console.WriteLine("The value of the month is " + eveMonth);
            }
            else if (monthChoice == "J" || monthChoice == "10")
            {
                Console.WriteLine("You can said you were born in " + Month.Oct+"ober");
                int eveMonth = (int)Month.Oct;
                Console.WriteLine("The value of the month is " + eveMonth);
            }
            else if (monthChoice == "K" || monthChoice == "11")
            {
                Console.WriteLine("You can said you were born in " + Month.Nov+"ember");
                int eveMonth = (int)Month.Nov;
                Console.WriteLine("The value of the month is " + eveMonth);
            }
            else if (monthChoice == "L" || monthChoice == "12")
            {
                Console.WriteLine("You can said you were born in " + Month.Dec+"ember");
                int eveMonth = (int)Month.Dec;
                Console.WriteLine("The value of the month is " + eveMonth);
            }
            else
            {
                Console.WriteLine("Error 404:\nUsers brain not found.");
            }

            Console.ReadLine();
        }
    }
}
