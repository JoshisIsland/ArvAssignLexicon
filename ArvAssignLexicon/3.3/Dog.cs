using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvAssignLexicon._3._3
{
    internal class Dog : Animal
    {
        Boolean goodBoy;
        public Dog(string name, double weight, int age, bool goodBoy) : base(name, weight, age)
        {
            this.goodBoy = goodBoy;
        }

        public override void DoSound()
        {
            Console.WriteLine("Woooof");
        }
    }
}
