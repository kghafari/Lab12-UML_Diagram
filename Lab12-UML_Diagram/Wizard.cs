using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12_UML_Diagram
{
    class Wizard : MagicUsingCharacter
    {
        //fields
        int spellNumber;
        //prop
        public int SpellNumber { get; set; }

        //const
        public Wizard()
        {

        }

        public Wizard(string _name, int _strength, int _intelligence, int _magicalEnergy, int _spellNumber)
        {
            Name = _name;
            Strength = _strength;
            Intelligence = _intelligence;
            MagicalEnergy = _magicalEnergy;
            spellNumber = _spellNumber;
        }

        //methods
        public override void Play()
        {
            base.Play();
            Console.WriteLine($"Number of Spells: {spellNumber}");
        }

    }
}
