namespace Account_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPass.Text) || string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("You have not entered full information !!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // tạo mới một ListViewItem
                ListViewItem lstvItem = new ListViewItem();

                lstvItem.Text = txtName.Text;

                ListViewItem.ListViewSubItem lstvsub = new ListViewItem.ListViewSubItem(lstvItem, txtPass.Text);

                ListViewItem.ListViewSubItem lstvsub1 = new ListViewItem.ListViewSubItem(lstvItem, txtID.Text);

                // thêm các thông tin vào các cột tương ứng trong ListView

                lstvItem.SubItems.Add(lstvsub);

                lstvItem.SubItems.Add(lstvsub1);

                listView1.Items.Add(lstvItem);

                MessageBox.Show("You have successfuly added your account", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // sau khi thêm thông tin ta sẽ xóa các thông tin đã nhập ở các ô textbox để có thể nhập và thêm mới tài khoản khác.

                txtName.Clear();

                txtPass.Clear();

                txtID.Clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count <= 0)

            {
                MessageBox.Show("You have not selected the item you want to delete", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (listView1.SelectedIndices.Count > 0)

            {
                DialogResult dl = MessageBox.Show("Bạn muốn xóa", "canh bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (dl == DialogResult.OK)

                    listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You want exit Application", "Ask client", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                Dispose();
        }
    }
}
