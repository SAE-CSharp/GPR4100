
using System;

namespace w3_task_5_1
{
    class Program
    {
        enum diff { Easy=1, Medium=2, Hard=3};
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the wacky wondful world of\n...well i can't remember what its called, but welcome!\nPlease choose a number from 1 to 3.");
            int numChoice = Convert.ToInt32(Console.ReadLine());
            int fatiuge = 10;


            switch (numChoice)
            {
                case (int)diff.Easy:
                    Console.WriteLine("Perfect a nice and easy route lays ahead\nI'm awfully glad you didnt choose the dark bramble filled road.\n\n" +
                        "Would you like to \n1. Walk\n2. Jog\n3. Run\nWe're on the safeest route so it just about how fast you want to end the journey in this world.\n" +
                        "Ptss you're fatiuge is currently "+fatiuge);
                    int easySpeedChoice = Convert.ToInt32(Console.ReadLine());
                    if (easySpeedChoice == 1)
                    {
                        fatiuge -= 1;
                        Console.WriteLine("A nice stroll down a well paved and maintained road await us, it may be long but it will be plesant." +
                            "\nWould you like to speed up or not? The choice remains the same as last time.");
                        int easySpeedChoice2 = Convert.ToInt32(Console.ReadLine());
                        if (easySpeedChoice2 == 1)
                        {
                            fatiuge -= 1;
                            Console.WriteLine("As our stroll continues we wont encounter any danger thanks to the regular patrols by the knight core.\n" +
                                "We should make it to the end of our journey by nightfall, ths is our last chance to change speed\nSame as last time 1 to 3");
                            int easySpeedChoice3 = Convert.ToInt32(Console.ReadLine());
                            if (easySpeedChoice3 == 1)
                            {
                                fatiuge -= 1;
                                Console.WriteLine("We've made it to the end of the road, woudl you like to rest? Y/N");
                                string restChoice = Console.ReadLine();
                                if (restChoice == "Y") 
                                {
                                    fatiuge = 10;
                                    Console.WriteLine("Wise choice my friend your fatiuge is now at " + fatiuge + "\nFully ressted i see.");
                                }
                                else if (restChoice == "N")
                                {
                                    Console.WriteLine("Your current fatigue points rest at " + fatiuge + " thats okay i guess");
                                }
                                else
                                {
                                    Console.WriteLine("That wasn't and option, please understand we have no room for creative freedom");
                                }
                            }
                            else if (easySpeedChoice3 == 2)
                            {
                                fatiuge -= 2;
                                Console.WriteLine("We've made it to the end of the road, woudl you like to rest? Y/N");
                                string restChoice = Console.ReadLine();
                                if (restChoice == "Y")
                                {
                                    fatiuge = 10;
                                    Console.WriteLine("Wise choice my friend your fatiuge is now at " + fatiuge + "\nFully ressted i see.");
                                }
                                else if (restChoice == "N")
                                {
                                    Console.WriteLine("Your current fatigue points rest at " + fatiuge + " thats okay i guess");
                                }
                                else
                                {
                                    Console.WriteLine("That wasn't and option, please understand we have no room for creative freedom");
                                }
                            }
                            else if (easySpeedChoice3 == 3)
                            {
                                fatiuge -= 3;
                                Console.WriteLine("We've made it to the end of the road, woudl you like to rest? Y/N");
                                string restChoice = Console.ReadLine();
                                if (restChoice == "Y")
                                {
                                    fatiuge = 10;
                                    Console.WriteLine("Wise choice my friend your fatiuge is now at " + fatiuge + "\nFully ressted i see.");
                                }
                                else if (restChoice == "N")
                                {
                                    Console.WriteLine("Your current fatigue points rest at " + fatiuge + " thats okay i guess");
                                }
                                else
                                {
                                    Console.WriteLine("That wasn't and option, please understand we have no room for creative freedom");
                                }
                            }
                            else
                            {
                                Console.WriteLine("That wasn't and option, please understand we have no room for creative freedom");
                            }

                        }
                        else if (easySpeedChoice2 == 2)
                        {
                            fatiuge -= 2;
                            Console.WriteLine("We've made it to the end of the road, woudl you like to rest? Y/N");
                            string restChoice = Console.ReadLine();
                            if (restChoice == "Y")
                            {
                                fatiuge = 10;
                                Console.WriteLine("Wise choice my friend your fatiuge is now at " + fatiuge + "\nFully ressted i see.");
                            }
                            else if (restChoice == "N")
                            {
                                Console.WriteLine("Your current fatigue points rest at " + fatiuge + " thats okay i guess");
                            }
                            else
                            {
                                Console.WriteLine("That wasn't and option, please understand we have no room for creative freedom");
                            }
                        }
                        else if (easySpeedChoice2 == 3)
                        {
                            fatiuge -= 3;
                            Console.WriteLine("We've made it to the end of the road, woudl you like to rest? Y/N");
                            string restChoice = Console.ReadLine();
                            if (restChoice == "Y")
                            {
                                fatiuge = 10;
                                Console.WriteLine("Wise choice my friend your fatiuge is now at " + fatiuge + "\nFully ressted i see.");
                            }
                            else if (restChoice == "N")
                            {
                                Console.WriteLine("Your current fatigue points rest at " + fatiuge + " thats okay i guess");
                            }
                            else
                            {
                                Console.WriteLine("That wasn't and option, please understand we have no room for creative freedom");
                            }
                        }
                        else
                        {
                            Console.WriteLine("That wasn't and option, please understand we have no room for creative freedom");
                        }
                    }
                    else if (easySpeedChoice == 2)
                    {
                        fatiuge -= 6;
                        Console.WriteLine("We're almost there jsut a little more to go, would you like to change speed?\nOnce again its 1 to 3");
                        int medSpeedChoice = Convert.ToInt32(Console.ReadLine());
                        if (medSpeedChoice == 1)
                        {
                            fatiuge -= 1;
                            Console.WriteLine("We are just one turn away from making it to the end.\nUnfortunatly we're too close to speed up.\nPress enter to finsh the jorney");
                            Console.ReadLine();
                            fatiuge -= 1;
                            Console.WriteLine("We've made it to the end of the road, woudl you like to rest? Y/N");
                            string restChoice = Console.ReadLine();
                            if (restChoice == "Y")
                            {
                                fatiuge = 10;
                                Console.WriteLine("Wise choice my friend your fatiuge is now at " + fatiuge + "\nFully ressted i see.");
                            }
                            else if (restChoice == "N")
                            {
                                Console.WriteLine("Your current fatigue points rest at " + fatiuge + " thats okay i guess");
                            }
                            else
                            {
                                Console.WriteLine("That wasn't and option, please understand we have no room for creative freedom");
                            }
                        }
                        else if ( medSpeedChoice == 2)
                        {
                            fatiuge -= 2;
                            Console.WriteLine("We've made it to the end of the road, woudl you like to rest? Y/N");
                            string restChoice = Console.ReadLine();
                            if (restChoice == "Y")
                            {
                                fatiuge = 10;
                                Console.WriteLine("Wise choice my friend your fatiuge is now at " + fatiuge + "\nFully ressted i see.");
                            }
                            else if (restChoice == "N")
                            {
                                Console.WriteLine("Your current fatigue points rest at " + fatiuge + " thats okay i guess");
                            }
                            else
                            {
                                Console.WriteLine("That wasn't and option, please understand we have no room for creative freedom");
                            }
                        }
                        else if (medSpeedChoice == 3)
                        {
                            fatiuge -= 3;
                            Console.WriteLine("We've made it to the end of the road, woudl you like to rest? Y/N");
                            string restChoice = Console.ReadLine();
                            if (restChoice == "Y")
                            {
                                fatiuge = 10;
                                Console.WriteLine("Wise choice my friend your fatiuge is now at " + fatiuge + "\nFully ressted i see.");
                            }
                            else if (restChoice == "N")
                            {
                                Console.WriteLine("Your current fatigue points rest at " + fatiuge + " thats okay i guess");
                            }
                            else
                            {
                                Console.WriteLine("That wasn't and option, please understand we have no room for creative freedom");
                            }
                        }
                        else
                        {
                            Console.WriteLine("That wasn't and option, please understand we have no room for creative freedom");
                        }
                    }
                    else if (easySpeedChoice == 3)
                    {
                        fatiuge -= 9;
                        Console.WriteLine("We'll make it there in no time but it will be a tireing adventure, you best rest when we reach the end of the road.");
                        Console.WriteLine("Press the Enter Key and you'll sprint to the end of the road");
                        Console.ReadLine();
                        Console.WriteLine("We've made it to the end of the road, woudl you like to rest? Y/N");
                        string restChoice = Console.ReadLine();
                        if (restChoice == "Y")
                        {
                            fatiuge = 10;
                            Console.WriteLine("Wise choice my friend your fatiuge is now at " + fatiuge + "\nFully ressted i see.");
                        }
                        else if (restChoice == "N")
                        {
                            Console.WriteLine("Your current fatigue points rest at " + fatiuge + " thats okay i guess");
                        }
                        else
                        {
                            Console.WriteLine("That wasn't and option, please understand we have no room for creative freedom");
                        }
                    }
                    else
                    {
                        Console.WriteLine("That wasn't and option, please understand we have no room for creative freedom!");
                    }


                    break;
                case (int)diff.Medium:
                    Console.WriteLine("Goody not too hard and not too easy a brilliant middle ground." +
                         "Would you like to \n1. Walk\n2. Jog\n3. Run\nWe're on the safeest route so it just about how fast you want to end the journey in this world.\n" +
                         "Ptss you're fatiuge is currently " + fatiuge);
                    int easySpeedChoice4 = Convert.ToInt32(Console.ReadLine());
                    if (easySpeedChoice4 == 1)
                    {
                        fatiuge -= 2;
                        Console.WriteLine("A nice stroll down a well paved and maintained road await us, it may be long but it will be plesant." +
                            "\nWould you like to speed up or not? The choice remains the same as last time.");
                        int easySpeedChoice5 = Convert.ToInt32(Console.ReadLine());
                        if (easySpeedChoice5 == 1)
                        {
                            fatiuge -= 2;
                            Console.WriteLine("As our stroll continues we wont encounter any danger thanks to the regular patrols by the knight core.\n" +
                                "We should make it to the end of our journey by nightfall, ths is our last chance to change speed\nSame as last time 1 to 3");
                            int easySpeedChoice6 = Convert.ToInt32(Console.ReadLine());
                            if (easySpeedChoice6 == 1)
                            {
                                fatiuge -= 2;
                                Console.WriteLine("We've made it to the end of the road, woudl you like to rest? Y/N");
                                string restChoice1 = Console.ReadLine();
                                if (restChoice1 == "Y") 
                                {
                                    fatiuge = 10;
                                    Console.WriteLine("Wise choice my friend your fatiuge is now at " + fatiuge + "\nFully ressted i see.");
                                }
                                else if (restChoice1 == "N")
                                {
                                    Console.WriteLine("Your current fatigue points rest at " + fatiuge + " thats okay i guess");
                                }
                                else
                                {
                                    Console.WriteLine("That wasn't and option, please understand we have no room for creative freedom");
                                }
                            }
                            else if (easySpeedChoice6 == 2)
                            {
                                fatiuge -= 3;
                                Console.WriteLine("We've made it to the end of the road, woudl you like to rest? Y/N");
                                string restChoice1 = Console.ReadLine();
                                if (restChoice1 == "Y")
                                {
                                    fatiuge = 10;
                                    Console.WriteLine("Wise choice my friend your fatiuge is now at " + fatiuge + "\nFully ressted i see.");
                                }
                                else if (restChoice1 == "N")
                                {
                                    Console.WriteLine("Your current fatigue points rest at " + fatiuge + " thats okay i guess");
                                }
                                else
                                {
                                    Console.WriteLine("That wasn't and option, please understand we have no room for creative freedom");
                                }
                            }
                            else if (easySpeedChoice6 == 3)
                            {
                                fatiuge -= 4;
                                Console.WriteLine("We've made it to the end of the road, woudl you like to rest? Y/N");
                                string restChoice1 = Console.ReadLine();
                                if (restChoice1 == "Y")
                                {
                                    fatiuge = 10;
                                    Console.WriteLine("Wise choice my friend your fatiuge is now at " + fatiuge + "\nFully ressted i see.");
                                }
                                else if (restChoice1 == "N")
                                {
                                    Console.WriteLine("Your current fatigue points rest at " + fatiuge + " thats okay i guess");
                                }
                                else
                                {
                                    Console.WriteLine("That wasn't and option, please understand we have no room for creative freedom");
                                }
                            }
                            else
                            {
                                Console.WriteLine("That wasn't and option, please understand we have no room for creative freedom");
                            }

                        }
                        else if (easySpeedChoice5 == 2)
                        {
                            fatiuge -= 3;
                            Console.WriteLine("We've made it to the end of the road, woudl you like to rest? Y/N");
                            string restChoice1 = Console.ReadLine();
                            if (restChoice1 == "Y")
                            {
                                fatiuge = 10;
                                Console.WriteLine("Wise choice my friend your fatiuge is now at " + fatiuge + "\nFully ressted i see.");
                            }
                            else if (restChoice1 == "N")
                            {
                                Console.WriteLine("Your current fatigue points rest at " + fatiuge + " thats okay i guess");
                            }
                            else
                            {
                                Console.WriteLine("That wasn't and option, please understand we have no room for creative freedom");
                            }
                        }
                        else if (easySpeedChoice5 == 3)
                        {
                            fatiuge -= 3;
                            Console.WriteLine("We've made it to the end of the road, woudl you like to rest? Y/N");
                            string restChoice1 = Console.ReadLine();
                            if (restChoice1 == "Y")
                            {
                                fatiuge = 10;
                                Console.WriteLine("Wise choice my friend your fatiuge is now at " + fatiuge + "\nFully ressted i see.");
                            }
                            else if (restChoice1 == "N")
                            {
                                Console.WriteLine("Your current fatigue points rest at " + fatiuge + " thats okay i guess");
                            }
                            else
                            {
                                Console.WriteLine("That wasn't and option, please understand we have no room for creative freedom");
                            }
                        }
                        else
                        {
                            Console.WriteLine("That wasn't and option, please understand we have no room for creative freedom");
                        }
                    }
                    else if (easySpeedChoice4 == 2)
                    {
                        fatiuge -= 7;
                        Console.WriteLine("We're almost there jsut a little more to go, would you like to change speed?\nOnce again its 1 to 3");
                        int medSpeedChoice1 = Convert.ToInt32(Console.ReadLine());
                        if (medSpeedChoice1 == 1)
                        {
                            fatiuge -= 2;
                            Console.WriteLine("We are just one turn away from making it to the end.\nUnfortunatly we're too close to speed up.\nPress enter to finsh the jorney");
                            Console.ReadLine();
                            fatiuge -= 2;
                            Console.WriteLine("We've made it to the end of the road, woudl you like to rest? Y/N");
                            string restChoice1 = Console.ReadLine();
                            if (restChoice1 == "Y")
                            {
                                fatiuge = 10;
                                Console.WriteLine("Wise choice my friend your fatiuge is now at " + fatiuge + "\nFully ressted i see.");
                            }
                            else if (restChoice1 == "N")
                            {
                                Console.WriteLine("Your current fatigue points rest at " + fatiuge + " thats okay i guess");
                            }
                            else
                            {
                                Console.WriteLine("That wasn't and option, please understand we have no room for creative freedom");
                            }
                        }
                        else if ( medSpeedChoice1 == 2)
                        {
                            fatiuge -= 3;
                            Console.WriteLine("We've made it to the end of the road, woudl you like to rest? Y/N");
                            string restChoice1 = Console.ReadLine();
                            if (restChoice1 == "Y")
                            {
                                fatiuge = 10;
                                Console.WriteLine("Wise choice my friend your fatiuge is now at " + fatiuge + "\nFully ressted i see.");
                            }
                            else if (restChoice1 == "N")
                            {
                                Console.WriteLine("Your current fatigue points rest at " + fatiuge + " thats okay i guess");
                            }
                            else
                            {
                                Console.WriteLine("That wasn't and option, please understand we have no room for creative freedom");
                            }
                        }
                        else if (medSpeedChoice1 == 3)
                        {
                            fatiuge -= 4;
                            Console.WriteLine("We've made it to the end of the road, woudl you like to rest? Y/N");
                            string restChoice1 = Console.ReadLine();
                            if (restChoice1 == "Y")
                            {
                                fatiuge = 10;
                                Console.WriteLine("Wise choice my friend your fatiuge is now at " + fatiuge + "\nFully ressted i see.");
                            }
                            else if (restChoice1 == "N")
                            {
                                Console.WriteLine("Your current fatigue points rest at " + fatiuge + " thats okay i guess");
                            }
                            else
                            {
                                Console.WriteLine("That wasn't and option, please understand we have no room for creative freedom");
                            }
                        }
                        else
                        {
                            Console.WriteLine("That wasn't and option, please understand we have no room for creative freedom");
                        }
                    }
                    else if (easySpeedChoice4 == 3)
                    {
                        fatiuge -= 10;
                        Console.WriteLine("We'll make it there in no time but it will be a tireing adventure, you best rest when we reach the end of the road.");
                        Console.WriteLine("Press the Enter Key and you'll sprint to the end of the road");
                        Console.ReadLine();
                        Console.WriteLine("We've made it to the end of the road, woudl you like to rest? Y/N");
                        string restChoice1 = Console.ReadLine();
                        if (restChoice1 == "Y")
                        {
                            fatiuge = 10;
                            Console.WriteLine("Wise choice my friend your fatiuge is now at " + fatiuge + "\nFully ressted i see.");
                        }
                        else if (restChoice1 == "N")
                        {
                            Console.WriteLine("Your current fatigue points rest at " + fatiuge + " you colapse!\nLucky you're at the end otherwise you'd be in danger!");
                        }
                        else
                        {
                            Console.WriteLine("That wasn't and option, please understand we have no room for creative freedom");
                        }
                    }
                    else
                    {
                        Console.WriteLine("That wasn't and option, please understand we have no room for creative freedom!");
                    }

                    break;
                case (int)diff.Hard:
                    Console.WriteLine("Oh, you like a challenge, or brambles but eitherway, thats a sight for sore eyes.");

                    break;
                default:
                    Console.WriteLine("Now both of us know thats not a number between 1 and 3.");
                    break;

            }



        }
    }
}
