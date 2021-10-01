using System;

namespace Colour
{
    class Program
    {
        enum Metal { Zinc= 100, Magnesium = 200, Gold = 300, Copper= 5}
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your favarote colours: \n 1.Red \n 2.Blue \n 3.Purple \n 4. Green");
            int colours = Int32.Parse(Console.ReadLine());
            if (colours == 1 || colours == 2)
            {
                Console.WriteLine("Wow that is a great color");
            }
            else
            {
                Console.WriteLine("Still cool but not my fav");
            }
            Console.WriteLine("============================================================");

            bool mateiralcheck = false;
            Console.WriteLine("Welcome to the Marketplace :) \n Select your Material");
            Console.WriteLine("and your amount");
            string matofch = Console.ReadLine();
            int qauntity = Int32.Parse(Console.ReadLine());

            if (!mateiralcheck)
            {
                if (matofch == "Zinc")
                {
                    Console.WriteLine("My offer is " + (int)Metal.Zinc * qauntity + " Gold coins for your loot");

                }
                else if (matofch == "Gold")
                {
                    Console.WriteLine("My offer is " + (int)Metal.Gold * qauntity + " Gold coins for your loot");
                }
                else if (matofch == "Magnesium")
                {
                    Console.WriteLine("My offer is " + (int)Metal.Magnesium * qauntity + " Gold coins for your loot");
                }
                else if (matofch == "Copper")
                {
                    Console.WriteLine("My offer is " + (int)Metal.Copper * qauntity + " Gold coins for your loot");
                }
                else
                {
                    Console.WriteLine("I cannot take this at this moment. Come back another time!");
                }
            
            }
            else
            {
                Console.WriteLine("Please enter a material!");
            }
        
        }
    }


}
