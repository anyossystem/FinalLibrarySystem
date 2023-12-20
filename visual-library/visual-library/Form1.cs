using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace visual_library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=mySQLlibrary;Integrated Security=SSPI;");

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_LoginAdmin", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@inputusername", SqlDbType.NVarChar).Value = textBox1.Text;
            cmd.Parameters.Add("@inputpassword", SqlDbType.NVarChar).Value = textBox2.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                LibraryBoard lb = new LibraryBoard();
                lb.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Login Failed");
            }
            con.Close();

        }

        private void student_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Login_Student WHERE username = @inputusername AND password = @inputpassword", con);
            cmd.Parameters.Add("@inputusername", SqlDbType.NVarChar).Value = textBox1.Text;
            cmd.Parameters.Add("@inputpassword", SqlDbType.NVarChar).Value = textBox2.Text;
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                string userRole = dr["UserRole"].ToString();  // Assuming UserRole is the name of the column in the database
                AddBooks ab = new AddBooks(userRole);  // Pass the user's role to the ViewBooks constructor
                ab.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed");
            }

            con.Close();
        }
    }
}