using System;
using System.Collections.Generic;
using System.Text;

namespace MCarpenter_Wk6_Ex3
{
    class Child2 : Parent
    {
        bool specific;

        public Child2(int cmn1, string cmn2, bool spcf)
        {
            this.common1 = cmn1;
            this.common2 = cmn2;
            this.specific = spcf;
        }

        public bool getSpcf()
        {
            return this.specific;
        }

        public void setSpcf(bool inputFloat)
        {
            this.specific = inputFloat;
        }
    }
}
