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
using static System.Net.Mime.MediaTypeNames;

namespace visual_library
{
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=mySQLlibrary;Integrated Security=SSPI;");
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_add_books", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Book_Name", SqlDbType.NVarChar).Value = textBox1.Text;
            cmd.Parameters.Add("@Author", SqlDbType.NVarChar).Value = textBox2.Text;
            cmd.Parameters.Add("@Publication", SqlDbType.NVarChar).Value = textBox3.Text;
            cmd.Parameters.Add("@Purchase_date", SqlDbType.NVarChar).Value = dateTimePicker1.Value;
            cmd.Parameters.Add("@Book_Price", SqlDbType.NVarChar).Value = textBox5.Text;
            cmd.Parameters.Add("@Book_Quantity", SqlDbType.NVarChar).Value = textBox6.Text;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Book Added Successfully");
            con.Close();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

        }
    }
}
