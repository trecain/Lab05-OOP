using System;
using System.Collections.Generic;
using System.Text;
using Lab05_OOP.Interfaces;

namespace Lab05_OOP.Classes
{
    public class Pig : Lizard, ISun, IEats
    {
        public Pig(string name, int legs, string speech, string color, string tail) : base(name, legs, speech, color, tail)
        {

        }

        public bool EatingFlys()
        {
            Console.WriteLine("slap, gobble, gobble");
            return true;
        }

        public bool SunBathes { get; set; } = true;

        public string Bathes()
        {
            Console.WriteLine("Simmmmmmerr, it's so hot");
            return "Burn !!!";
        }

        public bool Carnivore()
        {
            return true;
        }

        public override string Sleep()
        {
            Console.WriteLine("I'm sleeping tough");
            return "zzzzzzzzzzzzzz";
        }
    }
}
