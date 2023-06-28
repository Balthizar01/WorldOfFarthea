using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace WorldOfFarthea
{
    public partial class Form1 : BaseForm
    {

        private bool isApplicationExit;
        private WindowsMediaPlayer mediaPlayer;
        Timer delayTimer;
        public Form1()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            WindowsMediaPlayer1.URL = "E:\\CS Projects\\WorldOfFarthea\\WorldOfFarthea\\Audio\\mainScreenBackground_1.mp4";
            WindowsMediaPlayer1.uiMode = "none";
            WindowsMediaPlayer1.settings.setMode("loop", true);
            WindowsMediaPlayer1.Ctlcontrols.play();

            mediaPlayer = new WindowsMediaPlayer();
            mediaPlayer.URL = "E:\\CS Projects\\WorldOfFarthea\\WorldOfFarthea\\Audio\\mainMenu.mp3";
            mediaPlayer.settings.setMode("loop", true);
            mediaPlayer.controls.play();

            delayTimer = new Timer();
            delayTimer.Interval = 2000; // 3 seconds
            delayTimer.Tick += DelayTimer_Tick;

        }

        private void PlaySound(string soundFilePath)
        {
            SoundPlayer soundPlayer = new SoundPlayer(soundFilePath);
            soundPlayer.Play();
        }

        private void StartTimer(Action action)
        {
            // Assign the action to be executed when the timer ticks
            delayTimer.Tag = action;
            delayTimer.Start();
        }

        private void DelayTimer_Tick(object sender, EventArgs e)
        {
            // Stop the timer
            delayTimer.Stop();

            // Execute the action assigned to the timer
            Action action = delayTimer.Tag as Action;
            action?.Invoke();
        }
        private void exitGame_Button_Click(object sender, EventArgs e)
        {
            PlaySound("E:\\CS Projects\\WorldOfFarthea\\WorldOfFarthea\\Audio\\playerSelect.wav");
            StartTimer(() =>
            {
                this.Close();
            });
            
        }

        private void createNew_Button_Click(object sender, EventArgs e)
        {
            PlaySound("E:\\CS Projects\\WorldOfFarthea\\WorldOfFarthea\\Audio\\playerSelect.wav");
            StartTimer(() =>
            {
                using (CharacterCreationForm characterCreationForm = new CharacterCreationForm())
                {
                    characterCreationForm.StartPosition = FormStartPosition.Manual;
                    characterCreationForm.Location = this.Location;

                    // Hide current form
                    this.Hide();
                    mediaPlayer.controls.stop();
                    WindowsMediaPlayer1.Ctlcontrols.stop();

                    // Show the character creation form
                    characterCreationForm.ShowDialog();

                    // Show this form again
                    this.Show();
                    mediaPlayer.controls.play();
                    WindowsMediaPlayer1.Ctlcontrols.play();
                }
            });
            


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
            PlaySound("E:\\CS Projects\\WorldOfFarthea\\WorldOfFarthea\\Audio\\playerSelect.wav");

            StartTimer(() =>
            {
                using(LoadCharacterForm loadCharacterForm = new LoadCharacterForm())
                {
                    loadCharacterForm.StartPosition = FormStartPosition.Manual;
                    loadCharacterForm.Location = this.Location;

                    // Hide this form (Form1)
                    this.Hide();
                    mediaPlayer.controls.stop();
                    WindowsMediaPlayer1.Ctlcontrols.stop();

                    // Set the LoadCharacterForm start position and show it
                    loadCharacterForm.ShowDialog();

                    // Show this form again
                    this.Show();
                    mediaPlayer.controls.play();
                    WindowsMediaPlayer1.Ctlcontrols.play();

                }
            });


            

            
        }

    }
}
