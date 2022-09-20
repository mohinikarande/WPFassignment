using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //provider
using System.Configuration;

namespace WinForm_DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            //MySqlConnection connection = new MySqlConnection("server =localhost;port=3306;database=training;User Id=root; password=worldline;");

            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);


            string sql = "select * from dept";
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "dept");

            dataGridView1.DataSource = ds.Tables["dept"];
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {


            //  MySqlConnection connection = new MySqlConnection("server =localhost;port=3306;database=training;User Id=root; password=worldline;");

            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);

            string sql = "select * from emp";
            MySqlCommand command = new MySqlCommand(sql, connection);
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

            dataGridView1.DataSource = table;

        }
    }
}
