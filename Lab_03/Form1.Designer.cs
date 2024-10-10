namespace Lab_03
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
            label1 = new Label();
            txtKetQua = new TextBox();
            txtSon = new TextBox();
            txtSom = new TextBox();
            lnSon = new Label();
            lbSom = new Label();
            lbKetQua = new Label();
            btnCong = new Button();
            btnTru = new Button();
            btnNhan = new Button();
            btnChia = new Button();
            btnXoa = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(97, 25);
            label1.Name = "label1";
            label1.Size = new Size(399, 45);
            label1.TabIndex = 0;
            label1.Text = "Thực hiện các phép tính";
            // 
            // txtKetQua
            // 
            txtKetQua.Location = new Point(225, 254);
            txtKetQua.Name = "txtKetQua";
            txtKetQua.ReadOnly = true;
            txtKetQua.Size = new Size(271, 31);
            txtKetQua.TabIndex = 1;
            // 
            // txtSon
            // 
            txtSon.Location = new Point(225, 182);
            txtSon.Name = "txtSon";
            txtSon.Size = new Size(271, 31);
            txtSon.TabIndex = 2;
            // 
            // txtSom
            // 
            txtSom.Location = new Point(225, 103);
            txtSom.Name = "txtSom";
            txtSom.Size = new Size(271, 31);
            txtSom.TabIndex = 3;
            // 
            // lnSon
            // 
            lnSon.AutoSize = true;
            lnSon.Font = new Font("Calibri", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnSon.Location = new Point(73, 106);
            lnSon.Name = "lnSon";
            lnSon.Size = new Size(106, 24);
            lnSon.TabIndex = 4;
            lnSon.Text = "Nhập số m:";
            // 
            // lbSom
            // 
            lbSom.AutoSize = true;
            lbSom.Font = new Font("Calibri", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSom.Location = new Point(73, 185);
            lbSom.Name = "lbSom";
            lbSom.Size = new Size(101, 24);
            lbSom.TabIndex = 5;
            lbSom.Text = "Nhập số n:";
            // 
            // lbKetQua
            // 
            lbKetQua.AutoSize = true;
            lbKetQua.Font = new Font("Calibri", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbKetQua.Location = new Point(73, 254);
            lbKetQua.Name = "lbKetQua";
            lbKetQua.Size = new Size(81, 24);
            lbKetQua.TabIndex = 6;
            lbKetQua.Text = "Kết quả:";
            // 
            // btnCong
            // 
            btnCong.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCong.Location = new Point(47, 311);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(42, 41);
            btnCong.TabIndex = 7;
            btnCong.Text = "+";
            btnCong.UseVisualStyleBackColor = true;
            btnCong.Click += btnCong_Click;
            // 
            // btnTru
            // 
            btnTru.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTru.Location = new Point(121, 311);
            btnTru.Name = "btnTru";
            btnTru.Size = new Size(42, 41);
            btnTru.TabIndex = 8;
            btnTru.Text = "-";
            btnTru.UseVisualStyleBackColor = true;
            btnTru.Click += btnTru_Click;
            // 
            // btnNhan
            // 
            btnNhan.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNhan.Location = new Point(195, 311);
            btnNhan.Name = "btnNhan";
            btnNhan.Size = new Size(42, 41);
            btnNhan.TabIndex = 9;
            btnNhan.Text = "*";
            btnNhan.UseVisualStyleBackColor = true;
            btnNhan.Click += btnNhan_Click;
            // 
            // btnChia
            // 
            btnChia.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChia.Location = new Point(269, 311);
            btnChia.Name = "btnChia";
            btnChia.Size = new Size(42, 41);
            btnChia.TabIndex = 10;
            btnChia.Text = "/";
            btnChia.UseVisualStyleBackColor = true;
            btnChia.Click += btnChia_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(343, 311);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(76, 41);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(451, 311);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(96, 41);
            btnExit.TabIndex = 12;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 373);
            Controls.Add(btnExit);
            Controls.Add(btnXoa);
            Controls.Add(btnChia);
            Controls.Add(btnNhan);
            Controls.Add(btnTru);
            Controls.Add(btnCong);
            Controls.Add(lbKetQua);
            Controls.Add(lbSom);
            Controls.Add(lnSon);
            Controls.Add(txtSom);
            Controls.Add(txtSon);
            Controls.Add(txtKetQua);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtKetQua;
        private TextBox txtSon;
        private TextBox txtSom;
        private Label lnSon;
        private Label lbSom;
        private Label lbKetQua;
        private Button btnCong;
        private Button btnTru;
        private Button btnNhan;
        private Button btnChia;
        private Button btnXoa;
        private Button btnExit;
    }
}
