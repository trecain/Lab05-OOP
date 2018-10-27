using System;
using System.Collections.Generic;
using System.Text;
using Lab05_OOP.Interfaces;

namespace Lab05_OOP.Classes
{
    public abstract class Lizard : DomesticatedAnimals
    {
        public string TailColor { get; set; }
        public Lizard(string name, int legs, string speech, string color, string tail) : base(name, legs, speech, color)
        {
            TailColor = tail;
        }

        public override sealed string RequestFood()
        {
            string res = "*stomach growling* I'm hungry.";
            return res;
        }

        public override string Sleep()
        {
            Console.WriteLine("Knocked out");
            return "Knocked out";
        }
    }
    
}
