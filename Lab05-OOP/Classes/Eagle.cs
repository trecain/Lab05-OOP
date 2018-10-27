using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOP.Classes
{
    public class Eagle : Raccoon
    {
        public Eagle(string name, int legs, string speech, int rabies, bool eatsTrash) : base(name, legs, speech, rabies, eatsTrash)
        {

        }

        public override bool BiteSomeone()
        {
            Console.WriteLine("Chomp, chomp, chomp");
            return true;
        }
    }
}
