using System;
using System.Collections.Generic;
using System.Text;

namespace exeClasses
{
    class Student
    {
        public Student(string email, string name, int age)
        {
            this.em = email;
            this.years = age;
            this.nam = name;



        }
        string em; string nam; int years;

        public string getName()
        {
            return this.nam;
        }
        public int getAge()
        {
            return this.years;
        }
        public string getEmail()
        {
            return this.em;
        }

    }
}
