using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvAssignLexicon._3._2
{
    internal class StupidError : UserError
    {
        public override string UEMessage()
        {
            return "You are stupid and deserves this error message";
        }
    }
}
