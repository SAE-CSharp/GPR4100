using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Vehicles
    {
        private string Passengers;
        private int fuelcap;
        private double fuelcon;
        
        public Vehicles(string mypassenger, int myfuelcap, double myfuelcon)
        {
            this.Passengers = mypassenger;
            this.fuelcap = myfuelcap;
            this.fuelcon= myfuelcon;
        }
        public string getPassengers()
        {
            return this.Passengers;
        }
        public int getFuelCap()
        {
            return this.fuelcap;
        }
        public double getFuelCon()
        {
            return this.fuelcon;
        }

    }
}
