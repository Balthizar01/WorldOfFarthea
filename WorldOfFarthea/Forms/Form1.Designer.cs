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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.createNew_Button = new System.Windows.Forms.Button();
            this.loadCharacter_Button = new System.Windows.Forms.Button();
            this.exitGame_Button = new System.Windows.Forms.Button();
            this.WindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // createNew_Button
            // 
            this.createNew_Button.Location = new System.Drawing.Point(413, 499);
            this.createNew_Button.Name = "createNew_Button";
            this.createNew_Button.Size = new System.Drawing.Size(120, 53);
            this.createNew_Button.TabIndex = 0;
            this.createNew_Button.Text = "New Game";
            this.createNew_Button.UseVisualStyleBackColor = true;
            this.createNew_Button.Click += new System.EventHandler(this.createNew_Button_Click);
            // 
            // loadCharacter_Button
            // 
            this.loadCharacter_Button.Location = new System.Drawing.Point(558, 499);
            this.loadCharacter_Button.Name = "loadCharacter_Button";
            this.loadCharacter_Button.Size = new System.Drawing.Size(120, 53);
            this.loadCharacter_Button.TabIndex = 1;
            this.loadCharacter_Button.Text = "Load Game";
            this.loadCharacter_Button.UseVisualStyleBackColor = true;
            this.loadCharacter_Button.Click += new System.EventHandler(this.loadCharacter_Button_Click);
            // 
            // exitGame_Button
            // 
            this.exitGame_Button.Location = new System.Drawing.Point(701, 499);
            this.exitGame_Button.Name = "exitGame_Button";
            this.exitGame_Button.Size = new System.Drawing.Size(120, 53);
            this.exitGame_Button.TabIndex = 2;
            this.exitGame_Button.Text = "Exit Game";
            this.exitGame_Button.UseVisualStyleBackColor = true;
            this.exitGame_Button.Click += new System.EventHandler(this.exitGame_Button_Click);
            // 
            // WindowsMediaPlayer1
            // 
            this.WindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WindowsMediaPlayer1.Enabled = true;
            this.WindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.WindowsMediaPlayer1.Name = "WindowsMediaPlayer1";
            this.WindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WindowsMediaPlayer1.OcxState")));
            this.WindowsMediaPlayer1.Size = new System.Drawing.Size(1233, 695);
            this.WindowsMediaPlayer1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 695);
            this.Controls.Add(this.exitGame_Button);
            this.Controls.Add(this.loadCharacter_Button);
            this.Controls.Add(this.createNew_Button);
            this.Controls.Add(this.WindowsMediaPlayer1);
            this.Name = "Form1";
            this.Text = "World of Farthea";
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createNew_Button;
        private System.Windows.Forms.Button loadCharacter_Button;
        private System.Windows.Forms.Button exitGame_Button;
        private AxWMPLib.AxWindowsMediaPlayer WindowsMediaPlayer1;
    }
}

