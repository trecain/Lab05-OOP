using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOP.Classes
{
    public class Turkey : Lizard
    {
        public Turkey(string name, int legs, string speech, string color, string tail) : base(name, legs, speech, color, tail)
        {

        }

        public bool Gobble()
        {
            Console.WriteLine("Gobble, gobble, gobble");
            return true;
        }

        public bool Carnivore()
        {
            Console.WriteLine("No way, I don't eat that");
            Sleep();
            return false;
        }
    }
}
