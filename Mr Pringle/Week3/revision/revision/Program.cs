using System;

namespace revision
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Enter name!");
           // string name = Console.ReadLine();
            //Console.WriteLine("Enter age!");
            //int age = Convert.ToInt32(Console.ReadLine());
            string name = "Dalton";
            int age = 20;
            Console.WriteLine("My Name is " + name + ",");
            Console.WriteLine("and I am "+age+" Years Old.");
            name = "Tom";                                               //the value of name has changed from this point forward unless changed again
            age = 21;                                                   //the value of age has changed from this poinnt forward unless changed again
            Console.WriteLine("I like the name "+name+",");
            Console.WriteLine("but I don't like being "+age);
            /////////////////////////////////////////////////
            //datatypes
            string campus = "Liverpool";                                //Liverpool i stoered in the variable of campuss
            Console.WriteLine(campus.ToLower());                        // .ToLower makes everything lower case
            Console.WriteLine(campus.ToUpper());                        // .ToUpper makes everything upper case
            
            Console.WriteLine("SAE "+campus);
            Console.Write("Enter your campus name: ");
            string campus1 = Console.ReadLine();
            Console.WriteLine(campus1);
            Console.WriteLine("60 + 40 in line = "+60+40);
            int x = 60;
            int y = 40;
            int result = x + y;
            Console.WriteLine("X + Y = "+ result);
            /////////////////////////////////////////////////
            //float
            float speed = 5.6f;
            //double
            double speed1 = 5.6;
            //decimal
            decimal speed2 = 56;
            //char
            Console.WriteLine("Enter Grade!");
            char grade = Convert.ToChar(Console.ReadLine());
            //boolean
            bool nought = true;
            bool cross = false;
            //increase and decrease
            int a = 20;
            

            Console.WriteLine("Float "+speed);
            Console.WriteLine("Double "+speed1);
            Console.WriteLine("Decimal "+speed2);
            Console.WriteLine("Char "+grade);
            Console.WriteLine("Boolean "+nought);
            Console.WriteLine("Boolean "+cross);
            a = a++;
            Console.WriteLine("Increase "+a);
            a = a--;
            Console.WriteLine("Decease "+a);
            /////////////////////////////////////////////////

            Console.WriteLine("Enter a number between 0 and 10!");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num > 10)                                                        //operant is num and 10, operator is >
            {
                Console.WriteLine("You're number should be 10 or less");
            }
            else if (num<0)
            {
                Console.WriteLine("Your number should be more than 0");
            }
            else
            {
                Console.WriteLine("Well Done");
            }

            //////////////////////////////////////////////////////
            ///modulus operator %, it prints the remainder after dividing the first number by the second
            Console.WriteLine("5 % 2 = "+ 5 % 2);
            Console.WriteLine("6 % 3 = "+6 % 3);
            Console.WriteLine("10 % 4 = "+10 % 4);
            Console.WriteLine("3 % 2 = " + 3 % 2);
            Console.WriteLine("11 % 5 = " + 11 % 5);
            Console.WriteLine("17 & 4 = " + 17 % 4);
          Console.WriteLine("Enter an Even or Odd number");
            int eOo = Convert.ToInt32(Console.ReadLine());
            if (eOo % 2 == 0)
            {
                Console.WriteLine("Tis Even");
            }
            else
            {
                Console.WriteLine("Tis Odd");
            }

            Console.WriteLine("Enter a multiple of 10 up to 30.");
            int z = Convert.ToInt32(Console.ReadLine());
            if (z == 10)
            {
                Console.WriteLine("Value of Z is 10");
            }
            else if (z == 20)
            {
                Console.WriteLine("Value of Z is 20");
            }
            else if (z == 30)
            {
                Console.WriteLine("Value of Z is 30");
            }
            else
            {
                Console.WriteLine("That wasn't an option.");
            }

            ///////////////////////////////////////////////////
            Console.WriteLine("What day is it?");
            string day = Console.ReadLine();
            switch (day)
            {
                case "Monday":
                {
                    Console.WriteLine("Today is Monday");
                    break;
                }
                case "Tuesday":
                { 
                    Console.WriteLine("Today is Tuesday");
                    break;
                }
                case "Wednesday":
                {
                    Console.WriteLine("Today is Wednesday");
                    break;
                }
                case "Thursday":
                {
                    Console.WriteLine("Today is Thrusday");
                    break;
                }
                case "Friday":
                {
                    Console.WriteLine("Today is Friday");
                    break;
                }
                case "Saturday":
                {
                    Console.WriteLine("Today is Saturday");
                    break;
                }
                case "Sunday":
                {
                    Console.WriteLine("Today is Sunday");
                    break;
                }
                default:
                {
                    Console.WriteLine("Invalid Use propper grammar and or spellting next time!");
                    break;
                }

            }

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("An A thats a Perfect Grade");
                    break;
                case 'B':                               //by doing this its a B OR C 
                case 'C':
                    Console.WriteLine("Enter your Grade again!");
                    char option = Convert.ToChar(Console.ReadLine());
                    if (option == 'B')
                    {
                        Console.WriteLine("B thats Brill");
                    }
                    if (option == 'C')
                    {
                        Console.WriteLine("C you just passed you should try harder");
                    }
                    break;
                case 'D':
                    Console.WriteLine("D? Yeah you failed");
                    break;
                case 'F':
                    Console.WriteLine("F? thats worse than D");
                    break;
                default:
                    Console.WriteLine("Invalid Grade");
                    break;
            }

            ////////////////////////////////////////////////////////////////////////
            
            int tries = 3;
            while(tries != 0 || tries < 0)
            {
                Console.WriteLine("Guess the number, its between 0 and 10.");
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess == num)
                {
                    Console.WriteLine("Congrats you guessed right!\nYou had "+tries+" left!");
                    break;
                }
                else if (guess != num)
                {
                    tries--;
                    Console.WriteLine("That's Incorrect, you have " + tries + " left!");
                }

            }






            Console.ReadLine();
        }
    }
}
