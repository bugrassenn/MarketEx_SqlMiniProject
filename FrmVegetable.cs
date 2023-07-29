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
    public partial class FrmVegetable : Form
    {
        public FrmVegetable()
        {
            InitializeComponent();
        }
        // Sınıf olarakta yazılabilir 2 defa kullanıcağım için sınıf yazmadım
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-GA77R8Q;Initial Catalog=ExMarketDatabes;Integrated Security=True");

        private void FrmVegetable_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Product WHERE productType='Vegetable'", conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
