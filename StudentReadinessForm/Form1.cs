using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentReadinessForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Getting the input from your textboxes
            string inputUser = textBox1.Text;
            string inputPass = textBox2.Text;

            // Checking against your specific credentials
            if (inputUser == "20231860" && inputPass == "Philipus@13169")
            {
                MessageBox.Show("Login Successful! Welcome, Philip.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 1. Create the instance using the name you chose
                StudentForm mainDash = new StudentForm();

                // 2. Show the StudentForm
                mainDash.Show();

                // 3. Hide the login form
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Student Number or Password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                textBox2.Clear();
                textBox2.Focus();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
