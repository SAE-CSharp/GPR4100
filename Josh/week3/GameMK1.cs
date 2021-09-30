using System;

namespace _1st_game
{
    class Program
    {

        enum level { easy=1, medium=3, hard=5}
        enum character { knight, archer, assassin, thief}
        enum weapons { crossbow, longbow, sword, mace, poison, dagger, katana, throwing_stars}


        static void Main(string[] args)
        {
            bool mainLoop = true, checkLoop = true;
            string userInput = "", playersCharacter, playersWeapon;


            int difficultyMultiplier, attackSpeed, shortRange_Multi, longRange_Multi, damage;



            while (mainLoop)
            {
                switch (userInput)
                {
                    case "A":
                        Console.WriteLine("You have selected easy\n");
                        difficultyMultiplier = (int)level.easy;
                        break;
                    case "B":
                        Console.WriteLine("You have selected medium\n");
                        difficultyMultiplier = (int)level.medium;
                        break;
                    case "C":
                        Console.WriteLine("You have selected hard\n");
                        difficultyMultiplier = (int)level.hard;
                        break;
                }

                Console.WriteLine("Welcome to me game!\nWhat difficulty level would you like to play. Your selection will effect the strength and quantity of your enemies.:\n(A)Easy\t(B)Medium\t(C)Hard");
                userInput = (Console.ReadLine()).ToUpper();



                Console.WriteLine("What type of player will you be? Your choice will effect the how affective your combat is at different ranges.\n((A)knight\t(B)archer\t(C)assissin\t(D)ninja");
                userInput= Console.ReadLine().ToUpper();

                switch (userInput)
                {
                    case "A":
                        playersCharacter = ("Knight");
                        damage = 1;                                                     //change
                        longRange_Multi = 1;                                            //change
                        shortRange_Multi = 1;                                           //Change

                        Console.Write("What weapon would you like? (A)sword\t(B)mace\nThis will effect your strength, range and attack speed.");
                        userInput = Console.ReadLine().ToUpper();

                        if (userInput == "A" || userInput == "SWORD")
                        {
                            playersWeapon = "Sword";
                            attackSpeed = 1;                                            //change
                        }
                        else if (userInput == "B" || userInput == "MACE")
                        {
                            playersWeapon = "Mace";
                            attackSpeed = 1;                                            //change
                        }

                        break;

                    case "B":
                        playersCharacter = "Archer";
                        damage = 1;                                                     //change
                        longRange_Multi = 1;                                            //change
                        shortRange_Multi = 1;                                           //Change

                        Console.Write("What weapon would you like? (A)LongBow\t(B)Crossbow\nThis will effect your strength, range and attack speed.");
                        userInput = Console.ReadLine().ToUpper();

                        if (userInput == "A" || userInput == "LONGBOW")
                        {
                            playersWeapon = "LongBow";
                            attackSpeed = 1;                                            //change

                        }
                        else if (userInput == "B" || userInput == "CROSSBOW")
                        {
                            playersWeapon = "CrossBow";
                            attackSpeed = 1;                                            //change
                        }

                        break;


                    case "C":
                        playersCharacter = "Assissin";
                        damage = 1;                                                     //change
                        longRange_Multi = 1;                                            //change
                        shortRange_Multi = 1;                                           //Change

                        Console.Write("What weapon would you like? (A)Poison\t(B)Dagger\nThis will effect your strength, range and attack speed.");
                        userInput = Console.ReadLine().ToUpper();

                        if (userInput == "A" || userInput == "POISON")
                        {
                            playersWeapon = "Poison";
                            attackSpeed = 1;                                            //change

                        }
                        else if (userInput == "B" || userInput == "DAGGER")
                        {
                            playersWeapon = "Dagger";
                            attackSpeed = 1;                                            //change
                        }

                        break;

                    case "D":
                        playersCharacter = "Ninja";
                        damage = 1;                                                     //change
                        longRange_Multi = 1;                                            //change
                        shortRange_Multi = 1;                                           //Change

                        Console.Write("What weapon would you like? (A)Katana\t(B)Throwing Stars\nThis will effect your strength, range and attack speed.");
                        userInput = Console.ReadLine().ToUpper();

                        if (userInput == "A" || userInput == "KATANA")
                        {
                            playersWeapon = "Katana";
                            attackSpeed = 1;                                            //change

                        }
                        else if (userInput == "B" || userInput == "THROWING STARS")
                        {
                            playersWeapon = "Throwing Stars";
                            attackSpeed = 1;                                            //change
                        }

                        break;

                    default:
                        Console.WriteLine("Character unavailable!");
                        break;

                }



               






                Console.WriteLine("Would you like to go again? (Y/N)");
                userInput = Console.ReadLine().ToUpper();


                if (userInput == "N" || userInput == "NO")
                {
                    mainLoop = false;
                    break;
                }
                else
                {
                    Console.WriteLine("\n");
                }

            }

        }

    }
}
