using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOP.Classes
{
    public abstract class WildAnimals : Animal
    {
        public int RabiesLevel { get; set; }

        public WildAnimals(string name, int legs, string speech, int rabies) : base(name, legs, speech)
        {
            RabiesLevel = rabies;
        }

        public abstract bool BiteSomeone();
    }
}
