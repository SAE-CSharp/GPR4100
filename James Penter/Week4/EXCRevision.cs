using System;

namespace ExeWeek4
{
    class Program
    {
        static void Main(string[] args)
        {
            string Jo = "John";
            int age = 20;
            //***********************
            Console.WriteLine("My name is " + Jo + "!");
            Console.WriteLine("I am " + age + " years old");
            Jo = "Jay";//Changes name from this point onward
            Console.WriteLine("I like the name " + Jo);
            Console.WriteLine("But I dont like being " + age);
            //RULE of variables: Data type then Variable name then finally the text or integer value


            //datatypes
            string campus = "Liverpool";
            Console.WriteLine(campus.ToLower());//makes all characters in the string convert to lowercase

            string street = "lilford Avenue";
            Console.WriteLine(street.ToLower());

            Console.WriteLine(campus.ToUpper());//makes all character uppercase
            Console.WriteLine("Hi");
            Console.Write("Enter campus name: ");
            string campus1 = Console.ReadLine();
            Console.Write("So you campus is..." + campus1 + "\n");
            //**********************************************************************
            Console.Write(10 + 40);
            int x = 60;
            int y = 40;
            int z = 20;
            int result = x + y + z;
            Console.WriteLine("\n" + result);
            //***************************************************************
            //float,double,char
            float speed = 5.6f;//always ahve to add the 'f' at the end of float
            double time = 9.3;
            char grade = 'A';
            Console.WriteLine(grade);
            bool isalive = true;
            bool ismale = false;

            //ADDING VALUE OF 1
            int a = 20;
            Console.WriteLine(a++);
            Console.WriteLine(a += 1);


            //IF statements
            int number;
            Console.WriteLine("Write a number between 0 and 10");
            number = Int32.Parse(Console.ReadLine());

            if (number > 10)
            {
                Console.WriteLine("Your number should be less than 10");

            }
            else if (number < 0)
            {
                Console.WriteLine("Your number should be greater than zero");
            }
            else
            {
                Console.WriteLine("Well done!");
            }
            //MODULOS OPERATOR MEANT TO THE FIND THE REMAINING WHOLE VALUE AFTER DIVIDING THE FIRST OPERAND BY THE SECOND
            Console.WriteLine(5 % 2);
            Console.WriteLine(6 % 3);
            Console.WriteLine(10 % 4);
            Console.WriteLine(11 % 5);
            //ODD AND EVEN
            int val;
            Console.WriteLine("Enter any number ODD or EVEN");
            val = Int32.Parse(Console.ReadLine());
            if (val % 2 == 0)//Is the value entered by the user divisible by itself or not (ODD/EVEN)
            {
                Console.WriteLine("This an even number");
            }
            else
            {
                Console.WriteLine("This is an odd number");
            }
            //*****************************************************************************************
            int num;
            int jay;
            Console.WriteLine("Enter a number above 20 and below 30");
            jay = Int32.Parse(Console.ReadLine());
            if (jay < 20)
            {
                Console.WriteLine("This is lower than 20");
            }
            else if (jay > 30)
            {
                Console.WriteLine("This is greater than 30");
            }
            else if (jay > 20 || jay < 30)
            {
                Console.WriteLine("This is correct");

            }

            else if (jay == 30)
            {
                Console.WriteLine("This is equal to 30");

            }
            else
            {
                Console.WriteLine("Invalid number");
            }





            //Switch statement 

            char Grade1 = 'A';
            char Grade2 = 'B';
            char Grade3 = 'C';
            char Grade4 = 'D';
            string today = "Wednesday";


            switch (Grade1)
            {
                case ('A'):
                    Console.WriteLine("You got an A, Well done!");
                    break;
            }
            switch (Grade2)
            {
                case ('B'):
                    Console.WriteLine("Please enter your grade");
                    char option = char.Parse(Console.ReadLine());
                    if (option == 'B')
                    {
                        Console.WriteLine("You got a B");
                    }
                        else if (option == 'C')
                    {
                         Console.WriteLine("You got a C");
                    }
                    break;
                       
            }
            switch (Grade3)
            {
                case ('D'):
                    Console.WriteLine("You got a D, Well done!");
                    break;
            }
            switch (Grade4)
            {
                case ('E'):
                    Console.WriteLine("You got an E, Well done!");
                    break;

                
                    
            }
            
            
            //WHILE LOOPS
            int counter = 20;
            while (counter > 10)
            {
                Console.WriteLine("counter = " +  counter);
                counter--;
            }
            
            //acknowledging the current date
            string day;
            Console.WriteLine("What day is today?");
            day = Console.ReadLine();
            Console.WriteLine("So today is..." + day);























        }
    }
}
