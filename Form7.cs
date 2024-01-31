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
    public partial class Form7 : Form
    {
        private string userRole;
        public Form7()
        {
            InitializeComponent();
            //userRole = role;
        }

        private void Form7_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

            try
            {
                SqlCommand command = new SqlCommand();
                SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-T0EEFH0\SQLEXPRESS;Initial Catalog=Election Management System;Integrated Security=True");

                connection.Open();
                richTextBox1.Text = "Retrieving Records...";
                command.Connection = connection;
                command.CommandText = "select * from PollingStations";
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string username = Login.Username;
                Form2 frm = new Form2(username);
                //frm.SetButtonVisibility();
                frm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {//update
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-T0EEFH0\SQLEXPRESS; Initial Catalog=Election Management System;Integrated Security=True"))
                {
                    connection.Open();
                    richTextBox1.Text = "Updating Record...";

                    // Update the query based on your table structure
                    SqlCommand command = new SqlCommand("UPDATE PollingStations SET StationName = @StationName, Location = @Location, ElectionID = @ElectionID WHERE StationID = @StationID", connection);

                    // Assuming you have TextBox controls for each field
                    command.Parameters.AddWithValue("@StationID", int.Parse(textBox1.Text));
                    command.Parameters.AddWithValue("@StationName", textBox2.Text);
                    command.Parameters.AddWithValue("@Location", textBox3.Text);
                    command.Parameters.AddWithValue("@ElectionID", int.Parse(textBox4.Text));

                    command.ExecuteNonQuery();

                    // Refresh the data in the DataGridView
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    MessageBox.Show("Record Updated");
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
        {//delete
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-T0EEFH0\SQLEXPRESS; Initial Catalog=Election Management System;Integrated Security=True"))
                {
                    connection.Open();
                    richTextBox1.Text = "Deleting Record...";

                    // Update the query based on your table structure
                    SqlCommand command = new SqlCommand("DELETE FROM PollingStations WHERE StationID = @StationID", connection);

                    // Assuming you have a TextBox for StationID
                    command.Parameters.AddWithValue("@StationID", int.Parse(textBox1.Text));

                    command.ExecuteNonQuery();

                    // Refresh the data in the DataGridView
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    MessageBox.Show("Record Deleted");
                    richTextBox1.Text = "Record Deleted...";
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //insert
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-T0EEFH0\SQLEXPRESS;
                        Initial Catalog=Election Management System;Integrated Security=True"))
                {
                    connection.Open();
                    richTextBox1.Text = "Inserting Record...";

                    // Update the query based on your table structure
                    SqlCommand command = new SqlCommand("INSERT INTO PollingStations VALUES (@StationID, @StationName, @Location," +
                        "@ElectionID)", connection);

                    // Assuming you have TextBox controls for each field
                    command.Parameters.AddWithValue("@StationID", int.Parse(textBox1.Text));
                    command.Parameters.AddWithValue("@StationName", textBox2.Text);
                    command.Parameters.AddWithValue("@Location", textBox3.Text);
                    command.Parameters.AddWithValue("@ElectionID", int.Parse(textBox4.Text));

                    command.ExecuteNonQuery();
                    //SqlDataAdapter da = new SqlDataAdapter(command);
                    //DataTable dt = new DataTable();
                    //da.Fill(dt);

                    //dataGridView1.DataSource = dt;
                    MessageBox.Show("Record Inserted");
                    richTextBox1.Text = "Record Inserted...";
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
