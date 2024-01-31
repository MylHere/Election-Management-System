using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Election_Management_System
{
    public partial class Form4 : Form
    {
        private string userRole;
        public Form4()
        {
            InitializeComponent();
            //userRole = role;
        }

        private void Form4_Load(object sender, EventArgs e)
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

            try
            {
                SqlCommand command = new SqlCommand();
                SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-T0EEFH0\SQLEXPRESS;Initial Catalog=Election Management System;Integrated Security=True");

                connection.Open();
                richTextBox1.Text = "Retrieving Records...";
                command.Connection = connection;
                command.CommandText = "select * from Parties"; // Retrieve data from the "Elections" table
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
        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-T0EEFH0\SQLEXPRESS;Initial Catalog=Election Management System;Integrated Security=True"))
                {
                    connection.Open();
                    richTextBox1.Text = "Updating Party...";

                    // Update the query based on your table structure
                    SqlCommand command = new SqlCommand("UPDATE Parties SET PartyName = @PartyName, Symbol = @Symbol, FoundedDate = @FoundedDate, Leader = @Leader WHERE PartyID = @PartyID", connection);

                    // Assuming you have TextBox controls for each field
                    command.Parameters.AddWithValue("@PartyID", int.Parse(textBox1.Text));
                    command.Parameters.AddWithValue("@PartyName", textBox4.Text);
                    command.Parameters.AddWithValue("@Symbol", textBox5.Text);
                    command.Parameters.AddWithValue("@FoundedDate", dateTimePicker1.Value);
                    command.Parameters.AddWithValue("@Leader", textBox2.Text);

                    command.ExecuteNonQuery();

                    // Refresh the data in the DataGridView
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                    richTextBox1.Text = "Party Updated...";
                    MessageBox.Show("Party Updated");
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
                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-T0EEFH0\SQLEXPRESS;Initial Catalog=Election Management System;Integrated Security=True"))
                {
                    connection.Open();
                    richTextBox1.Text = "Deleting Party...";

                    // Update the query based on your table structure
                    SqlCommand command = new SqlCommand("DELETE FROM Parties WHERE PartyID = @PartyID", connection);

                    // Assuming you have TextBox controls for each field
                    command.Parameters.AddWithValue("@PartyID", int.Parse(textBox1.Text));

                    command.ExecuteNonQuery();

                    // Refresh the data in the DataGridView
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    MessageBox.Show("Party Deleted");
                    richTextBox1.Text = "Party Deleted...";
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-T0EEFH0\SQLEXPRESS;Initial Catalog=Election Management System;Integrated Security=True"))
                {
                    connection.Open();
                    richTextBox1.Text = "Inserting Record...";

                    // Update the query based on your table structure
                    SqlCommand command = new SqlCommand("INSERT INTO Parties VALUES (@PartyID, @PartyName, " +
                        "@Symbol, @FoundedDate, @Leader)", connection);

                    // Assuming you have TextBox controls for each field
                    command.Parameters.AddWithValue("@PartyID", int.Parse(textBox1.Text));
                    command.Parameters.AddWithValue("@PartyName", textBox4.Text);
                    command.Parameters.AddWithValue("@Symbol", textBox5.Text);
                    command.Parameters.AddWithValue("@FoundedDate", dateTimePicker1.Value);
                    command.Parameters.AddWithValue("@Leader", textBox2.Text);

                    command.ExecuteNonQuery();
                    //SqlDataAdapter da = new SqlDataAdapter(command);
                    //DataTable dt = new DataTable();
                    //da.Fill(dt);

                    //dataGridView1.DataSource = dt;
                    MessageBox.Show("Party Inserted");
                    richTextBox1.Text = "Record Inserted...";
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
