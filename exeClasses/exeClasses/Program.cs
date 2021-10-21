using System;

namespace exeClasses
{
    class Program
    {
        static void Main(string[] args)
        {


            // student james = new student();


            //create an object inside the main method
            Car car1 = new Car("Red", "Nissan GTR", 35.500);
            car1.getColour();
            car1.getModel();
            car1.getPrice();



            string Colour = car1.getColour();
            Console.WriteLine(Colour);
            double newPrice = car1.getPrice();
            string newModel = car1.getModel();
            Console.WriteLine(newModel + "-" + newPrice + "-" + "-" + Colour);
            car1.setColour("Blue");
            
            Console.WriteLine(newModel + "-" + newPrice + "-" + "-" + Colour);
            //***********************************************************************

            Student stu1 = new Student("jamespenter@live.co.uk", "Jay" , 22);
            stu1.getEmail();
            stu1.getName();
            stu1.getAge();

            string email = stu1.getEmail();
            string name = stu1.getName();
            int age = stu1.getAge();
            Console.WriteLine("Your email is : " + email + "\nYour name is : " + name + "\nYour current age is: " + age );

            //***********************************************************************

            Vehicles trip1 = new Vehicles(35, 1.8, 150);
            trip1.getCapac();
            trip1.getFuel();
            trip1.getPass();

            int capacity = trip1.getCapac();
            double fuel = trip1.getFuel();
            int passengers = trip1.getPass();
            Console.WriteLine("The current capacity is: " + capacity + "\nFuel is being consumed at a rate of: " + fuel + " gallons per hour" + "\nYour current transmission rate of passengers is: " + passengers);



        }














        
    }
}
