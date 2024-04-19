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
        // Initializing home page
        public Home()
        {
            InitializeComponent();
        }
        // Event Handler for add books button
        private void addBookBtn_Click(object sender, EventArgs e)
        {
            addBooks addb = new addBooks();
            addb.Show();
            this.Hide();
        }

        // Event Handler for view books button
        private void viewBookBtn_Click(object sender, EventArgs e)
        {
            viewBooks viewBooks = new viewBooks();
            viewBooks.Show();
            this.Hide();
        }

        // Event Handler for issue books button
        private void issueBookBtn_Click(object sender, EventArgs e)
        {
            issueBooks issueBooks = new issueBooks();
            issueBooks.Show();
            this.Hide();
        }

        // Event Handler for add student button
        private void addStudentBtn_Click(object sender, EventArgs e)
        {
            addStudents addStudents = new addStudents();
            addStudents.Show();
            this.Hide();
        }

        // Event Handler for view student info button
        private void viewStudentInfoBtn_Click(object sender, EventArgs e)
        {
            viewStudentInfo viewStudentInfo = new viewStudentInfo();
            viewStudentInfo.Show();
            this.Hide();
        }

        // Event Handler for exit button
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
