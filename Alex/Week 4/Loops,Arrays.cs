 class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 4, 6, 8, 10 };

           Console.WriteLine("what would you like to change the first number to ?");
            numbers[0] = Int32.Parse(Console.ReadLine());

            Console.WriteLine(numbers[0]);
            //the number in the square brackets is the number of the index in the array
            Console.WriteLine(numbers[4]);
            // if you want to display the entire array on one line you will need to write it out like this
            Console.Write(numbers[0] + " " + numbers[1] + " " + numbers[2] + " " + numbers[3] + " " + numbers[4] );
            // if you want to display the entire array you will need to write it out individually
            Console.Write("              ");
            Console.WriteLine( numbers[0]);
            Console.WriteLine( numbers[1]);
            Console.WriteLine( numbers[2]);







            string[] UKcountries = { "England", "Scotland", "Ireland", "Wales", "Isle of man" };


            int[] books = new int[5];

            books[0] = 3;
            books[1] = 4;
            books[2] = 5;
            books[3] = 6;
            books[4] = 7;



            string[] Studentnames = { "Alex", "Aaron", "Brandon", "Daisy", "Dalton", "James", "Josh", "Jurgita", "Tiernagh", "Tommy" };
            // Console.Write("In our class there are 10 students their names are " + Studentnames[0] + ", " + Studentnames[1] + ", " + Studentnames[2] + ", " + Studentnames[3] + ", " + Studentnames[4] + ", " + Studentnames[5] + ", " + Studentnames[6] + ", " + Studentnames[7] + ", " + Studentnames[8] + ", " + Studentnames[9]);
            int arraynum = Studentnames.Length; 

            for (int counter = 0; counter < arraynum; counter++)
            {
                Console.WriteLine("there are " + counter + " Names listed");
                Console.WriteLine("              ");
                Console.WriteLine(Studentnames[counter]) ;
                Console.WriteLine("              ");
                Console.WriteLine("              ");
            }
            int arraylegnth = Studentnames.Length;
            Console.WriteLine(" there are " + arraylegnth + " students in GPR4100");





            float[] Studentheight = { 6.1f, 6.0f, 5.9f, 5.6f };
            int arraylen = Studentheight.Length;
            Console.WriteLine("student height in order ranging from tallest to shortest");
            for (int counters = 0; counters < arraylen; counters++)
            {
                Console.WriteLine("The " + counters + " Students height is ...");
                Console.WriteLine(Studentheight[counters]);
                Console.WriteLine("             ");

            }


            


            string[] Campuses = { "glasgow", "london", "oxford", "liverpool" };
            int Campuslen = Campuses.Length;
            Console.WriteLine("below are a list of the four campuses in the UK, please choose one");

            //Campuses[0] = 1;

            for (int Count = 0; Count < Campuslen; Count++)
            {
               Console.WriteLine(Campuses[Count]);
                Console.WriteLine("Do you with to study at this campus");
                Console.WriteLine("Yes or No");
                string Qanswer = Console.ReadLine();
                if (Qanswer == "Yes" || Qanswer == "yes" || Qanswer == "Y" || Qanswer == "y")
                {
                    Console.WriteLine("        ");
                    Console.WriteLine("        ");
                    Console.WriteLine("Thank you for choosing this campus... ");
                    Console.WriteLine(" for more information visit ");
                    Console.WriteLine("https://www.sae.edu/gbr/home-creatives-landing-page?utm_campaign=SAE-GBR-LPL-SALL-PSE-LDGNR-GGLBRANDSRCH-CDNOTSET-20210909&utm_source=google&utm_medium=cpc&gclid=EAIaIQobChMIgKDz9My48wIV7YBQBh3w7gX0EAAYASAAEgL7q_D_BwE");
                    Console.WriteLine("        ");
                    Console.WriteLine("        ");
                    Console.WriteLine("        ");
                    break;

                }
                else
                {
                    continue;
                }
            

            }
        }
    }
