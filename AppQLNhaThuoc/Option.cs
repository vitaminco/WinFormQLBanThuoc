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
                txtMaT.Text = row.Cells["maThuoc"].Value.ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addThuoc_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the latest order ID
                string latestOrderQuery = "SELECT TOP 1 maDH FROM [DONHANG] ORDER BY maDH DESC";
                DataSet latestOrderDataSet = f.getData(latestOrderQuery);

                if (latestOrderDataSet.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("No orders found.");
                    return;
                }

                string latestOrderId = latestOrderDataSet.Tables[0].Rows[0]["maDH"].ToString();

                // Check if the product exists
                string productsQuery = $"SELECT * FROM [THUOC] WHERE [maThuoc] = '{txtMaT.Text}'";
                DataSet productDataSet = f.getData(productsQuery);

                if (productDataSet.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Product not found.");
                    return;
                }

                string maThuoc = productDataSet.Tables[0].Rows[0]["maThuoc"].ToString();
                decimal price = Convert.ToDecimal(productDataSet.Tables[0].Rows[0]["giaBan"]);

                // Insert into CT_DONHANG table
                string insertOrderDetailQuery = $"INSERT INTO CT_DONHANG (maDH, maThuoc, soLuong, donGia) VALUES ('{latestOrderId}', '{maThuoc}', 1, {price})";
                f.setData(insertOrderDetailQuery, "Thêm sản phẩm thành công");

                // Calculate total price for the order
                string orderDetailsQuery = $"SELECT * FROM CT_DONHANG WHERE maDH = '{latestOrderId}'";
                DataSet orderDetailsDataSet = f.getData(orderDetailsQuery);

                decimal totalPrice = 0;
                foreach (DataRow row in orderDetailsDataSet.Tables[0].Rows)
                {
                    int quantity = Convert.ToInt32(row["soLuong"]);
                    decimal unitPrice = Convert.ToDecimal(row["donGia"]);
                    totalPrice += quantity * unitPrice;
                }

                // Update the total amount in the DONHANG table
                string updateOrderQuery = $"UPDATE [DONHANG] SET totalAmount = {totalPrice} WHERE maDH = '{latestOrderId}'";
                f.setData(updateOrderQuery, "Cập nhật tổng tiền thành công!");

                // Reload data
                Option_Load(this, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
