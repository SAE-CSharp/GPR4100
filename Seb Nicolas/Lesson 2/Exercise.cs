{
    class Program
    {
        static void Main(string[] args)
        {

            /* \' \" \\ \n \t */

            string myName = "Seb";
            string myInstitute = "SAE London";
            int myAge = 18;
            string myTown = "Burgess Hill";
            int instituteMiles = 68;

            Console.WriteLine("My Name Is " + myName);
            Console.WriteLine("I'm a student at " + myInstitute + ". I am " + myAge + " years old.");
            Console.WriteLine("I Live in " + myTown + " which is " + instituteMiles + " miles away from " + myInstitute);
            Console.WriteLine("My Hobbies are; Playing the Piano, Playing Video Games, and Coding");
            Console.WriteLine("My Folder Location is: C:\\Users\\Admin\\Exercise2.cs");

            int x = 50, y = 20;
            int result = x + y;
            // + Addition
            Console.WriteLine("\n The Result of X + Y Operation is " + (x + y));
            // - Subtration
            Console.WriteLine("\n The Result of X - Y Operation is " + (x - y));
            // / Devision
            Console.WriteLine("\n The Result of X / Y Operation is " + (x / y));
            // * Multiply
            Console.WriteLine("\n The Result of X * Y Operation is " + (x * y));
            // % Modulus
            Console.WriteLine("\n The Result of X % Y Operation is " + (x % y));


        }
    }
}
