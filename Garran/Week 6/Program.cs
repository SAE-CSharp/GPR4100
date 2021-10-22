using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create(instantiate) an object of class car
            Car car1 = new Car();

            string color = car1.getColor();
            Console.WriteLine(color);
            //I changed the color to blue using the set color method
            car1.setColor("Blue");
            string newColor = car1.getColor();
            Console.WriteLine(newColor);

            string model = car1.getModel();
            Console.WriteLine(model);
            car1.setModel("B&W");
            string newModel = car1.getModel();
            Console.WriteLine(newModel);


            double price = car1.getPrice();
            Console.WriteLine(price);
            car1.setPrice(50.000);
            double newPrice = car1.getPrice();
            Console.WriteLine(newPrice);

            //Student class
            int counter = 3;
            while (counter > 0)
            {
                Console.WriteLine("Enter your name please ");
                string stdName = Console.ReadLine();
                Console.WriteLine("Enter your email please ");
                string stdEmail = Console.ReadLine();
                Console.WriteLine("Enter your number please ");
                int stdNumber = int.Parse(Console.ReadLine());

                Student std1 = new Student(stdName, stdEmail, stdNumber);
                string name = std1.getName();
                Console.WriteLine(name);
                string email = std1.getEmail();
                Console.WriteLine(email);
                int number = std1.getNumber();
                Console.WriteLine(number);
                counter--;

                //Vehicle class
                Console.WriteLine("Enter the number of passengers please ");
                int passenger = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your fuel capacity please ");
                int fuelCap = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your fuel consumption please ");
                double consumption = double.Parse(Console.ReadLine());
                Vehicles minivan = new Vehicles(passenger, fuelCap, consumption);
            }

        }


    }
}
