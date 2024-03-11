using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ArvAssignLexicon
{
    internal class PersonHandler
    {
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        public void setFName(Person pers, string fName)
        {
            pers.FName = fName;
        }

        public void setLName(Person pers, string lName)
        {
            pers.LName = lName;
        }

        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person newPerson = new Person(age, fname, lname, height, weight);

            return newPerson;
        }
    }
}
