using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace WinForm_DB
{
    public partial class DBLoginForm : Form
    {
        public DBLoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
            string sql = "select * from UserData where UserName = @user and Password = @pass";
            MySqlCommand command = new MySqlCommand(sql, connection);


            command.Parameters.AddWithValue("User", txtUserName.Text);
            command.Parameters.AddWithValue("pass", txtPassword.Text);


            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }


            MySqlDataReader reader = command.ExecuteReader();


            DataTable table = new DataTable();
            table.Load(reader);
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();

            }
            if (table.Rows.Count > 0)
            {
                DataRow row = table.Rows[0];
                MessageBox.Show(row["Role"].ToString());
            }
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("provided username and password is wrong");
            }
        }
        }
    }

