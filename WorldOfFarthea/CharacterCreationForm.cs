using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WorldOfFarthea
{
    public partial class CharacterCreationForm : Form
    {
        public CharacterCreationForm()
        {
            InitializeComponent();

            ToolStripMenuItem fileItem = new ToolStripMenuItem("File");

            ToolStripMenuItem exitGameItem = new ToolStripMenuItem("Exit");
            exitGameItem.Click += new EventHandler(exitGameItem_Click);
            fileItem.DropDownItems.Add(exitGameItem);

            menuStrip1.Items.Add(fileItem);
        }

        private void exitGameItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void characterCreation_Submit_Click(object sender, EventArgs e)
        {
            string characterName = characterNameTextBox.Text;
            string characterClass = GetCharacterClass();
            string characterRace = GetCharacterRace();

            Character newCharacter = new Character(characterName, characterClass, characterRace, 100, 15);

            string filePath = @"C:\WorldofFarthea\Characters.json";
            List<Character> characters = new List<Character>();
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                if (jsonString.StartsWith("["))
                {
                    characters = JsonConvert.DeserializeObject<List<Character>>(jsonString);
                }
                else
                {
                    Character existingCharacter = JsonConvert.DeserializeObject<Character>(jsonString);
                    characters.Add(existingCharacter);
                }
            }

            characters.Add(newCharacter);

            string updatedJsonString = JsonConvert.SerializeObject(characters);

            File.WriteAllText(filePath, updatedJsonString);

            this.Close();

        }

        private string GetCharacterClass()
        {
            if (warrior_Radio.Checked)
            {
                return "Warrior";
            }
            else if (paladin_Radio.Checked)
            {
                return "Paladin";
            }
            else if (priest_Radio.Checked)
            {
                return "Priest";
            }
            else if (hunter_Radio.Checked)
            {
                return "Hunter";
            }else if (deathknight_Radio.Checked)
            {
                return "Death Knight";
            }
            else
            {
                return "Unknown";
            }
        }

        private string GetCharacterRace()
        {
            if (humanRace_Radio.Checked)
            {
                return "Human";
            }
            else if (elfRace_Radio.Checked)
            {
                return "Elf";
            }
            else if (dwarfRace_Radio.Checked)
            {
                return "Dwarf";
            }
            else if (orcRace_Radio.Checked)
            {
                return "Orc";
            }
            else
            {
                return "Unknown";
            }
        }
    }
}
