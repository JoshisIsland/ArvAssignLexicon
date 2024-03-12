using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvAssignLexicon._3._3
{
    abstract class Animal
    {
        //F: Behöver alla djur ett nytt attribut borde dessa implementeras i animal klassen
        public string name;
        public double weight;
        public int age;

        public Animal(string name, double weight, int age)
        {
            this.name = name;
            this.weight = weight;
            this.age = age;
        }

        public abstract string DoSound();

        public virtual string Stats() { return "Name: " + name + " Weight: " + weight + " Age: "+ age; }
    }
}
