using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Election_Management_System
{
    public partial class Form5 : Form
    {
        private string userRole;
        public Form5()
        {
            InitializeComponent();
            //userRole = role;
        }

        private void Form5_Load(object sender, EventArgs e)
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
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-T0EEFH0\SQLEXPRESS;
                        Initial Catalog=Election Management System;Integrated Security=True"))
                {
                    connection.Open();
                    richTextBox1.Text = "Inserting Record...";

                    // Update the query based on your table structure
                    SqlCommand command = new SqlCommand("INSERT INTO Candidates VALUES (@CandidateID, @FirstName, @LastName,@DateOfBirth, @Address, @ContactNumber,@PartyAffiliation, @PartyID, @ElectionID)", connection);

                    // Assuming you have TextBox controls for each field
                    command.Parameters.AddWithValue("@CandidateID", int.Parse(textBox1.Text));
                    command.Parameters.AddWithValue("@FirstName", textBox2.Text);
                    command.Parameters.AddWithValue("@LastName", textBox3.Text);
                    command.Parameters.AddWithValue("@DateOfBirth", dateTimePicker1.Value);
                    command.Parameters.AddWithValue("@Address", textBox4.Text);
                    command.Parameters.AddWithValue("@ContactNumber", textBox5.Text);
                    command.Parameters.AddWithValue("@PartyAffiliation", textBox6.Text);
                    command.Parameters.AddWithValue("@PartyID", int.Parse(textBox7.Text));
                    command.Parameters.AddWithValue("@ElectionID", int.Parse(textBox8.Text));

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
                command.CommandText = "select * from Candidates"; // Retrieve data from the "Elections" table
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form5_Load_1(object sender, EventArgs e)
        {

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
                    SqlCommand command = new SqlCommand("UPDATE Candidates SET FirstName = @FirstName, LastName = @LastName, DateOfBirth = @DateOfBirth, Address = @Address, ContactNumber = @ContactNumber, PartyAffiliation = @PartyAffiliation, PartyID = @PartyID, ElectionID = @ElectionID WHERE CandidateID = @CandidateID", connection);

                    // Assuming you have TextBox controls for each field
                    command.Parameters.AddWithValue("@CandidateID", int.Parse(textBox1.Text));
                    command.Parameters.AddWithValue("@FirstName", textBox2.Text);
                    command.Parameters.AddWithValue("@LastName", textBox3.Text);
                    command.Parameters.AddWithValue("@DateOfBirth", dateTimePicker1.Value);
                    command.Parameters.AddWithValue("@Address", textBox4.Text);
                    command.Parameters.AddWithValue("@ContactNumber", textBox5.Text);
                    command.Parameters.AddWithValue("@PartyAffiliation", textBox6.Text);
                    command.Parameters.AddWithValue("@PartyID", int.Parse(textBox7.Text));
                    command.Parameters.AddWithValue("@ElectionID", int.Parse(textBox8.Text));

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
                    SqlCommand command = new SqlCommand("DELETE FROM Candidates WHERE CandidateID = @CandidateID", connection);

                    // Assuming you have a TextBox for CandidateID
                    command.Parameters.AddWithValue("@CandidateID", int.Parse(textBox1.Text));

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