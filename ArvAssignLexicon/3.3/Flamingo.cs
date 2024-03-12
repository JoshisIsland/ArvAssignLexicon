using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvAssignLexicon._3._3
{
    internal class Flamingo : Bird
    {
        string color;
        public Flamingo(string name, double weight, int age, int wingSpan, string color) : base(name, weight, age, wingSpan)
        {
            this.color = color;
        }
    }
}
