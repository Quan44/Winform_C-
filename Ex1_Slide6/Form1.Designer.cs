namespace Ex1_Slide6
{
    partial class frmEmployeeDetails
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
            lbTitle = new Label();
            lbEmpID = new Label();
            lbEmpName = new Label();
            lbPhone = new Label();
            lbGender = new Label();
            lbDegree = new Label();
            txtEmployeeID = new TextBox();
            txtEmployeeName = new TextBox();
            mtxtPhone = new MaskedTextBox();
            gbGender = new GroupBox();
            rdFemale = new RadioButton();
            rdMale = new RadioButton();
            cboDegree = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            mnFile = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            ctrlNToolStripMenuItem = new ToolStripMenuItem();
            exitAltXToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            gbGender.SuspendLayout();
            mnFile.SuspendLayout();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.BorderStyle = BorderStyle.FixedSingle;
            lbTitle.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitle.Location = new Point(208, 41);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(286, 47);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Employee Details";
            // 
            // lbEmpID
            // 
            lbEmpID.AutoSize = true;
            lbEmpID.Location = new Point(41, 122);
            lbEmpID.Name = "lbEmpID";
            lbEmpID.Size = new Size(113, 25);
            lbEmpID.TabIndex = 1;
            lbEmpID.Text = "Employee ID";
            // 
            // lbEmpName
            // 
            lbEmpName.AutoSize = true;
            lbEmpName.Location = new Point(41, 179);
            lbEmpName.Name = "lbEmpName";
            lbEmpName.Size = new Size(142, 25);
            lbEmpName.TabIndex = 2;
            lbEmpName.Text = "Employee Name";
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Location = new Point(41, 241);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(62, 25);
            lbPhone.TabIndex = 3;
            lbPhone.Text = "Phone";
            // 
            // lbGender
            // 
            lbGender.AutoSize = true;
            lbGender.Location = new Point(41, 308);
            lbGender.Name = "lbGender";
            lbGender.Size = new Size(69, 25);
            lbGender.TabIndex = 4;
            lbGender.Text = "Gender";
            // 
            // lbDegree
            // 
            lbDegree.AutoSize = true;
            lbDegree.Location = new Point(41, 374);
            lbDegree.Name = "lbDegree";
            lbDegree.Size = new Size(69, 25);
            lbDegree.TabIndex = 5;
            lbDegree.Text = "Degree";
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Location = new Point(226, 122);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new Size(410, 31);
            txtEmployeeID.TabIndex = 6;
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new Point(226, 173);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(410, 31);
            txtEmployeeName.TabIndex = 7;
            // 
            // mtxtPhone
            // 
            mtxtPhone.Location = new Point(226, 235);
            mtxtPhone.Mask = "000-0000000";
            mtxtPhone.Name = "mtxtPhone";
            mtxtPhone.Size = new Size(410, 31);
            mtxtPhone.TabIndex = 8;
            // 
            // gbGender
            // 
            gbGender.Controls.Add(rdFemale);
            gbGender.Controls.Add(rdMale);
            gbGender.Location = new Point(226, 290);
            gbGender.Name = "gbGender";
            gbGender.Size = new Size(410, 59);
            gbGender.TabIndex = 9;
            gbGender.TabStop = false;
            // 
            // rdFemale
            // 
            rdFemale.AutoSize = true;
            rdFemale.Location = new Point(280, 18);
            rdFemale.Name = "rdFemale";
            rdFemale.Size = new Size(93, 29);
            rdFemale.TabIndex = 1;
            rdFemale.Text = "Female";
            rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdMale
            // 
            rdMale.AutoSize = true;
            rdMale.Checked = true;
            rdMale.Location = new Point(35, 18);
            rdMale.Name = "rdMale";
            rdMale.Size = new Size(75, 29);
            rdMale.TabIndex = 0;
            rdMale.TabStop = true;
            rdMale.Text = "Male";
            rdMale.UseVisualStyleBackColor = true;
            // 
            // cboDegree
            // 
            cboDegree.FormattingEnabled = true;
            cboDegree.Items.AddRange(new object[] { "Ph. D.", "Master", "Engineer", "Bachelor", "Technician" });
            cboDegree.Location = new Point(226, 374);
            cboDegree.Name = "cboDegree";
            cboDegree.Size = new Size(410, 33);
            cboDegree.TabIndex = 10;
            cboDegree.Text = "---Select Degree---";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(226, 459);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(155, 46);
            btnSave.TabIndex = 11;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(481, 459);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(155, 46);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // mnFile
            // 
            mnFile.ImageScalingSize = new Size(24, 24);
            mnFile.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, aboutToolStripMenuItem });
            mnFile.Location = new Point(0, 0);
            mnFile.Name = "mnFile";
            mnFile.Size = new Size(713, 33);
            mnFile.TabIndex = 13;
            mnFile.Text = "File";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, ctrlNToolStripMenuItem, exitAltXToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(54, 29);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(270, 34);
            newToolStripMenuItem.Text = "New          Ctrl+N";
            // 
            // ctrlNToolStripMenuItem
            // 
            ctrlNToolStripMenuItem.Name = "ctrlNToolStripMenuItem";
            ctrlNToolStripMenuItem.Size = new Size(270, 34);
            ctrlNToolStripMenuItem.Text = "Open        Ctrl+O";
            // 
            // exitAltXToolStripMenuItem
            // 
            exitAltXToolStripMenuItem.Name = "exitAltXToolStripMenuItem";
            exitAltXToolStripMenuItem.Size = new Size(270, 34);
            exitAltXToolStripMenuItem.Text = "Exit            Alt+X";
            exitAltXToolStripMenuItem.Click += exitAltXToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(78, 29);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // frmEmployeeDetails
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(713, 534);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cboDegree);
            Controls.Add(gbGender);
            Controls.Add(mtxtPhone);
            Controls.Add(txtEmployeeName);
            Controls.Add(txtEmployeeID);
            Controls.Add(lbDegree);
            Controls.Add(lbGender);
            Controls.Add(lbPhone);
            Controls.Add(lbEmpName);
            Controls.Add(lbEmpID);
            Controls.Add(lbTitle);
            Controls.Add(mnFile);
            MainMenuStrip = mnFile;
            Name = "frmEmployeeDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee Details";
            gbGender.ResumeLayout(false);
            gbGender.PerformLayout();
            mnFile.ResumeLayout(false);
            mnFile.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitle;
        private Label lbEmpID;
        private Label lbEmpName;
        private Label lbPhone;
        private Label lbGender;
        private Label lbDegree;
        private TextBox txtEmployeeID;
        private TextBox txtEmployeeName;
        private MaskedTextBox mtxtPhone;
        private GroupBox gbGender;
        private RadioButton rdMale;
        private RadioButton rdFemale;
        private ComboBox cboDegree;
        private Button btnSave;
        private Button btnCancel;
        private MenuStrip mnFile;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem ctrlNToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem exitAltXToolStripMenuItem;
    }
}
