using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldOfFarthea
{
    public class MonsterRepository
    {
        public List<Monster> Monsters { get; set; }

        public MonsterRepository()
        {
            Monsters = new List<Monster>
            {
                // Monster(Name, Level, Health, Mana, AttackDamage)
                new Monster("Goblin", 1, 100, 0, 20),
                new Monster("Slime", 1, 50, 0, 5),
            };
        }

        public Monster GetMonsterByName(string name)
        {
            return Monsters.FirstOrDefault(monster => monster.Name == name);
        }
    }
}
