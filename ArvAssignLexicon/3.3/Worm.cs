using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvAssignLexicon._3._3
{
    internal class Worm : Animal
    {
        double length;
        public Worm(string name, double weight, int age, double length) : base(name, weight, age)
        {
            this.length = length;
        }

        public override string DoSound()
        {
            return "Wiggle wiggle wiggle";
        }
        public override string Stats()
        {
            return "Name: " + name + " Weight: " + weight + " Age: " + age + " Length: " + length;
        }
    }
}
