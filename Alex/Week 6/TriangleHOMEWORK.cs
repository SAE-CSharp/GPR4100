    class Program
    {
        static void Main(string[] args)
        {
            int Maxnum = 0;
            bool mainLoop = true;

            while (mainLoop)
            {

                Console.WriteLine("Please enter the length of the triangle :");
                var playernum = Console.ReadLine();
                Console.WriteLine("\n");

                if (int.TryParse(playernum, out Maxnum))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("your input is not recognized, please try again... ");
                    continue;
                }
            }

            int[] increaseArray = new int[Maxnum];

            for (int counter = 0; counter < increaseArray.Length; counter++)
            {
                increaseArray[counter] = Maxnum;
                Maxnum--;
            }
            Array.Sort(increaseArray);

            string[] decreaseArray = Array.ConvertAll(increaseArray, down => down.ToString());

            incline(increaseArray);
            decline(decreaseArray);



            static void incline(int[] increaseArray)
        {
            for (int counter = 0; counter < increaseArray.Length; counter++)
            {
                for (int Number = 0; Number <= counter; Number++)
                {
                    Console.Write(increaseArray[Number] + "  ");
                }
                Console.WriteLine("\n");               
            }
        }

        static void decline(string[] increaseArray)
        {
            for (int counter = 0; counter <= increaseArray.Length - 1; counter++)
            {
              increaseArray[increaseArray.Length - (1 + counter)] = "";
                for (int Number = 0; Number < increaseArray.Length; Number++)
                {
                    Console.Write(increaseArray[Number] + "  ");
                }
                Console.WriteLine("\n");
            }
        }
            // ignore everything below this line ------------------------------------------------------------------------------


        /*static void Main(string[] args)
        {
            int Maxnum = 0;
            bool mainLoop = true;

            while (mainLoop)
            {

                Console.WriteLine("Please enter the length of the triangle :");
                var playernum = Console.ReadLine();
                Console.WriteLine("\n");

                if (int.TryParse(playernum, out Maxnum))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("your input is not recognized, please try again... ");
                    continue;
                }
            }

            int[] increaseArray = new int[Maxnum];

            for (int counter = 0; counter < increaseArray.Length; counter++)
            {
                increaseArray[counter] = Maxnum;
                Maxnum--;
            }
            Array.Sort(increaseArray);

            string[] decreaseArray= Array.ConvertAll(increaseArray, down => down.ToString());

            incline(increaseArray);
            decline(decreaseArray);
             
            // 888888888888888888888888888888888888888888888888888888888888888888888888888888888888888
            
            Console.WriteLine("please enter the length of the triangle 1 - 10 ");
            int num = Int32.Parse(Console.ReadLine());
            int value =  0;
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(value);
                value++;

            }
           
           // this doesnt work, cannot get the number to add to the previous 

           //888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888
           */

        }
    }
