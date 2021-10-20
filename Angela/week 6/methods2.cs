using System;

namespace methods2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int num1 = 5;
            //void method
            intSquare(num1);

            //return method
            int res = square(4);

            //pass by Value 
            int localVar = 10;
            Console.WriteLine("Before passing the parameter into method " + localVar);
            passByVal(localVar);
            Console.WriteLine("after passing the parameter into method " + localVar);

            //pas by reference
            int[] grades = new int[1];
            grades[0] = 75;
            Console.WriteLine("the grade of the student before extra credit" + grades[0]);
            StudentGrade(grades);
            Console.WriteLine("the grade of the student after extra credit" + grades[0]);


            //temperature convertation
            Console.WriteLine("Enter your temperature pls: ");
            double temperature = double.Parse(Console.ReadLine());
            double temp = ConvertTemperature(temperature);
            Console.WriteLine("your temperature is " + temp);
            if (temp <= 35.0)
            {
                Console.WriteLine("You are sick");
            }

            //multiple return statement

            int counter = 3;
            while (counter > 0)
            {
                Console.WriteLine("Enter the first number: ");
                int first = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second number: ");
                //I can use int,convert/parse in converting string to integer, both works the same
                //if i need to convert string to double, use double.parse
                //int second = int.Parse(Console.ReadLine());
                int second = Convert.ToInt32(Console.ReadLine());
                int response = multipleReturn(first, second);
                Console.WriteLine(response);
                counter--;

            }

            //call the default parameter 
            DefaultParameters(2);
            DefaultParameters(2, 5);
            DefaultParameters(1, 4, 2);



        }

        //create void method

        static void intSquare(int x)
        {
            int result = x * x;
            Console.WriteLine(result);
        }

        static int square(int num1)
        {
            int result = num1 * num1;
            return result;
        }


        //pass parameter by Value
        static void passByVal(int x)
        {
            x = 20;
            Console.WriteLine("x== " + x);
        }

        //pass by reference
        static void StudentGrade(int[] grades)
        {
            grades[0] += 3;

        }

        static double ConvertTemperature(double TempperatureF)
        {
            double temperatureC = (TempperatureF - 32) * 5 / 9;
            return temperatureC;
        }

        //multiple return statement 
        static int multipleReturn (int x, int y)
        {
            if (x <y)
            {
                return 1;
            }
            else if (x == y)
            {
                return 0;
            }
            else
            {
                return -1;
            }

            static void PrintPositiveNumber (int number)
            {
                if (number < 0) //if the number is NOT positive, terminate the method
                {
                    return;
                }
                Console.WriteLine(number);
            }
        }

        //default parameters
        static void DefaultParameters(int x, int y = 10, int z = 15)
        {
            int answer = x * y * z;
            Console.WriteLine(answer);
        }

       
    }
}
