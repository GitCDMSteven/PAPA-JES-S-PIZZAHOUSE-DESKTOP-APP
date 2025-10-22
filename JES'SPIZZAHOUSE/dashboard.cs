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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            // Example logout logic: show login form and close dashboard
            var loginForm = new Form1(); // Replace Form1 with your actual login form class
            loginForm.Show();
            this.Hide();
            // Optionally, you can use this.Close(); if you want to exit the dashboard completely
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            var posForm = new POS();
            posForm.Show();
            this.Close(); // Closes the dashboard form
        }

        private void guna2HtmlLabel1_Click_1(object sender, EventArgs e)
        {
            guna2HtmlLabel1.Text = "INVENTORY";
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

            var btn = (Guna.UI2.WinForms.Guna2Button)sender;
            AddControls(new inventorycs());
            guna2HtmlLabel1.Text = btn.Text;
            SetActiveButton(btn);
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddControls(Form childForm)
        {
            // Remove existing controls from guna2Panel3
            guna2Panel3.Controls.Clear();

            // Set child form properties
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Add child form to panel and show it
            guna2Panel3.Controls.Add(childForm);
            childForm.Show();
        }

        private void SetActiveButton(Guna.UI2.WinForms.Guna2Button activeButton)
        {
            foreach (Control ctrl in guna2Panel2.Controls)
            {
                var btn = ctrl as Guna.UI2.WinForms.Guna2Button;
                // Only update color for buttons that are NOT guna2Button2 (LOGIN)
                if (btn != null && btn != guna2Button2)
                {
                    btn.FillColor = (btn == activeButton)
                        ? Color.FromArgb(173, 151, 97) // Active color
                        : Color.FromArgb(191, 121, 14); // Default color
                }
            }
            // Do NOT change guna2Button2's color or style here
        }

        private void Bt_Home_Click(object sender, EventArgs e)
        {
            var btn = (Guna.UI2.WinForms.Guna2Button)sender;
            AddControls(new dashpanel());
            guna2HtmlLabel1.Text = btn.Text;
            SetActiveButton(btn);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var btn = (Guna.UI2.WinForms.Guna2Button)sender;
            AddControls(new product());
            guna2HtmlLabel1.Text = btn.Text;
            SetActiveButton(btn);
        }

        private void Bt_Dashbord_Click(object sender, EventArgs e)
        {
            var btn = (Guna.UI2.WinForms.Guna2Button)sender;
            AddControls(new report());
            guna2HtmlLabel1.Text = btn.Text;
            SetActiveButton(btn);
        }
    }
}
