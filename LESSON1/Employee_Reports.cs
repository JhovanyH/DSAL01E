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
    public partial class Employee_Reports : Form
    {
        payrol_dbconnection pd = new payrol_dbconnection();
        public Employee_Reports()
        {
            pd.payrol_connString();
            InitializeComponent();
        }
        private void payrol_select()
        {
            pd.payrol_cmd();
            pd.payrol_sqladapterSelect();
            pd.payrol_sqldatasetSELECT();
            dataGridView1.DataSource = pd.payrol_sql_dataset.Tables[0];
        }

        private void cleartextboxes()
        {
            optionCombo.Text = "";
            optionInputTxtbox.Clear();
            optionCombo.Focus();

        }

        private void Cleartextboxes1()
        {
            optionInputTxtbox.Clear();
            optionInputTxtbox.Focus();
        }


        private void Employee_Reports_Load(object sender, EventArgs e)
        {
            pd.payrol_sql = "SELECT * FROM pos_empRegTbl";
            payrol_select();
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            if (optionCombo.Text == "employee_number")
            {
                pd.payrol_sql = "SELECT * FROM pos_empRegTbl WHERE emp_id = '" + optionInputTxtbox.Text + "'";
                payrol_select();    
                Cleartextboxes1();
            }
            else if (optionCombo.Text == "surname")
            {
                pd.payrol_sql = "SELECT * FROM pos_empRegTbl WHERE emp_surname = '" + optionInputTxtbox.Text + "'";
                payrol_select();
                Cleartextboxes1();
            }
            else if (optionCombo.Text == "firstname")
            {
                pd.payrol_sql = "SELECT * FROM pos_empRegTbl WHERE emp_fname = '" + optionInputTxtbox.Text + "'";
                payrol_select();
                Cleartextboxes1();       
            }
            else if (optionCombo.Text == "department")
            {
                pd.payrol_sql = "SELECT * FROM pos_empRegTbl WHERE emp_department = '" + optionInputTxtbox.Text + "'";
                payrol_select();
                Cleartextboxes1();
            }

            else if (optionCombo.Text == "designation")
            {
                pd.payrol_sql = "SELECT * FROM pos_empRegTbl WHERE position = '" + optionInputTxtbox.Text + "'";
                payrol_select();
                Cleartextboxes1();
            }

            else if (optionCombo.Text == "zipcode")
            {
                pd.payrol_sql = "SELECT * FROM pos_empRegTbl WHERE add_zipcode = '" + optionInputTxtbox.Text + "'";
                payrol_select();
                Cleartextboxes1();
            }

            else if (optionCombo.Text == "province")
            {
                pd.payrol_sql = "SELECT * FROM pos_empRegTbl WHERE add_state_province = '" + optionInputTxtbox.Text + "'";
                payrol_select();
                Cleartextboxes1();
            }

            else if (optionCombo.Text == "city")
            {
                pd.payrol_sql = "SELECT * FROM pos_empRegTbl WHERE add_city = '" + optionInputTxtbox.Text + "'";
                payrol_select();
                Cleartextboxes1();
            }

            else
            {
                MessageBox.Show("No Available Recored Found!");
            }
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            try
            {
                pd.payrol_sql = "SELECT * FROM pos_empRegTbl";
                payrol_select();
                cleartextboxes();
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact you administrator!");
            }
        }
    }
}
