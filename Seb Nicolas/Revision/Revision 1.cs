using System;

namespace Revision
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Seb";
            //int age = 18;
            //string friend = "Tony";

            //Console.WriteLine("Hello Babs, My name is " + name + "!");
            //Console.WriteLine("I am " + age + " years old");
            //Console.WriteLine("I have a friend named " + friend);
            //Console.WriteLine("He isn't very funny.");

            //char grade = 'A';
            //int number1 = 1000;
            //int number2 = -1000;

            //float speed = 1.5f;
            //double speed2 = 2.2;

            //bool death = true;
            //bool alive = false;

            //string campus = "London";
            //Console.WriteLine("London");
            //campus.ToUpper();
            //Console.WriteLine(campus);
            //Console.WriteLine(campus + " " + grade + " " + number1 + " " + number2 + " " + speed + " " + speed2 + " " + death + " " + alive);

            //Console.WriteLine("Please enter your name: ");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Woah! hey " + yourName + " Nice name!");
            //Console.WriteLine("=====================================");
            //int x = 5;
            //x++; // increase by 1
            //x += 2; // x = x+2
            //x -= 2; // x = x-2

            //Console.WriteLine("===================IF==================");
            //Console.WriteLine("Pick a number between 0 and 10");

            //int pick = Int32.Parse(Console.ReadLine());

            //if (pick < 0)
            //{
            //    Console.WriteLine("==========================");
            //    Console.WriteLine("Your number is less than 0");
            //    Console.WriteLine("==========================");
            //}
            //else if (pick < 10 || pick > 0)
            //{
            //    Console.WriteLine("===============================");
            //    Console.WriteLine("Your number is within the limit");
            //    Console.WriteLine("===============================");
            //}
            //else
            //{
            //    Console.WriteLine("==========================");
            //    Console.WriteLine("Your number is " + pick);
            //    Console.WriteLine("==========================");
            //}


            //Console.WriteLine("===================Modulus==================");

            //Console.WriteLine(5 % 2); // 1
            //Console.WriteLine(6 % 3); // 0
            //Console.WriteLine(10 % 4); // 2

            //Console.WriteLine("===================Switch==================");

            //Console.WriteLine("Please enter the day: ");
            
            //string today = Console.ReadLine();

            //switch (today)
            //{
            //    case "Monday":
            //        Console.WriteLine("Today is Monday");
            //        break;

            //    case "Tuesday":
            //        Console.WriteLine("Today is not Tuesday. Please enter the day from the list: \n1. Monday\n2. Wednesday\n3. Thursday\n4. Friday");
            //        int option = Int32.Parse(Console.ReadLine());
            //        if (option == 1)
            //        {
            //            Console.WriteLine("Today is not Monday :(");
            //        }
            //        if (option == 2)
            //        {
            //            Console.WriteLine("Today is not Wednesday :(");
            //        }
            //        if (option == 3)
            //        {
            //            Console.WriteLine("Today is not Thursday :(");
            //        }
            //        if (option == 4)
            //        {
            //            Console.WriteLine("Today is Friday! :(");
            //        }
            //        break;

            //    case "Wednesday":
            //        Console.WriteLine("Today is Wednesday");
            //        break;

            //    case "Thursday":
            //        Console.WriteLine("Today is Thursday");
            //        break;

            //    case "Friday":
            //        Console.WriteLine("Today is Friday");
            //        break;

            //    default:
            //        Console.WriteLine("Incorrect Format");
            //        break;
            //}

            //int a = 5;
            //int b = 2;
            //int result = 5 % 2;

            //Console.WriteLine(5 % 2);
            //Console.WriteLine(result);
            //Console.WriteLine(6 % 3);
            //Console.WriteLine(10 % 4);


            Console.WriteLine("===================While Loop==================");

            int counter = 10;

            while (counter >= 1)
            {
               
                Console.WriteLine("Counter is " + counter);
                counter--;

            }
        }
    }
}
