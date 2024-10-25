using System;
using System.Data;
using System.Windows.Forms;

namespace AppQLNhaThuoc
{
    public partial class Employ : Form
    {
        function f = new function();
        string query;
        public Employ()
        {
            InitializeComponent();
        }

        private void addEmploy_Click(object sender, EventArgs e)
        {
            if (txtcode.Text == "" || txtname.Text == "" || txtphone.Text == "")
            {
                MessageBox.Show("Hãy nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string code = txtcode.Text;
                string name = txtname.Text;
                string phone = txtphone.Text;
                query = "INSERT INTO Employee (EmployeeCode, FullName, Phone) VALUES ('" + code + "', N'" + name + "', '" + phone + "')";
                f.setData(query, "Thêm nhân viên thành công");
                Employ_Load(this, null);
            }
        }

        private void updateEmploy_Click(object sender, EventArgs e)
        {
            if (txtcode.Text == "" || txtname.Text == "" || txtphone.Text == "")
            {
                MessageBox.Show("Hãy nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string code = txtcode.Text;
                string name = txtname.Text;
                string phone = txtphone.Text;
                string query = "UPDATE Employee SET EmployeeCode = '" + code + "', FullName = N'" + name + "', Phone = '" + phone + "' WHERE EmployeeCode = '" + code + "'";
                f.setData(query, "Cập nhật thông tin nhân viên thành công");
                Employ_Load(this, null);
            }
        }

        private void delEmploy_Click(object sender, EventArgs e)
        {
            string code = txtcode.Text;
            string query = "DELETE FROM Employee WHERE EmployeeCode = '" + code + "'";

            f.setData(query, "Xóa nhân viên thành công");
            Employ_Load(this, null);
        }

        private void Employ_Load(object sender, EventArgs e)
        {
            query = "select * from Employee";
            DataSet ds = f.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}