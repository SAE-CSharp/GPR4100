using System;

namespace Week3
{
    class Program
    {
        enum Level { Easy, Medium, Hard };
        enum Months { Jan, Feb, Mar };//Create enumeration
        static void Main(string[] args)

        {
            Console.WriteLine("Which level would you like to play?\n 1.Easy \n 2.Medium \n 3.Hard");
            int gameLevel = Int32.Parse(Console.ReadLine());
            if (gameLevel == 1)
            {
                Console.WriteLine("Your level is " + Level.Easy + ", that may be too easy."); //The value of the level elements
                int eleValue = (int)Level.Easy;

                Console.WriteLine("\nThe value of the Easy level is " + eleValue);
            }



            Console.WriteLine("In which month were you born?\n 1 or A.Jan \n 2 or B.Feb \n 3 or C.Mar");
            
            char birthDate = char.Parse(Console.ReadLine());
            if (birthDate == 'A' || birthDate == '1' )
            

                {
                    Console.WriteLine("Your birth month is " + Months.Jan + ", that is the first month of the year."); //The value of the level elements
                    int monValue = (int)Months.Jan;

                    Console.WriteLine("\nThe value of January is " + monValue);
                }
            if (birthDate == 'B')
            {
                Console.WriteLine("Your birth month is " + Months.Feb + ", that is the second month of the year."); //The value of the level elements
                int tueValue = (int)Months.Feb;

                Console.WriteLine("\nThe value of February is " + tueValue);
            }
            if (birthDate == 'C')
            {
                Console.WriteLine("Your birth month is " + Months.Mar + ", that is the third month of the year."); //The value of the level elements
                int wedValue = (int)Months.Mar;

                Console.WriteLine("\nThe value of February is " + wedValue);

            }

        





            
        }
    }
}
