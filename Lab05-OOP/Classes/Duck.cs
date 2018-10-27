using System;
using System.Collections.Generic;
using System.Text;
using Lab05_OOP.Interfaces;

namespace Lab05_OOP.Classes
{
    class Duck : Raccoon, ISun
    {
        public Duck (string name, int legs, string speech, int rabiesLevel, bool eatsTrash ) : base(name, legs, speech, rabiesLevel, eatsTrash)
        {

        }

        public override bool BiteSomeone()
        {
            Console.WriteLine("Chomp, chomp, chomp");
            return true;
        }

        public bool SunBathes { get; set } = true; 

        public string Bathes()
        {
            Console.WriteLine("Feel that sun on my skin");
            return "Soaking those rays up";
        }
    }
}
