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
using ATMLibrary;

namespace WindowsATMFormDemo
{
    public partial class Form1 : Form
    {
        UserData datastore;
        public Form1()
        {
            InitializeComponent();
            datastore = new UserData(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            var user = datastore.GetAllUsers(txtCardNumber.Text, txtPinNumber.Text);

            if (user.Count > 0)

            {
               
                AtmOperation atmOperation1 = new AtmOperation();
                atmOperation1.UserName = user[0].UserName;
                atmOperation1.Show();
                //MessageBox.Show(row["CardNumber"].ToString());
            }
            else
            {
                MessageBox.Show("Please Provide Valid Details");
            }
        }
    
           
            void ClearTextBoxes()
            {
                txtCardNumber.Clear();
                txtPinNumber.Clear();
            }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
            ClearTextBoxes();
        }


    }
}
    

