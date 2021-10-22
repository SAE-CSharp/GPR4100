using System;

namespace MCarpenter_Wk6_Ex2
{
    class Program
    {
        static void DisplayVehicleInfo(Vehicle v)
        {
            Console.WriteLine("| >> Vehicle Information <<\n|");
            Console.WriteLine("| Vehicle Type:\n| - " + v.GetType());
            Console.WriteLine("| Passenger capacity:\n| - " + v.getPsngCpc());
            Console.WriteLine("| Fuel capacity:\n| - " + v.getFuelCpc() + " gallons");
            Console.WriteLine("| Average fuel consumption:\n| - " + v.getFuelCns() + " miles/gallon");
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the vehicle type.");
            string vType = Console.ReadLine();
            
            Console.WriteLine("\nPlease enter the vehicle's passenger capacity.");
            int vPassengers = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nPlease enter the vehicle's fuel capacity.\n (in gallons)");
            float vFuelCap = float.Parse(Console.ReadLine());

            Console.WriteLine("\nPlease enter the vehicle's average fuel consumption.\n (in miles/gallon)");
            float vFuelCns = float.Parse(Console.ReadLine());

            Vehicle vehicle1 = new Vehicle(vType, vPassengers, vFuelCap, vFuelCns);

            Console.WriteLine();

            DisplayVehicleInfo(vehicle1);

            Console.WriteLine();
        }
    }
}
