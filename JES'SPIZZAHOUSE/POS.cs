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
    public partial class POS : Form
    {
        // Add a list to store chart items
        private List<string> chartItems = new List<string>();
        private int totalPrice = 0;

        public POS()
        {
            InitializeComponent();
            guna2Panel15.Click += guna2Panel15_Click;
            guna2Panel16.Click += guna2Panel16_Click;
        }

        // Add this method to receive data from addtochart
        public void AddToChart(string item, int price)
        {
            chartItems.Add(item);
            totalPrice += price;
            guna2Panel17.Refresh(); // Refresh guna2Panel17 instead of guna2Panel4
            guna2HtmlLabel99.Text = totalPrice.ToString(); // Show total price
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel15_Click(object sender, EventArgs e)
        {
            string productName = guna2HtmlLabel15.Text;
            var addToChartForm = new addtochart(productName);
            if (addToChartForm.ShowDialog() == DialogResult.OK)
            {
                AddToChart(addToChartForm.GetSelectedProductData(), addToChartForm.GetSelectedTotalPrice());
            }
        }

        private void guna2Panel16_Click(object sender, EventArgs e)
        {
            string productName = guna2HtmlLabel1.Text;
            var addToChartForm = new addtochart(productName);
            if (addToChartForm.ShowDialog() == DialogResult.OK)
            {
                AddToChart(addToChartForm.GetSelectedProductData(), addToChartForm.GetSelectedTotalPrice());
            }
        }

        private void guna2HtmlLabel15_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel6_Paint(object sender, PaintEventArgs e)     
        {

        }

        private void guna2HtmlLabel23_Click(object sender, EventArgs e)
        {
            string productName = guna2HtmlLabel23.Text;
            var addToChartForm = new addtochart(productName);
            if (addToChartForm.ShowDialog() == DialogResult.OK)
            {
                AddToChart(addToChartForm.GetSelectedProductData(), addToChartForm.GetSelectedTotalPrice());
            }
        }

        private void guna2Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel32_Click(object sender, EventArgs e)
        {
            string productName = guna2HtmlLabel32.Text;
            var addToChartForm = new addtochart(productName);
            addToChartForm.ShowDialog();
        }

        private void guna2Panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel40_Click(object sender, EventArgs e)
        {
            string productName = guna2HtmlLabel40.Text;
            var addToChartForm = new addtochart(productName);
            addToChartForm.ShowDialog();
        }

        private void guna2Panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel48_Click(object sender, EventArgs e)
        {
            string productName = guna2HtmlLabel48.Text;
            var addToChartForm = new addtochart(productName);
            addToChartForm.ShowDialog();
        }

        private void guna2Panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel56_Click(object sender, EventArgs e)
        {
            string productName = guna2HtmlLabel56.Text;
            var addToChartForm = new addtochart(productName);
            addToChartForm.ShowDialog();
        }

        private void guna2Panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel64_Click(object sender, EventArgs e)
        {
            string productName = guna2HtmlLabel64.Text;
            var addToChartForm = new addtochart(productName);
            addToChartForm.ShowDialog();
        }

        private void guna2Panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel96_Click(object sender, EventArgs e)
        {
            string productName = guna2HtmlLabel96.Text;
            var addToChartForm = new addtochart(productName);
            addToChartForm.ShowDialog();
        }

        private void guna2Panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel88_Click(object sender, EventArgs e)
        {
            string productName = guna2HtmlLabel88.Text;
            var addToChartForm = new addtochart(productName);
            addToChartForm.ShowDialog();
        }

        private void guna2Panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel80_Click(object sender, EventArgs e)
        {
            string productName = guna2HtmlLabel80.Text;
            var addToChartForm = new addtochart(productName);
            addToChartForm.ShowDialog();
        }

        private void guna2Panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel72_Click(object sender, EventArgs e)
        {
            string productName = guna2HtmlLabel72.Text;
            var addToChartForm = new addtochart(productName);
            addToChartForm.ShowDialog();
        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {
            string display = string.Join(Environment.NewLine, chartItems);
            e.Graphics.DrawString(display, this.Font, Brushes.Black, new PointF(10, 10));
        }

        private void guna2HtmlLabel99_Click(object sender, EventArgs e)
        {
            guna2HtmlLabel99.Text = totalPrice.ToString();
        }

        private void guna2Panel17_Paint(object sender, PaintEventArgs e)
        {
            // Draw each item in chartItems, one per line (column layout)
            float y = 10;
            foreach (var item in chartItems)
            {
                e.Graphics.DrawString(item, this.Font, Brushes.Black, new PointF(10, y));
                y += this.Font.Height + 4; // Move down for next item
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
          
        }
    }
}
