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
        private int height { get; set; }
        private int weight { get; set; }

        public int Age
        {
            get { return age; }
            set
            {
                if (age > 10)
                {
                    age = value;
                } else
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
                if (fName.Length > 2 && fName.Length < 10)
                {
                    fName = value;
                } else
                {
                    throw new ArgumentException("First name needs to be atleast 2 and no more than 10");
                }
            }
        }

        public string LName
        {
            get { return lName; }
            set
            {
                if (lName.Length > 3 && lName.Length < 15)
                {
                    lName = value;
                } else
                {
                    throw new ArgumentException("Last name needs to be atleast 3 and no more than 15");
                }
            }
        }

    public Person(int age, string fName, string lName, int height, int weight)
        {
            this.age = age;
            this.fName = fName;
            this.lName = lName;
            this.height = height;
            this.weight = weight;
        }

        public string toString()
        {
            return "Name: " + FName + " " + LName + " Age: " + Age;
        }
    }
}
