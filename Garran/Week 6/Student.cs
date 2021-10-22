namespace Classes
{
    class Student
    {
        string name;
        string email;
        int number;


        public Student(string myName, string myEmail, int myNumber)
        {
            this.name = myName;
            this.email = myEmail;
            this.number = myNumber;
        }

        //getter methods
        public string getName()
        {
            return this.name;
        }

        public string getEmail()
        {
            return this.email;
        }

        public int getNumber()
        {
            return this.number;
        }
    }
}
