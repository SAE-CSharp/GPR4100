using System;

namespace operator2
{
    class Program
    {
        enum metal { Zinc=100, Magnesium=200, Gold=500, Copper=10}

        static void Main(string[] args)
        {

            bool materialchecked = false;
            Console.WriteLine("welcome to the marketplace \n select your meterial");
            Console.WriteLine("and your quantity");
            string matOfchoice = Console.ReadLine();
            int quantity = Int32.Parse(Console.ReadLine());


            if (!materialchecked) 
            {
                if (matOfchoice == "Zinc")
                {
                    Console.WriteLine("my offer is $" + (int)metal.Zinc * quantity + "for your metal");
                }
                else if (matOfchoice == "Gold")
                {
                    Console.WriteLine("my offer is $" + (int)metal.Gold * quantity + "for your metal");
                }
                else if (matOfchoice == "Magnesium")
                {
                    Console.WriteLine("my offer is $" + (int)metal.Magnesium * quantity + "for your metal");
                }
                else if (matOfchoice == "Copper")
                {
                    Console.WriteLine("my offer is $" + (int)metal.Copper * quantity + "for your metal");

                }
                else
                {
                    Console.WriteLine("you have to choose a metal");
                }


            }


        }


    }


}
