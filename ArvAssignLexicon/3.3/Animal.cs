using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvAssignLexicon._3._3
{
    abstract class Animal
    {
        string name;
        double weight;
        int age;

        public Animal(string name, double weight, int age)
        {
            this.name = name;
            this.weight = weight;
            this.age = age;
        }

        public abstract void DoSound();
    }
}
