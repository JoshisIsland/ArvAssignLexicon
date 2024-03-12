using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvAssignLexicon._3._3
{
    internal class Hedgehog : Animal
    {
        int spikes;
        public Hedgehog(string name, double weight, int age, int spikes) : base(name, weight, age)
        {
            this.spikes = spikes;
        }

        public override string DoSound()
        {
            return "Squek";
        }
        public override string Stats()
        {
            return "Name: " + name + " Weight: " + weight + " Age: " + age + " Number of spikes: " + spikes;
        }
    }
}
