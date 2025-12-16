using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LESSON1
{
    public partial class LoginFrm_Database : Form
    {
        employee_dbconnection emp_db_connect = new employee_dbconnection();
        loginDb_dbconnections login_db_connect = new loginDb_dbconnections();
        private string username1, password1, user_level;
        public LoginFrm_Database()
        {
            login_db_connect.login_connString();
            InitializeComponent();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            try
            {
                login_db_connect.login_connString(); // Ensure connection is established

                
                
                login_db_connect.login_sql = "SELECT pos_empRegTbl.emp_id, emp_fname, emp_surname, username, password, account_type, pos_terminal_no FROM pos_empRegTbl INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id WHERE username = '" + usernameTxtbox.Text + "' AND password = '" + passwordTxtbox.Text + "'";

                login_db_connect.login_cmd();
                login_db_connect.login_sqladapterSelect();
                login_db_connect.login_sqldatasetSELECT();

                // Retrieve data from the dataset
                // Note: Indexes correspond to the order in the SELECT statement above
                // [3]=username, [4]=password, [5]=account_type, [6]=pos_terminal_no
                string username1 = login_db_connect.login_sql_dataset.Tables[0].Rows[0][3].ToString();
                string password1 = login_db_connect.login_sql_dataset.Tables[0].Rows[0][4].ToString();
                string user_level = login_db_connect.login_sql_dataset.Tables[0].Rows[0][5].ToString();

                if (username1 == usernameTxtbox.Text && password1 == passwordTxtbox.Text)
                {
                    if (user_level == "Administrator")
                    {
                        MessageBox.Show("Access granted");
                        MainForm myform = new MainForm();
                        myform.Show();
                        cleartextboxes();
                        this.Hide();
                    }
                    else if (user_level == "Cashier1")
                    {
                        MessageBox.Show("Access granted");
                        POS2_DATABASE myform = new POS2_DATABASE();
                        cleartextboxes();
                        myform.Show();
                    }
                    else if (user_level == "Cashier2")
                    {
                        MessageBox.Show("Access granted");
                        POS1_DATABASE myform = new POS1_DATABASE();

                        // Passing data to labels on the Cashier2 form
                        myform.terminal_no.Text = login_db_connect.login_sql_dataset.Tables[0].Rows[0][6].ToString();
                        myform.emp_id.Text = login_db_connect.login_sql_dataset.Tables[0].Rows[0][0].ToString();
                        myform.emp_fname.Text = login_db_connect.login_sql_dataset.Tables[0].Rows[0][1].ToString();
                       
                        myform.emp_surname.Text = login_db_connect.login_sql_dataset.Tables[0].Rows[0][2].ToString();

                        DateTime dateTime = DateTime.Now;
                        myform.time_date.Text = dateTime.ToString("MMMM dd, yyyy");

                        cleartextboxes();
                        myform.Show();
                    }
                    else if (user_level == "HR Staff")
                    {
                        MessageBox.Show("Access granted");
                        EMP_REGISTRATION_DATABASE myform = new EMP_REGISTRATION_DATABASE();
                        myform.Delete_Button.Enabled = false; // Restrict delete permission for HR
                        cleartextboxes();
                        myform.Show();
                    }
                    else if (user_level == "Accounting Staff")
                    {
                        MessageBox.Show("Access granted");
                        PAYROL_DATABASE myform = new PAYROL_DATABASE(); 

                        // Hide editing controls for Accounting Staff
                        myform.Search_Edit_Button.Hide();
                        myform.edit_button.Hide();
                        myform.delete_button.Hide();

                        cleartextboxes();
                        myform.Show();
                    }
                    else if (user_level == "IT Staff")
                    {
                        MessageBox.Show("Access granted");
                        user_account myform = new user_account();

                        // Hide controls not allowed for IT Staff
                        myform.search_for_updateButton.Hide();
                        myform.Update_button.Hide();
                        myform.Delete_button.Hide();

                        cleartextboxes();
                        myform.Show();
                    }
                    else
                    {
                        MessageBox.Show("Access Denied");
                        cleartextboxes();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please to contact your administrator");
                cleartextboxes();
            }
        }
        

        private void cleartextboxes()
        {
            usernameTxtbox.Clear();
            passwordTxtbox.Clear();
            usernameTxtbox.Focus();
        }

        private void LoginFrm_Database_Load(object sender, EventArgs e)
        {

        }
    }
}
