namespace Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void selectStandardDark()
        {
            standerdDarkToolStripMenuItem.Text = "Standard Dark (CURRENT)";
            standardLightToolStripMenuItem.Text = "Standard Light";
            powershellBlueToolStripMenuItem.Text = "Powershell Blue";
            deepseaToolStripMenuItem.Text = "Deep Sea";
            oliveGreenToolStripMenuItem.Text = "Forest";
            gildedPurpleToolStripMenuItem.Text = "Gilded Purple";
            creatorsSpecialToolStripMenuItem.Text = "Creator's Special";
        }
        public void selectStandardLight()
        {
            standerdDarkToolStripMenuItem.Text = "Standard Dark";
            standardLightToolStripMenuItem.Text = "Standard Light (CURRENT)";
            powershellBlueToolStripMenuItem.Text = "Powershell Blue";
            deepseaToolStripMenuItem.Text = "Deep Sea";
            oliveGreenToolStripMenuItem.Text = "Forest";
            gildedPurpleToolStripMenuItem.Text = "Gilded Purple";
            creatorsSpecialToolStripMenuItem.Text = "Creator's Special";
        }
        public void selectPowerShellBlue()
        {
            standerdDarkToolStripMenuItem.Text = "Standard Dark";
            standardLightToolStripMenuItem.Text = "Standard Light";
            powershellBlueToolStripMenuItem.Text = "Powershell Blue (CURRENT)";
            deepseaToolStripMenuItem.Text = "Deep Sea";
            oliveGreenToolStripMenuItem.Text = "Forest";
            gildedPurpleToolStripMenuItem.Text = "Gilded Purple";
            creatorsSpecialToolStripMenuItem.Text = "Creator's Special";
        }
        public void selectDeepSea()
        {
            standerdDarkToolStripMenuItem.Text = "Standard Dark";
            standardLightToolStripMenuItem.Text = "Standard Light";
            powershellBlueToolStripMenuItem.Text = "Powershell Blue";
            deepseaToolStripMenuItem.Text = "Deep Sea (CURRENT)";
            oliveGreenToolStripMenuItem.Text = "Forest";
            gildedPurpleToolStripMenuItem.Text = "Gilded Purple";
            creatorsSpecialToolStripMenuItem.Text = "Creator's Special";
        }
        public void selectForest()
        {
            standerdDarkToolStripMenuItem.Text = "Standard Dark";
            standardLightToolStripMenuItem.Text = "Standard Light";
            powershellBlueToolStripMenuItem.Text = "Powershell Blue";
            deepseaToolStripMenuItem.Text = "Deep Sea";
            oliveGreenToolStripMenuItem.Text = "Forest (CURRENT)";
            gildedPurpleToolStripMenuItem.Text = "Gilded Purple";
            creatorsSpecialToolStripMenuItem.Text = "Creator's Special";
        }
        public void selectGuildedPurple()
        {
            standerdDarkToolStripMenuItem.Text = "Standard Dark";
            standardLightToolStripMenuItem.Text = "Standard Light";
            powershellBlueToolStripMenuItem.Text = "Powershell Blue";
            deepseaToolStripMenuItem.Text = "Deep Sea";
            oliveGreenToolStripMenuItem.Text = "Forest";
            gildedPurpleToolStripMenuItem.Text = "Gilded Purple (CURRENT)";
            creatorsSpecialToolStripMenuItem.Text = "Creator's Special";
        }
        public void selectCreatorsSpecial()
        {
            standerdDarkToolStripMenuItem.Text = "Standard Dark";
            standardLightToolStripMenuItem.Text = "Standard Light";
            powershellBlueToolStripMenuItem.Text = "Powershell Blue";
            deepseaToolStripMenuItem.Text = "Deep Sea";
            oliveGreenToolStripMenuItem.Text = "Forest";
            gildedPurpleToolStripMenuItem.Text = "Gilded Purple";
            creatorsSpecialToolStripMenuItem.Text = "Creator's Special (CURRENT)";
        }

        // -- Stuff for window dragging --
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }


        // -- File Tools --
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog user = new OpenFileDialog();
            user.Title = "Open";
            user.Filter = "Text Document (*.txt)|*.txt|All Files (*.*)|*.*";

            if (user.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(user.FileName, RichTextBoxStreamType.PlainText);
            }

            this.Text = user.FileName;

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog user = new SaveFileDialog();
            user.Title = "Save";
            user.Filter = "Text Document (*.txt)|*.txt|All Files (*.*)|*.*";

            if (user.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(user.FileName, RichTextBoxStreamType.PlainText);
            }

            this.Text = user.FileName;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        // -- Menu Strip Tools --
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void deleteAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }


        // -- Notepad Themes --

        // Standard Dark Theme
        private void standardDarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectStandardDark();

            // Main form
            this.BackColor = Color.Black;

            // Rich Text Box
            richTextBox1.BackColor = Color.Black;
            richTextBox1.ForeColor = Color.White;

            // Menu Strip
            menuStrip1.BackColor = Color.Black;
            fileToolStripMenuItem.BackColor = Color.Black; fileToolStripMenuItem.ForeColor = Color.White;
            editToolStripMenuItem.BackColor = Color.Black; editToolStripMenuItem.ForeColor = Color.White;
            customizeToolStripMenuItem.BackColor = Color.Black; customizeToolStripMenuItem.ForeColor = Color.White;
            exitButton.BackColor = Color.Black; exitButton.ForeColor = Color.White;
        }

        // Standard Light Theme
        private void standardLightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectStandardLight();

            // Main form
            this.BackColor = Color.White;

            // Rich Text Box
            richTextBox1.BackColor = Color.White;
            richTextBox1.ForeColor = Color.Black;

            // Menu Strip
            menuStrip1.BackColor = Color.White;
            fileToolStripMenuItem.BackColor = Color.White; fileToolStripMenuItem.ForeColor = Color.Black;
            editToolStripMenuItem.BackColor = Color.White; editToolStripMenuItem.ForeColor = Color.Black;
            customizeToolStripMenuItem.BackColor = Color.White; customizeToolStripMenuItem.ForeColor = Color.Black;
            exitButton.BackColor = Color.White; exitButton.ForeColor = Color.Black;
        }

        // Powershell Blue Theme
        private void powershellBlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectPowerShellBlue();

            // Main form
            this.BackColor = Color.DarkBlue;

            // Rich Text Box
            richTextBox1.BackColor = Color.DarkBlue;
            richTextBox1.ForeColor = Color.White;

            // Menu Strip
            menuStrip1.BackColor = Color.DarkBlue;
            fileToolStripMenuItem.BackColor = Color.DarkBlue; fileToolStripMenuItem.ForeColor = Color.White;
            editToolStripMenuItem.BackColor = Color.DarkBlue; editToolStripMenuItem.ForeColor = Color.White;
            customizeToolStripMenuItem.BackColor = Color.DarkBlue; customizeToolStripMenuItem.ForeColor = Color.White;
            exitButton.BackColor = Color.DarkBlue; exitButton.ForeColor = Color.White;
        }

        // Ocean Theme
        private void deepseaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectDeepSea();

            // Main form
            this.BackColor = Color.DarkSlateBlue;

            // Rich Text Box
            richTextBox1.BackColor = Color.DarkSlateBlue;
            richTextBox1.ForeColor = Color.LightSteelBlue;

            // Menu Strip
            menuStrip1.BackColor = Color.DarkSlateBlue;
            fileToolStripMenuItem.BackColor = Color.DarkSlateBlue; fileToolStripMenuItem.ForeColor = Color.LightSteelBlue;
            editToolStripMenuItem.BackColor = Color.DarkSlateBlue; editToolStripMenuItem.ForeColor = Color.LightSteelBlue;
            customizeToolStripMenuItem.BackColor = Color.DarkSlateBlue; customizeToolStripMenuItem.ForeColor = Color.LightSteelBlue;
            exitButton.BackColor = Color.DarkSlateBlue; exitButton.ForeColor = Color.LightSteelBlue;
        }

        // Olive-Green Theme
        private void forestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectForest();

            // Main form
            this.BackColor = Color.DarkOliveGreen;

            // Rich Text Box
            richTextBox1.BackColor = Color.DarkOliveGreen;
            richTextBox1.ForeColor = Color.White;

            // Menu Strip
            menuStrip1.BackColor = Color.DarkOliveGreen;
            fileToolStripMenuItem.BackColor = Color.DarkOliveGreen; fileToolStripMenuItem.ForeColor = Color.LightYellow;
            editToolStripMenuItem.BackColor = Color.DarkOliveGreen; editToolStripMenuItem.ForeColor = Color.LightYellow;
            customizeToolStripMenuItem.BackColor = Color.DarkOliveGreen; customizeToolStripMenuItem.ForeColor = Color.LightYellow;
            exitButton.BackColor = Color.DarkOliveGreen; exitButton.ForeColor = Color.White;
        }

        // Gilded Purple Theme
        private void gildedPurpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectGuildedPurple();

            // Main form
            this.BackColor = Color.DarkSlateBlue;

            // Rich Text Box
            richTextBox1.BackColor = Color.DarkSlateBlue;
            richTextBox1.ForeColor = Color.Thistle;

            // Menu Strip
            menuStrip1.BackColor = Color.DarkSlateBlue;
            fileToolStripMenuItem.BackColor = Color.DarkSlateBlue; fileToolStripMenuItem.ForeColor = Color.Gold;
            editToolStripMenuItem.BackColor = Color.DarkSlateBlue; editToolStripMenuItem.ForeColor = Color.Gold;
            customizeToolStripMenuItem.BackColor = Color.DarkSlateBlue; customizeToolStripMenuItem.ForeColor = Color.Gold;
            exitButton.BackColor = Color.DarkSlateBlue; exitButton.ForeColor = Color.Gold;
        }

        // Creator's Special
        private void creatorsSpecialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectCreatorsSpecial();

            // Main form
            this.BackColor = Color.FromArgb(38, 0, 230);

            // Rich Text Box
            richTextBox1.BackColor = Color.FromArgb(38, 0, 230);
            richTextBox1.ForeColor = Color.FromArgb(25, 255, 178);

            // Menu Strip
            menuStrip1.BackColor = Color.FromArgb(38, 0, 230);
            fileToolStripMenuItem.BackColor = Color.FromArgb(38, 0, 230); fileToolStripMenuItem.ForeColor = Color.FromArgb(25, 255, 178);
            editToolStripMenuItem.BackColor = Color.FromArgb(38, 0, 230); editToolStripMenuItem.ForeColor = Color.FromArgb(25, 255, 178);
            customizeToolStripMenuItem.BackColor = Color.FromArgb(38, 0, 230); customizeToolStripMenuItem.ForeColor = Color.FromArgb(25, 255, 178);
            exitButton.BackColor = Color.FromArgb(38, 0, 230); exitButton.ForeColor = Color.FromArgb(25, 255, 178);
        }


        // -- Fonts --

        // Menu Strip Microsoft Sans Seriff
        private void microsoftSansSeriffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customizeToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Bold);
            editToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Bold);
            fileToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Bold);
        }

        // Menu Strip Cascadia Code
        private void cascadiaCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customizeToolStripMenuItem.Font = new Font("Cascadia Code", 11, FontStyle.Bold);
            editToolStripMenuItem.Font = new Font("Cascadia Code", 11, FontStyle.Bold);
            fileToolStripMenuItem.Font = new Font("Cascadia Code", 11, FontStyle.Bold);
        }

        // Rich-Text-Box Microsoft Sans Seriff
        private void microsoftSansSeriffToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Microsoft Sans Serif", 9);
        }

        private void cascadiaCodeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Cascadia Code", 9);
        }
    }
}
