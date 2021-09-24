using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersice4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            Console.WriteLine("Please Type a Number");
            x = Int32.Parse(Console.ReadLine());

            if(x > 10)
            {
                Console.WriteLine("x is greater than 10");
            }
            else
            {
                Console.WriteLine("x is less than 10");
            }

            int playerSpeed;

            Console.WriteLine("Please Type a Player Speed");
            playerSpeed = Int32.Parse(Console.ReadLine());
            if(playerSpeed == 10)
            {
                Console.WriteLine("The Player Speed has been set to 10");
            }
            else if(playerSpeed == 20)
            {
                Console.WriteLine("The Player Speed has been set to 20");
            }
            else if (playerSpeed == 30)
            {
                Console.WriteLine("The Player Speed has been set to 30");
            }
            else
            {
                Console.WriteLine("Invalid Number, 10-20-30");
            }

        }
    }
}
