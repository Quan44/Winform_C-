namespace Demo_Cong2So
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
            lblTong = new Label();
            btnCal = new Button();
            btnRInput = new Button();
            btnExit = new Button();
            lblNum1 = new Label();
            lblNum2 = new Label();
            txtSum = new TextBox();
            txtNum2 = new TextBox();
            txtNum1 = new TextBox();
            lblTittle = new Label();
            SuspendLayout();
            // 
            // lblTong
            // 
            lblTong.AutoSize = true;
            lblTong.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTong.Location = new Point(114, 298);
            lblTong.Name = "lblTong";
            lblTong.Size = new Size(114, 30);
            lblTong.TabIndex = 0;
            lblTong.Text = "Tổng 2 số";
            // 
            // btnCal
            // 
            btnCal.Location = new Point(114, 388);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(112, 34);
            btnCal.TabIndex = 1;
            btnCal.Text = "Tính tổng";
            btnCal.UseVisualStyleBackColor = true;
            btnCal.Click += btnCal_Click;
            // 
            // btnRInput
            // 
            btnRInput.Location = new Point(349, 388);
            btnRInput.Name = "btnRInput";
            btnRInput.Size = new Size(112, 34);
            btnRInput.TabIndex = 2;
            btnRInput.Text = "Nhập lại";
            btnRInput.UseVisualStyleBackColor = true;
            btnRInput.Click += btnRInput_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(562, 388);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 3;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNum1.Location = new Point(114, 128);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(134, 30);
            lblNum1.TabIndex = 4;
            lblNum1.Text = "Số thứ nhất";
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNum2.Location = new Point(114, 212);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(118, 30);
            lblNum2.TabIndex = 5;
            lblNum2.Text = "Số thứ hai";
            // 
            // txtSum
            // 
            txtSum.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSum.Location = new Point(288, 295);
            txtSum.Name = "txtSum";
            txtSum.ReadOnly = true;
            txtSum.Size = new Size(386, 37);
            txtSum.TabIndex = 6;
            // 
            // txtNum2
            // 
            txtNum2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNum2.Location = new Point(288, 209);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(386, 37);
            txtNum2.TabIndex = 7;
            // 
            // txtNum1
            // 
            txtNum1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNum1.Location = new Point(288, 125);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(386, 37);
            txtNum1.TabIndex = 8;
            // 
            // lblTittle
            // 
            lblTittle.AutoSize = true;
            lblTittle.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTittle.Location = new Point(288, 27);
            lblTittle.Name = "lblTittle";
            lblTittle.Size = new Size(245, 45);
            lblTittle.TabIndex = 9;
            lblTittle.Text = "Tính tổng 2 số";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTittle);
            Controls.Add(txtNum1);
            Controls.Add(txtNum2);
            Controls.Add(txtSum);
            Controls.Add(lblNum2);
            Controls.Add(lblNum1);
            Controls.Add(btnExit);
            Controls.Add(btnRInput);
            Controls.Add(btnCal);
            Controls.Add(lblTong);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTong;
        private Button btnCal;
        private Button btnRInput;
        private Button btnExit;
        private Label lblNum1;
        private Label lblNum2;
        private TextBox txtSum;
        private TextBox txtNum2;
        private TextBox txtNum1;
        private Label lblTittle;
    }
}
