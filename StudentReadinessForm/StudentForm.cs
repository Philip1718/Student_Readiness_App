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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Convert text inputs
                double math = Convert.ToDouble(textBox1.Text);
                double Csharp = Convert.ToDouble(textBox2.Text);
                double dbDesign = Convert.ToDouble(textBox3.Text);
                double systemArch = Convert.ToDouble(textBox4.Text);
                double systemDev = Convert.ToDouble(textBox5.Text);

                // 2. Calculate the Average
                double average = (math + Csharp + dbDesign + systemArch + systemDev) / 5;

                // 3. Clear the ListBox first (so results don't stack every time you click)
                listBox1.Items.Clear();

                // 4. Add items to the ListBox
                listBox1.Items.Add("--- Student Report ---");
                listBox1.Items.Add($"Mathematics: {math}%");
                listBox1.Items.Add($"C# Programming: {Csharp}%");
                listBox1.Items.Add($"Database Design: {dbDesign}%");
                listBox1.Items.Add($"System Architecture: {systemArch}%");
                listBox1.Items.Add($"System Development: {systemDev}%");
                listBox1.Items.Add("----------------------");
                listBox1.Items.Add($"FINAL AVERAGE: {average}%");

                // 5. Logical check for Pass/Fail
                if (average >= 80)
                {
                    label6.Text = "Status: PASS";
                    label6.ForeColor = Color.Green;
                    listBox1.Items.Add("RESULT: PASSED");
                }
                else
                {
                    label6.Text = "Status: FAIL";
                    label6.ForeColor = Color.Red;
                    listBox1.Items.Add("RESULT: FAILED");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers in all boxes.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 1. Create an instance of the login form (Form1)
            Form1 login = new Form1();

            // 2. Show the login form
            login.Show();

            // 3. Close this StudentForm
            this.Close();
        }
    }
}
