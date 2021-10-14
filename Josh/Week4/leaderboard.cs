using System;

namespace leaderboard_
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int score, x;
            var array = new string[5, 2] { { " ", " " }, { " ", " " }, { " ", " " }, { " ", " " }, { " ", " " } };

            for (int i = 0; i < 5; i++)
            {
                //input
                Console.WriteLine("Enter your intials then score\nInitials: ");
                name = Console.ReadLine();
                Console.WriteLine("Score: ");
                var userInput = Console.ReadLine();

                //validate int was entered
                while ((int.TryParse(userInput, out score)) == false)
                {
                    Console.WriteLine("Enter a number");
                    userInput = Console.ReadLine();
                    continue;
                }

                //sorting
                if (array[0, 0] == " ")
                {
                    array[0, 0] = name;
                    array[0, 1] = Convert.ToString(score);
                }
                else if (Convert.ToInt32(array[0, 1]) <= score)
                {
                    array[4, 0] = array[3, 0];
                    array[4, 1] = array[3, 1];
                    array[3, 0] = array[2, 0];
                    array[3, 1] = array[2, 1];
                    array[2, 0] = array[1, 0];
                    array[2, 1] = array[1, 1];
                    array[1, 0] = array[0, 0];
                    array[1, 1] = array[0, 1];
                    array[0, 0] = name;
                    array[0, 1] = Convert.ToString(score);
                }
                else if (Convert.ToInt32(array[0, 1]) > score)
                {
                    if (array[1, 0] == " ")
                    {
                        array[1, 0] = name;
                        array[1, 1] = Convert.ToString(score);
                    }
                    else if (Convert.ToInt32(array[1, 1]) <= score)
                    {
                        array[4, 0] = array[3, 0];
                        array[4, 1] = array[3, 1];
                        array[3, 0] = array[2, 0];
                        array[3, 1] = array[2, 1];
                        array[2, 0] = array[1, 0];
                        array[2, 1] = array[1, 1];
                        array[1, 0] = name;
                        array[1, 1] = Convert.ToString(score);
                    }
                    else if (Convert.ToInt32(array[1, 1]) > score)
                    {
                        if (array[2, 0] == " ")
                        {
                            array[2, 0] = name;
                            array[2, 1] = Convert.ToString(score);
                        }
                        else if (Convert.ToInt32(array[2, 1]) <= score)
                        {
                            array[4, 0] = array[3, 0];
                            array[4, 1] = array[3, 1];
                            array[3, 0] = array[2, 0];
                            array[3, 1] = array[2, 1];
                            array[2, 0] = name;
                            array[2, 1] = Convert.ToString(score);
                        }
                        else if (Convert.ToInt32(array[2, 1]) > score)
                        {
                            if (array[3, 0] == " ")
                            {
                                array[3, 0] = name;
                                array[3, 1] = Convert.ToString(score);
                            }
                            else if (Convert.ToInt32(array[3, 1]) <= score)
                            {
                                array[4, 0] = array[3, 0];
                                array[4, 1] = array[3, 1];
                                array[3, 0] = name;
                                array[3, 1] = Convert.ToString(score);
                            }
                            else if (Convert.ToInt32(array[3, 1]) > score)
                            {
                                if (array[4, 0] == " " || Convert.ToInt32(array[4, 1]) <= score)
                                {
                                    array[4, 0] = name;
                                    array[4, 1] = Convert.ToString(score);
                                }
                            }
                        }
                    }
                }
                x = i;
                Console.WriteLine("\n*****LEADERBOARD*****\n");
                for (i = 0; i < array.Length / 2; i++)
                {
                    Console.WriteLine("  " + (i+1) + "|     " + array[i, 0] + ": " + array[i, 1]);
                }
                Console.WriteLine("   ~~~~~~~~~~~~~~~~\n\n");
                i = x;
            }
        }
    }
}
