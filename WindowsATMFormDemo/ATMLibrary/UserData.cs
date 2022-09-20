using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ATMLibrary;
using System.Data;

namespace ATMLibrary
{
    public class UserData
    {

        MySqlConnection connection;
     

        public UserData(string connectionString)
        {
            connection = new MySqlConnection(connectionString);
        }

        public List<User> GetAllUsers(string cardNumber, string pinNumber)
        {
            

            try
            {
                string sql = "Select * from CardInformation where CardNumber = @CardNo and Pin = @Pin";
                MySqlCommand command= new MySqlCommand(sql, connection);
                //command.Parameters.AddWithValue("eno", empno);

                command.Parameters.AddWithValue("CardNo", cardNumber);
                command.Parameters.AddWithValue("Pin", pinNumber);

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

               
                MySqlDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);

                List<User> userList = new List<User>();


                foreach(DataRow row in dt.Rows)
                {
                    User user = new User();
                    user.UserName  = row["UserName"].ToString();
                    user.CardNumber = row["CardNumber"].ToString();
                    user.Pin = Convert.ToInt32(row["Pin"]);
                    //employee.HireDate = (DateTime)reader["Hiredate"];
                    //employee.Sal = (decimal)reader["Sal"];

                    #region TypeConversion
                    //employee.HireDate = reader["Hiredate"] as DateTime?;
                    //employee.Sal = reader["Sal"] as decimal?;

                    #endregion

                    userList.Add(user);

                }
                return userList;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public Account GetAccountBalance(string userName)
        {
            Account account = new Account();

            try
            {
                string sql = "Select  *  from AccountDetails where UserName = @UserName order by TransactionDate desc";
             
                MySqlCommand command = new MySqlCommand(sql, connection);
                //command.Parameters.AddWithValue("eno", empno);

                command.Parameters.AddWithValue("UserName", userName);
                //command.Parameters.AddWithValue("Pin", pinNumber);

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                MySqlDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);


               
          
                    //account.AccountNumber  = reader["AccountNumber"].ToString();
                    account.AccountNumber =  dt.Rows[0]["AccountNumber"].ToString();
                    account.AccountBalance = Convert.ToDecimal(dt.Rows[0]["AccountBalance"]);
                    account.TransactionDate = Convert.ToDateTime(dt.Rows[0]["TransactionDate"]);
                    account.UserName =  dt.Rows[0]["UserName"].ToString();
                    account.TransactionAmount = Convert.ToInt32(dt.Rows[0]["TransactionAmount"]);
                    account.TransactionType =  dt.Rows[0]["TransactionType"].ToString();
                    //user.CardNumber = reader["CardNumber"].ToString();
                    //user.Pin = (int)reader["Pin"];
                    //employee.HireDate = (DateTime)reader["Hiredate"];
                    //employee.Sal = (decimal)reader["Sal"];

                    #region TypeConversion
                    //employee.HireDate = reader["Hiredate"] as DateTime?;
                    //employee.Sal = reader["Sal"] as decimal?;

                    #endregion



                
                return account;
            }
            catch (Exception)
            {
                throw;
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
    
