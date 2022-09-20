using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLibrary;
using System.Configuration;

namespace WinForm_DB
{
    public partial class DataDMLForm : Form
    {
        EmployeeDataStore dataStore;
        public DataDMLForm()
        {
            InitializeComponent();
            dataStore = new EmployeeDataStore(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
        }

        private void DataDMLForm_Load(object sender, EventArgs e)
        {
            try
            {
                EmpDataGrid.DataSource = dataStore.GetAllEmployees();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }
        void ClearTextBoxes()
        {
            txtEmpNo.Clear();
            txtEName.Clear();
            txtHireDate.Clear();
            txtSalary.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmpNo.Text == String.Empty)
                {
                    MessageBox.Show("Please enter empno value");
                    return;
                }
                int empno = Convert.ToInt32(txtEmpNo.Text);
                Employee employee = dataStore.GetEmployeeByNo(empno);

                if (employee == null)
                {
                    MessageBox.Show("No employee found for no" + empno.ToString());
                    ClearTextBoxes();
                }
                else
                {
                    txtEName.Text = employee.EName;
                    txtHireDate.Text = employee.HireDate.ToString();
                    txtSalary.Text = employee.Sal.ToString();
                    txtSalary.Text = employee.Sal.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception : \n" + ex.Message);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee()
                {
                    EmpNo = Convert.ToInt32(txtEmpNo.Text),
                    EName = txtEName.Text,
                    HireDate = Convert.ToDateTime(txtHireDate.Text),
                    Sal = Convert.ToDecimal(txtSalary.Text)
                };

                int count = dataStore.InsertEmployee(employee);

                if (count == 1)
                {
                    MessageBox.Show("Record Inserted");

                    EmpDataGrid.DataSource = dataStore.GetAllEmployees();
                    ClearTextBoxes();
                }
                else
                {
                    MessageBox.Show("Insert Fail");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception : \n" + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {



                int EmpNo = Convert.ToInt32(txtEmpNo.Text);

                int count = dataStore.DeleteEmployee(EmpNo);
                if (count == 1)
                {
                    MessageBox.Show("Record Deleted");
                    EmpDataGrid.DataSource = dataStore.GetAllEmployees();
                    ClearTextBoxes();
                }
                else
                {
                    MessageBox.Show("Delete Fail");
                }

            }
            catch
            {
                Exception exception = new Exception();
            }
        }

       
    }
    }

