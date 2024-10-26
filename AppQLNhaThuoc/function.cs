using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace AppQLNhaThuoc
{
    internal class function
    {
        protected SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data source =DESKTOP-9SAS8HE\\HUNGHUYNH; database=CN01;Integrated Security = true";
            return conn;
        }

        public DataSet getData(string query)
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet data = new DataSet();
            adapter.Fill(data);
            return data;
        }

        public void setData(string quyery, string msg)  // cập nhật thông tin có thông báo messebox
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open(); ;
            cmd.CommandText = quyery;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(msg, "thong tin ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void setDataNO(string quyery) // cập nhật thông tin không thông báo
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open(); ;
            cmd.CommandText = quyery;
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
