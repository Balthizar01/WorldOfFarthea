namespace WorldOfFarthea
{
    partial class CharacterCreationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title_Label = new System.Windows.Forms.Label();
            this.characterName_Label = new System.Windows.Forms.Label();
            this.characterNameTextBox = new System.Windows.Forms.TextBox();
            this.characterClass_Label = new System.Windows.Forms.Label();
            this.warrior_Radio = new System.Windows.Forms.RadioButton();
            this.paladin_Radio = new System.Windows.Forms.RadioButton();
            this.priest_Radio = new System.Windows.Forms.RadioButton();
            this.hunter_Radio = new System.Windows.Forms.RadioButton();
            this.deathknight_Radio = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.characterCreation_Submit = new System.Windows.Forms.Button();
            this.race_Label = new System.Windows.Forms.Label();
            this.humanRace_Radio = new System.Windows.Forms.RadioButton();
            this.elfRace_Radio = new System.Windows.Forms.RadioButton();
            this.dwarfRace_Radio = new System.Windows.Forms.RadioButton();
            this.orcRace_Radio = new System.Windows.Forms.RadioButton();
            this.class_groupBox = new System.Windows.Forms.GroupBox();
            this.race_groupBox = new System.Windows.Forms.GroupBox();
            this.class_groupBox.SuspendLayout();
            this.race_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_Label
            // 
            this.title_Label.AutoSize = true;
            this.title_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_Label.Location = new System.Drawing.Point(254, 50);
            this.title_Label.Name = "title_Label";
            this.title_Label.Size = new System.Drawing.Size(288, 39);
            this.title_Label.TabIndex = 0;
            this.title_Label.Text = "Character Creator";
            // 
            // characterName_Label
            // 
            this.characterName_Label.AutoSize = true;
            this.characterName_Label.Location = new System.Drawing.Point(30, 122);
            this.characterName_Label.Name = "characterName_Label";
            this.characterName_Label.Size = new System.Drawing.Size(41, 13);
            this.characterName_Label.TabIndex = 1;
            this.characterName_Label.Text = "Name: ";
            // 
            // characterNameTextBox
            // 
            this.characterNameTextBox.Location = new System.Drawing.Point(66, 119);
            this.characterNameTextBox.Name = "characterNameTextBox";
            this.characterNameTextBox.Size = new System.Drawing.Size(144, 20);
            this.characterNameTextBox.TabIndex = 2;
            // 
            // characterClass_Label
            // 
            this.characterClass_Label.AutoSize = true;
            this.characterClass_Label.Location = new System.Drawing.Point(7, 19);
            this.characterClass_Label.Name = "characterClass_Label";
            this.characterClass_Label.Size = new System.Drawing.Size(35, 13);
            this.characterClass_Label.TabIndex = 3;
            this.characterClass_Label.Text = "Class:";
            // 
            // warrior_Radio
            // 
            this.warrior_Radio.AutoSize = true;
            this.warrior_Radio.Location = new System.Drawing.Point(49, 19);
            this.warrior_Radio.Name = "warrior_Radio";
            this.warrior_Radio.Size = new System.Drawing.Size(59, 17);
            this.warrior_Radio.TabIndex = 4;
            this.warrior_Radio.TabStop = true;
            this.warrior_Radio.Text = "Warrior";
            this.warrior_Radio.UseVisualStyleBackColor = true;
            // 
            // paladin_Radio
            // 
            this.paladin_Radio.AutoSize = true;
            this.paladin_Radio.Location = new System.Drawing.Point(49, 43);
            this.paladin_Radio.Name = "paladin_Radio";
            this.paladin_Radio.Size = new System.Drawing.Size(60, 17);
            this.paladin_Radio.TabIndex = 5;
            this.paladin_Radio.TabStop = true;
            this.paladin_Radio.Text = "Paladin";
            this.paladin_Radio.UseVisualStyleBackColor = true;
            // 
            // priest_Radio
            // 
            this.priest_Radio.AutoSize = true;
            this.priest_Radio.Location = new System.Drawing.Point(49, 67);
            this.priest_Radio.Name = "priest_Radio";
            this.priest_Radio.Size = new System.Drawing.Size(51, 17);
            this.priest_Radio.TabIndex = 6;
            this.priest_Radio.TabStop = true;
            this.priest_Radio.Text = "Priest";
            this.priest_Radio.UseVisualStyleBackColor = true;
            // 
            // hunter_Radio
            // 
            this.hunter_Radio.AutoSize = true;
            this.hunter_Radio.Location = new System.Drawing.Point(49, 91);
            this.hunter_Radio.Name = "hunter_Radio";
            this.hunter_Radio.Size = new System.Drawing.Size(57, 17);
            this.hunter_Radio.TabIndex = 7;
            this.hunter_Radio.TabStop = true;
            this.hunter_Radio.Text = "Hunter";
            this.hunter_Radio.UseVisualStyleBackColor = true;
            // 
            // deathknight_Radio
            // 
            this.deathknight_Radio.AutoSize = true;
            this.deathknight_Radio.Location = new System.Drawing.Point(49, 115);
            this.deathknight_Radio.Name = "deathknight_Radio";
            this.deathknight_Radio.Size = new System.Drawing.Size(87, 17);
            this.deathknight_Radio.TabIndex = 8;
            this.deathknight_Radio.TabStop = true;
            this.deathknight_Radio.Text = "Death Knight";
            this.deathknight_Radio.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // characterCreation_Submit
            // 
            this.characterCreation_Submit.Location = new System.Drawing.Point(340, 350);
            this.characterCreation_Submit.Name = "characterCreation_Submit";
            this.characterCreation_Submit.Size = new System.Drawing.Size(114, 45);
            this.characterCreation_Submit.TabIndex = 10;
            this.characterCreation_Submit.Text = "Create";
            this.characterCreation_Submit.UseVisualStyleBackColor = true;
            this.characterCreation_Submit.Click += new System.EventHandler(this.characterCreation_Submit_Click);
            // 
            // race_Label
            // 
            this.race_Label.AutoSize = true;
            this.race_Label.Location = new System.Drawing.Point(17, 19);
            this.race_Label.Name = "race_Label";
            this.race_Label.Size = new System.Drawing.Size(36, 13);
            this.race_Label.TabIndex = 11;
            this.race_Label.Text = "Race:";
            // 
            // humanRace_Radio
            // 
            this.humanRace_Radio.AutoSize = true;
            this.humanRace_Radio.Location = new System.Drawing.Point(60, 19);
            this.humanRace_Radio.Name = "humanRace_Radio";
            this.humanRace_Radio.Size = new System.Drawing.Size(59, 17);
            this.humanRace_Radio.TabIndex = 12;
            this.humanRace_Radio.TabStop = true;
            this.humanRace_Radio.Text = "Human";
            this.humanRace_Radio.UseVisualStyleBackColor = true;
            // 
            // elfRace_Radio
            // 
            this.elfRace_Radio.AutoSize = true;
            this.elfRace_Radio.Location = new System.Drawing.Point(60, 43);
            this.elfRace_Radio.Name = "elfRace_Radio";
            this.elfRace_Radio.Size = new System.Drawing.Size(37, 17);
            this.elfRace_Radio.TabIndex = 13;
            this.elfRace_Radio.TabStop = true;
            this.elfRace_Radio.Text = "Elf";
            this.elfRace_Radio.UseVisualStyleBackColor = true;
            // 
            // dwarfRace_Radio
            // 
            this.dwarfRace_Radio.AutoSize = true;
            this.dwarfRace_Radio.Location = new System.Drawing.Point(60, 67);
            this.dwarfRace_Radio.Name = "dwarfRace_Radio";
            this.dwarfRace_Radio.Size = new System.Drawing.Size(53, 17);
            this.dwarfRace_Radio.TabIndex = 14;
            this.dwarfRace_Radio.TabStop = true;
            this.dwarfRace_Radio.Text = "Dwarf";
            this.dwarfRace_Radio.UseVisualStyleBackColor = true;
            // 
            // orcRace_Radio
            // 
            this.orcRace_Radio.AutoSize = true;
            this.orcRace_Radio.Location = new System.Drawing.Point(60, 91);
            this.orcRace_Radio.Name = "orcRace_Radio";
            this.orcRace_Radio.Size = new System.Drawing.Size(42, 17);
            this.orcRace_Radio.TabIndex = 15;
            this.orcRace_Radio.TabStop = true;
            this.orcRace_Radio.Text = "Orc";
            this.orcRace_Radio.UseVisualStyleBackColor = true;
            // 
            // class_groupBox
            // 
            this.class_groupBox.Controls.Add(this.warrior_Radio);
            this.class_groupBox.Controls.Add(this.characterClass_Label);
            this.class_groupBox.Controls.Add(this.paladin_Radio);
            this.class_groupBox.Controls.Add(this.priest_Radio);
            this.class_groupBox.Controls.Add(this.hunter_Radio);
            this.class_groupBox.Controls.Add(this.deathknight_Radio);
            this.class_groupBox.Location = new System.Drawing.Point(33, 154);
            this.class_groupBox.Name = "class_groupBox";
            this.class_groupBox.Size = new System.Drawing.Size(200, 148);
            this.class_groupBox.TabIndex = 16;
            this.class_groupBox.TabStop = false;
            // 
            // race_groupBox
            // 
            this.race_groupBox.Controls.Add(this.humanRace_Radio);
            this.race_groupBox.Controls.Add(this.race_Label);
            this.race_groupBox.Controls.Add(this.orcRace_Radio);
            this.race_groupBox.Controls.Add(this.elfRace_Radio);
            this.race_groupBox.Controls.Add(this.dwarfRace_Radio);
            this.race_groupBox.Location = new System.Drawing.Point(261, 154);
            this.race_groupBox.Name = "race_groupBox";
            this.race_groupBox.Size = new System.Drawing.Size(200, 148);
            this.race_groupBox.TabIndex = 17;
            this.race_groupBox.TabStop = false;
            // 
            // CharacterCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.race_groupBox);
            this.Controls.Add(this.class_groupBox);
            this.Controls.Add(this.characterCreation_Submit);
            this.Controls.Add(this.characterNameTextBox);
            this.Controls.Add(this.characterName_Label);
            this.Controls.Add(this.title_Label);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CharacterCreationForm";
            this.Text = "Character Creator";
            this.class_groupBox.ResumeLayout(false);
            this.class_groupBox.PerformLayout();
            this.race_groupBox.ResumeLayout(false);
            this.race_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_Label;
        private System.Windows.Forms.Label characterName_Label;
        private System.Windows.Forms.TextBox characterNameTextBox;
        private System.Windows.Forms.Label characterClass_Label;
        private System.Windows.Forms.RadioButton warrior_Radio;
        private System.Windows.Forms.RadioButton paladin_Radio;
        private System.Windows.Forms.RadioButton priest_Radio;
        private System.Windows.Forms.RadioButton hunter_Radio;
        private System.Windows.Forms.RadioButton deathknight_Radio;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button characterCreation_Submit;
        private System.Windows.Forms.Label race_Label;
        private System.Windows.Forms.RadioButton humanRace_Radio;
        private System.Windows.Forms.RadioButton elfRace_Radio;
        private System.Windows.Forms.RadioButton dwarfRace_Radio;
        private System.Windows.Forms.RadioButton orcRace_Radio;
        private System.Windows.Forms.GroupBox class_groupBox;
        private System.Windows.Forms.GroupBox race_groupBox;
    }
}