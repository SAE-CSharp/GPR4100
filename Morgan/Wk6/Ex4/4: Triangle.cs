using System;

namespace MCarpenter_Wk6_Ex4
{
    class Triangle : Shape
    {
        public double GetArea()
        {
            return (this.width * this.height) / 2;
        }
    }
}
