namespace Account_Management
{
    partial class Form1
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
            toolStripContainer1 = new ToolStripContainer();
            lbTitle = new Label();
            splitContainer1 = new SplitContainer();
            groupBox1 = new GroupBox();
            btnExit = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            groupBox2 = new GroupBox();
            listView1 = new ListView();
            clnName = new ColumnHeader();
            clnPass = new ColumnHeader();
            clnID = new ColumnHeader();
            txtID = new TextBox();
            txtPass = new TextBox();
            txtName = new TextBox();
            lbID = new Label();
            lbPass = new Label();
            lbAccName = new Label();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.BackColor = Color.FromArgb(255, 255, 128);
            toolStripContainer1.ContentPanel.Controls.Add(lbTitle);
            toolStripContainer1.ContentPanel.Size = new Size(1026, 81);
            toolStripContainer1.Location = new Point(0, 0);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(1026, 106);
            toolStripContainer1.TabIndex = 0;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitle.ForeColor = Color.Blue;
            lbTitle.Location = new Point(272, 31);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(532, 45);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Account Management Application";
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(1, 107);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox2);
            splitContainer1.Size = new Size(1025, 407);
            splitContainer1.SplitterDistance = 341;
            splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnExit);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(4, -1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(338, 406);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select the action";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(128, 255, 128);
            btnExit.Location = new Point(60, 304);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(207, 50);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit Application";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(128, 255, 128);
            btnDelete.Location = new Point(60, 192);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(207, 50);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete Account";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(128, 255, 128);
            btnAdd.Location = new Point(60, 80);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(207, 50);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add Account";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listView1);
            groupBox2.Controls.Add(txtID);
            groupBox2.Controls.Add(txtPass);
            groupBox2.Controls.Add(txtName);
            groupBox2.Controls.Add(lbID);
            groupBox2.Controls.Add(lbPass);
            groupBox2.Controls.Add(lbAccName);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(6, -1);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(670, 406);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Enter Infomation";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { clnName, clnPass, clnID });
            listView1.Location = new Point(31, 214);
            listView1.Name = "listView1";
            listView1.Size = new Size(608, 176);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // clnName
            // 
            clnName.Text = "Account name";
            clnName.Width = 200;
            // 
            // clnPass
            // 
            clnPass.Text = "Account password";
            clnPass.Width = 250;
            // 
            // clnID
            // 
            clnID.Text = "Account ID";
            clnID.Width = 200;
            // 
            // txtID
            // 
            txtID.Location = new Point(235, 155);
            txtID.Name = "txtID";
            txtID.Size = new Size(402, 39);
            txtID.TabIndex = 5;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(235, 98);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(402, 39);
            txtPass.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(235, 40);
            txtName.Name = "txtName";
            txtName.Size = new Size(402, 39);
            txtName.TabIndex = 3;
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbID.Location = new Point(32, 160);
            lbID.Name = "lbID";
            lbID.Size = new Size(33, 28);
            lbID.TabIndex = 2;
            lbID.Text = "ID";
            // 
            // lbPass
            // 
            lbPass.AutoSize = true;
            lbPass.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPass.Location = new Point(31, 103);
            lbPass.Name = "lbPass";
            lbPass.Size = new Size(185, 28);
            lbPass.TabIndex = 1;
            lbPass.Text = "Account password";
            // 
            // lbAccName
            // 
            lbAccName.AutoSize = true;
            lbAccName.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAccName.Location = new Point(31, 45);
            lbAccName.Name = "lbAccName";
            lbAccName.Size = new Size(148, 28);
            lbAccName.TabIndex = 0;
            lbAccName.Text = "Account name";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 513);
            Controls.Add(splitContainer1);
            Controls.Add(toolStripContainer1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.ContentPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStripContainer toolStripContainer1;
        private Label lbTitle;
        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
        private Button btnExit;
        private Button btnDelete;
        private Button btnAdd;
        private GroupBox groupBox2;
        private TextBox txtID;
        private TextBox txtPass;
        private TextBox txtName;
        private Label lbID;
        private Label lbPass;
        private Label lbAccName;
        private ListView listView1;
        private ColumnHeader clnName;
        private ColumnHeader clnPass;
        private ColumnHeader clnID;
    }
}
