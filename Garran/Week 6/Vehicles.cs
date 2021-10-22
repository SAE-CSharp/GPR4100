using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Vehicles
    {
        int passengers;
        int fuelCap; // fuel capacity
        double consumption; // fuel comsumption

        public Vehicles(int passenger, int fuelCap, double consumption)
        {
            this.passengers = passenger;
            this.fuelCap = fuelCap;
            this.consumption = consumption;
        }
        public int getPassenger()
        {
            return this.passengers;
        }

        public int getfuelCap()
        {
            return this.fuelCap;
        }
        public double getconsumption()
        {
            return this.consumption;
        }

    }    
   
}
