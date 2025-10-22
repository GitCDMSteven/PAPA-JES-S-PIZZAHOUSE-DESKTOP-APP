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
    public partial class addtochart : Form
    {
        // Add these fields
        private bool isLargeSelected = false;
        private int quantity = 1;

        public addtochart()
        {
            InitializeComponent();
        }

        // Update constructor to show price values immediately in buttons
        public addtochart(string productName)
        {
            InitializeComponent();
            guna2HtmlLabel1.Text = productName;
            guna2HtmlLabel7.Text = quantity.ToString();
            guna2Button5.Text = GetPrice(productName, false).ToString();
            guna2Button6.Text = GetPrice(productName, true).ToString();
            SetActiveButton(false); // Default to regular
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void addtochart_Load(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {
            // Display regular price in guna2HtmlLabel4
            string productName = guna2HtmlLabel1.Text;
            int regularPrice = GetPrice(productName, false);
           
        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {
            // Display large price in guna2HtmlLabel5
            string productName = guna2HtmlLabel1.Text;
            int largePrice = GetPrice(productName, true);
           
        }

        private int GetPrice(string productName, bool isLarge)
        {
            var prices = new Dictionary<string, (int large, int regular)>(StringComparer.OrdinalIgnoreCase)
            {
                { "DOUBLE CHEESE", (140, 105) },
                { "HAM & CHEESE", (140, 110) },
                { "CHEESY GARLIC", (155, 115) },
                { "HAWAIIAN", (155, 125) },
                { "PEPPERONI", (165, 145) },
                { "SHAWARMA PIZZA", (175, 155) },
                { "ALL MEAT", (165, 155) },
                { "ALL TOPPINGS", (165, 155) },
                { "CREAMY BEEF & MUSHROOM", (155, 145) },
                { "SUPREME DELIGHTS", (175, 155) },
                { "TAKOYAKI PIZZA", (175, 155) },
                { "HAWAIIAN CHICKEN", (185, 155) }
            };

            if (prices.TryGetValue(productName.Trim(), out var price))
            {
                return isLarge ? price.large : price.regular;
            }
            return 0; // Or handle unknown product
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            // Deduct quantity, minimum 1
            if (quantity > 1)
                quantity--;
            guna2HtmlLabel7.Text = quantity.ToString();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            // Add quantity
            quantity++;
            guna2HtmlLabel7.Text = quantity.ToString();
        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {
            // Optionally, show quantity (already shown in label)
            guna2HtmlLabel7.Text = quantity.ToString();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            isLargeSelected = false;
            SetActiveButton(false);

            // Display only regular price value in button text
            string productName = guna2HtmlLabel1.Text;
            int regularPrice = GetPrice(productName, false);
            guna2Button5.Text = regularPrice.ToString();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            isLargeSelected = true;
            SetActiveButton(true);

            // Display only large price value in button text
            string productName = guna2HtmlLabel1.Text;
            int largePrice = GetPrice(productName, true);
            guna2Button6.Text = largePrice.ToString();
        }

        // Helper to show active button design
        private void SetActiveButton(bool large)
        {
            guna2Button5.FillColor = large ? Color.LightGray : Color.DodgerBlue;
            guna2Button6.FillColor = large ? Color.DodgerBlue : Color.LightGray;
        }

        // Add to chart logic
        public string GetSelectedProductData()
        {
            string productName = guna2HtmlLabel1.Text;
            int price = GetPrice(productName, isLargeSelected);
            return $"{productName} | {(isLargeSelected ? "Large" : "Regular")} | {quantity} | {price * quantity}";
        }

        public int GetSelectedTotalPrice()
        {
            string productName = guna2HtmlLabel1.Text;
            int price = GetPrice(productName, isLargeSelected);
            return price * quantity;
        }
    }
}
