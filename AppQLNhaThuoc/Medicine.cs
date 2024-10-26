
using System;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace AppQLNhaThuoc
{
    public partial class Medicine : Form
    {
        function f = new function();
        string query;

        public Medicine()
        {
            InitializeComponent();
        }

        private void Medicine_Load(object sender, System.EventArgs e)
        {
            query = "select * from THUOC";
            DataSet ds = f.getData(query);
            dataMedi.DataSource = ds.Tables[0];
        }

        private void addMedi_Click(object sender, System.EventArgs e)
        {
            if (txtMaT.Text == "" || txtTenThuoc.Text == "" || txtSoLuong.Text == ""|| txtGiaBan.Text == ""|| dateTimeHSD.Text == "")
            {
                MessageBox.Show("Hãy nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string ma = txtMaT.Text;
                string ten = txtTenThuoc.Text;
                int so = Convert.ToInt32(txtSoLuong.Text);
                decimal gia = Convert.ToDecimal(txtGiaBan.Text);

                DateTime hsd = dateTimeHSD.Value;

                string maCN1 = "123";

                // Extract year from the selectedDate
                int year = hsd.Year;
                // Định dạng DateTime thành chuỗi
                string dateString = hsd.ToString("MM/dd/yyyy");

                query = "INSERT INTO THUOC (maThuoc, tenThuoc, soLuong, giaBan, hanSuDung) VALUES ('" + ma + "', N'" + ten + "', " + so + ", " + gia + ", '" + hsd + "')";
                f.setData(query, "Thêm nhân viên thành công");
                Medicine_Load(this, null);
            }
        }

        private void updateMedi_Click(object sender, System.EventArgs e)
        {

        }

        private void delMedi_Click(object sender, System.EventArgs e)
        {
            if (lblMaCN is null) {
                string maT = txtMaT.Text;
                string query = "DELETE FROM THUOC WHERE maThuoc = '" + maT + "'";

                f.setData(query, "Xóa thành công");
                Medicine_Load(this, null);
            }
            else
            {
                f.setData(query, "Xóa không thành công do có khóa ngoại");
            }
        }

        private void dataMedi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                DataGridViewRow row = dataMedi.Rows[e.RowIndex];
                txtMaT.Text = row.Cells["maThuoc"].Value.ToString();
                txtTenThuoc.Text = row.Cells["tenThuoc"].Value.ToString();
                txtSoLuong.Text = row.Cells["soLuong"].Value.ToString();
                txtGiaBan.Text = row.Cells["giaBan"].Value.ToString();
                dateTimeHSD.Text = row.Cells["hanSuDung"].Value.ToString();
                lblMaCN.Text = row.Cells["maCN"].Value.ToString();
            }
        }
    }
}
