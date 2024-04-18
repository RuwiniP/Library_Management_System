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
            DBAccess db = new DBAccess();
            string query = "INSERT INTO issueBook(enrollment_No,ISBN,issue_Date) VALUES ('" + textBox1.Text + "','" + isbn.Text + "','" + dateTimePicker1.Value.Date.ToString("yyyyMMdd") + "')";
            db.insertData(query);
            try
            {
                MessageBox.Show("You have succesfully issued the book");
                textBox1.Text = "";
                sName.Text = "";
                sEmail.Text = "";
                sContact.Text = "";
                isbn.Text = "";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

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
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
