using System;
using System.Collections.Generic;
using System.Text;

namespace MCarpenter_Wk6_Ex1
{
    class Car
    {
        // Attributes (data members)
        string colour;
        string manufacturer;
        double price;

        // Constructor - assigns values to the class' attributes
            // The constructor does not use a return type
        public Car()
        {
            this.colour = "Silver";
            this.manufacturer = "Audi";
            this.price = 7500.00;
        }

        // "Getter" methods - retrieve attribute values
            // These methods need to be accessible outside the
            // class, so they need to be set to "public"
        public string getColour()
        {
            return this.colour;
        }
        public string getManufacturer()
        {
            return this.manufacturer;
        }
        public double getPrice()
        {
            return this.price;
        }

        // "Setter" methods - assign attribute values
        public void setColour(string colour)
        {
            this.colour = colour;
        }
        public void setManufacturer(string manufacturer)
        {
            this.manufacturer = manufacturer;
        }
        public void setPrice(double price)
        {
            this.price = price;
        }

    }
}
