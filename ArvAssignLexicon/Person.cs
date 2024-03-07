using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvAssignLexicon
{
    internal class Person
    {
        private int age { get; set; }
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
    }
}
