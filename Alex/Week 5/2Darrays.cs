class Program
    {
        static void Main(string[] args)
        {
            int[,] intArray = new int[5, 3]
            {
            {1,2,3 },//  first row  =0
            {4,5,6 },//  second row =1
            {7,8,9 },//   third row =2
            {10,11,12},// forth row =3 
            {13,14,15} // fifth row =4


            };
            //                 row Num\/  \/ num in row 
            Console.WriteLine(intArray[0, 0]);
            Console.WriteLine(intArray[0, 1]);
            Console.WriteLine(intArray[0, 2]);
            Console.WriteLine(intArray[1, 0]);
            Console.WriteLine(intArray[1, 1]);
            Console.WriteLine(intArray[1, 2]);
            Console.WriteLine(intArray[2, 0]);
            Console.WriteLine(intArray[2, 1]);
            Console.WriteLine(intArray[2, 2]);
            Console.WriteLine(intArray[3, 0]);
            Console.WriteLine(intArray[3, 1]);
            Console.WriteLine(intArray[3, 2]);
            Console.WriteLine(intArray[4, 0]);
            Console.WriteLine(intArray[4, 1]);
            Console.WriteLine(intArray[4, 2]);


            Console.WriteLine("       ");
            Console.WriteLine("       ");
            Console.WriteLine("       ");
            Console.WriteLine("       ");
            Console.WriteLine("       ");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(intArray[i, j]);
                }



            }

            int[,] Array2D = new int[3, 4]
            {
                {2,4,6,8 },
                {10,12,14,16 },
                {18,20,22,24 }
            };

            for (int a = 0; a < 3; a++)
            {
                for (int b = 0; b < 4; b++)
                {
                    Console.WriteLine(Array2D[a, b]);
                    Console.WriteLine("A = " + a + " B " + b + " the number is : " + Array2D[a, b]);
                }
            }



            // ways to generate a random number

            Random rnd = new Random();
            // if you want to generate a random decimal number from 0.0 to 1.0
            Double randomnumdecimal = rnd.NextDouble();
            Console.WriteLine("the decimal random number was " + randomnumdecimal);

            // generates a random interger number from 0 to 99
            int randomnum = rnd.Next(0, 100);
            Console.WriteLine("the random number was " + randomnum);

            // generates a number that is less than 10, does not include 10
            int randomnumber = rnd.Next(10);
            Console.WriteLine("the random number less than 10 was " + randomnumber);

            // generates a random fucking number for no reason
            Console.WriteLine(rnd.Next());
        }
    }
