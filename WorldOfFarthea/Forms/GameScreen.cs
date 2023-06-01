using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldOfFarthea.Forms
{
    public partial class GameScreen : BaseForm
    {

        public Character PlayerCharacter { get; set; }
        public GameScreen(Character character)
        {
            InitializeComponent();
            PlayerCharacter = character;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Character.UpdateCharacter(PlayerCharacter);

            MessageBox.Show("Character saved successfully!");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
