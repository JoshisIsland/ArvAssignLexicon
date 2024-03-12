﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvAssignLexicon._3._3
{
    internal class Wolf : Animal
    {
        Boolean partOfPack;
        public Wolf(string name, double weight, int age, bool partOfPack) : base(name, weight, age)
        {
            this.partOfPack = partOfPack;
        }

        public override void DoSound()
        {
            Console.WriteLine("Howl");
        }
    }
}
