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
    public partial class LOGIN : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-NRMENEP4;Initial Catalog=Cosmeticshop;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public LOGIN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uname, pass;
            uname = txtuser.Text;
            pass = txtpass.Text;

            try
            {

                string qur = "select * from dbo.tblUser where uname='" + txtuser.Text + "' AND password='" + txtpass.Text + "';";
                SqlDataAdapter ad = new SqlDataAdapter(qur, con);
                DataTable dt = new DataTable();
                ad.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    uname = txtuser.Text;
                    pass = txtpass.Text;

                    Home_Page h = new Home_Page();
                    h.Show();
                    //    Register r = new Register();
                    //  r.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid user detail ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtuser.Clear();
                    txtpass.Clear();

                    txtuser.Focus();
                }
               

              }

            catch
            {
                MessageBox.Show("your password are is invalid please try again");
            }
                finally
                {
                    con.Close();
                }
            }
            
        
    

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            txtuser.Clear();
            txtpass.Clear();

            txtuser.Focus();
        }

        private void btnresgister_Click(object sender, EventArgs e)
        {
            Registration  rg = new Registration();
            rg.Show();
            this.Hide();
        }
    }
}
