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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Election_Management_System
{
    public partial class Form10 : Form
    {
        private string userRole;
        public Form10()
        {
            InitializeComponent();
            //userRole = role;
        }

        private void Form10_Load(object sender, EventArgs e)
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
                command.CommandText = "select * from AuditTrail";
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
                    SqlCommand command = new SqlCommand("INSERT INTO AuditTrail VALUES (@AuditID, @UserID, " +
                        "@Action,@ActionDate, @ActionDetails)", connection);

                    // Assuming you have TextBox controls for each field
                    command.Parameters.AddWithValue("@AuditID", int.Parse(textBox1.Text));
                    command.Parameters.AddWithValue("@UserID", textBox2.Text);
                    command.Parameters.AddWithValue("@Action", textBox3.Text);
                    command.Parameters.AddWithValue("@ActionDate", dateTimePicker1.Value);
                    command.Parameters.AddWithValue("@ActionDetails", textBox5.Text);


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
                    SqlCommand command = new SqlCommand("UPDATE AuditTrail SET UserID = @UserID, Action = @Action, ActionDate = @ActionDate, ActionDetails = @ActionDetails WHERE AuditID = @AuditID", connection);

                    // Assuming you have TextBox controls for each field
                    command.Parameters.AddWithValue("@AuditID", int.Parse(textBox1.Text));
                    command.Parameters.AddWithValue("@UserID", textBox2.Text);
                    command.Parameters.AddWithValue("@Action", textBox3.Text);
                    command.Parameters.AddWithValue("@ActionDate", dateTimePicker1.Value);
                    command.Parameters.AddWithValue("@ActionDetails", textBox5.Text);

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
                    SqlCommand command = new SqlCommand("DELETE FROM AuditTrail WHERE AuditID = @AuditID", connection);

                    // Assuming you have a TextBox for BallotID
                    command.Parameters.AddWithValue("@AuditID", int.Parse(textBox1.Text));

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
    }
}
