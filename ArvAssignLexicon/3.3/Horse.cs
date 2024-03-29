﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvAssignLexicon._3._3
{
    internal class Horse : Animal
    {
        Boolean ridable;
        public Horse(string name, double weight, int age, bool ridable) : base(name, weight, age)
        {
            this.ridable = ridable;
        }

        public override string DoSound()
        {
            return "Neigh?";
        }
        public override string Stats()
        {
            return "Name: " + name + " Weight: " + weight + " Age: " + age + " Ridable? " + ridable;
        }
    }
}
