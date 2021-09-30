using System;

namespace Week3_TextAdventure
{
    class Program
    {
        enum Direction { FOREST = 'n', RIVER = 's', VOLCANO = 'e', TOWN = 'w' };
        enum Actions { CAMP = 'c', EAT = 'e', HUNT = 'h', SPECIAL = 's' };
        static void Main(string[] args)
        {
            bool Alive = true;
            char Action;
            int Score = 0;
            while (Alive == true)
            {
                Console.WriteLine("Hello...This is a text adventure\n\n\nby me...have fun");
                Console.WriteLine("you are at a crossroads, where do you go?\nType e to go east\nType w to go west\nType n to go north\nType s to go south");
                char Travel = char.Parse(Console.ReadLine());

                switch (Travel)
                {
                    case (char)Direction.FOREST:
                        Console.WriteLine("You head north, deeper into the thicket and get lost in the forest");
                        Console.WriteLine("What do you do?\nPress c to camp\nPress e to eat\nPress h to hunt\npress s to do a special action...wonder what that\'ll do");
                        Action = char.Parse(Console.ReadLine());
                        if (Action == (char)Actions.CAMP || Action == (char)Actions.SPECIAL)
                        {
                            Console.WriteLine("you camp...wasnt relly much need for that...");
                            Console.WriteLine("you are mauled to death by wolves....");
                            Alive = false;
                        }
                        if (Action == (char)Actions.EAT)
                        {
                            Console.WriteLine("you have no food...\n\nyou die of starvation");
                            Alive = false;
                        }
                        if (Action == (char)Actions.HUNT)
                        {
                            Console.WriteLine("you manage to hunt a deer\n...\n...");
                            Console.WriteLine("you dont know how to skin an animal or butcher one\n you are mauled to death by a wolf");
                            Alive = false;
                        }
                        break;

                    case (char)Direction.RIVER:
                        Console.WriteLine("after hours of walking south you chance upon a river..Its nice");
                        Console.WriteLine("What do you do?\nPress c to camp\nPress e to eat\nPress h to hunt\npress s to do a special action...wonder what that\'ll do");
                        Action = char.Parse(Console.ReadLine());
                        if (Action == (char)Actions.CAMP)
                        {
                            Console.WriteLine("you camp...wasnt relly much need for that...");
                            Console.WriteLine("yoou roll over iin your sleep and fall into the river\nyou drown shortly after");
                            Alive = false;
                        }
                        if (Action == (char)Actions.HUNT)
                        {
                            Console.WriteLine("You see a bear and instead if hiding decide to hunt it\n\nit mauls you to death...because it\'s a bear");
                            Alive = false;
                        }
                        break;

                    case (char)Direction.VOLCANO:
                        Console.WriteLine("you head east and find a volcano...what even is this biosphere?");
                        Console.WriteLine("What do you do?\nPress c to camp\nPress e to eat\nPress h to hunt\npress s to do a special action...wonder what that\'ll do");
                        Action = char.Parse(Console.ReadLine());
                        if (Action == (char)Actions.CAMP)
                        {
                            Console.WriteLine("you camp...wasnt relly much need for that...");
                        }
                        else if (Action == (char)Actions.SPECIAL)
                        {
                            Console.WriteLine("For some unknown reason you decidee to jump into the volcano...\nI have no idea why but you do\n\nBut! you wake up...anticlimactic, huh?");
                            Score += 1;
                            Alive = false;
                        }
                        break;

                    case (char)Direction.TOWN:
                        Console.WriteLine("you head west and after some time you find a Town...why is a town so close to a volcano...spoilers");
                        Console.WriteLine("What do you do?\nPress c to camp\nPress e to eat\nPress h to hunt\npress s to do a special action...wonder what that\'ll do");
                        Action = char.Parse(Console.ReadLine());
                        if (Action == (char)Actions.CAMP)
                        {
                            Console.WriteLine("you camp...wasnt relly much need for that...");
                            Console.WriteLine("though you do get stabbed furing the nighjt and bleed out...");
                            Alive = false;
                        }
                        break;

                    default:
                        Console.WriteLine("there are only four directions...shut up about bearings you aren\'t in the military and you\'re not cool");
                        break;
                }
                if (Score == 1)
                {
                    Console.WriteLine("you did it...weird ending right, I guess not");
                }
                else
                {
                    Console.WriteLine("you are dead...That is all");
                }
            }
        }
    }
}
