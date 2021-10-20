using System;

namespace Method2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            int num1 = 5;

            //void method
            intSquare(num1);



            // a return method
            int res = square(4);
            Console.WriteLine(res);



            //pass by value
            int localVal = 10;
            Console.WriteLine("Before using the parameter into the method = " + localVal);
            MethodUsingByVal(localVal);
            Console.WriteLine("After using the parameter into the method = "+localVal);                                 //pass by vaule DOESN'T change the origional value 



            //pass by referance
            int[] grade = new int[1];
            grade[0] = 75;
            Console.WriteLine("Stident Grade Before using the extra credit = " + grade[0]);
            GivenExtraGradeArray(grade);
            Console.WriteLine("Student Grade After using the extra credit = " + grade[0]);                              //pass by referance DOES change the origional vaule



            //temp convertion
            Console.WriteLine("Temp in Freedomhight");
            double temperature = Convert.ToDouble(Console.ReadLine());
            double temp = ConvertTemperature(temperature);
            Console.WriteLine("Freedomhight converted to Correct is = " + temp);
            if(temp < 35.0||temp > 38.0)
            {
                Console.WriteLine("You're ill and should rest.");
            }



            //multiple return
            int counter = 3;
            while (counter > 0)
            {
                Console.WriteLine("Enter Number.");
                int first = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Again!");
                int second = Convert.ToInt32(Console.ReadLine());
                int responce = multipleReturn(first, second);
                Console.WriteLine(responce);
                counter--;
            }



            //positive numbers only
            Random num = new Random();
            int ranNum = num.Next();
            PrintPositiveNumber(ranNum);



            //default parameters || optional parameters
            SomeMethod(1); // because y and z are both pre-defined you only need to define x
            SomeMethod(2, 5); // defines x and re-defines y but leaves z alone
            SomeMethod(1, 2, 7); //re-defines y and z while just defining x 



            //overloading method
            int ans = 5;
            OverLoadingMethods(ans, ans); // will use the int version
            double answer = 5.5;
            OverLoadingMethods(answer, answer); // will use the double version
            float answord = 0;
            OverLoadingMethods(answord, answord); // will use the float version
        }


        // create void method
        static void intSquare(int x)
        {
            int result = x * x;
            Console.WriteLine(result);
        }


        // create return method
        static int square(int num1) 
        {
            int result = num1 * num1;
            return (result);
        }


        //Pass parameter by value
        public static void MethodUsingByVal(int intPara)
        {
            intPara = 20;
            Console.WriteLine("While using the parameter into the method = " + intPara);
        }


        //pass by referance
        static void GivenExtraGradeArray(int[] grades)
        {
            grades[0] += 3;
        }


        //temp convertion
        static double ConvertTemperature(double TemperatureF) 
        {
            double TemperatureC = (((TemperatureF - 32) * 5 ) / 9);
            return TemperatureC;
        }


        //multipule return statment
        static int multipleReturn(int x, int y)
        {
            if (x > y)
            {
                Console.WriteLine("First is greater then Second");
                return 1;
            }
            else if (x == y)
            {
                Console.WriteLine("Both are the same");
                return 0;
            }
            else
            {
                Console.WriteLine("Second is greater then first");
                return -1;
            }

        }


        //positive numbers only
        static void PrintPositiveNumber(int number)
        {
            if (number <= 0)
            {
                return; // breaks the method if the number is NOT posative
            }
            Console.WriteLine(number);
        }


        //default parameters || optional parameters
        static void SomeMethod(int x, int y = 10, int z = 15)
        {
            int answer = x * y * z;
            Console.WriteLine(x+" x "+y+" X "+z+" = "+answer);
        }


        //method overloading
        static void OverLoadingMethods (int x, int y)
        {
            int ans = x + y;
        }
        static void OverLoadingMethods(double x, double y)
        {
            double ans = x + y;
        }
        static void OverLoadingMethods(float x, float y)
        {
            float str = x + y;
        }
    }
}
