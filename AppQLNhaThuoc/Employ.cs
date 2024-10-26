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

        private void Employ_Load(object sender, EventArgs e)
        {
            query = "select * from KHACHHANG";
            DataSet ds = f.getData(query);
            dataEmploy.DataSource = ds.Tables[0];
        }

        private void dataEmploy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy dòng đang được chọn
                DataGridViewRow row = dataEmploy.Rows[e.RowIndex];

                // Gán giá trị từ các ô của dòng đó vào các textbox
                txtmaKH.Text = row.Cells["maKH"].Value.ToString();
                txttenKH.Text = row.Cells["tenKH"].Value.ToString();
                txtgioiTinh.Text = row.Cells["gioiTinh"].Value.ToString();
                datengaysinh.Value = DateTime.Parse(row.Cells["ngaySinh"].Value.ToString());
                txtdiaChi.Text = row.Cells["diaChi"].Value.ToString();
                txtsoDT.Text = row.Cells["soDT"].Value.ToString();
                txtmaCN.Text = row.Cells["maCN"].Value.ToString();
            }
        }

        private void addEmploy_Click(object sender, EventArgs e)
        {
            if (txtmaKH.Text == "" || txttenKH.Text == "" || datengaysinh.Text == "" || txtgioiTinh.Text == "" || txtdiaChi.Text == "" || txtsoDT.Text == "" || txtmaCN.Text == "")
            {
                MessageBox.Show("Hãy nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string ma = txtmaKH.Text;
                string ten = txttenKH.Text;
                string ngaysinh = datengaysinh.Value.ToString("yyyy-MM-dd");
                string diachi = txtdiaChi.Text;
                string sdt = txtsoDT.Text;
                string gioitinh = txtgioiTinh.Text;
                string macn = txtmaCN.Text;


                query = "INSERT INTO KHACHHANG (maKH, tenKH, ngaySinh, gioiTinh, diaChi, soDT, maCN) VALUES ('" + ma + "', N'" + ten + "', '" + ngaysinh + "', N'" + gioitinh + "', N'" + diachi + "', '" + sdt + "', '" + macn + "')";
                f.setData(query, "Thêm nhân viên thành công");
                Employ_Load(this, null);
                txtmaKH.Clear();
                txttenKH.Clear();
                txtmaCN.Clear();
                txtsoDT.Clear();
                txtdiaChi.Clear();
                txtgioiTinh.Clear();
            }
        }

        private void updateEmploy_Click(object sender, EventArgs e)
        {
            if (txtmaKH.Text == "" || txttenKH.Text == "" || datengaysinh.Text == "" || txtgioiTinh.Text == "" || txtdiaChi.Text == "" || txtsoDT.Text == "" || txtmaCN.Text == "")
            {
                MessageBox.Show("Hãy nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string ma = txtmaKH.Text;
                string ten = txttenKH.Text;
                string ngaysinh = datengaysinh.Value.ToString("yyyy-MM-dd");
                string diachi = txtdiaChi.Text;
                string sdt = txtsoDT.Text;
                string gioitinh = txtgioiTinh.Text;
                string macn = txtmaCN.Text;
                string query = "UPDATE KHACHHANG SET maKH = '" + ma + "', tenKH = N'" + ten + "', ngaySinh = '" + ngaysinh + "',  gioiTinh = N'" + gioitinh + "', diaChi = N'" + diachi + "', soDT = '" + sdt + "', maCN = '" + macn + "' WHERE maKH = '" + ma + "'";
                f.setData(query, "Cập nhật thông tin nhân viên thành công");
                Employ_Load(this, null);
                txtmaKH.Clear();
                txttenKH.Clear();
                txtmaCN.Clear();
                txtsoDT.Clear();
                txtdiaChi.Clear();
                txtgioiTinh.Clear();
            }
        }

        private void delEmploy_Click(object sender, EventArgs e)
        {
            string ma = txtmaKH.Text;
            string query = "DELETE FROM KHACHHANG WHERE maKh = '" + ma + "'";

            f.setData(query, "Xóa nhân viên thành công");
            Employ_Load(this, null);
            txtmaKH.Clear();
            txttenKH.Clear();
            txtmaCN.Clear();
            txtsoDT.Clear();
            txtdiaChi.Clear();
            txtgioiTinh.Clear();
        }

        private void btnCloseEm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
