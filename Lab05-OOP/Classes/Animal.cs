using System;
using System.Collections.Generic;
using System.Text;

namespace Lab05_OOP.Classes
{
    public abstract class Animal
    {
        /// <summary>
        /// base animal class that sets three properties
        /// Name, Legs, Speech
        /// </summary>
        public string Name { get; set; }
        public int Legs { get; set; }
        private string Speech { get; set; }

        public Animal(string name, int legs, string speech)
        {
            Name = name;
            Legs = legs;
            Speech = speech;
        }


        /// <summary>
        /// virtual method that returns a string and cand be used or overrided
        /// </summary>
        /// <returns></returns>
        public virtual string Sleep()
        {
            Console.WriteLine("ZZZZZZZzzzzzzzz");
            return "Goodnight";
        }


        /// <summary>
        /// returns the animals speech property
        /// </summary>
        /// <returns></returns>
        public string UserSpeech()
        {
            return Speech;
        }
    }
}
