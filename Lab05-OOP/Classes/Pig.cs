using System;
using System.Collections.Generic;
using System.Text;
using Lab05_OOP.Interfaces;

namespace Lab05_OOP.Classes
{
    public class Pig : Lizard, ISun, IEats
    {
        /// <summary>
        /// pig constructor 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="legs"></param>
        /// <param name="speech"></param>
        /// <param name="color"></param>
        /// <param name="tail"></param>
        public Pig(string name, int legs, string speech, string color, string tail) : base(name, legs, speech, color, tail)
        {

        }


        /// <summary>
        /// returns true for pig not eating fly
        /// </summary>
        /// <returns></returns>
        public bool EatingFlys()
        {
            Console.WriteLine("slap, gobble, gobble");
            return true;
        }


        /// <summary>
        /// sets sun bathes property
        /// </summary>
        public bool SunBathes { get; set; } = true;


        /// <summary>
        /// runs method and returns a string for sun bathe
        /// </summary>
        /// <returns></returns>
        public string Bathes()
        {
            Console.WriteLine("Simmmmmmerr, it's so hot");
            return "Burn !!!";
        }


        //Returns true if animal is a carnivore
        public bool Carnivore()
        {
            return true;
        }


        /// <summary>
        /// overrides sleep method
        /// </summary>
        /// <returns></returns>
        public override string Sleep()
        {
            Console.WriteLine("I'm sleeping tough");
            return "zzzzzzzzzzzzzz";
        }
    }
}
