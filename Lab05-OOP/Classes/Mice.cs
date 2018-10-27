using System;
using System.Collections.Generic;
using System.Text;
using Lab05_OOP.Interfaces;

namespace Lab05_OOP.Classes
{
    public class Mice : WildAnimals, IEats
    {
        /// <summary>
        /// creates disease property for mice class
        /// </summary>
        private string Disease { get; set; }


        /// <summary>
        /// Constructor for Mice class and sets the disease property
        /// </summary>
        /// <param name="name"></param>
        /// <param name="legs"></param>
        /// <param name="speech"></param>
        /// <param name="rabies"></param>
        /// <param name="disease"></param>
        public Mice(string name, int legs, string speech, int rabies, string disease) : base(name, legs, speech, rabies)
        {
            Disease = disease;
        }


        /// <summary>
        /// returns true that raccoon can bite someone
        /// </summary>
        /// <returns></returns>
        public override bool BiteSomeone()
        {
            Console.WriteLine("Chomp, chomp, chomp");
            return true;
        }


        /// <summary>
        /// returns true if raccoon is a carnivore
        /// </summary>
        /// <returns></returns>
        public bool Carnivore()
        {
            Console.WriteLine("Bite");

            return true;
        }

    }
}
