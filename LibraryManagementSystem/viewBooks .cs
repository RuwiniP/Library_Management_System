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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryManagementSystem
{
    public partial class viewBooks : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=libraryManagementSystem");
        public viewBooks()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                DBAccess db1 = new DBAccess();
                string query2 = ("SELECT COUNT(*) FROM BOOK where book_name = '" + textBox1.Text + "' OR ISBN = '" + textBox1.Text + "'");
                using (MySqlCommand command = new MySqlCommand(query2, con))
                {
                    con.Open();
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)

                    {
                        MySqlDataAdapter view_t = new MySqlDataAdapter("select book_id,book_name,ISBN,author,publisher,category,price,quantity from book where book_name = '" + textBox1.Text + "' OR ISBN = '" + textBox1.Text + "'", con);
                        DataTable DT3 = new DataTable();
                        view_t.Fill(DT3);
                        dataGridView1.DataSource = DT3;
                        con.Close();
                    }

                    else
                    {
                        MessageBox.Show("Book Data does not exist");
                        con.Close();
                    }
                }
            }
        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addBooksBtn_Click(object sender, EventArgs e)
        {
            addBooks ab = new addBooks();
            ab.Show();
            this.Hide();
        }

        private void issueBooksBtn_Click(object sender, EventArgs e)
        {
            issueBooks ib = new issueBooks();
            ib.Show();
            this.Hide();
        }

        private void addStudentBtn_Click(object sender, EventArgs e)
        {
            addStudents ads = new addStudents();
            ads.Show();
            this.Hide();
        }

        private void viewStudentInfoBtn_Click(object sender, EventArgs e)
        {
            viewStudentInfo vsi = new viewStudentInfo();
            vsi.Show();
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
            textBox1.Text = "";
            dataGridView1.DataSource = null;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            updateBooks updateBooks = new updateBooks();
            updateBooks.Show();
            this.Hide();
        }
    }
}
