﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldOfFarthea
{
    public partial class Form1 : Form
    {

        private bool isApplicationExit;
        public Form1()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void exitGame_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createNew_Button_Click(object sender, EventArgs e)
        {
            using (CharacterCreationForm characterCreationForm = new CharacterCreationForm())
            {
                characterCreationForm.StartPosition = FormStartPosition.Manual;

                characterCreationForm.Location = this.Location;
                characterCreationForm.FormClosing += CharacterCreationForm_FormClosing;


                this.Hide();
                characterCreationForm.ShowDialog();

                if (!isApplicationExit)
                {
                    this.Show();
                }
            }

            
        }

        private void CharacterCreationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.ApplicationExitCall)
            {
                isApplicationExit = true;
            }
        }

        private void loadCharacter_Button_Click(object sender, EventArgs e)
        {
            // Create LoadCharacterForm
            LoadCharacterForm loadCharacterForm = new LoadCharacterForm();
            loadCharacterForm.FormClosedEvent += LoadCharacterForm_FormClosedEvent;

            // Hide this form
            this.Hide();

            // Set the LoadCharacterForm start position and show it
            loadCharacterForm.StartPosition = FormStartPosition.CenterScreen;
            loadCharacterForm.ShowDialog();

            // Show this form only if it's not disposed
            if (!this.IsDisposed)
            {
                this.Show();
            }
        }

        private void LoadCharacterForm_FormClosedEvent()
        {
            // Close this form
            this.Close();
        }
    }
}
