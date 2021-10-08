using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string myname = "Garran";
            int Age = 20;
            Console.WriteLine("My name is " + myname + "!!!");
            Console.WriteLine("And I am " + Age + " years old ");
            Console.WriteLine("I study Games Programming at SAE Institute");
            Console.WriteLine("I do not like being " + Age);
            *//*char grade = 'A';
            int numbers = 12345;
            int number2 = -12345;

            float speed = 1.5f;
            double speed2 = 2.24;
            bool isAlive = true;
            bool isMale = false*//*


            string campus = "London";
            campus.ToLower();
            Console.WriteLine(campus);
            Console.WriteLine("Enter your name below please - ");
            string name = Console.ReadLine();
            Console.WriteLine("*******************************************");
            int x = 5;
            x++; // Increase by 1
            x--; // Decreases value by 1
            x += 2;//  x = x+1;
            x -= 2;

            Console.WriteLine("***********************If*******************");
            Console.WriteLine("Please enter a number between 0 and 10:");
            *//*int secretNumber = 8;*//*

            int number = Int32.Parse(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("Your number is less than 0");
            }
            else if (number > 10)
            {
                Console.WriteLine("Your number is grater than 10");
            }
            else if (number < 10 || number > 0)
            {
                Console.WriteLine("Your number is greater than 0");
            }
            else
            {
                Console.WriteLine("Well done ");
            }
           
            Console.WriteLine("***********************Modules************");

            Console.WriteLine(5 % 2);    // 1
            Console.WriteLine(6 % 3);    // 0
            Console.WriteLine(10 % 4);   // 2

            Console.WriteLine("Enter today's name");

            Console.WriteLine("Enter the day's name 1. tuesday\n 2. Wednesday");
            string today = Console.ReadLine();
            
            int option = Int32.Parse(Console.ReadLine());
            if (option == 1)
            {
                Console.WriteLine("Today is tuesday");
            }

            if (option == 2)
            {
                Console.WriteLine("Today is Wednesday");
            }

            switch (today)
            {
                case "Monday":
                    Console.WriteLine("Today is monday");
                    break;

                case "Tuesday":
                    Console.WriteLine("Today is tuesday");
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


            }
            Console.WriteLine("**********************************");

          *//*  int a = 5;
            int b = 2;*//*

            int result = 5 % 2;
            Console.WriteLine(result);*/

            Console.WriteLine("********************While loop**********************");

            int counter = 10;

            while (counter > 1)
            {
                Console.WriteLine("counter is " + counter);
                counter--;

                
            }
        }
    }
}
