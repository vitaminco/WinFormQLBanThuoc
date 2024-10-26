using System;
using System.Data;
using System.Windows.Forms;

namespace AppQLNhaThuoc
{
    public partial class Option : Form
    {
        function f = new function();
        string query;
        public Option()
        {
            InitializeComponent();
        }

        private void Option_Load(object sender, EventArgs e)
        {
            query = "select * from THUOC";
            DataSet ds = f.getData(query);
            dataOption.DataSource = ds.Tables[0];
        }

        private void dataOption_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataOption.Rows[e.RowIndex];
                lblTen.Text = row.Cells["tenThuoc"].Value.ToString();
                lblGia.Text = row.Cells["giaBan"].Value.ToString();
                lblHSD.Text = row.Cells["hanSuDung"].Value.ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
