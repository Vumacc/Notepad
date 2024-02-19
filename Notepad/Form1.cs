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
        }
        public void selectStandardLight()
        {
            standerdDarkToolStripMenuItem.Text = "Standard Dark";
            standardLightToolStripMenuItem.Text = "Standard Light (CURRENT)";
            powershellBlueToolStripMenuItem.Text = "Powershell Blue";
            deepseaToolStripMenuItem.Text = "Deep Sea";
            oliveGreenToolStripMenuItem.Text = "Forest";
        }
        public void selectPowerShellBlue()
        {
            standerdDarkToolStripMenuItem.Text = "Standard Dark";
            standardLightToolStripMenuItem.Text = "Standard Light";
            powershellBlueToolStripMenuItem.Text = "Powershell Blue (CURRENT)";
            deepseaToolStripMenuItem.Text = "Deep Sea";
            oliveGreenToolStripMenuItem.Text = "Forest";
        }
        public void selectDeepSea()
        {
            standerdDarkToolStripMenuItem.Text = "Standard Dark";
            standardLightToolStripMenuItem.Text = "Standard Light";
            powershellBlueToolStripMenuItem.Text = "Powershell Blue";
            deepseaToolStripMenuItem.Text = "Deep Sea (CURRENT)";
            oliveGreenToolStripMenuItem.Text = "Forest";
        }
        public void selectForest()
        {
            standerdDarkToolStripMenuItem.Text = "Standard Dark";
            standardLightToolStripMenuItem.Text = "Standard Light";
            powershellBlueToolStripMenuItem.Text = "Powershell Blue";
            deepseaToolStripMenuItem.Text = "Deep Sea";
            oliveGreenToolStripMenuItem.Text = "Forest (CURRENT)";
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


        // -- Edit Tools --
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

            // Search Box
            textBox1.BackColor = Color.Black;
            textBox1.ForeColor = Color.White;

            // Menu Strip
            menuStrip1.BackColor = Color.Black;
            fileToolStripMenuItem.BackColor = Color.Black; fileToolStripMenuItem.ForeColor = Color.White;
            editToolStripMenuItem.BackColor = Color.Black; editToolStripMenuItem.ForeColor = Color.White;
            customizeToolStripMenuItem.BackColor = Color.Black; customizeToolStripMenuItem.ForeColor = Color.White;
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

            // Search Box
            textBox1.BackColor = Color.White;
            textBox1.ForeColor = Color.Black;

            // Menu Strip
            menuStrip1.BackColor = Color.White;
            fileToolStripMenuItem.BackColor = Color.White; fileToolStripMenuItem.ForeColor = Color.Black;
            editToolStripMenuItem.BackColor = Color.White; editToolStripMenuItem.ForeColor = Color.Black;
            customizeToolStripMenuItem.BackColor = Color.White; customizeToolStripMenuItem.ForeColor = Color.Black;
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

            // Search Box
            textBox1.BackColor = Color.White;
            textBox1.ForeColor = Color.Black;

            // Menu Strip
            menuStrip1.BackColor = Color.DarkBlue;
            fileToolStripMenuItem.BackColor = Color.DarkBlue; fileToolStripMenuItem.ForeColor = Color.White;
            editToolStripMenuItem.BackColor = Color.DarkBlue; editToolStripMenuItem.ForeColor = Color.White;
            customizeToolStripMenuItem.BackColor = Color.DarkBlue; customizeToolStripMenuItem.ForeColor = Color.White;
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

            // Search Box
            textBox1.BackColor = Color.LightSteelBlue;
            textBox1.ForeColor = Color.DarkSlateBlue;

            // Menu Strip
            menuStrip1.BackColor = Color.DarkSlateBlue;
            fileToolStripMenuItem.BackColor = Color.DarkSlateBlue; fileToolStripMenuItem.ForeColor = Color.LightSteelBlue;
            editToolStripMenuItem.BackColor = Color.DarkSlateBlue; editToolStripMenuItem.ForeColor = Color.LightSteelBlue;
            customizeToolStripMenuItem.BackColor = Color.DarkSlateBlue; customizeToolStripMenuItem.ForeColor = Color.LightSteelBlue;
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

            // Search Box
            textBox1.BackColor = Color.LightYellow;
            textBox1.ForeColor = Color.DarkOliveGreen;

            // Menu Strip
            menuStrip1.BackColor = Color.DarkOliveGreen;
            fileToolStripMenuItem.BackColor = Color.DarkOliveGreen; fileToolStripMenuItem.ForeColor = Color.LightYellow;
            editToolStripMenuItem.BackColor = Color.DarkOliveGreen; editToolStripMenuItem.ForeColor = Color.LightYellow;
            customizeToolStripMenuItem.BackColor = Color.DarkOliveGreen; customizeToolStripMenuItem.ForeColor = Color.LightYellow;
        }


        // -- Search Box --
        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            textBox1.Text = "Search (NOT WORKING)";
        }
    }
}
