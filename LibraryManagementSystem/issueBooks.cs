using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LibraryManagementSystem
{
    public partial class issueBooks : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=libraryManagementSystem");
        public issueBooks()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(textBox1.Text)))
            {
                con.Open();
                MySqlCommand command = con.CreateCommand();
                command = con.CreateCommand();

                command.CommandText = "select student_name , student_email, student_contact from student where enrollment_No='" + textBox1.Text + "'";
                command.CommandType = CommandType.Text;
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    sName.Text = reader.GetString(0).ToString();
                    sEmail.Text = reader.GetString(1).ToString();
                    sContact.Text = reader.GetInt32(2).ToString();

                    string output = reader.ToString().ToString();
                }
                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("Please enter valid Enrollment number.");
            }
        }
        private void issueBookBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if the student ID and ISBN are provided
                if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(isbn.Text))
                {
                    MessageBox.Show("Please enter both the student's enrollment number and the book's ISBN.");
                    return;
                }

                // Check if the student exists in the database
                DBAccess db = new DBAccess();
                string studentCheckQuery = "SELECT COUNT(*) FROM student WHERE enrollment_No = '" + textBox1.Text + "'";
                int studentCount = Convert.ToInt32(db.GetScalarValue(studentCheckQuery));

                if (studentCount == 0)
                {
                    MessageBox.Show("The provided enrollment number does not exist in the database.");
                    return;
                }

                // Check if the book exists in the database
                string bookCheckQuery = "SELECT COUNT(*) FROM book WHERE ISBN = '" + isbn.Text + "'";
                int bookCount = Convert.ToInt32(db.GetScalarValue(bookCheckQuery));

                if (bookCount == 0)
                {
                    MessageBox.Show("The provided ISBN does not exist in the database.");
                    return;
                }

                // Check if the student has already issued 3 books
                string countQuery = "SELECT COUNT(*) FROM issuebook WHERE enrollment_No = '" + textBox1.Text + "'";
                int issuedBooksCount = Convert.ToInt32(db.GetScalarValue(countQuery));

                if (issuedBooksCount >= 3)
                {
                    MessageBox.Show("The student has already issued the maximum allowed number of books (3).");
                    return;
                }

                // Proceed to issue the book
                string query = "INSERT INTO issuebook (enrollment_No, ISBN, issue_Date) VALUES ('" + textBox1.Text + "','" + isbn.Text + "','" + dateTimePicker1.Value.Date.ToString("yyyyMMdd") + "')";
                db.insertData(query);

                MessageBox.Show("You have successfully issued the book.");
                // Clear input fields after successful issuance
                textBox1.Text = "";
                sName.Text = "";
                sEmail.Text = "";
                sContact.Text = "";
                isbn.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while issuing the book: " + ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            addBooks addBooks = new addBooks();
            addBooks.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            viewBooks viewBooks = new viewBooks();
            viewBooks.Show();
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

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            sName.Text = "";
            sEmail.Text = "";
            sContact.Text = "";
            isbn.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

    }
}
