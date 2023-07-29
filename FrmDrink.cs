using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace MarketExProject
{
    public partial class FrmDrink : Form
    {
        public FrmDrink()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-GA77R8Q;Initial Catalog=ExMarketDatabes;Integrated Security=True");

        private void FrmDrink_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Product WHERE productType='Drink'", conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
