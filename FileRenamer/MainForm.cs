namespace FileRenamer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            #region Controls init
            textBoxStartNumber.Text = "1";
            textBoxExpression.Text = " - ";
            checkBoxUseOldName.Checked = true;
            #endregion
        }

        private void pictureBoxToRename_Click(object sender, EventArgs e)
        {
            if (openFileDialogToRename.ShowDialog() != DialogResult.OK)
                return;
            richTextBoxToRename.Clear();
            OutputFilesToRichTextBox(openFileDialogToRename.FileNames);
        }

        private void buttonRename_Click(object sender, EventArgs e)
        {
            richTextBoxToRename.Clear();

            if (!openFileDialogToRename.FileNames.Any())
            {
                MessageBox.Show("No files selected!");
                return;
            }

            if (!checkBoxNumbers.Checked && !checkBoxExpression.Checked)
            {
                MessageBox.Show("Changes are not specified!");
                return;
            }

            var renamingMethods = new RenameConfig
            {
                UseNumbers = checkBoxNumbers.Checked,
                UseExpression = checkBoxExpression.Checked,
                UseOldName = checkBoxUseOldName.Checked,
                StartNumber = int.Parse(textBoxStartNumber.Text),
                Expression = textBoxExpression.Text
            };

            Renamer.RenameFiles(renamingMethods, openFileDialogToRename.FileNames);

            var directoryInfo = new DirectoryInfo($"{Path.GetDirectoryName(openFileDialogToRename.FileName)}\\");
            OutputFilesToRichTextBox(directoryInfo.EnumerateFiles().Select(f => Path.GetFileNameWithoutExtension(f.Name)));

            openFileDialogToRename.Dispose();

            richTextBoxToRename.SelectionColor = Color.Blue;
            richTextBoxToRename.AppendText("The End!");
        }

        private void OutputFilesToRichTextBox(IEnumerable<string> array)
        {
            foreach (var fileName in array)
            {
                richTextBoxToRename.AppendText(Path.GetFileNameWithoutExtension(fileName) + "\n");
            }
        }

        public void ShowSampleName()
        {
            string sampleName = string.Empty;

            if (checkBoxNumbers.Checked)
            {
                sampleName = textBoxStartNumber.Text;
            }

            if (checkBoxExpression.Checked)
            {
                sampleName += textBoxExpression.Text;
            }

            if (checkBoxUseOldName.Checked)
            {
                sampleName += "oldName";
            }

            labelShowSample.Text = sampleName;
        }

        #region Controls setup
        private void checkBoxNumbers_CheckedChanged(object sender, EventArgs e)
        {
            ShowSampleName();
        }

        private void checkBoxExpression_CheckedChanged(object sender, EventArgs e)
        {
            ShowSampleName();
        }

        private void checkBoxUseOldName_CheckedChanged(object sender, EventArgs e)
        {
            ShowSampleName();
        }

        private void textBoxStartNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char input = e.KeyChar;
            if (!char.IsDigit(input))
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}
