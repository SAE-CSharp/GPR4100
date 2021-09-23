using System;

namespace if_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose PLayer Speed 10 or 30");
            int playerStep = Convert.ToInt32(Console.ReadLine());
            int enemyStep = 10;
            if (playerStep == 10)
            {
                Console.WriteLine("Value of Player Speed is 10");
            }
            else if (playerStep == 30)
            {
                Console.WriteLine("Value of Player Speeed is 30");
            }
            else
            {
                Console.WriteLine("That's not 10 or 30");
            }


          * playerStep--;
            enemyStep++;
            playerStep += 1;
            enemyStep += 1;
            Console.WriteLine("Current PLayer Step Speed = " + playerStep + "\nThe Currrent Enemy Step Speed = " + enemyStep);

            if (playerStep==10)
            {
                Console.WriteLine("Player Speed up");
                playerStep++;
            }
            else { enemyStep++; Console.WriteLine("Enemy Speed up"); }
            Console.WriteLine("Current PLayer Step Speed = " + playerStep + "\nThe Currrent Enemy Step Speed = " + enemyStep);




            // this does work but is just practice!!!!!!!!!!!!*
            Console.WriteLine("enter a number");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x < 10)
            {
                Console.WriteLine("X is smaller than 10");
                Console.WriteLine("enter a second number");
                int y = Convert.ToInt32(Console.ReadLine());
                if (y < 10)
                { Console.WriteLine("Y is smaller than 10"); }
                else if (y == 10)
                { Console.WriteLine("Y is 10"); }
                else { Console.WriteLine("Y is more than 10"); }
            }
            else if (x == 10)
            { Console.WriteLine("X is 10"); }
            else
            { Console.WriteLine("X is larger than 10"); }


        }
    }
}
