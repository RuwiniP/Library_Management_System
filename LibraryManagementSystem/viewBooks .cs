﻿using MySql.Data.MySqlClient;
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
            con.Open();

            MySqlDataAdapter view_t = new MySqlDataAdapter("select book_id,book_name,ISBN,author,publisher,category,price,quantity from book where book_name = '" + textBox1.Text + "' OR ISBN = '" + textBox1.Text + "'", con);
            DataTable DT3 = new DataTable();

            view_t.Fill(DT3);
            dataGridView1.DataSource = DT3;
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            addBooks ab = new addBooks();
            ab.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            issueBooks ib = new issueBooks();
            ib.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            addStudents ads = new addStudents();
            ads.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            viewStudentInfo vsi = new viewStudentInfo();
            vsi.Show();
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
            dataGridView1.DataSource = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}