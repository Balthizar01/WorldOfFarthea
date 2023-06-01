using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldOfFarthea
{
    public class Character
    {
        public string Name { get; set; }

        public int Health { get; set; }
        public int Attack { get; set; }
        public string Class { get; set; }
        public string Race { get; set; }

        public Character(string name, string characterClass, string race, int health, int attack)
        {
            Name = name;
            Class = characterClass;
            Race = race;
            Health = health;
            Attack = attack;
            
        }
    }
}
