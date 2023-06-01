namespace WorldOfFarthea
{
    partial class Form1
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
            this.createNew_Button = new System.Windows.Forms.Button();
            this.loadCharacter_Button = new System.Windows.Forms.Button();
            this.exitGame_Button = new System.Windows.Forms.Button();
            this.titleText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createNew_Button
            // 
            this.createNew_Button.Location = new System.Drawing.Point(333, 177);
            this.createNew_Button.Name = "createNew_Button";
            this.createNew_Button.Size = new System.Drawing.Size(120, 53);
            this.createNew_Button.TabIndex = 0;
            this.createNew_Button.Text = "New Game";
            this.createNew_Button.UseVisualStyleBackColor = true;
            this.createNew_Button.Click += new System.EventHandler(this.createNew_Button_Click);
            // 
            // loadCharacter_Button
            // 
            this.loadCharacter_Button.Location = new System.Drawing.Point(333, 236);
            this.loadCharacter_Button.Name = "loadCharacter_Button";
            this.loadCharacter_Button.Size = new System.Drawing.Size(120, 53);
            this.loadCharacter_Button.TabIndex = 1;
            this.loadCharacter_Button.Text = "Load Game";
            this.loadCharacter_Button.UseVisualStyleBackColor = true;
            this.loadCharacter_Button.Click += new System.EventHandler(this.loadCharacter_Button_Click);
            // 
            // exitGame_Button
            // 
            this.exitGame_Button.Location = new System.Drawing.Point(333, 295);
            this.exitGame_Button.Name = "exitGame_Button";
            this.exitGame_Button.Size = new System.Drawing.Size(120, 53);
            this.exitGame_Button.TabIndex = 2;
            this.exitGame_Button.Text = "Exit Game";
            this.exitGame_Button.UseVisualStyleBackColor = true;
            this.exitGame_Button.Click += new System.EventHandler(this.exitGame_Button_Click);
            // 
            // titleText
            // 
            this.titleText.AutoSize = true;
            this.titleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleText.Location = new System.Drawing.Point(215, 67);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(370, 54);
            this.titleText.TabIndex = 3;
            this.titleText.Text = "World of Farthea";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.exitGame_Button);
            this.Controls.Add(this.loadCharacter_Button);
            this.Controls.Add(this.createNew_Button);
            this.Name = "Form1";
            this.Text = "World of Farthea";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createNew_Button;
        private System.Windows.Forms.Button loadCharacter_Button;
        private System.Windows.Forms.Button exitGame_Button;
        private System.Windows.Forms.Label titleText;
    }
}

