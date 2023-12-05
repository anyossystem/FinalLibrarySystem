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

namespace visual_library
{
    public partial class IssueBooks : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=mySQLlibrary;Integrated Security=SSPI;");
        public IssueBooks()
        {
            InitializeComponent();
        }

        private void IssueBooks_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_issuebooks", con);
            cmd.CommandType = CommandType.StoredProcedure; 
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                comboBox1.Items.Add(dr[0].ToString());
            }
            dr.Close();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("viewstudents", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@EnrollmentNo", SqlDbType.NVarChar).Value = textBox1.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = dr[0].ToString();
                textBox7.Text = dr[1].ToString();
                textBox8.Text = dr[2].ToString();
                textBox9.Text = dr[3].ToString();
                textBox12.Text = dr[4].ToString();
                textBox10.Text = dr[5].ToString();
            }

            dr.Close();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_addissuebook", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Student_Name", SqlDbType.NVarChar).Value = textBox7.Text;
            cmd.Parameters.Add("@Enrollment_No", SqlDbType.NVarChar).Value = textBox8.Text;
            cmd.Parameters.Add("@Department", SqlDbType.NVarChar).Value = textBox9.Text;
            cmd.Parameters.Add("@Contact", SqlDbType.NVarChar).Value = textBox12.Text;
            cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = textBox10.Text;
            cmd.Parameters.Add("@BookName", SqlDbType.NVarChar).Value = comboBox1.Text;
            cmd.Parameters.Add("@Issue_Date", SqlDbType.NVarChar).Value = dateTimePicker1.Value.ToString();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Issue Book Added Successfully");
            con.Close();
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox12.Text = "";
            textBox10.Text = "";
            comboBox1.Text = "";
            dateTimePicker1.Value.ToString();
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
