using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldOfFarthea
{
    public class Monster
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }
        public int AttackDamage { get; set; }


        public Monster(string name, int level, int health, int mana, int attackDamage)
        {
            Name = name;
            Level = level;
            Health = health;
            Mana = mana;
            AttackDamage = attackDamage;
        }
    }
}
