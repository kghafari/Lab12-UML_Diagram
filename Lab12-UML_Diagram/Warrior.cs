using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12_UML_Diagram
{
    class Warrior : GameCharacter
    {
        //fields
        string weaponType;

        //properties
        public string WeaponType { get; set; }

        //const
        public Warrior(string _name, int _strength, int _intelligence, string _weaponType)
        {
            Name = _name;
            Strength = _strength;
            Intelligence = _intelligence;
            weaponType = _weaponType;
        }

        //methods

        public override void Play()
        {
            base.Play();
            Console.WriteLine($"Weapon Type: {weaponType}");
        }
    }
}
