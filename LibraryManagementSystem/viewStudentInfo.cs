using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryManagementSystem
{
    public partial class viewStudentInfo : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=libraryManagementSystem");
        // Initializing view student info window
        public viewStudentInfo()
        {
            InitializeComponent();
        }

        // Event Handler for search button
        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                DBAccess db1 = new DBAccess();
                string query2 = ("SELECT COUNT(*) FROM STUDENT where enrollment_No = '" + textBox1.Text + "'");
                using (MySqlCommand command = new MySqlCommand(query2, con))
                {
                    con.Open();
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)

                    {
                        
                        MySqlDataAdapter view_t = new MySqlDataAdapter("select enrollment_No , student_name , student_email , student_contact ,enrolled_campus , department , enrolled_semester  from student where enrollment_No = '" + textBox1.Text + "'", con);
                        DataTable DT3 = new DataTable();

                        view_t.Fill(DT3);
                        dataGridView1.DataSource = DT3;
                        con.Close();
                    }

                    else
                    {
                        MessageBox.Show("Student Data does not exist");
                        con.Close();
                    }

                }
            }

        }

        // Event Handler for add books button
        private void addBooksBtn_Click(object sender, EventArgs e)
        {
            addBooks addBooks = new addBooks();
            addBooks.Show();
            this.Hide();
        }

        // Event Handler for view books button
        private void viewBooksBtn_Click(object sender, EventArgs e)
        {
            viewBooks viewBooks = new viewBooks();
            viewBooks.Show();
            this.Hide();
        }

        // Event Handler for issue books button
        private void issueBooksBtn_Click(object sender, EventArgs e)
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

        // Event Handler for exit button
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        // Event Handler for clear button
        private void clearBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            dataGridView1.DataSource = null;
        }

        // Event Handler for cancel button
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        // Event Handler for update button
        private void updateBtn_Click(object sender, EventArgs e)
        {
            updateStudentInfo updateStudentInfo = new updateStudentInfo();
            updateStudentInfo.Show();
            this.Hide();
        }
    }
}
