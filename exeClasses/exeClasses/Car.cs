using System;
using System.Collections.Generic;
using System.Text;

namespace exeClasses
{
    class Car
    {
        //constructor/method
         public Car()
         {
             this.colour = "Purple";
             this.model = "Nissan GTR";
             this.price = 35.500;

         }

        public Car(string myColour, string myModel, double myPrice)
        {
            this.colour = myColour;
            this.model = myModel;
            this.price = myPrice;

        }

        //attributes
        string colour;
        string model;
        double price;
        

        //setter methods 
        //THIS REPRESENTS THE OBJECT/ There is no return values
        //Only for changing the value 
        public void setColour(string mySecondColour)
        {


             this.colour = mySecondColour;

        }


        //getter methods that allow you to call these into the main method
        //getter method means I need to return something
        public string getColour()//only one return statement allowed per method. 
        {
            return this.colour;

        }
        public double getPrice()
        {
            return this.price;
                

        }
        public string getModel()
        {
            return this.model;
                

        }





    }


    



    







    
}
