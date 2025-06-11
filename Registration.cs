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
    public partial class Registration : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-NRMENEP4;Initial Catalog=Cosmeticshop;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        string gen;
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            con.Close();
            cmd = new SqlCommand("insert into dbo.tblUser values ('"+txtusern.Text+"','"+txtemail.Text+"','"+txtpassword.Text+"','"+txttype.Text+"','"+richTextBox1.Text+"','"+gen+"');", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("REGISTRATION DONE SUCCESSFULLY");

            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gen = "Female";

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gen = "Male"; 

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            gen = "Others"; 
        }

    }
}
