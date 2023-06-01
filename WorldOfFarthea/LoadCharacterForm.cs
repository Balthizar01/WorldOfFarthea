using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace WorldOfFarthea
{
    public partial class LoadCharacterForm : Form
    {
        public LoadCharacterForm()
        {
            InitializeComponent();

            ToolStripMenuItem fileItem = new ToolStripMenuItem("File");

            ToolStripMenuItem exitGameItem = new ToolStripMenuItem("Exit");
            exitGameItem.Click += new EventHandler(exitGameItem_Click);
            fileItem.DropDownItems.Add(exitGameItem);

            menuStrip1.Items.Add(fileItem);

            string filePath = @"C:\WorldofFarthea\Characters.json";
            List<Character> characters = new List<Character>();
            if (File.Exists(filePath)){
                string jsonString = File.ReadAllText(filePath);
                characters = JsonConvert.DeserializeObject<List<Character>>(jsonString);
            }

            foreach(Character character in characters)
            {
                loadCharacter_ListBox.Items.Add(character.Name);
            }
        }

        private void exitGameItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
