using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvAssignLexicon
{
    internal class Person
    {
        private int age;
        private string fName;
        private string lName;
        private double height { get; set; }
        private double weight { get; set; }

        public int Age
        {
            get { return age; }
            set
            {
                age = value;
                if (age < 0)
                {
                    throw new ArgumentException("Age cant be less than 0");
                }
            }
        }

        public string FName
        {
            get { return fName; }
            set
            {
                fName = value;
                if (fName.Length < 2 | fName.Length > 10)
                {
                    throw new ArgumentException("First name needs to be atleast 2 letters and no more than 10");
                }  
            }
        }

        public string LName
        {
            get { return lName; }
            set
            {
                lName = value;
                if (lName.Length < 3 | lName.Length > 15)
                {
                    throw new ArgumentException("Last name needs to be atleast 3 letters and no more than 15");
                }
            }
        }

    public Person(int age, string fName, string lName, double height, double weight)
        {
            Age = age;
            FName = fName;
            LName = lName;
            this.height = height;
            this.weight = weight;
        }

        public string toString()
        {
            return "Name: " + FName + " " + LName + " Age: " + Age;
        }
    }
}
