using System;

namespace Formatted_outputs
{
    class Program
    {
        //-----Method Oveerloading------------

        static void DrawInt(int x, int y)
        {
            //Draw integer
            int ans = x + y;
        }

        static void DrawInt(double x, double y)
        {
            //Draw integer
            double ans = x + y;
        }
        static void DrawInt(double x)
        {
            //Draw integer
            double ans = x;
        }

        static void Main(string[] args)
        {
            //-----------------------------------------------------------
            //formatted outputs
            string str = "Hello World";
            string str2 = "Hey world";
            //standard print statement
            Console.WriteLine(str);
            //Formmatted string print statement
            Console.Write("{0} {1}", str, str2);

            string name = "Brandon"; 
            int age = 18;
            Console.WriteLine("My name is {0}, I am {1}", name, age);
        }
    }
}
