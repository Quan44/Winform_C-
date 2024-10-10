namespace Demo_Cong2So
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            double a = 0, b = 0;
            try
            {
                a = Convert.ToDouble(txtNum1.Text);
                b = Convert.ToDouble(txtNum2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error number" + ex.Message);
            }

            double sum = a + b;
            txtSum.Text = sum.ToString();
        }
        private void btnRInput_Click(object sender, EventArgs e)
        {
            txtNum1.Text = string.Empty;
            txtNum2.Text = string.Empty;
            txtSum.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNum1.Select();
        }
    }
}
