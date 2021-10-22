using System;

namespace MCarpenter_Wk6_Ex2
{
    class Vehicle
    {
        string type;
        int passengerCapacity;
        float fuelCapacity;
        float fuelConsumption;

        public Vehicle(string type, int psngCpc, float fuelCpc, float fuelCns)
        {
            this.type = type;
            this.passengerCapacity = psngCpc;
            this.fuelCapacity = fuelCpc;
            this.fuelConsumption = fuelCns;
        }

        public string getType()
        {
            return this.type;
        }
        public int getPsngCpc()
        {
            return this.passengerCapacity;
        }
        public float getFuelCpc()
        {
            return this.fuelCapacity;
        }
        public float getFuelCns()
        {
            return this.fuelConsumption;
        }
    }
}
