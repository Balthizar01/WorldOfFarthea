﻿using System;
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
using WorldOfFarthea.Forms;

namespace WorldOfFarthea
{
    public partial class LoadCharacterForm : BaseForm
    {
        public LoadCharacterForm()
        {
            InitializeComponent();

            string filePath = @"C:\WorldofFarthea\Characters.json";
            List<Character> characters = new List<Character>();
            if (File.Exists(filePath)){
                string jsonString = File.ReadAllText(filePath);
                characters = JsonConvert.DeserializeObject<List<Character>>(jsonString);
            }

            foreach(Character character in characters)
            {
                loadCharacter_ListBox.Items.Add(character);
            }
        }

        private void loadCharacter_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_Button.Visible = loadCharacter_ListBox.SelectedIndex != -1;
            back_Button.Location = new Point(280, 350);
            load_Button.Location = new Point(400, 350);
        }

        private void exitGameItem_Click(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void load_Button_Click(object sender, EventArgs e)
        {
            Character selectedCharacter = (Character)loadCharacter_ListBox.SelectedItem;

            GameScreen gameScreen = new GameScreen(selectedCharacter);

            this.Hide();
            gameScreen.StartPosition = FormStartPosition.CenterScreen;
            gameScreen.ShowDialog();

            this.Close();
        }
    }
}
