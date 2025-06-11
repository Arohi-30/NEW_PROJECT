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
    public partial class Product_Page : Form
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-NRMENEP4;Initial Catalog=Cosmeticshop;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public Product_Page()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.ResetText();
            comboBox2.ResetText();
            comboBox3.ResetText();

        }

        private void Product_Page_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Close();
            cmd = new SqlCommand("insert into tblprod values ('"+comboBox1.SelectedItem+"','"+comboBox2.SelectedItem+"','"+comboBox3.SelectedItem+"',"+textBox2.Text+","+textBox3.Text+");", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Added !");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.ResetText();
            comboBox2.ResetText();
            comboBox3.ResetText();
           
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            con.Close();
            cmd = new SqlCommand("update dbo.tblprod set catname='"+comboBox2.Text+"',bname = '"+comboBox1.Text+"',subcat = '"+comboBox3.Text+"',price="+textBox2.Text+",qty="+textBox3.Text+" where pid="+textBox1.Text+";", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Update successfull !");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.ResetText();
            comboBox2.ResetText();
            comboBox3.ResetText();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Close();
            cmd = new SqlCommand("delete from dbo.tblprod where pid="+textBox1.Text+";", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted Record !");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.ResetText();
            comboBox2.ResetText();
            comboBox3.ResetText();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            con.Open();
            //string result = "";
            //SqlCommand cmd1 = new SqlCommand("select bname from tblprod where pid = " + textBox1.Text + ";", con);
            //result = cmd1.ExecuteScalar().ToString();
            //comboBox1.SelectedItem = result;

            SqlCommand cmd2 = new SqlCommand("select * from dbo.tblprod where pid=" + textBox1.Text + ";", con);
            SqlDataReader dr = cmd2.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                textBox1.Text = dr.GetValue(0).ToString();
                comboBox1.SelectedItem = dr.GetString(1).Trim().ToString();
                comboBox2.SelectedItem = dr.GetString(2).Trim().ToString();
                comboBox3.SelectedItem = dr.GetString(3).Trim().ToString();
                textBox2.Text = dr.GetValue(4).ToString();
                textBox3.Text = dr.GetValue(5).ToString();
            }
            dr.Close();
            con.Close();



        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            view v=new view();
            v.Show();

        }
    }
}
