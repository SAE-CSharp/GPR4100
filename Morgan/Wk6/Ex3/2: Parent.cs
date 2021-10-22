using System;
using System.Collections.Generic;
using System.Text;

namespace MCarpenter_Wk6_Ex3
{
    class Parent
    {
        protected int common1;
        protected string common2;

        public int getCmn1()
        {
            return this.common1;
        }
        public string getCmn2()
        {
            return this.common2;
        }

        public void setCmn1(int inputInt)
        {
            this.common1 = inputInt;
        }
        public void setCmn2(string inputString)
        {
            this.common2 = inputString;
        }
    }
}
