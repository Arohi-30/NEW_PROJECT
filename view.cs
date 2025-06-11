using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace CosmeticManagement
{
    public partial class view : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-NRMENEP4;Initial Catalog=Cosmeticshop;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public view()
        {
            InitializeComponent();
        }

        private void view_Load(object sender, EventArgs e)
        {
            BindProduct();
        }
        private void BindProduct()
        {
            SqlDataAdapter ad = new SqlDataAdapter();
            DataTable dt = new DataTable();

            con.Close();
            ad = new SqlDataAdapter("select * from dbo.tblprod", con);
            con.Open();
            ad.Fill(dt);
            con.Close();
       
            dataGridView1.DataSource = dt;

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
