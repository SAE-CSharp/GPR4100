using System;

namespace Test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World #1");
            Console.WriteLine("Hello World #2");
       /*     int Age; //Declaring a variable */
/*
            Age = 30; //Assigning a value to the variable

            String StudentName; //Declaring a new variable
            StudentName = "Tom"; //Assigning value to the variable (The String)

            String Student = "Aaron"; //Another way to declare a variable whilst assigning a value in one line rather than two.*/

            Console.WriteLine("****************************************************************************************************");


            int V1, V2, Sum;

                V1 = 10;
                V2 = 30;
                Sum = V1 + V2;

            Console.WriteLine(Sum);

            Console.WriteLine("****************************************************************************************************");

            int E1, E2, E3, E4, Sum2;

            E1 = 10;
            E2 = 30;
            E3 = 60;
            E4 = 100;
            Sum2 = E4 - E2 + E3 / E1;
            Console.WriteLine(Sum2);

            Console.WriteLine("****************************************************************************************************");

            String FirstSen;
            FirstSen = "This Sentence";
            String SecondSen;
            SecondSen = " Was done using";
            String ThirdSen;
            ThirdSen = " Three Strings";
            String CompleteSen;
            CompleteSen = FirstSen + SecondSen + ThirdSen;
            Console.WriteLine(CompleteSen);

            Console.WriteLine("****************************************************************************************************");

            String Name;
            Name = "Thomas is";
            String StuAge;
            StuAge = " 18";
            String Sen3;
            Sen3 = " he has really liked the name Tom";
            String Sen4;
            Sen4 = " but he doesnt like being 18";
            String Finish;
            Finish = Name + StuAge + Sen3 + Sen4;

            Console.WriteLine(Finish);
        }
    }
}
