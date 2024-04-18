using MySql.Data.MySqlClient;
using System.CodeDom;

namespace LibraryManagementSystem
{
    public partial class Login : Form
    {
        
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=libraryManagementSystem");
       
        public Login()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            string username = this.usernameTxt.Text.ToString();
            string password = this.passwordTxt.Text.ToString();
            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                MessageBox.Show("No empty space allowed");
            }

            else
            {
                
                MySqlCommand cmd = new MySqlCommand("select * from user", con);
                
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (username.Equals(reader.GetString("username")) && (password.Equals(reader.GetString("password"))))
                    {  
                        Home home = new Home();
                        home.Show();
                        this.Hide();                      
                    }

                    else
                    {
                        
                        MessageBox.Show("You have entered invalid credentials. Please try again !");
                        
                    }

                   
                }

                con.Close();


            }
        }
    }
}