using System;
using System.Collections.Generic;
using System.Text;

namespace MCarpenter_Wk6_Ex1
{
    class Student
    {
        string name;
        string email;
        int studentID;

        public Student()
        {
            this.name = "Morgan Carpenter";
            this.email = "100194uk@saeinstitute.edu";
            this.studentID = 100194;
        }

        public string getName()
        {
            return this.name;
        }
        public string getEmail()
        {
            return this.email;
        }
        public int getID()
        {
            return this.studentID;
        }

        public void setName(string name)
        {
            this.name = name;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }
        public void setID(int ID)
        {
            this.studentID = ID;
        }
    }
}
