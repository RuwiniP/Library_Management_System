using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryManagementSystem
{
    public partial class updateStudentInfo : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=libraryManagementSystem");
        public updateStudentInfo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();

            MySqlDataAdapter cmd = new MySqlDataAdapter("select enrollment_No , student_name , student_email , student_contact ,enrolled_campus , department , enrolled_semester  from student where enrollment_No = '" + SID.Text + "'", con);
            DataTable dataTable = new DataTable();

            // Fill the DataTable with the data from the database
            cmd.Fill(dataTable);

            // Check if any rows were returned
            if (dataTable.Rows.Count > 0)
            {
                // Populate text boxes with retrieved information from the first row
                DataRow row = dataTable.Rows[0];
                Sname.Text = row["student_name"].ToString();
                Semail.Text = row["student_email"].ToString();
                Scontact.Text = row["student_contact"].ToString();
                Campus.Text = row["enrolled_campus"].ToString();
                Department.Text = row["department"].ToString();
                Semester.Text = row["enrolled_semester"].ToString();
            }
            else
            {
                MessageBox.Show("Student not found."); // Display message if student not found
            }

            con.Close();
        }

        private void updateBtn_Click_1(object sender, EventArgs e)
        {
            if (ValidateInput())
            {

                DBAccess db = new DBAccess();
                string query = "UPDATE student SET student_name = '" + Sname.Text + "', student_email = '" + Semail.Text + "', student_contact = '" + Convert.ToInt64(Scontact.Text) + "', enrolled_campus = '" + Campus.Text + "', department = '" + Department.Text + "', enrolled_semester = '" + Semester.Text + "' WHERE enrollment_No = '" + Convert.ToInt64(SID.Text) + "'";
                db.insertData(query);


                try
                {

                    MessageBox.Show("You have succesfully updated the student details");
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
            if (!Sname.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
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


        private void button9_Click(object sender, EventArgs e)
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

        private void button8_Click(object sender, EventArgs e)
        {
            issueBooks issueBooks = new issueBooks();
            issueBooks.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            viewStudentInfo studentInfo = new viewStudentInfo();
            studentInfo.Show();
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

            if (!string.IsNullOrWhiteSpace(SID.Text))
            {
                DBAccess db1 = new DBAccess();
                string query2 = ("SELECT COUNT(*) FROM STUDENT where enrollment_No = '" + SID.Text + "'");

                {
                    using (MySqlCommand command = new MySqlCommand(query2, con))
                    {
                        con.Open();
                        int count = Convert.ToInt32(command.ExecuteScalar()); 

                        if (count > 0)
                        {
                            string query1 = ("DELETE FROM STUDENT where enrollment_No = '" + SID.Text + "'");
                            db1.insertData(query1);
                            MessageBox.Show("Deleted Student data successfully");
                            SID.Text = "";
                            Sname.Text = "";
                            Semail.Text = "";
                            Scontact.Text = "";
                            Campus.Text = "";
                            Department.Text = "";
                            Semester.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Student Data does not exist");
                        }

                        con.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter Enrollment ID");
            }
  
        }

        private void button4_Click(object sender, EventArgs e)
        {
            viewStudentInfo viewStudentInfo = new viewStudentInfo();
            viewStudentInfo.Show();
            this.Hide();
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

    }
}
