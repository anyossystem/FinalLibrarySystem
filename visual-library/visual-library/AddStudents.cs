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
    public partial class AddStudents : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=mySQLlibrary;Integrated Security=SSPI;");

        public AddStudents()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_add_students", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Student_Name", SqlDbType.NVarChar).Value = textBox1.Text;
            cmd.Parameters.Add("@Enrollment_Number", SqlDbType.NVarChar).Value = textBox2.Text;
            cmd.Parameters.Add("@Department", SqlDbType.NVarChar).Value = textBox3.Text;
            cmd.Parameters.Add("@Contact", SqlDbType.NVarChar).Value =textBox4.Text;
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = textBox5.Text;
            cmd.Parameters.Add("@Semester", SqlDbType.NVarChar).Value = textBox6.Text;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Student Added Successfully");
            con.Close();
        }
    }
}
