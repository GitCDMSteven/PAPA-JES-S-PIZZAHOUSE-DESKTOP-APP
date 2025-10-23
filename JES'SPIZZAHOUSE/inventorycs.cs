using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JES_SPIZZAHOUSE
{
    public partial class inventorycs : Form
    {
        public inventorycs()
        {
            InitializeComponent();
            guna2Panel5.Visible = false; // Panel is hidden on startup
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            // Show the addproduct form when the picture box is clicked
            var addProductForm = new addproduct();
            addProductForm.ShowDialog(); // Use Show() if you want it non-modal
        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel21_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            guna2Panel5.Visible = true; // Show the panel, triggers Paint event
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            guna2Panel5.Visible = false; // Hide the panel
        }

        private void inventorycs_Load(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel23_Click(object sender, EventArgs e)
        {

        }
    }
}
