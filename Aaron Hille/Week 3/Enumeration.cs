using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration1
{
    class Program
    {

        enum months { Jan, Feb, Mar, Apr };
        static void Main(string[] args)
        {

            Console.WriteLine("What month would you like to chose? \n1 or A =  Jan. \n2 or B = Feb. \n3 or C Mar. \n4 or D Apr.");

            char monthPos = Convert.ToChar(Console.ReadLine());

            if (monthPos == 'A' || monthPos == '1')
            {
                Console.WriteLine("The month you have selected is " + (months.Jan));
            }

            else if (monthPos == 'B' || monthPos == '2')
            {
                Console.WriteLine("The month you have selected is " + (months.Feb));
            }

            else if (monthPos == 'C' || monthPos == '3')
            {
                Console.WriteLine("The month you have selected is " + (months.Mar));
            }

            else if (monthPos == 'D' || monthPos == '4')
            {
                Console.WriteLine("The month you have selected is " + (months.Apr));
            }


            Console.ReadLine(); //MUST have this at the bottom of EVERY program.
        }
    }
}

