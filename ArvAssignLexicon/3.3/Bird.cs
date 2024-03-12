using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvAssignLexicon._3._3
{
    internal class Bird : Animal
    {
        int wingSpan;
        public Bird(string name, double weight, int age, int wingSpan) : base(name, weight, age)
        {
            this.wingSpan = wingSpan;
        }

        public override void DoSound()
        {
            Console.WriteLine("Ka Ka");
        }
    }
}
