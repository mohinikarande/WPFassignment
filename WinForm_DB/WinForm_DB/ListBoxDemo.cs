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
    public partial class ListBoxDemo : Form
    {
        MySqlConnection connection;
        public ListBoxDemo()
        {
            InitializeComponent();
            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
        }


        private void ListBoxDemo_Load_1(object sender, EventArgs e)
        {
            try
            {
                string sql = "Select Deptno, Dname from dept";
                MySqlCommand command = new MySqlCommand(sql, connection);

               if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                MySqlDataReader reader = command.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);

                listBox1.DisplayMember = table.Columns["Dname"].ToString();
                listBox1.ValueMember = table.Columns["Deptno"].ToString();
                listBox1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.SelectedValue.ToString());

            try
            {
                string sql = "select * from emp where deptno=@dno";
                int deptno = Convert.ToInt32(listBox1.SelectedValue.ToString());

                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("dno", deptno);

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                MySqlDataReader reader = command.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);

                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}

