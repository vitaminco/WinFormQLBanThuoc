
using System.Data;
using System.Windows.Forms;

namespace AppQLNhaThuoc
{
    public partial class Branch : Form
    {
        function f = new function();
        string query;

        public Branch()
        {
            InitializeComponent();
        }

        private void Branch_Load(object sender, System.EventArgs e)
        {
            query = "select * from CHINHANH";
            DataSet ds = f.getData(query);
            dataBranch.DataSource = ds.Tables[0];
        }
    }
}
