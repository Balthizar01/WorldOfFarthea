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
            this.back_Button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.luckPlusButton = new System.Windows.Forms.Button();
            this.luckMinusButton = new System.Windows.Forms.Button();
            this.charismaPlusButton = new System.Windows.Forms.Button();
            this.charismaMinusButton = new System.Windows.Forms.Button();
            this.endurancePlusButton = new System.Windows.Forms.Button();
            this.enduranceMinusButton = new System.Windows.Forms.Button();
            this.agilityPlusButton = new System.Windows.Forms.Button();
            this.agilityMinusButton = new System.Windows.Forms.Button();
            this.intellectPlusButton = new System.Windows.Forms.Button();
            this.intellectMinusButton = new System.Windows.Forms.Button();
            this.strengthMinusButton = new System.Windows.Forms.Button();
            this.strengthPlusButton = new System.Windows.Forms.Button();
            this.luckStat = new System.Windows.Forms.Label();
            this.charismaStat = new System.Windows.Forms.Label();
            this.enduranceStat = new System.Windows.Forms.Label();
            this.agilityStat = new System.Windows.Forms.Label();
            this.intellectStat = new System.Windows.Forms.Label();
            this.strengthStat = new System.Windows.Forms.Label();
            this.luck_Label = new System.Windows.Forms.Label();
            this.charisma_Label = new System.Windows.Forms.Label();
            this.endurance_Label = new System.Windows.Forms.Label();
            this.agility_Label = new System.Windows.Forms.Label();
            this.intellect_Label = new System.Windows.Forms.Label();
            this.strength_Label = new System.Windows.Forms.Label();
            this.statPoints_Label = new System.Windows.Forms.Label();
            this.statPoints = new System.Windows.Forms.Label();
            this.class_groupBox.SuspendLayout();
            this.race_groupBox.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.characterCreation_Submit.Location = new System.Drawing.Point(392, 350);
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
            // back_Button
            // 
            this.back_Button.Location = new System.Drawing.Point(272, 350);
            this.back_Button.Name = "back_Button";
            this.back_Button.Size = new System.Drawing.Size(114, 45);
            this.back_Button.TabIndex = 18;
            this.back_Button.Text = "Back";
            this.back_Button.UseVisualStyleBackColor = true;
            this.back_Button.Click += new System.EventHandler(this.back_Button_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.luckPlusButton);
            this.panel1.Controls.Add(this.luckMinusButton);
            this.panel1.Controls.Add(this.charismaPlusButton);
            this.panel1.Controls.Add(this.charismaMinusButton);
            this.panel1.Controls.Add(this.endurancePlusButton);
            this.panel1.Controls.Add(this.enduranceMinusButton);
            this.panel1.Controls.Add(this.agilityPlusButton);
            this.panel1.Controls.Add(this.agilityMinusButton);
            this.panel1.Controls.Add(this.intellectPlusButton);
            this.panel1.Controls.Add(this.intellectMinusButton);
            this.panel1.Controls.Add(this.strengthMinusButton);
            this.panel1.Controls.Add(this.strengthPlusButton);
            this.panel1.Controls.Add(this.luckStat);
            this.panel1.Controls.Add(this.charismaStat);
            this.panel1.Controls.Add(this.enduranceStat);
            this.panel1.Controls.Add(this.agilityStat);
            this.panel1.Controls.Add(this.intellectStat);
            this.panel1.Controls.Add(this.strengthStat);
            this.panel1.Controls.Add(this.luck_Label);
            this.panel1.Controls.Add(this.charisma_Label);
            this.panel1.Controls.Add(this.endurance_Label);
            this.panel1.Controls.Add(this.agility_Label);
            this.panel1.Controls.Add(this.intellect_Label);
            this.panel1.Controls.Add(this.strength_Label);
            this.panel1.Location = new System.Drawing.Point(476, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 222);
            this.panel1.TabIndex = 19;
            // 
            // luckPlusButton
            // 
            this.luckPlusButton.Location = new System.Drawing.Point(199, 132);
            this.luckPlusButton.Name = "luckPlusButton";
            this.luckPlusButton.Size = new System.Drawing.Size(60, 25);
            this.luckPlusButton.TabIndex = 23;
            this.luckPlusButton.Text = "+";
            this.luckPlusButton.UseVisualStyleBackColor = true;
            this.luckPlusButton.Click += new System.EventHandler(this.luckPlusButton_Click);
            // 
            // luckMinusButton
            // 
            this.luckMinusButton.Location = new System.Drawing.Point(133, 132);
            this.luckMinusButton.Name = "luckMinusButton";
            this.luckMinusButton.Size = new System.Drawing.Size(60, 25);
            this.luckMinusButton.TabIndex = 22;
            this.luckMinusButton.Text = "-";
            this.luckMinusButton.UseVisualStyleBackColor = true;
            this.luckMinusButton.Click += new System.EventHandler(this.luckMinusButton_Click);
            // 
            // charismaPlusButton
            // 
            this.charismaPlusButton.Location = new System.Drawing.Point(199, 107);
            this.charismaPlusButton.Name = "charismaPlusButton";
            this.charismaPlusButton.Size = new System.Drawing.Size(60, 25);
            this.charismaPlusButton.TabIndex = 21;
            this.charismaPlusButton.Text = "+";
            this.charismaPlusButton.UseVisualStyleBackColor = true;
            this.charismaPlusButton.Click += new System.EventHandler(this.charismaPlusButton_Click);
            // 
            // charismaMinusButton
            // 
            this.charismaMinusButton.Location = new System.Drawing.Point(133, 107);
            this.charismaMinusButton.Name = "charismaMinusButton";
            this.charismaMinusButton.Size = new System.Drawing.Size(60, 25);
            this.charismaMinusButton.TabIndex = 20;
            this.charismaMinusButton.Text = "-";
            this.charismaMinusButton.UseVisualStyleBackColor = true;
            this.charismaMinusButton.Click += new System.EventHandler(this.charismaMinusButton_Click);
            // 
            // endurancePlusButton
            // 
            this.endurancePlusButton.Location = new System.Drawing.Point(199, 83);
            this.endurancePlusButton.Name = "endurancePlusButton";
            this.endurancePlusButton.Size = new System.Drawing.Size(60, 25);
            this.endurancePlusButton.TabIndex = 19;
            this.endurancePlusButton.Text = "+";
            this.endurancePlusButton.UseVisualStyleBackColor = true;
            this.endurancePlusButton.Click += new System.EventHandler(this.endurancePlusButton_Click);
            // 
            // enduranceMinusButton
            // 
            this.enduranceMinusButton.Location = new System.Drawing.Point(133, 84);
            this.enduranceMinusButton.Name = "enduranceMinusButton";
            this.enduranceMinusButton.Size = new System.Drawing.Size(60, 25);
            this.enduranceMinusButton.TabIndex = 18;
            this.enduranceMinusButton.Text = "-";
            this.enduranceMinusButton.UseVisualStyleBackColor = true;
            this.enduranceMinusButton.Click += new System.EventHandler(this.enduranceMinusButton_Click);
            // 
            // agilityPlusButton
            // 
            this.agilityPlusButton.Location = new System.Drawing.Point(199, 59);
            this.agilityPlusButton.Name = "agilityPlusButton";
            this.agilityPlusButton.Size = new System.Drawing.Size(60, 25);
            this.agilityPlusButton.TabIndex = 17;
            this.agilityPlusButton.Text = "+";
            this.agilityPlusButton.UseVisualStyleBackColor = true;
            this.agilityPlusButton.Click += new System.EventHandler(this.agilityPlusButton_Click);
            // 
            // agilityMinusButton
            // 
            this.agilityMinusButton.Location = new System.Drawing.Point(133, 60);
            this.agilityMinusButton.Name = "agilityMinusButton";
            this.agilityMinusButton.Size = new System.Drawing.Size(60, 25);
            this.agilityMinusButton.TabIndex = 16;
            this.agilityMinusButton.Text = "-";
            this.agilityMinusButton.UseVisualStyleBackColor = true;
            this.agilityMinusButton.Click += new System.EventHandler(this.agilityMinusButton_Click);
            // 
            // intellectPlusButton
            // 
            this.intellectPlusButton.Location = new System.Drawing.Point(199, 35);
            this.intellectPlusButton.Name = "intellectPlusButton";
            this.intellectPlusButton.Size = new System.Drawing.Size(60, 25);
            this.intellectPlusButton.TabIndex = 15;
            this.intellectPlusButton.Text = "+";
            this.intellectPlusButton.UseVisualStyleBackColor = true;
            this.intellectPlusButton.Click += new System.EventHandler(this.intellectPlusButton_Click);
            // 
            // intellectMinusButton
            // 
            this.intellectMinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intellectMinusButton.Location = new System.Drawing.Point(133, 36);
            this.intellectMinusButton.Name = "intellectMinusButton";
            this.intellectMinusButton.Size = new System.Drawing.Size(60, 25);
            this.intellectMinusButton.TabIndex = 14;
            this.intellectMinusButton.Text = "-";
            this.intellectMinusButton.UseVisualStyleBackColor = true;
            this.intellectMinusButton.Click += new System.EventHandler(this.intellectMinusButton_Click);
            // 
            // strengthMinusButton
            // 
            this.strengthMinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strengthMinusButton.Location = new System.Drawing.Point(133, 11);
            this.strengthMinusButton.Name = "strengthMinusButton";
            this.strengthMinusButton.Size = new System.Drawing.Size(60, 25);
            this.strengthMinusButton.TabIndex = 13;
            this.strengthMinusButton.Text = "-";
            this.strengthMinusButton.UseVisualStyleBackColor = true;
            this.strengthMinusButton.Click += new System.EventHandler(this.strengthMinusButton_Click);
            // 
            // strengthPlusButton
            // 
            this.strengthPlusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strengthPlusButton.Location = new System.Drawing.Point(199, 11);
            this.strengthPlusButton.Name = "strengthPlusButton";
            this.strengthPlusButton.Size = new System.Drawing.Size(60, 25);
            this.strengthPlusButton.TabIndex = 12;
            this.strengthPlusButton.Text = "+";
            this.strengthPlusButton.UseVisualStyleBackColor = true;
            this.strengthPlusButton.Click += new System.EventHandler(this.strengthPlusButton_Click);
            // 
            // luckStat
            // 
            this.luckStat.AutoSize = true;
            this.luckStat.Location = new System.Drawing.Point(92, 138);
            this.luckStat.Name = "luckStat";
            this.luckStat.Size = new System.Drawing.Size(13, 13);
            this.luckStat.TabIndex = 11;
            this.luckStat.Text = "5";
            // 
            // charismaStat
            // 
            this.charismaStat.AutoSize = true;
            this.charismaStat.Location = new System.Drawing.Point(92, 113);
            this.charismaStat.Name = "charismaStat";
            this.charismaStat.Size = new System.Drawing.Size(13, 13);
            this.charismaStat.TabIndex = 10;
            this.charismaStat.Text = "5";
            // 
            // enduranceStat
            // 
            this.enduranceStat.AutoSize = true;
            this.enduranceStat.Location = new System.Drawing.Point(92, 90);
            this.enduranceStat.Name = "enduranceStat";
            this.enduranceStat.Size = new System.Drawing.Size(13, 13);
            this.enduranceStat.TabIndex = 9;
            this.enduranceStat.Text = "5";
            // 
            // agilityStat
            // 
            this.agilityStat.AutoSize = true;
            this.agilityStat.Location = new System.Drawing.Point(92, 66);
            this.agilityStat.Name = "agilityStat";
            this.agilityStat.Size = new System.Drawing.Size(13, 13);
            this.agilityStat.TabIndex = 8;
            this.agilityStat.Text = "5";
            // 
            // intellectStat
            // 
            this.intellectStat.AutoSize = true;
            this.intellectStat.Location = new System.Drawing.Point(92, 41);
            this.intellectStat.Name = "intellectStat";
            this.intellectStat.Size = new System.Drawing.Size(13, 13);
            this.intellectStat.TabIndex = 7;
            this.intellectStat.Text = "5";
            // 
            // strengthStat
            // 
            this.strengthStat.AutoSize = true;
            this.strengthStat.Location = new System.Drawing.Point(92, 17);
            this.strengthStat.Name = "strengthStat";
            this.strengthStat.Size = new System.Drawing.Size(13, 13);
            this.strengthStat.TabIndex = 6;
            this.strengthStat.Text = "5";
            // 
            // luck_Label
            // 
            this.luck_Label.AutoSize = true;
            this.luck_Label.Location = new System.Drawing.Point(12, 138);
            this.luck_Label.Name = "luck_Label";
            this.luck_Label.Size = new System.Drawing.Size(34, 13);
            this.luck_Label.TabIndex = 5;
            this.luck_Label.Text = "Luck:";
            // 
            // charisma_Label
            // 
            this.charisma_Label.AutoSize = true;
            this.charisma_Label.Location = new System.Drawing.Point(12, 113);
            this.charisma_Label.Name = "charisma_Label";
            this.charisma_Label.Size = new System.Drawing.Size(53, 13);
            this.charisma_Label.TabIndex = 4;
            this.charisma_Label.Text = "Charisma:";
            // 
            // endurance_Label
            // 
            this.endurance_Label.AutoSize = true;
            this.endurance_Label.Location = new System.Drawing.Point(12, 90);
            this.endurance_Label.Name = "endurance_Label";
            this.endurance_Label.Size = new System.Drawing.Size(62, 13);
            this.endurance_Label.TabIndex = 3;
            this.endurance_Label.Text = "Endurance:";
            // 
            // agility_Label
            // 
            this.agility_Label.AutoSize = true;
            this.agility_Label.Location = new System.Drawing.Point(12, 66);
            this.agility_Label.Name = "agility_Label";
            this.agility_Label.Size = new System.Drawing.Size(37, 13);
            this.agility_Label.TabIndex = 2;
            this.agility_Label.Text = "Agility:";
            // 
            // intellect_Label
            // 
            this.intellect_Label.AutoSize = true;
            this.intellect_Label.Location = new System.Drawing.Point(12, 41);
            this.intellect_Label.Name = "intellect_Label";
            this.intellect_Label.Size = new System.Drawing.Size(47, 13);
            this.intellect_Label.TabIndex = 1;
            this.intellect_Label.Text = "Intellect:";
            // 
            // strength_Label
            // 
            this.strength_Label.AutoSize = true;
            this.strength_Label.Location = new System.Drawing.Point(12, 17);
            this.strength_Label.Name = "strength_Label";
            this.strength_Label.Size = new System.Drawing.Size(50, 13);
            this.strength_Label.TabIndex = 0;
            this.strength_Label.Text = "Strength:";
            // 
            // statPoints_Label
            // 
            this.statPoints_Label.AutoSize = true;
            this.statPoints_Label.Location = new System.Drawing.Point(571, 103);
            this.statPoints_Label.Name = "statPoints_Label";
            this.statPoints_Label.Size = new System.Drawing.Size(61, 13);
            this.statPoints_Label.TabIndex = 20;
            this.statPoints_Label.Text = "Stat Points:";
            // 
            // statPoints
            // 
            this.statPoints.AutoSize = true;
            this.statPoints.Location = new System.Drawing.Point(634, 103);
            this.statPoints.Name = "statPoints";
            this.statPoints.Size = new System.Drawing.Size(35, 13);
            this.statPoints.TabIndex = 21;
            this.statPoints.Text = "label1";
            // 
            // CharacterCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statPoints);
            this.Controls.Add(this.statPoints_Label);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.back_Button);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button back_Button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label luckStat;
        private System.Windows.Forms.Label charismaStat;
        private System.Windows.Forms.Label enduranceStat;
        private System.Windows.Forms.Label agilityStat;
        private System.Windows.Forms.Label intellectStat;
        private System.Windows.Forms.Label strengthStat;
        private System.Windows.Forms.Label luck_Label;
        private System.Windows.Forms.Label charisma_Label;
        private System.Windows.Forms.Label endurance_Label;
        private System.Windows.Forms.Label agility_Label;
        private System.Windows.Forms.Label intellect_Label;
        private System.Windows.Forms.Label strength_Label;
        private System.Windows.Forms.Button luckPlusButton;
        private System.Windows.Forms.Button luckMinusButton;
        private System.Windows.Forms.Button charismaPlusButton;
        private System.Windows.Forms.Button charismaMinusButton;
        private System.Windows.Forms.Button endurancePlusButton;
        private System.Windows.Forms.Button enduranceMinusButton;
        private System.Windows.Forms.Button agilityPlusButton;
        private System.Windows.Forms.Button agilityMinusButton;
        private System.Windows.Forms.Button intellectPlusButton;
        private System.Windows.Forms.Button intellectMinusButton;
        private System.Windows.Forms.Button strengthMinusButton;
        private System.Windows.Forms.Button strengthPlusButton;
        private System.Windows.Forms.Label statPoints_Label;
        private System.Windows.Forms.Label statPoints;
    }
}