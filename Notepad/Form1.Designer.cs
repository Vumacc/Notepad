namespace Notepad
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
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
            richTextBox1 = new RichTextBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem1 = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            deleteAllToolStripMenuItem = new ToolStripMenuItem();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            customizeToolStripMenuItem = new ToolStripMenuItem();
            notepadThemesToolStripMenuItem = new ToolStripMenuItem();
            standerdDarkToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem8 = new ToolStripSeparator();
            standardLightToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripSeparator();
            creatorsSpecialToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem7 = new ToolStripSeparator();
            powershellBlueToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripSeparator();
            gildedPurpleToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            deepseaToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripSeparator();
            oliveGreenToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            fontsToolStripMenuItem = new ToolStripMenuItem();
            menuStripFontToolStripMenuItem = new ToolStripMenuItem();
            microsoftSansSeriffToolStripMenuItem = new ToolStripMenuItem();
            cascadiaCodeToolStripMenuItem = new ToolStripMenuItem();
            mainFontToolStripMenuItem = new ToolStripMenuItem();
            microsoftSansSeriffToolStripMenuItem1 = new ToolStripMenuItem();
            cascadiaCodeToolStripMenuItem1 = new ToolStripMenuItem();
            exitButton = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.Black;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.ForeColor = Color.White;
            richTextBox1.Location = new Point(12, 58);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(563, 604);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Black;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Font = new Font("Segoe UI", 12F);
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, customizeToolStripMenuItem });
            menuStrip1.Location = new Point(9, 12);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(466, 34);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.BackColor = Color.Black;
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, exitToolStripMenuItem, editToolStripMenuItem1 });
            fileToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fileToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(67, 30);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 11F);
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(167, 34);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 11F);
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(167, 34);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 11F);
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(167, 34);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 11F);
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(167, 34);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem1
            // 
            editToolStripMenuItem1.Font = new Font("Microsoft Sans Serif", 11F);
            editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            editToolStripMenuItem1.Size = new Size(167, 34);
            editToolStripMenuItem1.Text = "Edit";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.BackColor = Color.Black;
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, toolStripMenuItem1, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, toolStripMenuItem2, deleteAllToolStripMenuItem, selectAllToolStripMenuItem });
            editToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            editToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(70, 30);
            editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.Size = new Size(205, 34);
            undoToolStripMenuItem.Text = "Undo";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 11F);
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.Size = new Size(205, 34);
            redoToolStripMenuItem.Text = "Redo";
            redoToolStripMenuItem.Click += redoToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(202, 6);
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 11F);
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new Size(205, 34);
            cutToolStripMenuItem.Text = "Cut";
            cutToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 11F);
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(205, 34);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 11F);
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(205, 34);
            pasteToolStripMenuItem.Text = "Paste";
            pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(202, 6);
            // 
            // deleteAllToolStripMenuItem
            // 
            deleteAllToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 11F);
            deleteAllToolStripMenuItem.Name = "deleteAllToolStripMenuItem";
            deleteAllToolStripMenuItem.Size = new Size(205, 34);
            deleteAllToolStripMenuItem.Text = "Delete all";
            deleteAllToolStripMenuItem.Click += deleteAllToolStripMenuItem_Click;
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 11F);
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.Size = new Size(205, 34);
            selectAllToolStripMenuItem.Text = "Select all";
            selectAllToolStripMenuItem.Click += selectAllToolStripMenuItem_Click;
            // 
            // customizeToolStripMenuItem
            // 
            customizeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { notepadThemesToolStripMenuItem, toolStripMenuItem3, fontsToolStripMenuItem });
            customizeToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customizeToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            customizeToolStripMenuItem.Size = new Size(141, 30);
            customizeToolStripMenuItem.Text = "Customize";
            // 
            // notepadThemesToolStripMenuItem
            // 
            notepadThemesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { standerdDarkToolStripMenuItem, toolStripMenuItem8, standardLightToolStripMenuItem, toolStripMenuItem4, creatorsSpecialToolStripMenuItem, toolStripMenuItem7, powershellBlueToolStripMenuItem, toolStripMenuItem5, gildedPurpleToolStripMenuItem, toolStripSeparator1, deepseaToolStripMenuItem, toolStripMenuItem6, oliveGreenToolStripMenuItem });
            notepadThemesToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 11F);
            notepadThemesToolStripMenuItem.Name = "notepadThemesToolStripMenuItem";
            notepadThemesToolStripMenuItem.Size = new Size(338, 34);
            notepadThemesToolStripMenuItem.Text = "Notepad Color Themes";
            // 
            // standerdDarkToolStripMenuItem
            // 
            standerdDarkToolStripMenuItem.BackColor = Color.Black;
            standerdDarkToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 11F);
            standerdDarkToolStripMenuItem.ForeColor = Color.White;
            standerdDarkToolStripMenuItem.Name = "standerdDarkToolStripMenuItem";
            standerdDarkToolStripMenuItem.Size = new Size(381, 34);
            standerdDarkToolStripMenuItem.Text = "Standard Dark (CURRENT)";
            standerdDarkToolStripMenuItem.Click += standardDarkToolStripMenuItem_Click;
            // 
            // toolStripMenuItem8
            // 
            toolStripMenuItem8.Name = "toolStripMenuItem8";
            toolStripMenuItem8.Size = new Size(378, 6);
            // 
            // standardLightToolStripMenuItem
            // 
            standardLightToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 11F);
            standardLightToolStripMenuItem.Name = "standardLightToolStripMenuItem";
            standardLightToolStripMenuItem.Size = new Size(381, 34);
            standardLightToolStripMenuItem.Text = "Standard Light";
            standardLightToolStripMenuItem.Click += standardLightToolStripMenuItem_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(378, 6);
            // 
            // creatorsSpecialToolStripMenuItem
            // 
            creatorsSpecialToolStripMenuItem.BackColor = Color.FromArgb(38, 0, 230);
            creatorsSpecialToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 11F);
            creatorsSpecialToolStripMenuItem.ForeColor = Color.LightSteelBlue;
            creatorsSpecialToolStripMenuItem.Name = "creatorsSpecialToolStripMenuItem";
            creatorsSpecialToolStripMenuItem.Size = new Size(381, 34);
            creatorsSpecialToolStripMenuItem.Text = "Creator's Special";
            creatorsSpecialToolStripMenuItem.Click += creatorsSpecialToolStripMenuItem_Click;
            // 
            // toolStripMenuItem7
            // 
            toolStripMenuItem7.Name = "toolStripMenuItem7";
            toolStripMenuItem7.Size = new Size(378, 6);
            // 
            // powershellBlueToolStripMenuItem
            // 
            powershellBlueToolStripMenuItem.BackColor = Color.DarkBlue;
            powershellBlueToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 11F);
            powershellBlueToolStripMenuItem.ForeColor = Color.White;
            powershellBlueToolStripMenuItem.Name = "powershellBlueToolStripMenuItem";
            powershellBlueToolStripMenuItem.Size = new Size(381, 34);
            powershellBlueToolStripMenuItem.Text = "Deep Blue";
            powershellBlueToolStripMenuItem.Click += powershellBlueToolStripMenuItem_Click;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(378, 6);
            // 
            // gildedPurpleToolStripMenuItem
            // 
            gildedPurpleToolStripMenuItem.BackColor = Color.DarkSlateBlue;
            gildedPurpleToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 11F);
            gildedPurpleToolStripMenuItem.ForeColor = Color.Gold;
            gildedPurpleToolStripMenuItem.Name = "gildedPurpleToolStripMenuItem";
            gildedPurpleToolStripMenuItem.Size = new Size(381, 34);
            gildedPurpleToolStripMenuItem.Text = "Gilded Purple";
            gildedPurpleToolStripMenuItem.Click += gildedPurpleToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(378, 6);
            // 
            // deepseaToolStripMenuItem
            // 
            deepseaToolStripMenuItem.BackColor = Color.DarkSlateBlue;
            deepseaToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 11F);
            deepseaToolStripMenuItem.ForeColor = Color.LightSteelBlue;
            deepseaToolStripMenuItem.Name = "deepseaToolStripMenuItem";
            deepseaToolStripMenuItem.Size = new Size(381, 34);
            deepseaToolStripMenuItem.Text = "Slate Blue";
            deepseaToolStripMenuItem.Click += deepseaToolStripMenuItem_Click;
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(378, 6);
            // 
            // oliveGreenToolStripMenuItem
            // 
            oliveGreenToolStripMenuItem.BackColor = Color.DarkOliveGreen;
            oliveGreenToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 11F);
            oliveGreenToolStripMenuItem.ForeColor = Color.LightYellow;
            oliveGreenToolStripMenuItem.Name = "oliveGreenToolStripMenuItem";
            oliveGreenToolStripMenuItem.Size = new Size(381, 34);
            oliveGreenToolStripMenuItem.Text = "Olive Green";
            oliveGreenToolStripMenuItem.Click += forestToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(335, 6);
            // 
            // fontsToolStripMenuItem
            // 
            fontsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuStripFontToolStripMenuItem, mainFontToolStripMenuItem });
            fontsToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 11F);
            fontsToolStripMenuItem.Name = "fontsToolStripMenuItem";
            fontsToolStripMenuItem.Size = new Size(338, 34);
            fontsToolStripMenuItem.Text = "Fonts";
            // 
            // menuStripFontToolStripMenuItem
            // 
            menuStripFontToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { microsoftSansSeriffToolStripMenuItem, cascadiaCodeToolStripMenuItem });
            menuStripFontToolStripMenuItem.Name = "menuStripFontToolStripMenuItem";
            menuStripFontToolStripMenuItem.Size = new Size(270, 34);
            menuStripFontToolStripMenuItem.Text = "Menu Strip Font";
            // 
            // microsoftSansSeriffToolStripMenuItem
            // 
            microsoftSansSeriffToolStripMenuItem.Name = "microsoftSansSeriffToolStripMenuItem";
            microsoftSansSeriffToolStripMenuItem.Size = new Size(315, 38);
            microsoftSansSeriffToolStripMenuItem.Text = "Microsoft Sans Seriff";
            microsoftSansSeriffToolStripMenuItem.Click += microsoftSansSeriffToolStripMenuItem_Click;
            // 
            // cascadiaCodeToolStripMenuItem
            // 
            cascadiaCodeToolStripMenuItem.Font = new Font("Cascadia Code", 11F);
            cascadiaCodeToolStripMenuItem.Name = "cascadiaCodeToolStripMenuItem";
            cascadiaCodeToolStripMenuItem.Size = new Size(315, 38);
            cascadiaCodeToolStripMenuItem.Text = "Cascadia Code";
            cascadiaCodeToolStripMenuItem.Click += cascadiaCodeToolStripMenuItem_Click;
            // 
            // mainFontToolStripMenuItem
            // 
            mainFontToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { microsoftSansSeriffToolStripMenuItem1, cascadiaCodeToolStripMenuItem1 });
            mainFontToolStripMenuItem.Name = "mainFontToolStripMenuItem";
            mainFontToolStripMenuItem.Size = new Size(270, 34);
            mainFontToolStripMenuItem.Text = "Main Font";
            // 
            // microsoftSansSeriffToolStripMenuItem1
            // 
            microsoftSansSeriffToolStripMenuItem1.Name = "microsoftSansSeriffToolStripMenuItem1";
            microsoftSansSeriffToolStripMenuItem1.Size = new Size(315, 38);
            microsoftSansSeriffToolStripMenuItem1.Text = "Microsoft Sans Seriff";
            microsoftSansSeriffToolStripMenuItem1.Click += microsoftSansSeriffToolStripMenuItem1_Click;
            // 
            // cascadiaCodeToolStripMenuItem1
            // 
            cascadiaCodeToolStripMenuItem1.Font = new Font("Cascadia Code", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cascadiaCodeToolStripMenuItem1.Name = "cascadiaCodeToolStripMenuItem1";
            cascadiaCodeToolStripMenuItem1.Size = new Size(315, 38);
            cascadiaCodeToolStripMenuItem1.Text = "Cascadia Code";
            cascadiaCodeToolStripMenuItem1.Click += cascadiaCodeToolStripMenuItem1_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.Black;
            exitButton.BackgroundImageLayout = ImageLayout.None;
            exitButton.Cursor = Cursors.Hand;
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Lucida Sans Unicode", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitButton.ForeColor = SystemColors.ControlLightLight;
            exitButton.Location = new Point(535, 12);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(40, 40);
            exitButton.TabIndex = 2;
            exitButton.Text = "X";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(587, 674);
            Controls.Add(exitButton);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Notepad";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem deleteAllToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem1;
        private ToolStripMenuItem customizeToolStripMenuItem;
        private ToolStripMenuItem notepadThemesToolStripMenuItem;
        private ToolStripMenuItem standerdDarkToolStripMenuItem;
        private ToolStripMenuItem standardLightToolStripMenuItem;
        private ToolStripMenuItem powershellBlueToolStripMenuItem;
        private ToolStripMenuItem deepseaToolStripMenuItem;
        private ToolStripMenuItem oliveGreenToolStripMenuItem;
        private Button exitButton;
        private ToolStripMenuItem gildedPurpleToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem fontsToolStripMenuItem;
        private ToolStripMenuItem menuStripFontToolStripMenuItem;
        private ToolStripMenuItem microsoftSansSeriffToolStripMenuItem;
        private ToolStripMenuItem cascadiaCodeToolStripMenuItem;
        private ToolStripMenuItem mainFontToolStripMenuItem;
        private ToolStripMenuItem microsoftSansSeriffToolStripMenuItem1;
        private ToolStripMenuItem cascadiaCodeToolStripMenuItem1;
        private ToolStripMenuItem creatorsSpecialToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem8;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripSeparator toolStripMenuItem7;
        private ToolStripSeparator toolStripMenuItem5;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripMenuItem6;
    }
}
