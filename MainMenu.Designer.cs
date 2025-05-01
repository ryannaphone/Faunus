namespace faunusVB
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            newGameLabel = new Label();
            settingsLabel = new Label();
            exitLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Univers Condensed", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(229, 97);
            label1.Name = "label1";
            label1.Size = new Size(380, 142);
            label1.TabIndex = 0;
            label1.Text = "Faunus";
            // 
            // newGameLabel
            // 
            newGameLabel.AutoSize = true;
            newGameLabel.Font = new Font("Univers Condensed", 15.9000006F, FontStyle.Italic, GraphicsUnit.Point, 0);
            newGameLabel.ForeColor = SystemColors.ButtonFace;
            newGameLabel.Location = new Point(302, 276);
            newGameLabel.Name = "newGameLabel";
            newGameLabel.Size = new Size(228, 64);
            newGameLabel.TabIndex = 1;
            newGameLabel.Text = "New Game";
            newGameLabel.Click += newGameLabel_Click;
            newGameLabel.MouseEnter += this.newGameLabel_MouseEnter;
            newGameLabel.MouseLeave += this.newGameLabel_MouseLeave;
            // 
            // settingsLabel
            // 
            settingsLabel.AutoSize = true;
            settingsLabel.Font = new Font("Univers Condensed", 15.9000006F, FontStyle.Italic, GraphicsUnit.Point, 0);
            settingsLabel.ForeColor = SystemColors.ButtonFace;
            settingsLabel.Location = new Point(325, 368);
            settingsLabel.Name = "settingsLabel";
            settingsLabel.Size = new Size(180, 64);
            settingsLabel.TabIndex = 2;
            settingsLabel.Text = "Settings";
            settingsLabel.Click += this.settingsLabel_Click;
            settingsLabel.MouseEnter += this.settingsLabel_MouseEnter;
            settingsLabel.MouseLeave += this.settingsLabel_MouseLeave;
            // 
            // exitLabel
            // 
            exitLabel.AutoSize = true;
            exitLabel.Font = new Font("Univers Condensed", 15.9000006F, FontStyle.Italic, GraphicsUnit.Point, 0);
            exitLabel.ForeColor = SystemColors.ButtonFace;
            exitLabel.Location = new Point(356, 463);
            exitLabel.Name = "exitLabel";
            exitLabel.Size = new Size(97, 64);
            exitLabel.TabIndex = 3;
            exitLabel.Text = "Exit";
            exitLabel.Click += this.exitLabel_Click;
            exitLabel.MouseEnter += this.exitLabel_MouseEnter;
            exitLabel.MouseLeave += this.exitLabel_MouseLeave;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(850, 723);
            Controls.Add(exitLabel);
            Controls.Add(settingsLabel);
            Controls.Add(newGameLabel);
            Controls.Add(label1);
            Name = "MainMenu";
            Text = "SurvivalGame";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        

        #endregion

        private Label label1;
        private Label newGameLabel;
        private Label settingsLabel;
        private Label exitLabel;
    }
}
