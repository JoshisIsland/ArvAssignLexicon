using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvAssignLexicon._3._2
{
    internal class SleepyError : UserError
    {
        public override string UEMessage()
        {
            return "You are too sleepy to code so you get this error.. Go to sleep please";
        }
    }
}
