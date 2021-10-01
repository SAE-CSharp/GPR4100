using System;

namespace Operator2
{
    class Program

    {
        enum metal { Zinc = 100, Magnesium = 200, Gold = 500, Copper = 10 }
        static void Main(string[] args)
        {
            bool materialChecked = false;
            Console.WriteLine("Welcome to the marketplace \n Select your material");
            Console.WriteLine("and your quantity");
            string matOfChoice = Console.ReadLine();
            int quantity = Int32.Parse(Console.ReadLine());

            if (!materialChecked)
            {
                if (matOfChoice == "Zinc")
                {
                    Console.WriteLine("my offer is $" + (int)metal.Zinc * quantity + "for your metal");
                }
                else if (matOfChoice == "Gold")
                {
                    Console.WriteLine("My offer is $" + (int)metal.Gold * quantity + "for your metal");
                }
                else if (matOfChoice == "Copper")
                {
                    Console.WriteLine("my offer is $" + (int)metal.Copper * quantity + "for your metal");
                }
                else if (matOfChoice == "Magnesium")

                {
                    Console.WriteLine("my offer is $" + (int)metal.Magnesium * quantity + "for your metal");
                }
            }
            
        }
    }
}
