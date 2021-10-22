using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Traingle:Shape
    {
        string style;
     
        public Traingle(double w, double h)
        {
            height = h;
            width=w;
            
        }

        public double getArea()
        {

            return width * height / 2;
        }



    }
}
