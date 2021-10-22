namespace Inheritance
{
    class Cat: Animal //the cat is a child of animal class
    {
        string voice;


        public void setVoice(string CatVoice)
        {
            this.name = CatVoice;
        }

        public string getVoice()
        {
            return this.voice;
        }
        public void setName(string Catname)
        {
            this.name = Catname;
        }
        public string getName()
        {
            return this.name;
        }
    }

   
}
