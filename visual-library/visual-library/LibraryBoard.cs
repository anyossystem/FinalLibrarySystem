using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visual_library
{
    public partial class LibraryBoard : Form
    {
        public LibraryBoard()
        {
            InitializeComponent();
        }

        private void LibraryBoard_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddBooks ab = new AddBooks();
            ab.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewBooks vb = new ViewBooks();
            vb.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddStudents stud = new AddStudents();
            stud.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ViewStudents vstud = new ViewStudents();
            vstud.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            IssueBooks issueBooks = new IssueBooks();
            issueBooks.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ReturnBooks returnBooks = new ReturnBooks();
            returnBooks.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IssueBookReport ibp = new IssueBookReport();
            ibp.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Accept", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
