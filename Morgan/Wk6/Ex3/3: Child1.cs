using System;
using System.Collections.Generic;
using System.Text;

namespace MCarpenter_Wk6_Ex3
{
    class Child1 : Parent
    {
        float specific;

        public Child1(int cmn1, string cmn2, float spcf)
        {
            this.common1 = cmn1;
            this.common2 = cmn2;
            this.specific = spcf;
        }

        public float getSpcf()
        {
            return this.specific;
        }

        public void setSpcf(float inputFloat)
        {
            this.specific = inputFloat;
        }
    }
}
