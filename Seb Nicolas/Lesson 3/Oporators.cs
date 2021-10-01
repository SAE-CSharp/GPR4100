using System;

namespace Oporators
{
    class Program
    {
        enum difficulty { PRACTICE, EASY, NORMAL, HARD };
        enum months { Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec };

        static void Main(string[] args)
        {
            int a;
            int b;

            Console.WriteLine("Enter an Intager");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter another Intager");
            b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("The Remainder is: " + a % b + "\n");
            if ((a % b) == 0)
            {
                Console.WriteLine("A is evenly devisible by B");
            }
            else
            {
                Console.WriteLine("A is not evenly devisable by B");
            }

            int carbons;
            const double RATEOFCARBON = 0.3;
            Console.WriteLine("How much carbon have you collected?");
            carbons = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Your Carbon is worth: $" + (carbons * RATEOFCARBON));

            int lvl;
            Console.WriteLine("Enter your level \n1. practice \n2. easy \n3. normal \n4. hard ");
            lvl = Int32.Parse(Console.ReadLine());
            if (lvl == 1)
            {
                int practice = (int)difficulty.PRACTICE;
                Console.WriteLine("Practice level selected");
                difficulty playerDifficulty = difficulty.PRACTICE;
                Console.WriteLine((practice + 1) + " " + playerDifficulty + " Has been set");
            }

            else if (lvl == 2)
            {
                int easy = (int)difficulty.EASY;
                Console.WriteLine("Easy level selected");
                difficulty playerDifficulty = difficulty.EASY;
                Console.WriteLine((easy + 1) + " " + playerDifficulty + " Has been set");
            }

            else if (lvl == 3)
            {
                int normal = (int)difficulty.NORMAL;
                Console.WriteLine("Normal level selected");
                difficulty playerDifficulty = difficulty.NORMAL;
                Console.WriteLine((normal + 1) + " " + playerDifficulty + " Has been set");
            }

            else if (lvl == 4)
            {
                int hard = (int)difficulty.HARD;
                Console.WriteLine("Hard level selected");
                difficulty playerDifficulty = difficulty.HARD;
                Console.WriteLine((hard + 1) + " " + playerDifficulty + " Has been set");
            }

            else
            {
                Console.WriteLine("Sorry, that is not a level listed. Please close and try again.");
            }

            int month;
            Console.WriteLine("Enter your favourite month: \n1. Jan \n2. Feb \n3. Mar \n4. Apr \n5. May \n6. Jun \n7. Jul \n8. Aug \n9. Sep \n10. Oct \n11. Nov \n12. Dec  ");
            month = Int32.Parse(Console.ReadLine());
            if (month == 1)
            {
                int mon = (int)months.Jan;
                Console.WriteLine(months.Jan + " selected");
                months playerMonths = months.Jan;
                Console.WriteLine((mon + 1) + " " + playerMonths + " Has been set");
            }

            else if (month == 2)
            {
                int mon = (int)months.Feb;
                Console.WriteLine(months.Feb + " selected");
                months playerMonths = months.Feb;
                Console.WriteLine((mon + 1) + " " + playerMonths + " Has been set");
            }

            else if (month == 3)
            {
                int mon = (int)months.Mar;
                Console.WriteLine(months.Mar + " selected");
                months playerMonths = months.Mar;
                Console.WriteLine((mon + 1) + " " + playerMonths + " Has been set");
            }

            else if (month == 4)
            {
                int mon = (int)months.Apr;
                Console.WriteLine(months.Apr + " selected");
                months playerMonths = months.Apr;
                Console.WriteLine((mon + 1) + " " + playerMonths + " Has been set");
            }

            else if (month == 5)
            {
                int mon = (int)months.May;
                Console.WriteLine(months.May + " selected");
                months playerMonths = months.May;
                Console.WriteLine((mon + 1) + " " + playerMonths + " Has been set");
            }

            else if (month == 6)
            {
                int mon = (int)months.Jun;
                Console.WriteLine(months.Jun + " selected");
                months playerMonths = months.Jun;
                Console.WriteLine((mon + 1) + " " + playerMonths + " Has been set");
            }

            else if (month == 7)
            {
                int mon = (int)months.Jul;
                Console.WriteLine(months.Jul + " selected");
                months playerMonths = months.Jul;
                Console.WriteLine((mon + 1) + " " + playerMonths + " Has been set");
            }

            else if (month == 8)
            {
                int mon = (int)months.Aug;
                Console.WriteLine(months.Aug + " selected");
                months playerMonths = months.Aug;
                Console.WriteLine((mon + 1) + " " + playerMonths + " Has been set");
            }

            else if (month == 9)
            {
                int mon = (int)months.Sep;
                Console.WriteLine(months.Sep + " selected");
                months playerMonths = months.Sep;
                Console.WriteLine((mon + 1) + " " + playerMonths + " Has been set");
            }

            else if (month == 10)
            {
                int mon = (int)months.Oct;
                Console.WriteLine(months.Oct + " selected");
                months playerMonths = months.Oct;
                Console.WriteLine((mon + 1) + " " + playerMonths + " Has been set");
            }

            else if (month == 11)
            {
                int mon = (int)months.Nov;
                Console.WriteLine(months.Nov + " selected");
                months playerMonths = months.Nov;
                Console.WriteLine((mon + 1) + " " + playerMonths + " Has been set");
            }

            else if (month == 12)
            {
                int mon = (int)months.Dec;
                Console.WriteLine(months.Dec + " selected");
                months playerMonths = months.Dec;
                Console.WriteLine((mon + 1) + " " + playerMonths + " Has been set");
            }

            else
            {
                Console.WriteLine("Sorry, that is not a month listed. Please close and try again.");
            }

        }
        }
    }
}
