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
    public partial class ViewBooks : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=mySQLlibrary;Integrated Security=SSPI;");
        
        public ViewBooks()
        {
            InitializeComponent();
            

            previousform.Click += button2_Click;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewBooks_Load(object sender, EventArgs e)
        {
           
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("ViewBooks", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@Book_Name", SqlDbType.NVarChar).Value = "";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("ViewBooks", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Book_Name", SqlDbType.NVarChar).Value = textBox1.Text;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            previousform.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                con.Open();
                int book_ID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Book_ID"].Value);
                string newBookName = textBox6.Text;
                string newauthor = textBox4.Text;
                string newpublication = textBox2.Text;
                string newpurchasedate = dateTimePicker1.Text;
                string newbookprice = textBox3.Text;
                string newbookquantity = textBox5.Text;

                SqlCommand cmd = new SqlCommand("updatebookname", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@BookID", SqlDbType.Int).Value = book_ID;
                cmd.Parameters.Add("@NewBookName", SqlDbType.NVarChar).Value = newBookName;
                cmd.Parameters.Add("@NewAuthor", SqlDbType.NVarChar).Value = newauthor;
                cmd.Parameters.Add("@NewPurchaseDate", SqlDbType.Date).Value = newpurchasedate;
                cmd.Parameters.Add("@NewPublication", SqlDbType.NVarChar).Value = newpublication;
                cmd.Parameters.Add("@NewBookPrice", SqlDbType.NVarChar).Value = newbookprice;
                cmd.Parameters.Add("@NewBookQuantity", SqlDbType.Int).Value = newbookquantity;
                cmd.ExecuteNonQuery();

                SqlCommand refreshCmd = new SqlCommand("ViewBooks", con);
                refreshCmd.CommandType = CommandType.StoredProcedure;
                refreshCmd.Parameters.Add("@Book_Name", SqlDbType.NVarChar).Value = "";
                refreshCmd.Parameters.Add("@Author", SqlDbType.NVarChar).Value = "";
                refreshCmd.Parameters.Add("@Publication", SqlDbType.NVarChar).Value = "";
                refreshCmd.Parameters.Add("@Purchase_date", SqlDbType.NVarChar).Value = "";
                refreshCmd.Parameters.Add("@Book_Price", SqlDbType.NVarChar).Value = "";
                refreshCmd.Parameters.Add("@Book_Quantity", SqlDbType.NVarChar).Value = "";

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
    

