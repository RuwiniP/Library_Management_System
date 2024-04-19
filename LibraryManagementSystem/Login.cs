using MySql.Data.MySqlClient;
using System.CodeDom;

namespace LibraryManagementSystem
{
    public partial class Login : Form
    {

        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=libraryManagementSystem");
        // Initializing login page
        public Login()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
        }

        // Event Handler for Login button, verify the fields and provide access if valid user
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = this.usernameTxt.Text;
            string password = this.passwordTxt.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("No empty space allowed");
                return;
            }

            using (MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=libraryManagementSystem"))
            {
                con.Open();

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM user WHERE username = @username", con);
                cmd.Parameters.AddWithValue("@username", username);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        if (password == reader.GetString("password"))
                        {
                            Home home = new Home();
                            home.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("You have entered an invalid password. Please try again !");
                        }
                    }
                    else
                    {
                        MessageBox.Show("User not found. Please check your username.");
                    }
                }
            }
        }

    }
}