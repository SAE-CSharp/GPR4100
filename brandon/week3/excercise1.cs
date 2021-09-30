
using System;

namespace Excersise1_week3
{
    class Program
    {
        // enumertion
        //************************
        //create enumeration
        enum Level { EASY, MEDIUM, HARD}; // enumeration must be intialised outside of main method
        enum Month { JANUARY, FEBRUARY, MARCH, APRIL, MAY, JUNE, JULY, AUGUST, SEPTEMBER, OCTOBER, NOVEMBER, DECEMBER};
        static void Main(string[] args)
        {
            Console.WriteLine("what difficulty would you like to play\n1 = easy\n2 = medium\n3 = hard");
            int GameLevel = Int32.Parse(Console.ReadLine());
                if (GameLevel == 1)
                {
                    Console.WriteLine(Level.EASY + " mode selected");
                    //value of the Level element
                    int eleValue = (int)Level.EASY;
                    Console.WriteLine(eleValue);
                }
                else if (GameLevel == 2)
                {
                    Console.WriteLine(Level.MEDIUM + " mode selected");
                    int eleValue = (int)Level.MEDIUM;
                    Console.WriteLine(eleValue);
                }
                else if (GameLevel == 3)
                {
                    Console.WriteLine(Level.HARD + " mode selected");
                    int eleValue = (int)Level.HARD;
                    Console.WriteLine(eleValue);
                }
                else
                {
                    Console.WriteLine("that difficuty does not exist, try again");
                    GameLevel = 0;
                }
            Console.WriteLine("please enter a month (numerically or alphabetically)");
            char MonthVal = char.Parse(Console.ReadLine());
            int MonthValue = Int32.Parse(Console.ReadLine());
                if (MonthVal == 'a'|| MonthValue == 1)
                {
                    Console.WriteLine(MonthVal + " is " + Month.JANUARY);
                    int eleValue = (char)Month.JANUARY;
                    Console.WriteLine(eleValue);
                }
                if (MonthVal == 'b'|| MonthValue == 2)
                {
                    Console.WriteLine(MonthVal + " is " + Month.FEBRUARY);
                    int eleValue = (char)Month.FEBRUARY;
                    Console.WriteLine(eleValue);
                }
                if (MonthVal == 'c'|| MonthValue == 3)
                {
                    Console.WriteLine(MonthVal + " is " + Month.MARCH);
                    int eleValue = (char)Month.MARCH;
                    Console.WriteLine(eleValue);
                }
                if (MonthVal == 'd'||MonthValue == 4)
                {
                    Console.WriteLine(MonthVal + " is " + Month.APRIL);
                    int eleValue = (char)Month.APRIL;
                    Console.WriteLine(eleValue);
                }
        }
    }
}
