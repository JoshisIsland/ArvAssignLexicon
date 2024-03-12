using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvAssignLexicon._3._3
{
    internal class Swan : Bird
    {
        Boolean aggresive;
        public Swan(string name, double weight, int age, int wingSpan, bool aggresive) : base(name, weight, age, wingSpan)
        {
            this.aggresive = aggresive;
        }
    }
}
