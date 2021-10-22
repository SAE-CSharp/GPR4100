namespace Classes
{
    class Car1
    {
        private string name;
        private double topSpeed;
        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setTopSpeed(double speedMPH)
        {
            this.topSpeed = speedMPH;
        }
        public double getTopSpeedMPH()
        {
            return topSpeed;
        }
        public double getTopSpeedKMH()
        {
            return topSpeed * 1.609;
        }
    }
}
