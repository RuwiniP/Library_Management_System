using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addBooks addb = new addBooks();
            addb.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            viewBooks viewBooks = new viewBooks();
            viewBooks.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            issueBooks issueBooks = new issueBooks();
            issueBooks.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            addStudents addStudents = new addStudents();
            addStudents.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            viewStudentInfo viewStudentInfo = new viewStudentInfo();
            viewStudentInfo.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
