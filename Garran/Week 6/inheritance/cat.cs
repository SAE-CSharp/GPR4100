using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Cat : Animal //The cat is a child of animal class
    {
        string voice;

        public void setName(string Catvoice)
        {
            this.voice = Catvoice;
        }

        public void getName(string Catname)
        {
            this.name = Catname;
        }
        public string getVoice()
        {
            return this.voice;
        }
        public void setVoice(string catvoice)
        {
            this.voice = catvoice;
        }
        public string getName()
        {
            return this.name;
        }
        
    }
}
