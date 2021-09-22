using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = "Alex";
            String student = studentName;

            Console.WriteLine("I\'m " + studentName + " and I\'m Studying games programing at SAE");
            Console.WriteLine("I\'m studying the \"GPR4100\" course");
            Console.WriteLine("I\'m using the following folder C:\\ User \\ Admin \\ Alex ");

            int hoursPlayed;
            hoursPlayed = 3000;

            String Genre = "open world";
            float distance = 0.5f;
            String Accomodation = "Moorfield student flats";


            Console.WriteLine("I\'m studying at SAE institute which is only " + distance + " miles away from" + Accomodation);
            Console.WriteLine("My favorite game genre is " + Genre + " games as I enjoy the freedom to do what ever you want, I have over" + hoursPlayed + " hours played in this genre");

        }
    }
}
