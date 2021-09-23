using System;

namespace excercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
/*            string Name = "";
            Console.WriteLine("Enter your name");
            Name = Console.ReadLine();
            Console.WriteLine("wow, your parents had no imagination did they, " + Name + "?\ndon\'t you want to change it?");
            Name = Console.ReadLine();
            Console.WriteLine("Well, " + Name + ", how old are you?");
            int Age = Int32.Parse(Console.ReadLine()); // Int32 refers to the integer data type the 32 means 32 bit
            Console.WriteLine("Wow, " + Age + ", and you dont think thats kind of old?");
            Console.WriteLine("how far away do you live?");
            float Distance = float.Parse(Console.ReadLine());
            Console.WriteLine(Distance + " what? " + Distance + " miles or kilometers?");
            Console.WriteLine("What was the first letter of your name again ?");
            char Name1 = char.Parse(Console.ReadLine());
            Console.WriteLine(Name1 + "?, what kind of name starts with a " + Name1 + "?");

            Console.WriteLine("******************************");

            float exercise, diet, PlayerAge, DeathTime;
            Console.WriteLine("how many hours a week do you spend exercising?");
            exercise = float.Parse(Console.ReadLine());
            Console.WriteLine("How many vegetables and fruits do you eat a day");
            diet = float.Parse(Console.ReadLine());
            Console.WriteLine("How old are you?");
            PlayerAge = float.Parse(Console.ReadLine());
            DeathTime = PlayerAge * (exercise / diet);
            Console.WriteLine("you have "+DeathTime+" years to live");
*/
            Console.WriteLine("*****************************************************");

            int PlayerStep = 8, EnemyStep = 7;
            PlayerStep++;
            string Player_Class;

            Console.WriteLine(PlayerStep);
            EnemyStep += 1;
            Console.WriteLine(EnemyStep);
            if (PlayerStep > 10)
            {
                Console.WriteLine("You move one step");
            }
            else
            {
                Console.WriteLine("you cheated to see this");
            }
            Console.WriteLine("Do you want to be a Knight or Archer");
            Player_Class = Console.ReadLine();
            if (Player_Class == "Knight")
            {
                Console.WriteLine("You are a Knight...that is all");
            }
            else if (Player_Class == "Archer")
            {
                Console.WriteLine("so you're a legolas wannabe");
            }
            else
            {
                Console.WriteLine("Wow, so cool that you don't conform");
            }
            Console.WriteLine("Enter the player speed");
            int Player_Spd = Int32.Parse(Console.ReadLine());

            if (Player_Spd == 10)
            {
                Console.WriteLine("The player speed is "+Player_Spd);
            }
            else if (Player_Spd == 30)
            {
                Console.WriteLine("The player speed is " + Player_Spd);
            }
            else
            {
                Console.WriteLine("that is an invalid speed");
            }

        }   
    }
}
