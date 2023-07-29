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

namespace MarketExProject
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnFruit_Click(object sender, EventArgs e)
        {
            FrmFruit fr = new FrmFruit();
            fr.Show();
        }

        private void BtnVegetable_Click(object sender, EventArgs e)
        {
            FrmVegetable fr = new FrmVegetable();
            fr.Show();
        }

        private void BtnDrink_Click(object sender, EventArgs e)
        {
            FrmDrink fr = new FrmDrink();
            fr.Show();
        }
    }
}
