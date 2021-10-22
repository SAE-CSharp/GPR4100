namespace Classes
{
    public class Car
    {
        //attributes= data members
        //by default attributes are private
        //public or private
        
        private string color;
        private string model;
        private double price;
        //constructor to assign values to the class attributes
        //no return value from constructor
        public Car()
        {
            this.color = "Red";
            this.model = "Mazda";
            this.price = 20.000;
        }
        //setter method to change the values of the class attributes
        public void setColor(string myColor)
        {
            this.color = myColor;
        }
        public void setmodel(string myModel)
        {
            this.model = myModel;
        }
        //getter methods
        public void setPrice(double myPrice)
        {
            this.price = myPrice;
        }

        public string getcolor()
        {
            return this.color;

        }

        public string getmodel()
        {
            return this.model;
        }

        public double getprice()
        {
            return this.price;
        }
        
    }
}
