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
            topPanel = new Panel();
            label2 = new Label();
            infoPanel = new Panel();
            infoLabel = new Label();
            statsPanel = new Panel();
            thirstLabel = new Label();
            hungerLabel = new Label();
            energyLabel = new Label();
            sanityLabel = new Label();
            healthLabel = new Label();
            statsLabel = new Label();
            titleLabel = new Label();
            panel1 = new Panel();
            actionTabControl = new TabControl();
            tabPage1 = new TabPage();
            panel8 = new Panel();
            panel7 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel2 = new Panel();
            gatherLeavesButton = new Button();
            gatherStoneButton = new Button();
            gatherSticksButton = new Button();
            basicGatheringLabel = new Label();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            tabPage7 = new TabPage();
            tabPage10 = new TabPage();
            wholePanel = new Panel();
            managementPanel = new Panel();
            managementTabControl = new TabControl();
            tabPage8 = new TabPage();
            tabPage9 = new TabPage();
            panel3 = new Panel();
            label1 = new Label();
            inventoryListBox = new ListBox();
            bottomPanel = new Panel();
            newsLabel = new Label();
            endDayButton = new Button();
            topPanel.SuspendLayout();
            infoPanel.SuspendLayout();
            statsPanel.SuspendLayout();
            panel1.SuspendLayout();
            actionTabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            panel2.SuspendLayout();
            wholePanel.SuspendLayout();
            managementPanel.SuspendLayout();
            managementTabControl.SuspendLayout();
            panel3.SuspendLayout();
            bottomPanel.SuspendLayout();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.BorderStyle = BorderStyle.Fixed3D;
            topPanel.Controls.Add(label2);
            topPanel.Controls.Add(infoPanel);
            topPanel.Controls.Add(statsPanel);
            topPanel.Controls.Add(titleLabel);
            topPanel.Location = new Point(3, 3);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(2308, 246);
            topPanel.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Univers 55", 27.9000015F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(800, 65);
            label2.Name = "label2";
            label2.Size = new Size(704, 112);
            label2.TabIndex = 3;
            label2.Text = "Survival Game";
            // 
            // infoPanel
            // 
            infoPanel.Controls.Add(infoLabel);
            infoPanel.Location = new Point(756, 3);
            infoPanel.Name = "infoPanel";
            infoPanel.Size = new Size(961, 238);
            infoPanel.TabIndex = 2;
            // 
            // infoLabel
            // 
            infoLabel.AutoSize = true;
            infoLabel.Location = new Point(14, 9);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(77, 41);
            infoLabel.TabIndex = 2;
            infoLabel.Text = "Info:";
            // 
            // statsPanel
            // 
            statsPanel.Controls.Add(thirstLabel);
            statsPanel.Controls.Add(hungerLabel);
            statsPanel.Controls.Add(energyLabel);
            statsPanel.Controls.Add(sanityLabel);
            statsPanel.Controls.Add(healthLabel);
            statsPanel.Controls.Add(statsLabel);
            statsPanel.Location = new Point(1722, 3);
            statsPanel.Name = "statsPanel";
            statsPanel.Size = new Size(581, 238);
            statsPanel.TabIndex = 1;
            // 
            // thirstLabel
            // 
            thirstLabel.AutoSize = true;
            thirstLabel.Location = new Point(242, 145);
            thirstLabel.Name = "thirstLabel";
            thirstLabel.Size = new Size(98, 41);
            thirstLabel.TabIndex = 5;
            thirstLabel.Text = "Thirst:";
            // 
            // hungerLabel
            // 
            hungerLabel.AutoSize = true;
            hungerLabel.Location = new Point(242, 104);
            hungerLabel.Name = "hungerLabel";
            hungerLabel.Size = new Size(124, 41);
            hungerLabel.TabIndex = 4;
            hungerLabel.Text = "Hunger:";
            // 
            // energyLabel
            // 
            energyLabel.AutoSize = true;
            energyLabel.Location = new Point(242, 63);
            energyLabel.Name = "energyLabel";
            energyLabel.Size = new Size(116, 41);
            energyLabel.TabIndex = 3;
            energyLabel.Text = "Energy:";
            // 
            // sanityLabel
            // 
            sanityLabel.AutoSize = true;
            sanityLabel.Location = new Point(4, 104);
            sanityLabel.Name = "sanityLabel";
            sanityLabel.Size = new Size(105, 41);
            sanityLabel.TabIndex = 2;
            sanityLabel.Text = "Sanity:";
            // 
            // healthLabel
            // 
            healthLabel.AutoSize = true;
            healthLabel.Location = new Point(3, 63);
            healthLabel.Name = "healthLabel";
            healthLabel.Size = new Size(119, 41);
            healthLabel.TabIndex = 1;
            healthLabel.Text = "Health: ";
            // 
            // statsLabel
            // 
            statsLabel.AutoSize = true;
            statsLabel.Location = new Point(3, 9);
            statsLabel.Name = "statsLabel";
            statsLabel.Size = new Size(81, 41);
            statsLabel.TabIndex = 0;
            statsLabel.Text = "Stats";
            statsLabel.Click += label2_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Univers 55", 27.9000015F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(12, 12);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(704, 112);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Survival Game";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(actionTabControl);
            panel1.Location = new Point(3, 255);
            panel1.Name = "panel1";
            panel1.Size = new Size(1188, 1201);
            panel1.TabIndex = 3;
            // 
            // actionTabControl
            // 
            actionTabControl.Controls.Add(tabPage1);
            actionTabControl.Controls.Add(tabPage2);
            actionTabControl.Controls.Add(tabPage3);
            actionTabControl.Controls.Add(tabPage4);
            actionTabControl.Controls.Add(tabPage5);
            actionTabControl.Controls.Add(tabPage6);
            actionTabControl.Controls.Add(tabPage7);
            actionTabControl.Controls.Add(tabPage10);
            actionTabControl.Location = new Point(3, 23);
            actionTabControl.Name = "actionTabControl";
            actionTabControl.SelectedIndex = 0;
            actionTabControl.Size = new Size(1180, 1167);
            actionTabControl.TabIndex = 0;
            actionTabControl.SelectedIndexChanged += actionTabControl_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(panel8);
            tabPage1.Controls.Add(panel7);
            tabPage1.Controls.Add(panel6);
            tabPage1.Controls.Add(panel5);
            tabPage1.Controls.Add(panel4);
            tabPage1.Controls.Add(panel2);
            tabPage1.Location = new Point(10, 58);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1160, 1099);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Gathering";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            panel8.BorderStyle = BorderStyle.FixedSingle;
            panel8.Location = new Point(770, 555);
            panel8.Name = "panel8";
            panel8.Size = new Size(376, 538);
            panel8.TabIndex = 5;
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Location = new Point(388, 555);
            panel7.Name = "panel7";
            panel7.Size = new Size(376, 538);
            panel7.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Location = new Point(6, 555);
            panel6.Name = "panel6";
            panel6.Size = new Size(376, 538);
            panel6.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Location = new Point(770, 6);
            panel5.Name = "panel5";
            panel5.Size = new Size(376, 538);
            panel5.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Location = new Point(388, 6);
            panel4.Name = "panel4";
            panel4.Size = new Size(376, 538);
            panel4.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(gatherLeavesButton);
            panel2.Controls.Add(gatherStoneButton);
            panel2.Controls.Add(gatherSticksButton);
            panel2.Controls.Add(basicGatheringLabel);
            panel2.Location = new Point(6, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(376, 538);
            panel2.TabIndex = 0;
            // 
            // gatherLeavesButton
            // 
            gatherLeavesButton.Location = new Point(3, 181);
            gatherLeavesButton.Name = "gatherLeavesButton";
            gatherLeavesButton.Size = new Size(368, 58);
            gatherLeavesButton.TabIndex = 3;
            gatherLeavesButton.Text = "Leaves";
            gatherLeavesButton.UseVisualStyleBackColor = true;
            // 
            // gatherStoneButton
            // 
            gatherStoneButton.Location = new Point(3, 117);
            gatherStoneButton.Name = "gatherStoneButton";
            gatherStoneButton.Size = new Size(368, 58);
            gatherStoneButton.TabIndex = 2;
            gatherStoneButton.Text = "Stones";
            gatherStoneButton.UseVisualStyleBackColor = true;
            // 
            // gatherSticksButton
            // 
            gatherSticksButton.Location = new Point(3, 53);
            gatherSticksButton.Name = "gatherSticksButton";
            gatherSticksButton.Size = new Size(368, 58);
            gatherSticksButton.TabIndex = 1;
            gatherSticksButton.Text = "Sticks";
            gatherSticksButton.UseVisualStyleBackColor = true;
            // 
            // basicGatheringLabel
            // 
            basicGatheringLabel.AutoSize = true;
            basicGatheringLabel.Location = new Point(3, 0);
            basicGatheringLabel.Name = "basicGatheringLabel";
            basicGatheringLabel.Size = new Size(226, 41);
            basicGatheringLabel.TabIndex = 0;
            basicGatheringLabel.Text = "Basic Resources";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(10, 58);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1160, 1099);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Consume Items";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(10, 58);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1160, 1099);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Crafting";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(10, 58);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1160, 1099);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Building";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(10, 58);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(1160, 1099);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Hunting";
            tabPage5.UseVisualStyleBackColor = true;
            tabPage5.Click += tabPage5_Click;
            // 
            // tabPage6
            // 
            tabPage6.Location = new Point(10, 58);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(1160, 1099);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Cooking";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            tabPage7.Location = new Point(10, 58);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(1160, 1099);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "Maintenance";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage10
            // 
            tabPage10.Location = new Point(10, 58);
            tabPage10.Name = "tabPage10";
            tabPage10.Padding = new Padding(3);
            tabPage10.Size = new Size(1160, 1099);
            tabPage10.TabIndex = 7;
            tabPage10.Text = "tabPage10";
            tabPage10.UseVisualStyleBackColor = true;
            // 
            // wholePanel
            // 
            wholePanel.BorderStyle = BorderStyle.FixedSingle;
            wholePanel.Controls.Add(managementPanel);
            wholePanel.Controls.Add(panel3);
            wholePanel.Controls.Add(bottomPanel);
            wholePanel.Controls.Add(panel1);
            wholePanel.Controls.Add(topPanel);
            wholePanel.Location = new Point(12, 7);
            wholePanel.Name = "wholePanel";
            wholePanel.Size = new Size(2323, 1775);
            wholePanel.TabIndex = 1;
            // 
            // managementPanel
            // 
            managementPanel.BorderStyle = BorderStyle.Fixed3D;
            managementPanel.Controls.Add(managementTabControl);
            managementPanel.Location = new Point(1726, 253);
            managementPanel.Name = "managementPanel";
            managementPanel.Size = new Size(585, 1203);
            managementPanel.TabIndex = 6;
            // 
            // managementTabControl
            // 
            managementTabControl.Controls.Add(tabPage8);
            managementTabControl.Controls.Add(tabPage9);
            managementTabControl.Location = new Point(3, 25);
            managementTabControl.Name = "managementTabControl";
            managementTabControl.SelectedIndex = 0;
            managementTabControl.Size = new Size(578, 1167);
            managementTabControl.TabIndex = 0;
            // 
            // tabPage8
            // 
            tabPage8.Location = new Point(10, 58);
            tabPage8.Name = "tabPage8";
            tabPage8.Padding = new Padding(3);
            tabPage8.Size = new Size(558, 1099);
            tabPage8.TabIndex = 0;
            tabPage8.Text = "Levels";
            tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabPage9
            // 
            tabPage9.Location = new Point(10, 58);
            tabPage9.Name = "tabPage9";
            tabPage9.Padding = new Padding(3);
            tabPage9.Size = new Size(558, 1099);
            tabPage9.TabIndex = 1;
            tabPage9.Text = "Buildings";
            tabPage9.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(inventoryListBox);
            panel3.Location = new Point(1197, 255);
            panel3.Name = "panel3";
            panel3.Size = new Size(524, 1201);
            panel3.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 35);
            label1.Name = "label1";
            label1.Size = new Size(143, 41);
            label1.TabIndex = 1;
            label1.Text = "Inventory";
            // 
            // inventoryListBox
            // 
            inventoryListBox.FormattingEnabled = true;
            inventoryListBox.ItemHeight = 41;
            inventoryListBox.Location = new Point(3, 79);
            inventoryListBox.Name = "inventoryListBox";
            inventoryListBox.Size = new Size(518, 1111);
            inventoryListBox.TabIndex = 0;
            // 
            // bottomPanel
            // 
            bottomPanel.BorderStyle = BorderStyle.Fixed3D;
            bottomPanel.Controls.Add(newsLabel);
            bottomPanel.Controls.Add(endDayButton);
            bottomPanel.Font = new Font("Segoe UI", 9F);
            bottomPanel.Location = new Point(3, 1478);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Size = new Size(2315, 287);
            bottomPanel.TabIndex = 4;
            // 
            // newsLabel
            // 
            newsLabel.AutoSize = true;
            newsLabel.Location = new Point(13, 18);
            newsLabel.Name = "newsLabel";
            newsLabel.Size = new Size(98, 41);
            newsLabel.TabIndex = 1;
            newsLabel.Text = "News:";
            // 
            // endDayButton
            // 
            endDayButton.Location = new Point(1786, 3);
            endDayButton.Name = "endDayButton";
            endDayButton.Size = new Size(521, 280);
            endDayButton.TabIndex = 0;
            endDayButton.Text = "END DAY";
            endDayButton.UseVisualStyleBackColor = true;
            endDayButton.Click += endDayButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2343, 1790);
            Controls.Add(wholePanel);
            Name = "Form1";
            Text = "SurvivalGame";
            Load += Form1_Load;
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            infoPanel.ResumeLayout(false);
            infoPanel.PerformLayout();
            statsPanel.ResumeLayout(false);
            statsPanel.PerformLayout();
            panel1.ResumeLayout(false);
            actionTabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            wholePanel.ResumeLayout(false);
            managementPanel.ResumeLayout(false);
            managementTabControl.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            bottomPanel.ResumeLayout(false);
            bottomPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel topPanel;
        private Panel panel1;
        private TabControl actionTabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel wholePanel;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private Panel panel3;
        private Panel bottomPanel;
        private Button endDayButton;
        private Label titleLabel;
        private Label label1;
        private ListBox inventoryListBox;
        private Panel managementPanel;
        private Panel statsPanel;
        private Panel infoPanel;
        private TabControl managementTabControl;
        private TabPage tabPage8;
        private TabPage tabPage9;
        private Label statsLabel;
        private Label healthLabel;
        private Panel panel2;
        private Panel panel5;
        private Panel panel4;
        private Panel panel8;
        private Panel panel7;
        private Panel panel6;
        private Label sanityLabel;
        private Label thirstLabel;
        private Label hungerLabel;
        private Label energyLabel;
        private Label infoLabel;
        private Label newsLabel;
        private Label label2;
        private Button gatherLeavesButton;
        private Button gatherStoneButton;
        private Button gatherSticksButton;
        private Label basicGatheringLabel;
        private TabPage tabPage10;
    }
}
