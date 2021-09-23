using System;

namespace exe2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName;
            Console.WriteLine("Enter your full");
            fullName = Console.ReadLine();
            Console.WriteLine("your name is"+fullName);
            Console.WriteLine("Are you sure you want to use this name?"+fullName+ "Why don\'t use another one");
            fullName = Console.ReadLine();
            Console.WriteLine("How old are you?");
            int Age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Your Age is: "+Age);
            Console.WriteLine("How far is yourhome from the city ");
            float distance = float.Parse(Console.ReadLine());
            Console.WriteLine("the distance is: "+distance);
           
            Console.WriteLine("*********************************");
            //int exeT, diet, PlayerAge, DeathYears;
            int PlayerSteps = 10;
            int enemySteps = 10;
            PlayerSteps++;
            enemySteps++;
            PlayerSteps += 1;
            enemySteps += 1;

          
        }
    }
}
