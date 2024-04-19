using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    class DBAccess
    {


        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=libraryManagementSystem");
        MySqlCommand cmd;

        public void insertData(string query)
        {
            con.Open();


            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;

            cmd.ExecuteNonQuery();


            con.Close();

        }

        public object GetScalarValue(string query)
        {
            object result = null;

            {
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    con.Open();
                    result = cmd.ExecuteScalar();
                    con.Close();
                }
            }
            return result;
        }


    }

}

