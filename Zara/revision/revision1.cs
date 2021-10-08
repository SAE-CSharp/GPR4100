using System;

namespace revision1
{
    class Program
    {
        static void Main(string[] args)
        {

            string myName ="John";
            int Age = 20;
            Console.WriteLine("My name is"+myName);
            Console.WriteLine("and I am" + Age+ "years old");

            myName = "Tom";
            Console.WriteLine("I like the name " + myName);
            Console.WriteLine("but I don't like being "+Age);
            Console.WriteLine("****************************");

            // datatypes
            string campus = "Liverpool";

            Console.WriteLine(campus.ToLower());
            //Console.WriteLine("sae liverpool");
            Console.Write("Enter your campus name: ");
            string campus1 = Console.ReadLine();
            Console.WriteLine(60+40);

            int x = 60;
            int y = 40;
            int result = x + y;

            //float, double
            float speed = 5.6f;
            double playerSpeed = 9.3;

            // char
            char grade = 'C';

            bool isAlive = true;
            bool isMale = false;

            int a = 20;

            // modulus

            Console.WriteLine(3 % 2);
            Console.WriteLine(11 % 5);
            Console.WriteLine(17 % 4);

            Console.WriteLine("Enter an even number or an odd number");
            int num = Int32.Parse(Console.ReadLine());

            if (num % 2 == 0)// 6/2=0, 10/2
            {
                Console.WriteLine(" this is an even number");


            }
            else
            {
                Console.WriteLine(" this is an odd number");

            }
            Console.WriteLine("******************************************");

            string today = "Wednesday";

            switch (today)
            {
                case "Monday":
                    Console.WriteLine("today is Monday");
                    break;
                case "Tuseday":
                    Console.WriteLine("today is Tuesday");
                    break;
                case "Wednesday":
                    Console.WriteLine("today is Wednesday");

                    break;

                default:
                    Console.WriteLine("invalid day");
                    break;

            }

            char grade1 = 'A';

            switch (grade1)
            {
                case 'A':
                    Console.WriteLine("Excellent you got A");
                break;
                case 'B':
                case 'C':
                    Console.WriteLine("enter your grade");
                    char option = char.Parse(Console.ReadLine());
                    if (option == 'B') 
                    {
                    Console.WriteLine("well done you got B");
                    }
                    else
                    {
                    Console.WriteLine("well done you got C");

                    }
                    break;

                default:
                    Console.WriteLine("invalid grade");
                    break;


            }

        }
    }
}
