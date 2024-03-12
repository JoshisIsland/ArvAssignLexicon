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

        public override void DoSound()
        {
            Console.WriteLine("Wiggle wiggle wiggle");
        }
    }
}
