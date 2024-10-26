using System;
using System.Data;
using System.Windows.Forms;

namespace AppQLNhaThuoc
{
    public partial class Warehouse : Form
    {
        function f = new function();
        string query;
        public Warehouse()
        {
            InitializeComponent();
        }

        private void Warehouse_Load(object sender, EventArgs e)
        {
            query = "select * from CT_DONHANG";
            DataSet ds = f.getData(query);
            dataWare.DataSource = ds.Tables[0];
        }

        private void addCate_Click(object sender, EventArgs e)
        {
            if (txtmaDH.Text == "" || txtmaThuoc.Text == "" || txtsoLuong.Text == "" || txtdonGia.Text == "")
            {
                MessageBox.Show("Hãy nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string maDH = txtmaDH.Text;
                string maThuoc = txtmaThuoc.Text;
                string soLuong = txtsoLuong.Text;
                string donGia = txtdonGia.Text;


                query = "INSERT INTO CT_DONHANG (maDH, maThuoc, soLuong, donGia) VALUES ('" + maDH + "', '" + maThuoc + "', '" + soLuong + "', '" + donGia + "')";
                f.setData(query, "Thêm chi tiết đơn hàng thành công");
                Warehouse_Load(this, null);
                txtmaDH.Clear();
                txtmaThuoc.Clear();
                txtsoLuong.Clear();
                txtdonGia.Clear();
            }
        }

        private void updateCate_Click(object sender, EventArgs e)
        {
            if (txtmaDH.Text == "" || txtmaThuoc.Text == "" || txtsoLuong.Text == "" || txtdonGia.Text == "")
            {
                MessageBox.Show("Hãy nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string maDH = txtmaDH.Text;
                string maThuoc = txtmaThuoc.Text;
                string soLuong = txtsoLuong.Text;
                string donGia = txtdonGia.Text;


                string query = "UPDATE CT_DONHANG SET maDH = '" + maDH + "', maThuoc = '" + maThuoc + "', soLuong = '" + soLuong + "',  donGia = '" + donGia + "' WHERE maDH = '" + maThuoc + "'";
                f.setData(query, "Cập nhật thông tin chi tiết đơn hàng thành công");

                Warehouse_Load(this, null);
                txtmaDH.Clear();
                txtmaThuoc.Clear();
                txtsoLuong.Clear();
                txtdonGia.Clear();
            }
        }

        private void delCate_Click(object sender, EventArgs e)
        {
            string maDH = txtmaDH.Text;
            string query = "DELETE FROM CT_DONHANG WHERE maDH = '" + maDH + "'";

            f.setData(query, "Xóa đơn hàng thành công");
            Warehouse_Load(this, null);
            txtmaDH.Clear();
            txtmaThuoc.Clear();
            txtsoLuong.Clear();
            txtdonGia.Clear();
        }

        private void dataWare_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy dòng đang được chọn
                DataGridViewRow row = dataWare.Rows[e.RowIndex];

                // Gán giá trị từ các ô của dòng đó vào các textbox
                txtmaDH.Text = row.Cells["maDH"].Value.ToString();
                txtmaThuoc.Text = row.Cells["maThuoc"].Value.ToString();
                txtsoLuong.Text = row.Cells["soLuong"].Value.ToString();
                txtdonGia.Text = row.Cells["donGia"].Value.ToString();
            }
        }

        private void btnCloseWa_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
