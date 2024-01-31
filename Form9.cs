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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Election_Management_System
{
    public partial class Form9 : Form
    {
        private string userRole;
        public Form9()
        {
            InitializeComponent();
            //userRole = role;
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "Startup...";
            try
            {
                var datasource = @"DESKTOP-T0EEFH0\SQLEXPRESS";
                var database = "Election Management System";
                string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Integrated Security=True";

                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                richTextBox1.Text = "Connection Successful on Startup";
                conn.Close();
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
                SqlCommand command = new SqlCommand();
                SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-T0EEFH0\SQLEXPRESS;Initial Catalog=Election Management System;Integrated Security=True");

                connection.Open();
                richTextBox1.Text = "Retrieving Records...";
                command.Connection = connection;
                command.CommandText = "select * from Nominations";
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

                richTextBox1.Text = "Retrieval Successful!";
                connection.Close();
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-T0EEFH0\SQLEXPRESS;
                        Initial Catalog=Election Management System;Integrated Security=True"))
                {
                    connection.Open();
                    richTextBox1.Text = "Inserting Record...";

                    // Update the query based on your table structure
                    SqlCommand command = new SqlCommand("INSERT INTO Nominations VALUES (@ElectionID, " +
                        "@CandidateID,@Position)", connection);

                    // Assuming you have TextBox controls for each field
                    //command.Parameters.AddWithValue("@NominationID", int.Parse(textBox1.Text));
                    command.Parameters.AddWithValue("@ElectionID", int.Parse(textBox2.Text));
                    command.Parameters.AddWithValue("@CandidateID", int.Parse(textBox3.Text));
                    command.Parameters.AddWithValue("@Position", textBox4.Text);



                    command.ExecuteNonQuery();
                    //SqlDataAdapter da = new SqlDataAdapter(command);
                    //DataTable dt = new DataTable();
                    //da.Fill(dt);

                    //dataGridView1.DataSource = dt;

                    richTextBox1.Text = "Record Inserted...";
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-T0EEFH0\SQLEXPRESS; Initial Catalog=Election Management System;Integrated Security=True"))
                {
                    connection.Open();
                    richTextBox1.Text = "Updating Record...";

                    // Update the query based on your table structure
                    SqlCommand command = new SqlCommand("UPDATE Nominations SET ElectionID = @ElectionID, Position = @Position WHERE CandidateID = @CandidateID", connection);

                    // Assuming you have TextBox controls for each field
                    // command.Parameters.AddWithValue("@NominationID", int.Parse(textBox1.Text));
                    command.Parameters.AddWithValue("@ElectionID", textBox3.Text);
                    command.Parameters.AddWithValue("@CandidateID", textBox2.Text);
                    command.Parameters.AddWithValue("@Position", textBox4.Text);


                    command.ExecuteNonQuery();

                    // Refresh the data in the DataGridView
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                    richTextBox1.Text = "Record Updated...";
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-T0EEFH0\SQLEXPRESS; Initial Catalog=Election Management System;Integrated Security=True"))
                {
                    connection.Open();
                    richTextBox1.Text = "Deleting Record...";

                    // Update the query based on your table structure
                    SqlCommand command = new SqlCommand("DELETE FROM Nominations WHERE CandidateID = @CandidateID", connection);

                    // Assuming you have a TextBox for Bal
                    command.Parameters.AddWithValue("@CandidateID", int.Parse(textBox2.Text));

                    command.ExecuteNonQuery();

                    // Refresh the data in the DataGridView
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                    richTextBox1.Text = "Record Deleted...";
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
