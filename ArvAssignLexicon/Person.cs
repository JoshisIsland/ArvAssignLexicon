using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvAssignLexicon
{
    internal class Person
    {
        private int age
        {
            get { return age; }
            set
            {
                if (age > 0)
                { age = value; }
                else
                {
                    Console.WriteLine("Cant be below 0");
                }
            }
        }
        private string fName { get; set; }
        private string lName { get; set; }
        private int height { get; set; }
        private int weight { get; set; }

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
            return "Name: " + fName + " " + lName + " Age: " + age;
        }
    }
}
