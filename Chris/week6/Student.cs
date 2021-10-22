namespace Classes
{
    class student
    {
        private string name;
        private string email;
        private int id;

        public student(string myname, string myemail, int myid)
        {
            this.name = myname;
            this.email = myemail;
            this.id = myid;
        }
        public string getname()
        {
            return this.name;
        }
        public string getemail()
        {
            return this.email;
        }
        public int getid()
        {
            return this.id;
        }
       
    }
   
    
    
}
