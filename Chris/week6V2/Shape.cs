using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Triangle: Shape
    {
        string style;

        public void setWidth(double Twidth)
        {
            this.width = Twidth;
            
        }
        public double getWidth()
        {
            return this.width;
        }
        public void setHeight(double Theight)
        {
            this.height = Theight;

        }
        public double getHeight()
        {
            return this.height;
        }
        public double getArea()
        {
            return this.width * this.height / 2;
        }
    }
}
