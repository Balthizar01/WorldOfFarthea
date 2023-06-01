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
using System.Diagnostics;
using WorldOfFarthea.Forms;

namespace WorldOfFarthea
{
    public partial class CharacterCreationForm : BaseForm
    {
        private int statPointsRemaining = 10;
        public CharacterCreationForm()
        {
            InitializeComponent();
            statPoints.Text = statPointsRemaining.ToString();

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
            Character newCharacter = new Character()
            {
                Name = characterNameTextBox.Text,
                Race = GetCharacterRace(),
                Class = GetCharacterClass(),
                Strength = int.Parse(strengthStat.Text),
                Intellect = int.Parse(intellectStat.Text),
                Agility = int.Parse(agilityStat.Text),
                Endurance = int.Parse(enduranceStat.Text),
                Charisma = int.Parse(charismaStat.Text),
                Luck = int.Parse(luckStat.Text)
            };

            List<Character> characters = Character.LoadCharacters();
            characters.Add(newCharacter);
            Character.SaveCharacters(characters);

            this.Hide();
            GameScreen gameScreen = new GameScreen(newCharacter);
            gameScreen.StartPosition = FormStartPosition.Manual;
            gameScreen.Location = this.Location;
            gameScreen.FormClosed += (s, args) => this.Close();
            gameScreen.Show();

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

        private void back_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void strengthPlusButton_Click(object sender, EventArgs e)
        {
            if(statPointsRemaining > 0)
            {
                int strength = int.Parse(strengthStat.Text);
                strength++;
                strengthStat.Text = strength.ToString();
                statPointsRemaining--;
                statPoints.Text = statPointsRemaining.ToString();
            }
            else
            {
                strengthPlusButton.Visible = false;
            }
        }

        private void strengthMinusButton_Click(object sender, EventArgs e)
        {
            if (statPointsRemaining >= 0)
            {
                int strength = int.Parse(strengthStat.Text);
                strength--;
                strengthStat.Text = strength.ToString();
                statPointsRemaining++;
                statPoints.Text = statPointsRemaining.ToString();
            }
            else
            {
                strengthMinusButton.Visible = false;
            }
        }

        private void intellectPlusButton_Click(object sender, EventArgs e)
        {
            if (statPointsRemaining > 0)
            {
                int intellect = int.Parse(intellectStat.Text);
                intellect++;
                intellectStat.Text = intellect.ToString();
                statPointsRemaining--;
                statPoints.Text = statPointsRemaining.ToString();
            }
            else
            {
                intellectPlusButton.Visible = false;
            }
        }

        private void intellectMinusButton_Click(object sender, EventArgs e)
        {

            if (statPointsRemaining >= 0)
            {
                int intellect = int.Parse(intellectStat.Text);
                intellect--;
                intellectStat.Text = intellect.ToString();
                statPointsRemaining++;
                statPoints.Text = statPointsRemaining.ToString();
            }
            else
            {
                intellectMinusButton.Visible = false;
            }
        }

        private void agilityPlusButton_Click(object sender, EventArgs e)
        {
            if (statPointsRemaining > 0)
            {
                int agility = int.Parse(agilityStat.Text);
                agility++;
                agilityStat.Text = agility.ToString();
                statPointsRemaining--;
                statPoints.Text = statPointsRemaining.ToString();
            }
            else
            {
                agilityPlusButton.Visible = false;
            }
        }

        private void agilityMinusButton_Click(object sender, EventArgs e)
        {
            if (statPointsRemaining >= 0)
            {
                int agility = int.Parse(agilityStat.Text);
                agility--;
                agilityStat.Text = agility.ToString();
                statPointsRemaining++;
                statPoints.Text = statPointsRemaining.ToString();
            }
            else
            {
                agilityMinusButton.Visible = false;
            }
        }

        private void endurancePlusButton_Click(object sender, EventArgs e)
        {
            if (statPointsRemaining > 0)
            {
                int endurance = int.Parse(enduranceStat.Text);
                endurance++;
                enduranceStat.Text = endurance.ToString();
                statPointsRemaining--;
                statPoints.Text = statPointsRemaining.ToString();
            }
            else
            {
                endurancePlusButton.Visible = false;
            }
        }

        private void enduranceMinusButton_Click(object sender, EventArgs e)
        {
            if (statPointsRemaining >= 0)
            {
                int endurance = int.Parse(enduranceStat.Text);
                endurance--;
                enduranceStat.Text = endurance.ToString();
                statPointsRemaining++;
                statPoints.Text = statPointsRemaining.ToString();
            }
            else
            {
                enduranceMinusButton.Visible = false;
            }
        }

        private void charismaPlusButton_Click(object sender, EventArgs e)
        {
            if (statPointsRemaining > 0)
            {
                int charisma = int.Parse(charismaStat.Text);
                charisma++;
                charismaStat.Text = charisma.ToString();
                statPointsRemaining--;
                statPoints.Text = statPointsRemaining.ToString();
            }
            else
            {
                charismaPlusButton.Visible = false;
            }
        }

        private void charismaMinusButton_Click(object sender, EventArgs e)
        {
            if (statPointsRemaining >= 0)
            {
                int charisma = int.Parse(charismaStat.Text);
                charisma--;
                charismaStat.Text = charisma.ToString();
                statPointsRemaining++;
                statPoints.Text = statPointsRemaining.ToString();
            }
            else
            {
                charismaMinusButton.Visible = false;
            }
        }

        private void luckPlusButton_Click(object sender, EventArgs e)
        {
            if (statPointsRemaining > 0)
            {
                int luck = int.Parse(luckStat.Text);
                luck++;
                luckStat.Text = luck.ToString();
                statPointsRemaining--;
                statPoints.Text = statPointsRemaining.ToString();
            }
            else
            {
                luckPlusButton.Visible = false;
            }
        }

        private void luckMinusButton_Click(object sender, EventArgs e)
        {
            if (statPointsRemaining >= 0)
            {
                int luck = int.Parse(luckStat.Text);
                luck--;
                luckStat.Text = luck.ToString();
                statPointsRemaining++;
                statPoints.Text = statPointsRemaining.ToString();
            }
            else
            {
                luckMinusButton.Visible = false;
            }
        }
    }
}
