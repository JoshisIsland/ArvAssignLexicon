using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvAssignLexicon._3._2
{
    internal class NoInputError : UserError
    {
        public override string UEMessage()
        {
            return "You didnt input anything in the field. This fired an error!";
        }
    }
}
