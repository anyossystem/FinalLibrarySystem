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

namespace visual_library
{

    public partial class ViewStudents : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=mySQLlibrary;Integrated Security=SSPI;");

        public ViewStudents()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ViewStudents_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("viewstudents", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@EnrollmentNo", SqlDbType.NVarChar).Value = "";
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("viewstudents", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@EnrollmentNo", SqlDbType.NVarChar).Value = textBox1.Text;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void UpdateStudent_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                con.Open();
                int student_ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Student_ID"].Value);
                string newStudent_ID = textBox8.Text;
                string newStudentName = textBox7.Text;
                string newEnrollmentNumber = textBox2.Text;
                string newDepartment = textBox3.Text;
                string newContact = textBox4.Text;
                string newEmail = textBox5.Text;
                string newSemester = textBox6.Text;

                SqlCommand cmd = new SqlCommand("updatestudent", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@StudentID", SqlDbType.Int).Value = student_ID;
                cmd.Parameters.Add("@NewStudentName", SqlDbType.NVarChar).Value = newStudentName;
                cmd.Parameters.Add("@NewEnrollmentNumber", SqlDbType.NVarChar).Value = newEnrollmentNumber;
                cmd.Parameters.Add("@NewDepartment", SqlDbType.NVarChar).Value = newDepartment;
                cmd.Parameters.Add("@NewContact", SqlDbType.NVarChar).Value = newContact;
                cmd.Parameters.Add("@NewEmail", SqlDbType.NVarChar).Value = newEmail;
                cmd.Parameters.Add("@NewSemester", SqlDbType.NVarChar).Value = newSemester;
                cmd.ExecuteNonQuery();

                SqlCommand refreshCmd = new SqlCommand("ViewStudents", con);
                refreshCmd.CommandType = CommandType.StoredProcedure;
                refreshCmd.Parameters.Add("@Student_Name", SqlDbType.NVarChar).Value = "";
                refreshCmd.Parameters.Add("@Enrollment_Number", SqlDbType.NVarChar).Value = "";
                refreshCmd.Parameters.Add("@Department", SqlDbType.NVarChar).Value = "";
                refreshCmd.Parameters.Add("@Contact", SqlDbType.NVarChar).Value = "";
                refreshCmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = "";
                refreshCmd.Parameters.Add("@Semester", SqlDbType.NVarChar).Value = "";

                SqlDataAdapter sda = new SqlDataAdapter(refreshCmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;

                con.Close();
            }
            else
            {
                MessageBox.Show("You must select a row in order to update.");
            }

        }
    }
}
    


