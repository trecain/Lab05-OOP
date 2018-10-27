using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOP.Classes
{
    public abstract class Raccoon : WildAnimals
    {
        public bool EatsTrash { get; set; }
        public Raccoon(string name, int legs, string speech, int rabies, bool eatsTrash) : base(name, legs, speech, rabies )
        {
            EatsTrash = eatsTrash;
        }

        public bool CanScratch()
        {
            return true;
        }

        public override string Sleep()
        {
            Console.WriteLine("Goodnight");
            return "zzzzzzzzzZZZZZZZZ";
        }
    }
}
