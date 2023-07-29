using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace MarketExProject
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-GA77R8Q;Initial Catalog=ExMarketDatabes;Integrated Security=True");

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * From Tbl_Admin Where name=@p1 and password=@p2", conn);
            cmd.Parameters.AddWithValue("@p1", TxtUsername.Text);
            cmd.Parameters.AddWithValue("@p2", TxtPassword.Text);
            SqlDataReader dr = cmd.ExecuteReader();

            if ( dr.Read() )
            {
                FrmMain fr = new FrmMain();
                fr.Show();
                //this.Hide();
            }
            else
            {
                MessageBox.Show("Please check Username or Password !");
            }
            conn.Close();
        }
    }
}
