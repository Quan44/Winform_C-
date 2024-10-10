namespace Lab_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtSom.Select();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            double n = double.Parse(txtSon.Text);
            double m = double.Parse(txtSom.Text);
            double Tong = n + m;
            txtKetQua.Text = Tong.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtSon.Text = "";
            txtSom.Text = "";
            txtKetQua.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            double n = double.Parse(txtSon.Text);
            double m = double.Parse(txtSom.Text);
            double Hieu = n - m;
            txtKetQua.Text = Hieu.ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            double n = double.Parse(txtSon.Text);
            double m = double.Parse(txtSom.Text);
            double Nhan = n * m;
            txtKetQua.Text = Nhan.ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            double n = double.Parse(txtSon.Text);
            double m = double.Parse(txtSom.Text);
            double Chia = n / m;
            txtKetQua.Text = Chia.ToString();
        }
    }
}
