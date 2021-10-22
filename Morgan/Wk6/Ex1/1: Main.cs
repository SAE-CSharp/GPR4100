using System;

namespace MCarpenter_Wk6_Ex1
{
    class Program
    {
        static void GetCarInfo(Car car)
        {
            string printInfo = (" > Manufacturer: " + car.getManufacturer() + "\n > Colour: " + car.getColour() + "\n > Price: £");
            if (car.getPrice() % 1 == 0)
            {
                printInfo = (printInfo + car.getPrice() + ".00");
            }
            else
            {
                printInfo = (printInfo + car.getPrice());
            }
            Console.WriteLine("Car information:\n" + printInfo);


        }
        
        static void GetStudentInfo(Student student)
        {
            string printInfo = (" > Name: " + student.getName() + "\n > Email: " + student.getEmail() + "\n > Student ID: " + student.getID());

            Console.WriteLine("Student information:\n" + printInfo);
        }
        
        static void Main(string[] args)
        {
            // Instantiating (creating) an object using the "Car" class

            Car car1 = new Car();

            GetCarInfo(car1);

            Console.WriteLine();

            car1.setColour("Blue");
            car1.setManufacturer("BMW");
            car1.setPrice(22000.00);

            GetCarInfo(car1);

            Console.WriteLine();


            Student student1 = new Student();

            GetStudentInfo(student1);

            Console.WriteLine();

            student1.setName("Chiara Carrozza");
            student1.setEmail("99043uk@saeinstitute.edu");
            student1.setID(99043);

            GetStudentInfo(student1);

            Console.WriteLine();
        }
    }
}
