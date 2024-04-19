using MySql.Data.MySqlClient;


namespace LibraryManagementSystem
{
    public partial class addBooks : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=libraryManagementSystem");
        //Initializing add books window
        public addBooks()
        {
            InitializeComponent();
        }

        //Event Handler for save button 
        private void saveBtn_Click(object sender, EventArgs e)
        {
            // Validate input fields
            if (ValidateInput())
            {
                DBAccess db = new DBAccess();
                string query = "INSERT INTO book(book_name,ISBN,author,publisher,category,price,quantity) VALUES ('" + bookName.Text + "','" + isbn.Text + "','" + author.Text + "','" + publisher.Text + "','" + category.Text + "','" + Convert.ToDouble(price.Text) + "','" + Convert.ToInt64(qty.Text) + "')";
                db.insertData(query);


                try
                {
                    MessageBox.Show("You have succesfully added the book details");
                    bookName.Text = "";
                    isbn.Text = "";
                    author.Text = "";
                    publisher.Text = "";
                    category.Text = "";
                    price.Text = "";
                    qty.Text = "";
                }

                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        // Method to validate input data before adding to the database of books
        private bool ValidateInput()
        {
            // Check if any of the required fields are empty
            if (string.IsNullOrWhiteSpace(bookName.Text) ||
                string.IsNullOrWhiteSpace(isbn.Text) ||
                string.IsNullOrWhiteSpace(author.Text) ||
                string.IsNullOrWhiteSpace(publisher.Text) ||
                string.IsNullOrWhiteSpace(category.Text) ||
                string.IsNullOrWhiteSpace(price.Text) ||
                string.IsNullOrWhiteSpace(qty.Text))
            {
                // Display an error message if any required field is empty
                MessageBox.Show("Please fill in all required fields.");
                return false; // Validation failed
            }

            // Validate that price is a valid numeric value
            if (!double.TryParse(price.Text, out _))
            {
                // Display an error message if price is not a valid numeric value
                MessageBox.Show("Please enter a valid price.");
                return false; // Validation failed
            }

            // Validate that quantity is a valid numeric value
            if (!double.TryParse(qty.Text, out _))
            {
                // Display an error message if quantity is not a valid numeric value
                MessageBox.Show("Please enter a valid quantity.");
                return false; // Validation failed
            }

            // All validation checks passed
            return true; // Validation succeeded
        }

        // Event Handler for view books button
        private void viewBookBtn_Click(object sender, EventArgs e)
        {
            viewBooks vb = new viewBooks();
            vb.Show();
            this.Hide();
        }

        // Event Handler for issue books button
        private void issueBookBtn_Click(object sender, EventArgs e)
        {
            issueBooks ib = new issueBooks();
            ib.Show();
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
            viewStudentInfo vsi = new viewStudentInfo();
            vsi.Show();
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
            bookName.Text = "";
            isbn.Text = "";
            author.Text = "";
            publisher.Text = "";
            category.Text = "";
            price.Text = "";
            qty.Text = "";
        }

        // Event Handler for cancel button
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
