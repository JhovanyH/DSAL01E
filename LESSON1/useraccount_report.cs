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
    public partial class useraccount_report : Form
    {
        useraccount_db_connection useraccount_db_connect = new useraccount_db_connection();
        public useraccount_report()
        {
            useraccount_db_connect.useraccount_connString();
            InitializeComponent();
        }

        private void useraccount_select()
        {
            useraccount_db_connect.useraccount_cmd();
            useraccount_db_connect.useraccount_sqladapterSelect();
            useraccount_db_connect.useraccount_sqldatasetSELECT();
            dataGridView1.DataSource = useraccount_db_connect.useraccount_sql_dataset.Tables[0];
        }

        private void cleartextboxes()
        {
            optionCombo.Text = "";
            optionInputTxtbox.Clear();
        }

        private void cleartextboxes1()
        {
            optionInputTxtbox.Clear();
            optionInputTxtbox.Focus();
        }

        private void useraccount_report_Load(object sender, EventArgs e)
        {
            try
            {
                useraccount_db_connect.useraccount_sql = "SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, emp_age, emp_gender, emp_department, position, user_id, username, password, user_status, account_type FROM pos_empRegTbl INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id";

                // Note: The method useraccount_select() is likely a custom helper method you wrote 
                // to call cmd(), sqladapterSelect(), etc. similar to previous forms.
                useraccount_select();
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (optionCombo.Text == "user_id")
                {
                    useraccount_db_connect.useraccount_sql = "SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, emp_age, emp_gender, emp_department, position, user_id, username, password, user_status, account_type FROM pos_empRegTbl INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id WHERE user_id = '" + optionInputTxtbox.Text + "'";
                    useraccount_select();
                    cleartextboxes1();
                }
                else if (optionCombo.Text == "employee_number")
                {
                    // Note: The column name in the WHERE clause is likely 'pos_empRegTbl.emp_id' 
                    // but the image text cuts off slightly.
                    useraccount_db_connect.useraccount_sql = "SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, emp_age, emp_gender, emp_department, position, user_id, username, password, user_status, account_type FROM pos_empRegTbl INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id WHERE pos_empRegTbl.emp_id = '" + optionInputTxtbox.Text + "'";
                    useraccount_select();
                    cleartextboxes1();
                }
                else if (optionCombo.Text == "surname")
                {
                    useraccount_db_connect.useraccount_sql = "SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, emp_age, emp_gender, emp_department, position, user_id, username, password, user_status, account_type FROM pos_empRegTbl INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id WHERE emp_surname = '" + optionInputTxtbox.Text + "'";
                    useraccount_select();
                    cleartextboxes1();
                }
                else if (optionCombo.Text == "firstname")
                {
                    useraccount_db_connect.useraccount_sql = "SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, emp_age, emp_gender, emp_department, position, user_id, username, password, user_status, account_type FROM pos_empRegTbl INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id WHERE emp_fname = '" + optionInputTxtbox.Text + "'";
                    useraccount_select();
                    cleartextboxes1();
                }
                else if (optionCombo.Text == "active")
                {
                    // Note: The book likely intends to filter by 'user_status'. 
                    // Be careful: The code in the book image for 'active' still uses 'optionInputTxtbox.Text' in the WHERE clause.
                    // Usually for a status search like 'active', you might hardcode the value 'Active' or take it from the combo box directly.
                    // I will transcribe it exactly as written in the book image:
                    useraccount_db_connect.useraccount_sql = "SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, emp_age, emp_gender, emp_department, position, user_id, username, password, user_status, account_type FROM pos_empRegTbl INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id WHERE user_status = '" + optionInputTxtbox.Text + "'";
                    useraccount_select();
                    cleartextboxes1();
                }
                else if (optionCombo.Text == "deactivate") // The book image uses "deactivate"
                {
                    useraccount_db_connect.useraccount_sql = "SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, emp_age, emp_gender, emp_department, position, user_id, username, password, user_status, account_type FROM pos_empRegTbl INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id WHERE user_status = '" + optionInputTxtbox.Text + "'";
                    useraccount_select();
                    cleartextboxes1();
                }
                else
                {
                    MessageBox.Show("No Available Record Found!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            try
            {
                useraccount_db_connect.useraccount_sql = "SELECT pos_empRegTbl.emp_id, emp_fname, emp_mname, emp_surname, emp_age, emp_gender, emp_department, position, user_id, username, password, user_status, account_type FROM pos_empRegTbl INNER JOIN useraccountTbl ON pos_empRegTbl.emp_id = useraccountTbl.emp_id";

                // Note: The method useraccount_select() is likely a custom helper method you wrote 
                // to call cmd(), sqladapterSelect(), etc. similar to previous forms.
                useraccount_select();
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }
        }
    }
}
