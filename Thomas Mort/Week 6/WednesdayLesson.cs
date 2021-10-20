using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
/*           //void method
            intSquare(5);

            //int method
            int res = square(10);
            Console.WriteLine(res);*/

            //Pass By Value
            int localVar = 10;
            Console.WriteLine("Before passing the parameter into method: " +localVar); // will print 10
            passByVal(localVar);  // will print 20
            Console.WriteLine("After passing the parameter into method: " + localVar);  // will print 10
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("**********************************************************************************");

            int localTest = 49;
            Console.WriteLine(localTest); // uses the variable above
            Test(localTest); // jumps to the method and changed the variable to whatever is in the method
            Console.WriteLine(localTest); // back to original variable
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("**********************************************************************************");

            int[] grade = new int[3];
            grade[0] = 68;
            grade[1] = 34;
            grade[2] = 79;
            Console.WriteLine("Before Extra credit,\nStudent 1 got: " + grade[0] + " %\nStudent 2 got: " + grade[1] + " %\nStudent 3 got: " + grade[2] + " %");
            StudentGrades(grade);
            Console.WriteLine("After Extra credit,\nStudent 1 got: " + grade[0] + " % overall \nStudent 2 got: " + grade[1] + " % overall \nStudent 3 got: " + grade[2] + " % overall");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("**********************************************************************************");

            Console.WriteLine("Input a temp in F: ");
            Double temperature = Double.Parse(Console.ReadLine());
            double temp = ConvertTemperature(temperature);
            Console.WriteLine("Your temperature in Degrees C is: " + temp);

            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("What number would you like to use?");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= count; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.WriteLine(j);
                }
                Console.WriteLine("\n");
            }
            
            Console.WriteLine("**********************************************************************************");

            /* int counter = 3;
             while (counter > 0)
             {
                 Console.WriteLine("Pick a number! ");
                 int first = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine("Pick another number! ");
                 int second = Convert.ToInt32(Console.ReadLine());
                 int h = MultipleReturns(first, second);
                 Console.WriteLine(h);
                 counter--;
             }*/
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("**********************************************************************************");

            PrintPositiveNumber(10);

            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("**********************************************************************************");
/*            // call the default parameters
            DefaultParameters(5);
            Console.WriteLine("**********************************************************************************");
            DefaultParameters(10, 7);
            Console.WriteLine("**********************************************************************************");
            DefaultParameters(7,5,9);*/

            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("**********************************************************************************");

            string str = "Hello World and C#";
            Console.WriteLine("{0}", str);

            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("**********************************************************************************");

            string name = "Tom";
            int age = 18;
            string town = "Birkenhead";
            Console.WriteLine("{0} is {1} years old from {2} ", name, age, town);

            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("**********************************************************************************");

            OverloadingMethod(10, 15);
            OverloadingMethod(10.5, 100.7);
            OverloadingMethod(10);

            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("**********************************************************************************");

            //whenever you pass an array into a method, it would pass by a reference, you pass a location of the array.
            // any changes you do on the array inside the method will be reflected on the original.
        }
        // create void method
        static void intSquare(int x)
              {
                  int result = x * x;
                  Console.WriteLine("The result is: " + result);
              }
              static int square(int z)
              {
                  int result = z * z;
                  return result;
              }
        //pass parameter by value
        static void passByVal(int f)
        {
            f = 20;
            Console.WriteLine(f);
        }

        static void Test(int b)
        {
            b = 50;
            Console.WriteLine(b);
        }

        static void StudentGrades(int[] grades)
        {
            grades[0] += 3;
            grades[1] += 5;
            grades[2] += 1;
        }
        static double ConvertTemperature(double temperatureF)
        {
            double temperatureC = (temperatureF - 32 * 5 / 9);
            return temperatureC;
        }

        static int MultipleReturns(int h, int l)
        {
            if (h < l)
            {
                return 1;
            }
            else if (h == l)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        static void PrintPositiveNumber (int number)
        {
            if (number <= 0)
            {
                return;
            }
            Console.WriteLine(number);
        }

        static void DefaultParameters(int x, int y = 10, int z = 15)  // =10 and =15 are optional parameters
        {
            int answer = x * y * z;
            Console.WriteLine(answer);
            Console.WriteLine(x * z);
            Console.WriteLine(y * z);
        }

        static void OverloadingMethod(int x, int y)
        {
            int ans = x + y;
            return;
        }
        static void OverloadingMethod(double x, double y)
        {
            double ans = x + y;
            return;
        }

        static void OverloadingMethod(int x)
        {
            int ans = x + x;
            return;
        }
    }
}
