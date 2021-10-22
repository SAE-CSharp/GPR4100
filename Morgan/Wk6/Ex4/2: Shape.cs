using System;

namespace MCarpenter_Wk6_Ex4
{
    class Shape
    {
        protected double height;
        protected double width;

        public double GetHeight()
        {
            return this.height;
        }
        public double GetWidth()
        {
            return this.width;
        }
        public string GetShapeType()
        {
            return Convert.ToString( this.GetType() ).Split('.')[1];
        }

        public void SetHeight(double h)
        {
            this.height = h;
        }
        public void SetWidth(double w)
        {
            this.width = w;
        }
    }
}
