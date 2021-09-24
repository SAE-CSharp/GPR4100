using System;

namespace ConsoleAppStory_MCarpenter
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = "Morgan";
            int studentAge = 21;
            string studentUni = "SAE London";
            string studentLocation = "Bicester";
            float studentDistance = 52.3f;
            
            Console.WriteLine("My name is "+studentName+"."); // Name
            Console.WriteLine("I\'m "+studentAge+" years old, and I am a student at "+studentUni+"."); // Age + University
            Console.WriteLine("I live in "+studentLocation+",\nwhich is "+studentDistance+" miles away from my university.\n"); // Location + Distance to uni

            string filePath = "C:\\Users\\Admin\\Documents"

            Console.WriteLine("Example filepath: "+filePath);
        }
    }
}
