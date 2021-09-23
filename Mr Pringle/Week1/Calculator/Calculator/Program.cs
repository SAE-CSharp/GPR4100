using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            float firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the type of calculation youd like to do.");
            string cal = Console.ReadLine();
            Console.WriteLine("Enter the second number");
            float secNum = Convert.ToInt32(Console.ReadLine());

            if (cal == "*")
            {
                float timesAns = firstNum * secNum;
                Console.WriteLine("The Answer is " + timesAns);
            }
            else if (cal == "/")
            {
                float devideAns = firstNum / secNum;
                Console.WriteLine("The Answer is " + devideAns);
            }
            else if (cal == "+")
            {
                float addAns = firstNum + secNum;
                Console.WriteLine("The Answer is " + addAns);
            }
            else if (cal == "-")
            {
                float minusAns = firstNum - secNum;
                Console.WriteLine("The Answer is " + minusAns);
            }
            else if (cal == "%")
            {
                float perAns = firstNum % secNum;
                Console.WriteLine("The Answer is " + perAns);
            }
            else
            {
                Console.WriteLine("Error 404:\nUsers Brain not found");
            }
            
            Console.ReadLine();
        }
    }
}
