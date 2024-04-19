using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LibraryManagementSystem
{
    public partial class updateBooks : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=libraryManagementSystem");
        
        // Initializing update books window
        public updateBooks()
        {
            InitializeComponent();
        }

        // Event Handler for search button
        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(ISBN.Text)))
            {
                con.Open();
                MySqlCommand command = con.CreateCommand();
                command = con.CreateCommand();

                command.CommandText = "select book_name , author, publisher, price, quantity from book where ISBN='" + ISBN.Text + "'";
                command.CommandType = CommandType.Text;
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Bname.Text = reader.GetString(0).ToString();
                    AName.Text = reader.GetString(1).ToString();
                    PName.Text = reader.GetString(2).ToString();
                    Price.Text = reader.GetInt32(3).ToString();
                    Quantity.Text = reader.GetInt32(4).ToString();


                    string output = reader.ToString().ToString();
                }
                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("Please enter valid ISBN.");
            }
        }

        // Method to validate the inputs provided by user before updating the database
        private bool ValidateInput()
        {
            // Check if any of the required fields are empty
            if (string.IsNullOrWhiteSpace(ISBN.Text))

            {
                // Display an error message if any required field is empty
                MessageBox.Show("Please fill in all required fields.");
                return false; // Validation failed
            }



            // Validate Price is numeric value
            if (!double.TryParse(Price.Text, out _))
            {

                MessageBox.Show("price  should be numeric.");
                return false; // Validation failed
            }



            // Validate Quantity is numeric values
            if (!double.TryParse(Quantity.Text, out _))
            {

                MessageBox.Show("Quantity  should be numeric.");
                return false; // Validation failed
            }

            // All validation checks passed
            return true; // Validation succeeded
        }

        // Event Handler for update button
        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {

                DBAccess db = new DBAccess();
                string query = "UPDATE book SET book_name = '" + Bname.Text + "', author = '" + AName.Text + "', price = '" + Convert.ToInt64(Price.Text) + "', quantity = '" + Convert.ToInt64(Quantity.Text) + "', publisher = '" + PName.Text + "' WHERE ISBN = '" + ISBN.Text + "'";
                db.insertData(query);


                try
                {

                    MessageBox.Show("You have succesfully updated the Book details");
                    ISBN.Text = "";
                    Bname.Text = "";
                    AName.Text = "";
                    PName.Text = "";
                    Price.Text = "";
                    Quantity.Text = "";

                }

                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        // Event Handler for delete button
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ISBN.Text))
            {
                DBAccess db1 = new DBAccess();
                string query2 = ("SELECT COUNT(*) FROM BOOK where ISBN = '" + ISBN.Text + "'");

                {
                    using (MySqlCommand command = new MySqlCommand(query2, con))
                    {
                        con.Open();
                        int count = Convert.ToInt32(command.ExecuteScalar());

                        if (count > 0)
                        {
                            string query1 = ("DELETE FROM BOOK where ISBN = '" + ISBN.Text + "'");
                            db1.insertData(query1);
                            MessageBox.Show("Deleted Book data successfully");
                            ISBN.Text = "";
                            Bname.Text = "";
                            AName.Text = "";
                            PName.Text = "";
                            Price.Text = "";
                            Quantity.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Book Data does not exist");
                        }

                        con.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter ISBN");
            }

        }

        // Event Handler for back button
        private void backBtn_Click(object sender, EventArgs e)
        {
            viewBooks viewBooks = new viewBooks();
            viewBooks.Show();
            this.Close();
        }

        // Event Handler for add books button
        private void addBooksBtn_Click(object sender, EventArgs e)
        {
            addBooks addBooks = new addBooks();
            addBooks.Show();
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
        private void addStudentsBtn_Click(object sender, EventArgs e)
        {
            addStudents addStudents = new addStudents();
            addStudents.Show();
            this.Hide();
        }

        // Event Handler for view student info button
        private void viewStudentInfoBtn_Click(object sender, EventArgs e)
        {
            viewStudentInfo studentInfo = new viewStudentInfo();
            studentInfo.Show();
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
