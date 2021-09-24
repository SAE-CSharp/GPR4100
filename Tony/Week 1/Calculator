using System;

namespace Calc
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int firstNum;
            int seconum;
            char finalA;


            Console.WriteLine("Please input your first numer:");
            firstNum = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Your first number is " + firstNum);
            Console.WriteLine("Please enter your second number:");
            seconum = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Your second number is " + seconum);
            Console.WriteLine("Please choose either +,-,*,/");
            finalA = char.Parse(Console.ReadLine());

            if (finalA == '+')
            {
                Console.WriteLine("the result of "+firstNum+ "+"+seconum+" is "+ (firstNum +seconum));
            }
            else if (finalA == '-')
            {
                Console.WriteLine("the result of " + firstNum + "-" + seconum + "  is " + (firstNum - seconum));
            }
            else if (finalA == '*')
            {
                Console.WriteLine("the result of " + firstNum + "*" + seconum + " is " + (firstNum * seconum));
            }
            else if (finalA == '/')
            {
                Console.WriteLine("the result of " + firstNum + "/" + seconum + "is " + (firstNum / seconum));
            }
            
            else
            {
                Console.WriteLine("Incorrect operation");
            }
