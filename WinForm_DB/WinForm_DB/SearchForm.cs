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
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
            //traditional query
            //string sql = "select * from emp where deptno = " +txtdeptno.Text;

            //parameterized query
            string sql = "select * from emp where deptno = @dno and job = @job";
            MySqlCommand command = new MySqlCommand(sql, connection);

            command.Parameters.AddWithValue("dno", txtdeptno.Text);
            command.Parameters.AddWithValue("job", txtJob.Text);


            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            if (string.IsNullOrEmpty(txtdeptno.Text))
            {
                MessageBox.Show("Please Enter Deptno in Search Box :");
            }

            MySqlDataReader reader = command.ExecuteReader();

            DataTable table = new DataTable();
            table.Load(reader);
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }

            dataGridView1.DataSource = table;


            if (table.Rows.Count == 0)
            {
                MessageBox.Show("No emp found for Deptno" +txtdeptno.Text);
            }



        }

     
    }
}
