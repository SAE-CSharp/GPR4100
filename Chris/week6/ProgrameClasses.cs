using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //create(instantiate) an object of class car
            Car car1 = new Car();
            string color=car1.getcolor();
            Console.WriteLine(color);
            // i change the color to blue using setcolor method
            car1.setColor("Blue");
            string newcolor = car1.getcolor();
            Console.WriteLine(newcolor);
            string model = car1.getmodel();
            Console.WriteLine(model);
            //changing model using setmodel method
            car1.setmodel("toyota");
            string newmodel = car1.getmodel();
            Console.WriteLine(newmodel);
            double price = car1.getprice();
            Console.WriteLine(price);
            //changing price using setprice method
            car1.setPrice(30.000);
            double newprice = car1.getprice();
            Console.WriteLine(newprice);
            

            //student class
            //while loop to ask 3 times
            int counter = 3;
            while (counter > 0)
            {
                Console.WriteLine("enter your name please: ");
                string stdname = (Console.ReadLine());
                Console.WriteLine("enter your email please: ");
                string stdemail = (Console.ReadLine());
                Console.WriteLine("enter your id number please: ");
                int stdid = int.Parse(Console.ReadLine());
                student std1 = new student(stdname, stdemail, stdid);
                string name = std1.getname();
                Console.WriteLine("name: " +name);
                string email = std1.getemail();
                Console.WriteLine("email: " +email);
                int id = std1.getid();
                Console.WriteLine("I.D: " +id);
                counter--;

                //Vehicles class
                Console.WriteLine("enter your number of passengers: ");
                string passenger = (Console.ReadLine());
                Console.WriteLine("enter your fuel capacity: ");
                int fuelcap = int.Parse(Console.ReadLine());
                Console.WriteLine("enter your fuel consumption: ");
                double fuelcon = double.Parse(Console.ReadLine());
                Vehicles minivan = new Vehicles(passenger, fuelcap, fuelcon);

                Car1 car = new Car1();
                car.setName("Nissan");
                car.setTopSpeed(200.0);

                Console.WriteLine(car.getName() + " top speed in MPH is " + car.getTopSpeedMPH());







            }


        }
    }
}
