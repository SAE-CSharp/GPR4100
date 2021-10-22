using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Car
    {
        //Attributes = data members
        //By default attributes are private
        //Public or private
        string color;
        string model;
        double price;
    
        //Constructor to assign values to the class's attributes
        //No return value from constructor
        public Car()
        {
            this.color = "Red";
            this.model = "Mazda";
            this.price = 20.000;
        }

        //Setter method to change the values of the class's attributes
        public void setColor(string C)
        {
            this.color = C;
        }

        public void setModel(string C)
        {
            this.model = C;
        }

        public void setPrice(double C)
        {
            this.price = C;
        }
        //Getter methods

        public string getColor()
        {
            return this.color;
        }

        public string getModel()
        {
            return this.model;
        }

        public double getPrice()
        {
            return this.price;
        }
    }
}
