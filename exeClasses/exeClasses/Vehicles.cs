using System;
using System.Collections.Generic;
using System.Text;

namespace exeClasses
{
    class Vehicles
    {
        public Vehicles(int pass, double fuel, int capac)
        {
            this.passenger = pass;
            this.gas = fuel;
            this.people = capac;
        }


        
        int passenger; double gas; int people;

        public int getPass()
        {
            return this.passenger;
        }
        public double getFuel()
        {
            return this.gas;
        }
        public int getCapac()
        {
            return this.people;
        }

    }
}
