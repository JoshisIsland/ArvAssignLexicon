using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvAssignLexicon._3._3
{
    internal class Bird : Animal
    {
        //F: Nya attribut för samtliga fåglar borde implemnteras i bird klassen
        int wingSpan;
        public Bird(string name, double weight, int age, int wingSpan) : base(name, weight, age)
        {
            this.wingSpan = wingSpan;
        }

        public override string DoSound()
        {
            return "Ka Ka";
        }

        public override string Stats()
        {
            return "Name: " + name + " Weight: " + weight + " Age: " + age + " Wingspan" + wingSpan;
        }
    }
}
