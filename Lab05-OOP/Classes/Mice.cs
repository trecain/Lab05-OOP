using System;
using System.Collections.Generic;
using System.Text;
using Lab05_OOP.Interfaces;

namespace Lab05_OOP.Classes
{
    public class Mice : WildAnimals, IEats
    {
        private string Disease { get; set; }

        public Mice(string name, int legs, string speech, int rabies, string disease) : base(name, legs, speech, rabies)
        {
            Disease = disease;
        }

        public override bool BiteSomeone()
        {
            Console.WriteLine("Chomp, chomp, chomp");
            return true;
        }

        public bool Carnivore()
        {
            Console.WriteLine("Bite");

            return true;
        }

    }
}
