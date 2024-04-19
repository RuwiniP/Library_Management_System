using MySql.Data.MySqlClient;
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
    public partial class addStudents : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=libraryManagementSystem");
        public addStudents()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {

                DBAccess db = new DBAccess();
                string query = "INSERT INTO student(enrollment_No,student_name,student_email,student_contact,enrolled_campus,department,enrolled_semester) VALUES ('" + Convert.ToInt64(SID.Text) + "','" + Sname.Text + "','" + Semail.Text + "','" + Convert.ToInt64(Scontact.Text) + "','" + Campus.Text + "','" + Department.Text + "','" + Semester.Text + "')";
                db.insertData(query);


                try
                {

                    MessageBox.Show("You have succesfully added the student details");
                    SID.Text = "";
                    Sname.Text = "";
                    Semail.Text = "";
                    Scontact.Text = "";
                    Campus.Text = "";
                    Department.Text = "";
                    Semester.Text = "";
                }

                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private bool ValidateInput()
        {
            // Check if any of the required fields are empty
            if (string.IsNullOrWhiteSpace(SID.Text) ||
                string.IsNullOrWhiteSpace(Sname.Text) ||
                string.IsNullOrWhiteSpace(Semail.Text) ||
                string.IsNullOrWhiteSpace(Scontact.Text) ||
                string.IsNullOrWhiteSpace(Campus.Text) ||
                string.IsNullOrWhiteSpace(Department.Text) ||
                string.IsNullOrWhiteSpace(Semester.Text))
            {
                // Display an error message if any required field is empty
                MessageBox.Show("Please fill in all required fields.");
                return false; // Validation failed
            }

            // Validate that Sname contains only alphabetic characters
            if (!Sname.Text.All(char.IsLetter))
            {
                // Display an error message if Sname contains non-alphabetic characters
                MessageBox.Show("Student name should contain only alphabetic characters.");
                return false; // Validation failed
            }

            // Validate email format
            try
            {
                var email = new System.Net.Mail.MailAddress(Semail.Text);
            }
            catch (FormatException)
            {
                // Display an error message if email format is invalid
                MessageBox.Show("Please enter a valid email address.");
                return false; // Validation failed
            }

            if (!double.TryParse(Scontact.Text, out _))
            {
                // Display an error message if student contact is not numeric
                MessageBox.Show("Contact number should be numeric.");
                return false; // Validation failed
            }

            // Validate contact number length
            if (Scontact.Text.Length != 10)
            {
                // Display an error message if contact number length is not 10
                MessageBox.Show("Contact number should be exactly 10 digits.");
                return false; // Validation failed
            }

            // Validate that enrollment number is numeric values
            if (!double.TryParse(SID.Text, out _))
            {
                // Display an error message if enrollment number is not numeric
                MessageBox.Show("Enrollment number should be numeric.");
                return false; // Validation failed
            }

            // All validation checks passed
            return true; // Validation succeeded
        }


        private void addBooksBtn_Click(object sender, EventArgs e)
        {
            addBooks addBooks = new addBooks();
            addBooks.Show();
            this.Hide();
        }

        private void viewBooksBtn_Click(object sender, EventArgs e)
        {
            viewBooks viewBooks = new viewBooks();
            viewBooks.Show();
            this.Hide();
        }

        private void issueBooksBtn_Click(object sender, EventArgs e)
        {
            issueBooks issueBooks = new issueBooks();
            issueBooks.Show();
            this.Hide();
        }

        private void viewStudentInfoBtn_Click(object sender, EventArgs e)
        {
            viewStudentInfo studentInfo = new viewStudentInfo();
            studentInfo.Show();
            this.Hide();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            SID.Text = "";
            Sname.Text = "";
            Semail.Text = "";
            Scontact.Text = "";
            Campus.Text = "";
            Department.Text = "";
            Semester.Text = "";
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
