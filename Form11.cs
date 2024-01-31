//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Data.SqlClient;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Election_Management_System
//{
//    public partial class Form11 : Form
//    {
//        public Form11()
//        {
//            InitializeComponent();
//        }
//        private void Form11_Load(object sender, EventArgs e)
//        {
//            richTextBox1.Text = "Startup...";
//            try
//            {
//                var datasource = @"DESKTOP-T0EEFH0\SQLEXPRESS";
//                var database = "Election Management System";
//                string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Integrated Security=True";

//                SqlConnection conn = new SqlConnection(connString);
//                conn.Open();
//                richTextBox1.Text = "Connection Successful on Startup";
//                conn.Close();
//            }
//            catch (Exception ex)
//            {
//                richTextBox1.Text = "Error, " + ex.Message;
//            }
//            dataGridView1.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
//            dataGridView1.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.BackColor;
//            dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {
//            dataGridView1.DataSource = null;

//            try
//            {
//                SqlCommand command = new SqlCommand();
//                SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-T0EEFH0\SQLEXPRESS;Initial Catalog=Election Management System;Integrated Security=True");

//                connection.Open();
//                richTextBox1.Text = "Retrieving Records...";
//                command.Connection = connection;
//                command.CommandText = "select * from MNA_Result";
//                SqlDataAdapter da = new SqlDataAdapter(command);
//                DataTable dt = new DataTable();
//                da.Fill(dt);

//                dataGridView1.DataSource = dt;

//                richTextBox1.Text = "Retrieval Successful!";
//                connection.Close();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("An error occurred: " + ex.Message);
//            }
//        }

//        private void button3_Click(object sender, EventArgs e)
//        {
//            dataGridView2.DataSource = null;

//            try
//            {
//                SqlCommand command = new SqlCommand();
//                SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-T0EEFH0\SQLEXPRESS;Initial Catalog=Election Management System;Integrated Security=True");

//                connection.Open();
//                richTextBox1.Text = "Retrieving Records...";
//                command.Connection = connection;
//                command.CommandText = "select * from MPA_Result";
//                SqlDataAdapter da = new SqlDataAdapter(command);
//                DataTable dt = new DataTable();
//                da.Fill(dt);

//                dataGridView2.DataSource = dt;

//                richTextBox1.Text = "Retrieval Successful!";
//                connection.Close();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("An error occurred: " + ex.Message);
//            }
//        }

//        private void button2_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                Form2 frm = new Form2();
//                frm.Show();
//                this.Hide();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Error: " + ex.Message);
//            }
//        }


//    }
//}
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Election_Management_System
{
    public partial class Form11 : Form
    {
        private string userRole;
        public Form11()
        {
            InitializeComponent();
            //userRole = role;
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "Startup...";
            try
            {
                var datasource = @"DESKTOP-T0EEFH0\SQLEXPRESS";
                var database = "Election Management System";
                string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    richTextBox1.Text = "Connection Successful on Startup";
                }
            }
            catch (Exception ex)
            {
                richTextBox1.Text = "Error, " + ex.Message;
            }

            dataGridView1.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dataGridView1.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.BackColor;
            dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-T0EEFH0\SQLEXPRESS;Initial Catalog=Election Management System;Integrated Security=True"))
                {
                    connection.Open();
                    richTextBox1.Text = "Retrieving Records...";
                    using (SqlCommand command = new SqlCommand("SELECT * FROM MNA_Result", connection))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }

                    // Get the party with maximum seats
                    using (SqlCommand getMaxSeatsPartyCommand = new SqlCommand("SELECT TOP 1 PartyName FROM MNA_Result ORDER BY VotesReceived DESC", connection))
                    {
                        string maxSeatsParty = getMaxSeatsPartyCommand.ExecuteScalar() as string;
                        label3.Text = $"Party with Maximum MNA Seats: {maxSeatsParty}";
                    }

                    richTextBox1.Text = "Retrieval Successful!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;

            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-T0EEFH0\SQLEXPRESS;Initial Catalog=Election Management System;Integrated Security=True"))
                {
                    connection.Open();
                    richTextBox1.Text = "Retrieving Records...";
                    using (SqlCommand command = new SqlCommand("SELECT * FROM MPA_Result", connection))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView2.DataSource = dt;
                    }
                    richTextBox1.Text = "Retrieval Successful!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string username = Login.Username;
                Form2 frm = new Form2(username);
                frm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
