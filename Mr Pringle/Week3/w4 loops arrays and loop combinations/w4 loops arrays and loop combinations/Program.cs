using System;

namespace w4_loops_arrays_and_loop_combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            //An Arrays is a collection of variables of the same type, reffered to by a common name. Arrays are stored in a sequential and ordered manner
            // the first element of an array will have the index of 0
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };      //this array is 10 elaments long so its size is 10
            // index numbers  0, 1, 2, 3, 4, 5, 6, 7, 8, 9      for the elements above
            // the square brackets are the difference between a normal variable and an array
            Console.Write(numbers[0] + " ");
            Console.Write(numbers[1] + " ");
            Console.Write(numbers[2] + " ");
            Console.Write(numbers[3] + " ");
            Console.Write(numbers[4] + " ");
            Console.Write(numbers[5] + " ");
            Console.Write(numbers[6] + " ");
            Console.Write(numbers[7] + " ");
            Console.Write(numbers[8] + " ");
            Console.Write(numbers[9] + " ");
            Console.WriteLine("\n");
            Console.Write("Enter index number:");
            int indexNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numbers[indexNum]+" is the data stored in the index code entered");
            ///////////////////////////////////////////////////
            Console.WriteLine("\n");

            string[] cities={ "Mumbai", "London", "New York", "Paris", "Dublin"};
            Console.Write(cities[0] + " ");
            Console.Write(cities[1] + " ");
            Console.Write(cities[2] + " ");
            Console.Write(cities[3] + " ");
            Console.Write(cities[4] + " ");
            Console.WriteLine("\n");
            Console.Write("Enter City index number: ");
            int indexCities = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(cities[indexCities] + " is the City you chose.");
            /////////////////////////////////////////////////////
            Console.WriteLine("\n");

            string[] studentName = { "Dalton", "James", "Brandon", "Daisy", "Angela", "Tia", "Alex", "Aaron", "Josh", "Tommy", "Jack" };
            Console.Write(studentName[0] + " ");
            Console.Write(studentName[1] + " ");
            Console.Write(studentName[2] + " ");
            Console.Write(studentName[3] + " ");
            Console.Write(studentName[4] + " ");
            Console.Write(studentName[5] + " ");
            Console.Write(studentName[6] + " ");
            Console.Write(studentName[7] + " ");
            Console.Write(studentName[8] + " ");
            Console.Write(studentName[9] + " ");
            Console.Write(studentName[10] + " ");
            Console.WriteLine("\n");
            Console.Write("Enter the Students Index: ");
            int indexStudent = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nice " + studentName[indexStudent] + " is definatly a student.");

            int studentNameLength = studentName.Length;



            float[] studentFloat = { 2.5f, 1.5f, 7.5f, 1.1f};
            int floatLength = studentFloat.Length;
            for (int i = 0; i < floatLength; i++)
            {
                Console.WriteLine("The index is: " + i + " and the element is: " + studentFloat[i]);
            }
            ///////////////////////////////////////////////////////
            int[] book = new int[4];
            //the numebr of elements of the array is 4
            //the last index is 3 (0-3)
            book[0] = 3;
            book[1] = 6;
            book[2] = 5;
            book[3] = 10;
            //this is decarling the elements of the array outside the array creation line
            Console.WriteLine("\n");

            int[] num = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            Console.Write(num[0] + " ");
            Console.Write(num[1] + " ");
            Console.Write(num[2] + " ");
            Console.Write(num[3] + " ");
            Console.Write(num[4] + " ");
            Console.Write(num[5] + " ");
            Console.Write(num[6] + " ");
            Console.Write(num[7] + " ");
            Console.Write(num[8] + " ");
            Console.WriteLine("\n");
            int arrayLenght = num.Length;
            Console.WriteLine(arrayLenght+" lines in the array above detected!");
            /*
                        int[] number;
                        number = new int[4];

                        string[] word = new string[9];

                        float[] deci;
                        deci = new float[456];

                        these are all arrays with the arrays elements to be definded later for the spesific array length thats defined here
            */
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///FOR LOOPS
            ///for loops are like whiles but have a counter built in for a set number of times of repeating
            Console.WriteLine("\n");
            int[] myNum = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100};
            int myNumLengh = myNum.Length;
            for (int i = 0; i< myNumLengh ; i++)
            {
                Console.WriteLine("The Index is: " + i + " and the element is: " + myNum[i]);
            }
            for (int i = 0; i <= 10; i++) 
            {
                Console.WriteLine("Hello World! "+i);
            }
            //the i is a local variable to the for loop and will not leak out, thus no errors
            

            string[] campus = { "London", "Liverpool", "Oxford", "Glasgow" };
            int campLen = campus.Length;
            for (int i = 0; i <campLen; i++)
            {
                Console.WriteLine("The SAE Campus with the index number: " + i + " is the " + campus[i] + " campus");
                if (i == 1)
                {
                    Console.WriteLine("Hello Liverpool!!!!");
                    continue;
                }
            }







            Console.ReadLine();
        }
    }
}
