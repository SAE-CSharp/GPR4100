using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] number = { 10, 20, 30, 40, 50 };
            Console.WriteLine(number [2]);
            Console.WriteLine(number[3]);
            Console.WriteLine(number[0]);
            Console.WriteLine(number[4]);

            Console.WriteLine(number[2]); //30
            number[2] = 100;

            int arraylength = number.Length;
            Console.WriteLine(arraylength);


            string[] cities = { "London", "Tokyo", "Souel", "Paris" };
            Console.Write(cities[1]);
            cities[1] = " Texas";
            Console.Write(cities[1]);

            int arraylength2 = cities.Length;
            Console.WriteLine(arraylength2);

            float[] myfloatarray = { 1.2f, 1.5f, 1.7f, 1.9f };

            int len = myfloatarray.Length;
            Console.WriteLine(myfloatarray[5]);

            char[] grades = { 'A', 'B', 'C', 'D' };
            int len3 = grades.Length;
            Console.WriteLine(grades[3]);

            
            int[] myarray ={ 20, 30 ,40};
            //another way to declare and specify the size or length of the array
            int[] array1 = new int[4];
            array1[0] = 100;
            array1[1] = 200;
            array1[2] = 300;
            array1[3] = 400;


            float[] pos = new float[5];
            pos[0] = 1.2f;
            pos[1] = 1.6f;
            pos[2] = 2.2f;
            pos[3] = 3.4f;
            pos[4] = 4.5f;
            pos[5] = 5.2f;

            Console.WriteLine(pos[0]);
            Console.WriteLine(pos[1]);
            Console.WriteLine(pos[2]);
            Console.WriteLine(pos[3]);
            Console.WriteLine(pos[4]);
            Console.WriteLine(pos[5]);*/

/*
            for (int i=0; i<10;i++)
            {
                Console.WriteLine("The value of I is: " + i);
                if(i == 5)
                {
                    break;
                }


            }

            int[] intarray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int arraylength = intarray.Length;

            for(int i=0; i< arraylength; i++)
            {
                Console.WriteLine("the value of i is:" + i +" the element is "+ intarray[2]  ) ;

            }
*/


            string[] colours = { "red", "green", "blue", "yellow" };
            int len2 = colours.Length;

            Console.WriteLine("What is your favoraite colour? \nRed\n Green \n Blue\n Yellow");
            string option = Console.ReadLine();


            for (int i=0; i<= len2; i++)
            {
                Console.WriteLine("The value of the I is:"+ i+ " and the colour is:"+ option);
                if(option == colours[0])
                {
                    Console.WriteLine("Your fav colour is RED");
                    break;
                }
                 if (option == colours[1])
                {
                    Console.WriteLine("Your fav colour is GREEN");
                    break;
                }
                 if (option == colours[2])
                {
                    Console.WriteLine("Your fav colour is BLUE");
                    break;
                }
                if (option == colours[3])
                {
                    Console.WriteLine("Your fav colour is YELLOW");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Colour");
                }
            }



            int[] array5 = { 2, 4, 6, 8 };
            int len6 = array5.Length;

            for(int i=0; i< len6; i++)
            {


                Console.WriteLine("The value of the I is:" + i + " and the element is:" +array5 );

            }

            int[] arr1 = new int[4];
                int len7 = arr1.Length;

            for (int i = 0; i < len7; i++)
            {

                arr1[0] = i;
                Console.WriteLine("The I is " + i);
            }


            int[,] intarr = new int[3, 2] { { 4, 5 }, { 5, 0 }, { 3, 1 } };

            for (int i =0; i<3; i++)
            {
                for (int j=0; j<2; j++)
                {
                    Console.WriteLine("The element is " + intarr[i, j]);
                }
            }



















        }

    }
}
