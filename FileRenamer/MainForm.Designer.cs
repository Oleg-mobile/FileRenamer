namespace FileRenamer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.openFileDialogToRename = new System.Windows.Forms.OpenFileDialog();
            this.pictureBoxToRename = new System.Windows.Forms.PictureBox();
            this.richTextBoxToRename = new System.Windows.Forms.RichTextBox();
            this.buttonRename = new System.Windows.Forms.Button();
            this.groupBoxRenamingMethods = new System.Windows.Forms.GroupBox();
            this.labelShowSample = new System.Windows.Forms.Label();
            this.labelSample = new System.Windows.Forms.Label();
            this.checkBoxUseOldName = new System.Windows.Forms.CheckBox();
            this.textBoxExpression = new System.Windows.Forms.TextBox();
            this.checkBoxExpression = new System.Windows.Forms.CheckBox();
            this.labelStartWithNumbers = new System.Windows.Forms.Label();
            this.textBoxStartNumber = new System.Windows.Forms.TextBox();
            this.checkBoxNumbers = new System.Windows.Forms.CheckBox();
            this.labelOpenFiles = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxToRename)).BeginInit();
            this.groupBoxRenamingMethods.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialogToRename
            // 
            this.openFileDialogToRename.Multiselect = true;
            this.openFileDialogToRename.Title = "Files to rename";
            // 
            // pictureBoxToRename
            // 
            this.pictureBoxToRename.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxToRename.Image = global::FileRenamer.Properties.Resources.folder1;
            this.pictureBoxToRename.Location = new System.Drawing.Point(30, 30);
            this.pictureBoxToRename.Name = "pictureBoxToRename";
            this.pictureBoxToRename.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxToRename.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxToRename.TabIndex = 0;
            this.pictureBoxToRename.TabStop = false;
            this.pictureBoxToRename.Click += new System.EventHandler(this.pictureBoxToRename_Click);
            // 
            // richTextBoxToRename
            // 
            this.richTextBoxToRename.Location = new System.Drawing.Point(270, 30);
            this.richTextBoxToRename.Name = "richTextBoxToRename";
            this.richTextBoxToRename.Size = new System.Drawing.Size(480, 380);
            this.richTextBoxToRename.TabIndex = 1;
            this.richTextBoxToRename.Text = "";
            // 
            // buttonRename
            // 
            this.buttonRename.Location = new System.Drawing.Point(30, 360);
            this.buttonRename.Name = "buttonRename";
            this.buttonRename.Size = new System.Drawing.Size(140, 50);
            this.buttonRename.TabIndex = 2;
            this.buttonRename.Text = "Rename";
            this.buttonRename.UseVisualStyleBackColor = true;
            this.buttonRename.Click += new System.EventHandler(this.buttonRename_Click);
            // 
            // groupBoxRenamingMethods
            // 
            this.groupBoxRenamingMethods.Controls.Add(this.labelShowSample);
            this.groupBoxRenamingMethods.Controls.Add(this.labelSample);
            this.groupBoxRenamingMethods.Controls.Add(this.checkBoxUseOldName);
            this.groupBoxRenamingMethods.Controls.Add(this.textBoxExpression);
            this.groupBoxRenamingMethods.Controls.Add(this.checkBoxExpression);
            this.groupBoxRenamingMethods.Controls.Add(this.labelStartWithNumbers);
            this.groupBoxRenamingMethods.Controls.Add(this.textBoxStartNumber);
            this.groupBoxRenamingMethods.Controls.Add(this.checkBoxNumbers);
            this.groupBoxRenamingMethods.Location = new System.Drawing.Point(30, 100);
            this.groupBoxRenamingMethods.Name = "groupBoxRenamingMethods";
            this.groupBoxRenamingMethods.Size = new System.Drawing.Size(220, 220);
            this.groupBoxRenamingMethods.TabIndex = 3;
            this.groupBoxRenamingMethods.TabStop = false;
            this.groupBoxRenamingMethods.Text = "Renaming methods";
            // 
            // labelShowSample
            // 
            this.labelShowSample.AutoSize = true;
            this.labelShowSample.Location = new System.Drawing.Point(75, 180);
            this.labelShowSample.Name = "labelShowSample";
            this.labelShowSample.Size = new System.Drawing.Size(57, 15);
            this.labelShowSample.TabIndex = 10;
            this.labelShowSample.Text = "old name";
            // 
            // labelSample
            // 
            this.labelSample.AutoSize = true;
            this.labelSample.Location = new System.Drawing.Point(15, 180);
            this.labelSample.Name = "labelSample";
            this.labelSample.Size = new System.Drawing.Size(49, 15);
            this.labelSample.TabIndex = 9;
            this.labelSample.Text = "Sample:";
            // 
            // checkBoxUseOldName
            // 
            this.checkBoxUseOldName.AutoSize = true;
            this.checkBoxUseOldName.Location = new System.Drawing.Point(15, 135);
            this.checkBoxUseOldName.Name = "checkBoxUseOldName";
            this.checkBoxUseOldName.Size = new System.Drawing.Size(118, 19);
            this.checkBoxUseOldName.TabIndex = 8;
            this.checkBoxUseOldName.Text = "Use the old name";
            this.checkBoxUseOldName.UseVisualStyleBackColor = true;
            this.checkBoxUseOldName.CheckedChanged += new System.EventHandler(this.checkBoxUseOldName_CheckedChanged);
            // 
            // textBoxExpression
            // 
            this.textBoxExpression.Location = new System.Drawing.Point(100, 90);
            this.textBoxExpression.Name = "textBoxExpression";
            this.textBoxExpression.Size = new System.Drawing.Size(100, 23);
            this.textBoxExpression.TabIndex = 7;
            // 
            // checkBoxExpression
            // 
            this.checkBoxExpression.AutoSize = true;
            this.checkBoxExpression.Location = new System.Drawing.Point(15, 90);
            this.checkBoxExpression.Name = "checkBoxExpression";
            this.checkBoxExpression.Size = new System.Drawing.Size(85, 19);
            this.checkBoxExpression.TabIndex = 6;
            this.checkBoxExpression.Text = "Expression:";
            this.checkBoxExpression.UseVisualStyleBackColor = true;
            this.checkBoxExpression.CheckedChanged += new System.EventHandler(this.checkBoxExpression_CheckedChanged);
            // 
            // labelStartWithNumbers
            // 
            this.labelStartWithNumbers.AutoSize = true;
            this.labelStartWithNumbers.Location = new System.Drawing.Point(100, 45);
            this.labelStartWithNumbers.Name = "labelStartWithNumbers";
            this.labelStartWithNumbers.Size = new System.Drawing.Size(60, 15);
            this.labelStartWithNumbers.TabIndex = 2;
            this.labelStartWithNumbers.Text = "Start with:";
            // 
            // textBoxStartNumber
            // 
            this.textBoxStartNumber.Location = new System.Drawing.Point(175, 41);
            this.textBoxStartNumber.Name = "textBoxStartNumber";
            this.textBoxStartNumber.Size = new System.Drawing.Size(25, 23);
            this.textBoxStartNumber.TabIndex = 1;
            this.textBoxStartNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStartNumber_KeyPress);
            // 
            // checkBoxNumbers
            // 
            this.checkBoxNumbers.AutoSize = true;
            this.checkBoxNumbers.Location = new System.Drawing.Point(15, 45);
            this.checkBoxNumbers.Name = "checkBoxNumbers";
            this.checkBoxNumbers.Size = new System.Drawing.Size(71, 19);
            this.checkBoxNumbers.TabIndex = 0;
            this.checkBoxNumbers.Text = "1, 2, 3, ...";
            this.checkBoxNumbers.UseVisualStyleBackColor = true;
            this.checkBoxNumbers.CheckedChanged += new System.EventHandler(this.checkBoxNumbers_CheckedChanged);
            // 
            // labelOpenFiles
            // 
            this.labelOpenFiles.AutoSize = true;
            this.labelOpenFiles.Location = new System.Drawing.Point(100, 50);
            this.labelOpenFiles.Name = "labelOpenFiles";
            this.labelOpenFiles.Size = new System.Drawing.Size(60, 15);
            this.labelOpenFiles.TabIndex = 4;
            this.labelOpenFiles.Text = "Open files";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 457);
            this.Controls.Add(this.labelOpenFiles);
            this.Controls.Add(this.groupBoxRenamingMethods);
            this.Controls.Add(this.buttonRename);
            this.Controls.Add(this.richTextBoxToRename);
            this.Controls.Add(this.pictureBoxToRename);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "File renamer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxToRename)).EndInit();
            this.groupBoxRenamingMethods.ResumeLayout(false);
            this.groupBoxRenamingMethods.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenFileDialog openFileDialogToRename;
        private PictureBox pictureBoxToRename;
        private RichTextBox richTextBoxToRename;
        private Button buttonRename;
        private GroupBox groupBoxRenamingMethods;
        private TextBox textBoxExpression;
        private CheckBox checkBoxExpression;
        private Label labelStartWithNumbers;
        private TextBox textBoxStartNumber;
        private CheckBox checkBoxNumbers;
        private CheckBox checkBoxUseOldName;
        private Label labelSample;
        private Label labelShowSample;
        private Label labelOpenFiles;
    }
}