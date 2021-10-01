using System;

namespace MCarpenter_Wk3_Ex1
{
    class Program
    {
        enum difficulty { Easy, Medium, Hard };
        enum month { Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec };

        static void Main(string[] args)
        {
            Console.WriteLine("\nInput a difficulty (Easy/Medium/Hard):");
            string diffInput = Console.ReadLine();
            int diffSel = 0;
            if (diffInput == "Easy")
            {
                diffSel = (int)difficulty.Easy;
            }
            else if (diffInput == "Medium")
            {
                diffSel = (int)difficulty.Medium;
            }
            else if (diffInput == "Hard")
            {
                diffSel = (int)difficulty.Hard;
            }
            Console.WriteLine("\nYou have selected difficulty level " + diffSel);

            Console.WriteLine("\nPlease enter the current year:");
            int yearInput = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nPlease enter the current month (name, not number):");
            string monthInput = Console.ReadLine();

            Console.WriteLine("\nPlease enter the current day:");
            int dayInput = Int32.Parse(Console.ReadLine());

            int monthInt = 0;
            if (monthInput == "January")
            {
                monthInt = (int)month.Jan + 1;
            }
            else if (monthInput == "February")
            {
                monthInt = (int)month.Feb + 1;
            }
            else if (monthInput == "March")
            {
                monthInt = (int)month.Mar + 1;
            }
            else if (monthInput == "April")
            {
                monthInt = (int)month.Apr + 1;
            }
            else if (monthInput == "May")
            {
                monthInt = (int)month.May + 1;
            }
            else if (monthInput == "June")
            {
                monthInt = (int)month.Jun + 1;
            }
            else if (monthInput == "July")
            {
                monthInt = (int)month.Jul + 1;
            }
            else if (monthInput == "August")
            {
                monthInt = (int)month.Aug + 1;
            }
            else if (monthInput == "September")
            {
                monthInt = (int)month.Sep + 1;
            }
            else if (monthInput == "October")
            {
                monthInt = (int)month.Oct + 1;
            }
            else if (monthInput == "November")
            {
                monthInt = (int)month.Nov + 1;
            }
            else if (monthInput == "December")
            {
                monthInt = (int)month.Dec + 1;
            }

            Console.WriteLine("\nThe current date is " + dayInput + "/" + monthInt + "/" + yearInput);
        }
    }
}
