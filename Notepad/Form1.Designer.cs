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
            standardLightToolStripMenuItem = new ToolStripMenuItem();
            powershellBlueToolStripMenuItem = new ToolStripMenuItem();
            deepseaToolStripMenuItem = new ToolStripMenuItem();
            oliveGreenToolStripMenuItem = new ToolStripMenuItem();
            textBox1 = new TextBox();
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
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, customizeToolStripMenuItem });
            menuStrip1.Location = new Point(12, 12);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(229, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.BackColor = Color.Black;
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, saveToolStripMenuItem, exitToolStripMenuItem, editToolStripMenuItem1 });
            fileToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9F);
            fileToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(55, 26);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(154, 34);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(154, 34);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(154, 34);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(154, 34);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem1
            // 
            editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            editToolStripMenuItem1.Size = new Size(154, 34);
            editToolStripMenuItem1.Text = "Edit";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.BackColor = Color.Black;
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, toolStripMenuItem1, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, toolStripMenuItem2, deleteAllToolStripMenuItem, selectAllToolStripMenuItem });
            editToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(57, 26);
            editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.Size = new Size(185, 34);
            undoToolStripMenuItem.Text = "Undo";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.Size = new Size(185, 34);
            redoToolStripMenuItem.Text = "Redo";
            redoToolStripMenuItem.Click += redoToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(182, 6);
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new Size(185, 34);
            cutToolStripMenuItem.Text = "Cut";
            cutToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(185, 34);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(185, 34);
            pasteToolStripMenuItem.Text = "Paste";
            pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(182, 6);
            // 
            // deleteAllToolStripMenuItem
            // 
            deleteAllToolStripMenuItem.Name = "deleteAllToolStripMenuItem";
            deleteAllToolStripMenuItem.Size = new Size(185, 34);
            deleteAllToolStripMenuItem.Text = "Delete all";
            deleteAllToolStripMenuItem.Click += deleteAllToolStripMenuItem_Click;
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.Size = new Size(185, 34);
            selectAllToolStripMenuItem.Text = "Select all";
            selectAllToolStripMenuItem.Click += selectAllToolStripMenuItem_Click;
            // 
            // customizeToolStripMenuItem
            // 
            customizeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { notepadThemesToolStripMenuItem });
            customizeToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9F);
            customizeToolStripMenuItem.ForeColor = SystemColors.ControlLightLight;
            customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            customizeToolStripMenuItem.Size = new Size(109, 26);
            customizeToolStripMenuItem.Text = "Customize";
            // 
            // notepadThemesToolStripMenuItem
            // 
            notepadThemesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { standerdDarkToolStripMenuItem, standardLightToolStripMenuItem, powershellBlueToolStripMenuItem, deepseaToolStripMenuItem, oliveGreenToolStripMenuItem });
            notepadThemesToolStripMenuItem.Name = "notepadThemesToolStripMenuItem";
            notepadThemesToolStripMenuItem.Size = new Size(296, 34);
            notepadThemesToolStripMenuItem.Text = "Notepad Color Themes";
            // 
            // standerdDarkToolStripMenuItem
            // 
            standerdDarkToolStripMenuItem.BackColor = Color.Black;
            standerdDarkToolStripMenuItem.ForeColor = Color.White;
            standerdDarkToolStripMenuItem.Name = "standerdDarkToolStripMenuItem";
            standerdDarkToolStripMenuItem.Size = new Size(332, 34);
            standerdDarkToolStripMenuItem.Text = "Standard Dark (CURRENT)";
            standerdDarkToolStripMenuItem.Click += standardDarkToolStripMenuItem_Click;
            // 
            // standardLightToolStripMenuItem
            // 
            standardLightToolStripMenuItem.Name = "standardLightToolStripMenuItem";
            standardLightToolStripMenuItem.Size = new Size(332, 34);
            standardLightToolStripMenuItem.Text = "Standard Light";
            standardLightToolStripMenuItem.Click += standardLightToolStripMenuItem_Click;
            // 
            // powershellBlueToolStripMenuItem
            // 
            powershellBlueToolStripMenuItem.BackColor = Color.DarkBlue;
            powershellBlueToolStripMenuItem.ForeColor = Color.White;
            powershellBlueToolStripMenuItem.Name = "powershellBlueToolStripMenuItem";
            powershellBlueToolStripMenuItem.Size = new Size(332, 34);
            powershellBlueToolStripMenuItem.Text = "Powershell Blue";
            powershellBlueToolStripMenuItem.Click += powershellBlueToolStripMenuItem_Click;
            // 
            // deepseaToolStripMenuItem
            // 
            deepseaToolStripMenuItem.BackColor = Color.DarkSlateBlue;
            deepseaToolStripMenuItem.ForeColor = Color.LightSteelBlue;
            deepseaToolStripMenuItem.Name = "deepseaToolStripMenuItem";
            deepseaToolStripMenuItem.Size = new Size(332, 34);
            deepseaToolStripMenuItem.Text = "Slate Blue";
            deepseaToolStripMenuItem.Click += deepseaToolStripMenuItem_Click;
            // 
            // oliveGreenToolStripMenuItem
            // 
            oliveGreenToolStripMenuItem.BackColor = Color.DarkOliveGreen;
            oliveGreenToolStripMenuItem.ForeColor = Color.LightYellow;
            oliveGreenToolStripMenuItem.Name = "oliveGreenToolStripMenuItem";
            oliveGreenToolStripMenuItem.Size = new Size(332, 34);
            oliveGreenToolStripMenuItem.Text = "Olive Green";
            oliveGreenToolStripMenuItem.Click += forestToolStripMenuItem_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Black;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = Color.Gray;
            textBox1.Location = new Point(244, 11);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(331, 31);
            textBox1.TabIndex = 2;
            textBox1.Text = "Search (NOT WORKING)";
            textBox1.MouseEnter += textBox1_MouseEnter;
            textBox1.MouseLeave += textBox1_MouseLeave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(587, 674);
            Controls.Add(textBox1);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
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
        private TextBox textBox1;
        private ToolStripMenuItem customizeToolStripMenuItem;
        private ToolStripMenuItem notepadThemesToolStripMenuItem;
        private ToolStripMenuItem standerdDarkToolStripMenuItem;
        private ToolStripMenuItem standardLightToolStripMenuItem;
        private ToolStripMenuItem powershellBlueToolStripMenuItem;
        private ToolStripMenuItem deepseaToolStripMenuItem;
        private ToolStripMenuItem oliveGreenToolStripMenuItem;
    }
}
