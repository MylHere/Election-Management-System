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
    public partial class Login : Form
    {
        //private string userRole;

        public Login()
        {
            InitializeComponent();
            //userRole = role;

        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

        public static string Username = "";
        public static string Password = "";

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlConnection connection = new SqlConnection(@"Data Source = DESKTOP-O31QORP\SQLEXPRESS; Initial Catalog = Northwind; Integrated Security = True");
            Username = textBox1.Text;
            Password = textBox2.Text;
            if (Username == "" || Password == "")
            {
                MessageBox.Show("Please enter your username and password.");
            }
            else
            {
                var datasource = @"DESKTOP-T0EEFH0\SQLEXPRESS"; var database = "Election Management System";
                var thisUsername = Username; var thisPassword = Password;

                string connString = @"Data Source=" + datasource +
                    ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + thisUsername +
                    ";Password=" + thisPassword;
                SqlConnection conn = new SqlConnection(connString);

                try
                {
                    conn.Open();

                    Form2 frm1 = new Form2(Username);

                    frm1.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);

                }



            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
