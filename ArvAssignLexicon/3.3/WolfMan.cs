using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvAssignLexicon._3._3
{
    internal class WolfMan : Wolf, IPerson
    {
        public WolfMan(string name, double weight, int age, bool partOfPack) : base(name, weight, age, partOfPack)
        {
        }

        public string Talk()
        {
            return "what am I..";
        }
    }
}
