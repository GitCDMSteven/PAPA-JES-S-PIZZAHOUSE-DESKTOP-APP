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
    public partial class Form1 : Form
    {
        // Add a field to track password visibility
        private bool isPasswordVisible = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#6E2929");
          
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e) 
        {
           
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            
            if (guna2TextBox1.PasswordChar != '●')
            {
                guna2TextBox1.PasswordChar = '●';
                guna2PictureBox2.Image = Properties.Resources.eye_closed;
                isPasswordVisible = false;
            }
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;
            guna2TextBox1.PasswordChar = isPasswordVisible ? '\0' : '●';
            guna2PictureBox2.Image = isPasswordVisible 
                ? Properties.Resources.eye_open    
                : Properties.Resources.eye_closed; 
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Check if both email and password are "admin"
            if (txtEmail.Text == "admin" && guna2TextBox1.Text == "admin")
            {
                // Show dashboard form
                dashboard dash = new dashboard();
                dash.Show();

                // Optionally hide or close the login form
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
