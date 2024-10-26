
using System.Data;
using System.Windows.Forms;

namespace AppQLNhaThuoc
{
    public partial class Order : Form
    {
        function f = new function();
        string query;

        private Form currentFormchid;
        public void openchildform(Form childform)
        {
            if (currentFormchid != null && currentFormchid.GetType() != childform.GetType())
            {
                currentFormchid.Close();
            }

            currentFormchid = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            childform.BringToFront();
            childform.Show();
        }

        public Order()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataOrder.Rows[e.RowIndex];
                txtMaDH.Text = row.Cells["maDH"].Value.ToString();
                txtMaKH.Text = row.Cells["maKH"].Value.ToString();
                createdAt.Text = row.Cells["ngayDat"].Value.ToString();
                lblTongTien.Text = row.Cells["totalAmount"].Value.ToString();
                lblMaCN.Text = row.Cells["maCN"].Value.ToString();
            }
        }

        private void Order_Load(object sender, System.EventArgs e)
        {
            query = "select * from DONHANG";
            DataSet ds = f.getData(query);
            dataOrder.DataSource = ds.Tables[0];
        }

        private void addMedi_Click(object sender, System.EventArgs e)
        {
            if (txtMaDH != null && txtMaKH != null)
            {
                openchildform(new Option());
                Option option = new Option();
                option.ShowDialog();
            }
        }

        private void delMedi_Click(object sender, System.EventArgs e)
        {
            if (lblMaCN is null)
            {
                string maDH = txtMaDH.Text;
                string query = "DELETE FROM DONHANG WHERE maDH = '" + maDH + "'";

                f.setData(query, "Xóa thành công");
                Order_Load(this, null);
            }
            else
            {
                f.setData(query, "Xóa không thành công");
            }
        }

        private void btnCloseOr_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
