using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft;

namespace WorldOfFarthea
{
    public class Character
    {
        public string Name { get; set; }

        public int Health { get; set; }
        public int Attack { get; set; }
        public string Class { get; set; }
        public string Race { get; set; }
        public int Strength { get; set; }
        public int Intellect { get; set; }
        public int Dexterity { get; set; }
        public int Agility { get; set; }
        public int Endurance { get; set; }
        public int Charisma { get; set; }
        public int Luck { get; set; }

        /**public Character(string name, string race, string charClass, int strength, int intellect, int agility, int endurance, int charisma, int luck)
        {
            Name = name;
            Race = race;
            Class = charClass;
            Strength = strength;
            Intellect = intellect;
            Agility = agility;
            Endurance = endurance;
            Charisma = charisma;
            Luck = luck;
        }
        **/

        public Character()
        {

        }

        public override string ToString()
        {
            return $"{Name} - {Class}";
        }

        public static List<Character> LoadCharacters()
        {
            string filePath = @"C:\WorldofFarthea\Characters.json";
            string jsonString;

            if(File.Exists(filePath))
            {
                jsonString = File.ReadAllText(filePath);
                return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Character>>(jsonString);
            }

            return new List<Character>();
        }

        public static void SaveCharacters(List<Character> characters)
        {
            string filePath = @"C:\WorldofFarthea\Characters.json";
            string jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(characters, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(filePath, jsonString);
        }

        public static void UpdateCharacter(Character updatedCharacter)
        {
            List<Character> characters = LoadCharacters();

            int index = LoadCharacters().FindIndex(c  => c.Name == updatedCharacter.Name);

            if(index != -1)
            {
                characters[index] = updatedCharacter;
            }

            SaveCharacters(characters);
        }
    }
}
