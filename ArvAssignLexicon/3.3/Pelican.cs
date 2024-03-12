using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvAssignLexicon._3._3
{
    internal class Pelican : Bird
    {
        int sizeOfBeak;
        public Pelican(string name, double weight, int age, int wingSpan, int sizeOfBeak) : base(name, weight, age, wingSpan)
        {
            this.sizeOfBeak = sizeOfBeak;
        }
    }
}
