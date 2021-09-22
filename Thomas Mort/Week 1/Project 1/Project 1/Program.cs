using System;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Age;
            Age = 18;

            float Distance;
            Distance = 100.5f;

            char ch = 'T';

            string FullSentence;
            FullSentence = ("Tom is\t"+ Age +"\nAnd he has walked\t"+ Distance +" miles today.\n His name begins with "+ch);
            Console.WriteLine(FullSentence);
        }
    }
}
