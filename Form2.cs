using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Election_Management_System
{
    public partial class Form2 : Form
    {

        // string username = Login.Username;
        private string username;
        public Form2(string username)
        {
            InitializeComponent();
            this.username = username;
            SetButtonVisibility();


        }
        private void Form2_Load(object sender, EventArgs e) { }

        public void SetButtonVisibility()
        {


            button1.Visible = IsAdmin();
            button2.Visible = IsAdmin();
            button3.Visible = IsAdmin();
            button4.Visible = true;
            button5.Visible = IsAdmin();
            button6.Visible = IsAdmin();
            button7.Visible = IsAdmin();
            button8.Visible = IsAdmin();
            button9.Visible = IsAdmin();
            button10.Visible = IsAdmin();
        }

        private bool IsAdmin()
        {
            // Modify this condition based on the actual admin username
            return username == "User_admin";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                Form3 frm = new Form3();

                frm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {


                Form4 frm1 = new Form4();
                frm1.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {


                Form5 frm2 = new Form5();
                frm2.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        }





        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Form11 frm2 = new Form11();
                frm2.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Form12 frm2 = new Form12();
                frm2.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        }






        private void button4_Click(object sender, EventArgs e)
        {
            try
            {


                Form6 frm2 = new Form6();
                frm2.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {


                Form7 frm2 = new Form7();
                frm2.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                Form8 frm = new Form8();
                frm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                Form9 frm = new Form9();
                frm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {


                Form10 frm2 = new Form10();
                frm2.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
