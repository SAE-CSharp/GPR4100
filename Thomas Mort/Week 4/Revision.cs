using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("**********************");
            string today;
            Console.WriteLine("What day of the week is it?");
            today = Console.ReadLine();
            switch (today)
            {
                case "Monday":
                    Console.WriteLine("Today Is Monday");
                    break;

                case "Tuesday":
                    Console.WriteLine("Today Is Tuesday");
                    break;

                case "Wednesday":
                    Console.WriteLine("Today is Wednesday");
                    break;

                case "Thursday":
                    Console.WriteLine("Today is Thursday");
                    break;

                case "Friday":
                    Console.WriteLine("Today is Friday");
                    break;

                case "Saturday":
                    Console.WriteLine("Today is Saturday");
                    break;

                case "Sunday":
                    Console.WriteLine("Today is Sunday");
                    break;

                default:
                    Console.WriteLine("This is an Invalid day..");
                    break;

            }
            char grade;
            Console.WriteLine("What grade did student 1 get?");
            grade = char.Parse(Console.ReadLine());

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("You got an A!");
                    break;
                case 'B':
                    Console.WriteLine("You got a B!");
                    break;
                case 'C':
                    Console.WriteLine("You got a C!");
                    break;
                case 'D':
                    Console.WriteLine("You got a D.. please see the teacher later..");
                    break;
                case 'F':
                    Console.WriteLine("You failed this exam. Please revise more.");
                    break;
                default:
                    Console.WriteLine("That is an invalid grade. Please use A-F next time.");
                    break;
            }
            int x =0;
            while(x<11)
            {
                Console.WriteLine(x);
                x++;
            }
        }
    }
}
