using System;

namespace exeLoopsArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] names = { "jay", "jack", "john","jeff"};//store multiple names or groups of text in the same box
            int [] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };//store multiple integer variables in the same box
            Console.WriteLine("What would you like the first number to be?");

            nums[0] = Int32.Parse(Console.ReadLine());//user changes the value themselves

            nums[4] = 67;
            nums[7] = 33;
            
            Console.WriteLine(nums[0]+" You changed this number, remember?");//allows you to select a variable from your previously created array from user input
            Console.WriteLine(nums[1]);//allows you to select a variable from your previously created array
            Console.WriteLine(nums[4]);
            Console.WriteLine(nums[7]);
            //***********************************************
            names[0] = "Liverpool";
            Console.WriteLine(names[1]);
            Console.WriteLine(names[3]);
            Console.WriteLine(names[0]);

            string[] group = { "Dalton", "Josh", "Daisy", "Jurgita", "Tommy", "Jack", "Alex", "Zahra" };//creating a string array 
            Console.WriteLine(group[4]); Console.WriteLine(group[2]); Console.WriteLine(group[0]);
            string secondstudent = group[1];//how you store a previously created array variable in its own sepearte variable
            Console.WriteLine(secondstudent);

            //**************************************************
            int[] books = new int[4];//creating the array first and stating the length but not the internal values
            //the number of elements of the array is 4 
            //the last index is 3(0-3)(position)
            books[0] = 3;
            books[1] = 6;
            books[2] = 9;
            books[3] = 12;
            Console.WriteLine(books[2]);
            //*************************************************
            int[] val = { 10, 20, 30, 40 };
            int arrayLength = val.Length;

            Console.WriteLine(arrayLength);
            //*************************************************
            int[] mynums = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            int aralength = mynums.Length;
            for (int x = 0; x < aralength; x++)
            {
                Console.WriteLine("the index is: " + x + " and the element is: " + mynums[x]);
            }
                
            //***************************************************
            for (int i = 0; i <= 10; i++) 
            {
                Console.WriteLine("The value of i is..." + i);
            }
            //****************************************
            string[] team = { "AA", "AB", "AC", "AD", "AE" };
            int temlength = team.Length;
            float[] myfloat = { 2.3f, 3.6f, 5.7f, 1.1f,9.6f,7.7f };
            int arrlength = myfloat.Length;
            for (int z = 0; z < temlength; z++)
            {
                Console.WriteLine("The value of z is..." + z + " and the element is: "+ myfloat[z]);
            }
            //****************************************************
            string[] camp = { "Liverpool", "London", "Madrid", "Amsterdam", "Paris" };//lsiting multiple campuses
            int camlength = camp.Length;//obtaning how many campuses
            float[] thefloat = { 8.3f, 4.6f, 2.7f, 7.1f, 8.6f, 3.9f };
            int arraylength = thefloat.Length;
            for (int xo = 0; xo < camlength; xo++)//increment from 0 to how many campuses there are in total
            {
                Console.WriteLine("The number of this campus is... " + xo + "," + " Hello... " +   camp[xo]);
                if (xo == 2) //once on the 2nd campus
                {
                    Console.WriteLine("This is the third campus on the list, would you like to see the remaining campuses");
                    Console.ReadLine();
                    
                    continue;//continue the loop on the 2nd campus, can be whatever you want it to be
                }

                
            }





        }
    }
}
