using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CosmeticManagement
{
    public partial class Home_Page : Form
    {
        public Home_Page()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void addUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product_Page pg = new Product_Page();
            pg.Show();
        }

        private void deleteViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product_Page pg = new Product_Page();
            pg.Show();
        }
    }
}
