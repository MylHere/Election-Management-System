using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Election_Management_System
{
    public partial class Form6 : Form
    {
        private Form12 form12;
        private string userRole;
        public Form6()
        {

            InitializeComponent();
            this.form12 = form12;


        }

        private void Form5_Load(object sender, EventArgs e)
        {
            //richTextBox1.Text = "Startup...";
            try
            {
                var datasource = @"DESKTOP-T0EEFH0\SQLEXPRESS";
                var database = "Election Management System";
                string connString = @"Data Source=" + datasource + ";Initial Catalog=" + database + ";Integrated Security=True";

                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                //richTextBox1.Text = "Connection Successful on Startup";
                conn.Close();
            }
            catch (Exception ex)
            {
                //richTextBox1.Text = "Error, " + ex.Message;
            }

        }



        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-T0EEFH0\SQLEXPRESS;Initial Catalog=Election Management System;Integrated Security=True"))
                {
                    connection.Open();
                    //richTextBox1.Text = "Inserting Record...";

                    System.Windows.Forms.RadioButton selectedRadioButtonMNA = panel2.Controls.OfType<System.Windows.Forms.RadioButton>().FirstOrDefault(r => r.Checked);
                    System.Windows.Forms.RadioButton selectedRadioButtonMPA = panel3.Controls.OfType<System.Windows.Forms.RadioButton>().FirstOrDefault(r => r.Checked);

                    if (selectedRadioButtonMNA != null || selectedRadioButtonMPA != null)
                    {
                        // Update the query based on your table structure
                        SqlCommand command = new SqlCommand("INSERT INTO Voters VALUES (@VoterID, @FirstName, @LastName," +
                            "@DateOfBirth, @Address, @ContactNumber,@VoterCardNumber, " +
                            "@ElectionID,@MNAVoteFor,@MPAVoteFor)", connection);

                        // Assuming you have TextBox controls for each field
                        command.Parameters.AddWithValue("@VoterID", int.Parse(textBox1.Text));
                        command.Parameters.AddWithValue("@FirstName", textBox2.Text);
                        command.Parameters.AddWithValue("@LastName", textBox3.Text);
                        command.Parameters.AddWithValue("@DateOfBirth", dateTimePicker1.Value);
                        command.Parameters.AddWithValue("@Address", textBox5.Text);
                        command.Parameters.AddWithValue("@ContactNumber", textBox6.Text);
                        command.Parameters.AddWithValue("@VoterCardNumber", textBox7.Text);
                        command.Parameters.AddWithValue("@ElectionID", int.Parse(textBox4.Text));

                        command.Parameters.AddWithValue("@MNAVoteFor", selectedRadioButtonMNA.Text);
                        command.Parameters.AddWithValue("@MPAVoteFor", selectedRadioButtonMPA.Text);
                        command.ExecuteNonQuery();


                        SqlCommand updateVotesCommandMNA = new SqlCommand("UPDATE MNA_Result SET VotesReceived = VotesReceived + 1 WHERE PartyName = @PartyName", connection);
                        updateVotesCommandMNA.Parameters.AddWithValue("@PartyName", selectedRadioButtonMNA.Text);
                        updateVotesCommandMNA.ExecuteNonQuery();




                        SqlCommand updateVotesCommandMPA = new SqlCommand("UPDATE MPA_Result SET VotesReceived = VotesReceived + 1 WHERE PartyName = @PartyName", connection);
                        updateVotesCommandMPA.Parameters.AddWithValue("@PartyName", selectedRadioButtonMPA.Text);
                        updateVotesCommandMPA.ExecuteNonQuery();

                        //SqlDataAdapter da = new SqlDataAdapter(command);
                        //DataTable dt = new DataTable();
                        //da.Fill(dt);
                        //form12.dataGridView1.DataSource = dt;



                        //richTextBox1.Text = "Record Inserted...";
                        MessageBox.Show("Successfully Vote Casted!");
                    }
                    else
                    {
                        //richTextBox1.Text = "Please select a political party before inserting.";
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }





        private void Form6_Load(object sender, EventArgs e)
        {

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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
