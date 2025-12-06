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
    public partial class UserAccount_Database : Form
    {
        payrol_dbconnection pd = new payrol_dbconnection();
        Payroll_Variables_Database pv = new Payroll_Variables_Database();
        private string picpath;
        private double basic_income = 0.00,
            rate_basic = 0.00,
            no_hours_basic = 0.00,
            hono_income = 0.00,
            rate_hono = 0.00,
            no_hours_hono = 0.00,
            other_income = 0.00,
            rate_other = 0.00,
            no_hours_others = 0.00,
            gross_income = 0.00,
            sss_contrib = 0.00,
            phil_contrib = 0.00,
            net_income = 0.00,
            tax_contrib = 0.00,
            pagibig_contrib = 0.00,
            sss_loan = 0.00,
            pagibig_loan = 0.00,
            FSD = 0.00,
            FSL = 0.00,
            salary_loan = 0.00,
            other_loan = 0.00,
            total_deductions = 0.00,
            total_contrib = 0.00,
            total_loan = 0.00;

        private void exit_button_Click(object sender, EventArgs e)
        {

        }

        private void search_button_Click(object sender, EventArgs e)
        {
            try
            {
                // First query - get employee basic info
                pd.payrol_sql = "SELECT emp_id, emp_fname, emp_mname, emp_surname, emp_status, " +
                    "position, emp_no_of_dependents, emp_work_status, emp_department, picpath " +
                    "FROM pos_empRegTbl WHERE emp_id = '" + employeenumtxtbox.Text + "'";

                pd.payrol_cmd();
                pd.payrol_sqladapterSelect();
                pd.payrol_sqldatasetSELECT();

                fnametxtbox.Text = pd.payrol_sql_dataset.Tables[0].Rows[0][1].ToString();
                Mnametxtbox.Text = pd.payrol_sql_dataset.Tables[0].Rows[0][2].ToString();
                Snametxtbox.Text = pd.payrol_sql_dataset.Tables[0].Rows[0][3].ToString();
                civilstattxtbox.Text = pd.payrol_sql_dataset.Tables[0].Rows[0][4].ToString();
                designationtxtbox.Text = pd.payrol_sql_dataset.Tables[0].Rows[0][5].ToString();
                numberDependentsTxtbox.Text = pd.payrol_sql_dataset.Tables[0].Rows[0][6].ToString();
                employeestatustxtbox.Text = pd.payrol_sql_dataset.Tables[0].Rows[0][7].ToString();
                departmentTxtbox.Text = pd.payrol_sql_dataset.Tables[0].Rows[0][8].ToString();
                picpathtxtbox.Text = pd.payrol_sql_dataset.Tables[0].Rows[0][9].ToString();

                // Load picture with validation
                if (!string.IsNullOrEmpty(picpathtxtbox.Text) && System.IO.File.Exists(picpathtxtbox.Text))
                {
                    pictureBox1.Image = System.Drawing.Image.FromFile(picpathtxtbox.Text);
                }
                else
                {
                    pictureBox1.Image = System.Drawing.Image.FromFile("C:\\Users\\jhovany\\OneDrive\\Pictures\\question.png");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Employee not found or error: " + ex.Message);
                return;
            }

            // Second query - get payroll data
            try
            {
                pd.payrol_sql = "SELECT pos_empRegTbl.emp_id, emp_fname, " +
                    "emp_mname, emp_surname, emp_status, position, emp_no_of_dependents," +
                    " emp_work_status, emp_department, picpath, basic_rate_hr," +
                    "basic_no_of_hrs_cutOff, basic_income_per_cutOff, honorarium_rate_hr," +
                    " honorarium_no_of_hrs_cutOff, honorarium_income_per_cutOff," +
                    " other_rate_hr, other_no_of_hrs_cutOff, other_income_per_cutOff," +
                    "sss_contrib, philhealth_contrib, pagibig_contrib, tax_contrib," +
                    "sss_loan, pagibig_loan, fac_savings_deposit, fac_savings_loan," +
                    "salary_loan, other_loans, total_deductions, gross_income," +
                    "net_income, payrolTbl.emp_id, pay_date FROM pos_empRegTbl INNER" +
                    "JOIN payrolTbl ON pos_empRegTbl.emp_id = payrolTbl.emp_id WHERE" +
                    "(payrolTbl.emp_id = '" + employeenumtxtbox.Text + "' AND" +
                    "payrolTbl.pay_date = '" + paydateCombo.Text + "')";

                pd.payrol_cmd();
                pd.payrol_sqladapterSelect();
                pd.payrol_sqldatasetSELECT();

                // Load payroll data - CHANGED payrol_db_connect to pd
                fnametxtbox.Text = pd.payrol_sql_dataset.Tables[0].Rows[0][1].ToString();
                Mnametxtbox.Text = pd.payrol_sql_dataset.Tables[0].Rows[0][2].ToString();
                Snametxtbox.Text = pd.payrol_sql_dataset.Tables[0].Rows[0][3].ToString();
                civilstattxtbox.Text = pd.payrol_sql_dataset.Tables[0].Rows[0][4].ToString();
                designationtxtbox.Text = pd.payrol_sql_dataset.Tables[0].Rows[0][5].ToString();
                numberDependentsTxtbox.Text = pd.payrol_sql_dataset.Tables[0].Rows[0][6].ToString();
                employeestatustxtbox.Text = pd.payrol_sql_dataset.Tables[0].Rows[0][7].ToString();
                departmentTxtbox.Text = pd.payrol_sql_dataset.Tables[0].Rows[0][8].ToString();
                picpathtxtbox.Text = pd.payrol_sql_dataset.Tables[0].Rows[0][9].ToString();

                if (!string.IsNullOrEmpty(picpathtxtbox.Text) && System.IO.File.Exists(picpathtxtbox.Text))
                {
                    pictureBox1.Image = System.Drawing.Image.FromFile(picpathtxtbox.Text);
                }

                rate_hour_basicIntxtbox.Text = pd.payrol_sql_dataset.Tables[0].Rows[0][10].ToString();
                no_hours_basicIntxtbox.Text = pd.payrol_sql_dataset.Tables[0].Rows[0][11].ToString();
                income_basicintxtbox.Text = pd.payrol_sql_dataset.Tables[0].Rows[0][12].ToString();

                rate_hourHonorTxtbox.Text = pd.payrol_sql_dataset.Tables[0].Rows[0][13].ToString();
                no_hoursHonotxtbox.Text = pd.payrol_sql_dataset.Tables[0].Rows[0][14].ToString();
                income_HonorariumTxtbox.Text = pd.payrol_sql_dataset.Tables[0].Rows[0][15].ToString();

                ratehour_OtherTxtbox.Text = pd.payrol_sql_dataset.Tables[0].Rows[0][16].ToString();
                no_HoursOtherTxtbox.Text = pd.payrol_sql_dataset.Tables[0].Rows[0][17].ToString();
                Income_otherTxtbox.Text = pd.payrol_sql_dataset.Tables[0].Rows[0][18].ToString();

                ssscontritxtbox.Text = pd.payrol_sql_dataset.Tables[0].Rows[0][19].ToString();
                philhealthcontritxtbox.Text = pd.payrol_sql_dataset.Tables[0].Rows[0][20].ToString();
                pagibigcontrittxtbox.Text = pd.payrol_sql_dataset.Tables[0].Rows[0][21].ToString();
                tax_contribTxtbox.Text = pd.payrol_sql_dataset.Tables[0].Rows[0][22].ToString();

                sssloantxtbox.Text = pd.payrol_sql_dataset.Tables[0].Rows[0][23].ToString();
                pagibigloantxtbox.Text = pd.payrol_sql_dataset.Tables[0].Rows[0][24].ToString();
                facultydeposittxtbox.Text = pd.payrol_sql_dataset.Tables[0].Rows[0][25].ToString();
                facultysavingstxtbox.Text = pd.payrol_sql_dataset.Tables[0].Rows[0][26].ToString();
                salaryloantxtbox.Text = pd.payrol_sql_dataset.Tables[0].Rows[0][27].ToString();
                other_loanTxtbox.Text = pd.payrol_sql_dataset.Tables[0].Rows[0][28].ToString();

                total_deducTxtbox.Text = pd.payrol_sql_dataset.Tables[0].Rows[0][29].ToString();
                grossIncometxtbox.Text = pd.payrol_sql_dataset.Tables[0].Rows[0][30].ToString();
                netincometxtbox.Text = pd.payrol_sql_dataset.Tables[0].Rows[0][31].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No payroll record found. You can add a new one. Error: " + ex.Message);
            }
        }
        

        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                pd.payrol_sql =
                    "DELETE FROM payrolTbl WHERE payrolTbl.emp_id = '" +
                    employeenumtxtbox.Text + "'";

                pd.payrol_cmd();
                pd.payrol_sqladapterDelete();
                cleartextboxes();
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }

        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            try
            {
                pd.payrol_sql =
               "INSERT INTO payrolTbl (" +
               "basic_rate_hr, basic_no_of_hrs_cutOff, basic_income_per_cutOff, " +
               "honorarium_rate_hr, honorarium_no_of_hrs_cutOff, honorarium_income_per_cutOff, " +
               "other_rate_hr, other_no_of_hrs_cutOff, other_income_per_cutOff, " +
               "sss_contrib, philhealth_contrib, pagibig_contrib, tax_contrib, " +
               "sss_loan, pagibig_loan, fac_savings_deposit, fac_savings_loan, " +
               "salary_loan, other_loans, total_deductions, gross_income, " +
               "net_income, emp_id, pay_date) " +
               "VALUES ('" + rate_hour_basicIntxtbox.Text +
               "', '" + no_hours_basicIntxtbox.Text +
               "', '" + income_basicintxtbox.Text +
               "', '" + rate_hourHonorTxtbox.Text +
               "', '" + no_hoursHonotxtbox.Text +
               "', '" + income_HonorariumTxtbox.Text +
               "', '" + ratehour_OtherTxtbox.Text +
               "', '" + no_HoursOtherTxtbox.Text +
               "', '" + Income_otherTxtbox.Text +
               "', '" + ssscontritxtbox.Text +
               "', '" + philhealthcontritxtbox.Text +
               "', '" + pagibigcontrittxtbox.Text +
               "', '" + tax_contribTxtbox.Text +
               "', '" + sssloantxtbox.Text +
               "', '" + pagibigloantxtbox.Text +
               "', '" + facultydeposittxtbox.Text +
               "', '" + facultysavingstxtbox.Text +
               "', '" + salaryloantxtbox.Text +
               "', '" + other_loanTxtbox.Text +
               "', '" + total_deducTxtbox.Text +
               "', '" + grossIncometxtbox.Text +
               "', '" + netincometxtbox.Text +
               "', '" + employeenumtxtbox.Text +
               "', '" + paydateCombo.Text + "')";

                pd.payrol_cmd();
                pd.payrol_sqladapterUpdate();
                cleartextboxes();
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }

        }

        private void save_button_Click(object sender, EventArgs e)
        {
            try
            {
                pd.payrol_sql =
                "INSERT INTO payrolTbl (" +
                "basic_rate_hr, basic_no_of_hrs_cutOff, basic_income_per_cutOff, " +
                "honorarium_rate_hr, honorarium_no_of_hrs_cutOff, honorarium_income_per_cutOff, " +
                "other_rate_hr, other_no_of_hrs_cutOff, other_income_per_cutOff, " +
                "sss_contrib, philhealth_contrib, pagibig_contrib, tax_contrib, " +
                "sss_loan, pagibig_loan, fac_savings_deposit, fac_savings_loan, " +
                "salary_loan, other_loans, total_deductions, gross_income, " +
                "net_income, emp_id, pay_date) " +
                "VALUES ('" + rate_hour_basicIntxtbox.Text +
                "', '" + no_hours_basicIntxtbox.Text +
                "', '" + income_basicintxtbox.Text +
                "', '" + rate_hourHonorTxtbox.Text +
                "', '" + no_hoursHonotxtbox.Text +
                "', '" + income_HonorariumTxtbox.Text +
                "', '" + ratehour_OtherTxtbox.Text +
                "', '" + no_HoursOtherTxtbox.Text +
                "', '" + Income_otherTxtbox.Text +
                "', '" + ssscontritxtbox.Text +
                "', '" + philhealthcontritxtbox.Text +
                "', '" + pagibigcontrittxtbox.Text +
                "', '" + tax_contribTxtbox.Text +
                "', '" + sssloantxtbox.Text +
                "', '" + pagibigloantxtbox.Text +
                "', '" + facultydeposittxtbox.Text +
                "', '" + facultysavingstxtbox.Text +
                "', '" + salaryloantxtbox.Text +
                "', '" + other_loanTxtbox.Text +
                "', '" + total_deducTxtbox.Text +
                "', '" + grossIncometxtbox.Text +
                "', '" + netincometxtbox.Text +
                "', '" + employeenumtxtbox.Text +
                "', '" + paydateCombo.Text + "')";

                pd.payrol_cmd();
                pd.payrol_sqladapterInsert();
                cleartextboxes();
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs in this area. Please contact your administrator!");
            }

        }

        public UserAccount_Database() 
        { 
            InitializeComponent();
            pd.payrol_connString();
            InitializeComponent();
        }

        private void no_hours_basicIntxtbox_TextChanged(object sender, EventArgs e)
        {
            CalculateBasicIncome();
        }

        private void no_hoursHonotxtbox_TextChanged(object sender, EventArgs e)
        {
            CalculateOtherIncome();
        }

        private void no_HoursOtherTxtbox_TextChanged(object sender, EventArgs e)
        {
            CalculateOtherIncome();
            CalculateGrossIncome();
        }
        private void CalculateBasicIncome()
        {
            if (double.TryParse(no_hours_basicIntxtbox.Text, out no_hours_basic) &&
                double.TryParse(rate_hour_basicIntxtbox.Text, out rate_basic))
            {
                basic_income = no_hours_basic * rate_basic;
                income_basicintxtbox.Text = basic_income.ToString("n");
            }
        }
        private void CalculateHonorarium()
        {
            if (double.TryParse(rate_hourHonorTxtbox.Text, out rate_hono) &&
                double.TryParse(no_hoursHonotxtbox.Text, out no_hours_hono))
            {
                hono_income = rate_hono * no_hours_hono;
                income_HonorariumTxtbox.Text = hono_income.ToString("n");
            }
        }
        private void CalculateOtherIncome()
        {
            if (double.TryParse(ratehour_OtherTxtbox.Text, out rate_other) &&
                double.TryParse(no_HoursOtherTxtbox.Text, out no_hours_others))
            {
                other_income = rate_other * no_hours_others;
                Income_otherTxtbox.Text = other_income.ToString("n");
            }
        }
        private void CalculateGrossIncome()
        {
            gross_income = basic_income + hono_income + other_income;
            grossIncometxtbox.Text = gross_income.ToString("n");
        }


        private void print_payslipButton_Click(object sender, EventArgs e)
        {
            //codes for calling the other form connected to the current form
            UserAccount_DatabasePrintForm pf = new UserAccount_DatabasePrintForm();
            //codes to display the contents of the listbox from other form to the current form.
            pf.Display_ListBox.Items.AddRange(this.Payslip_viewlistbox.Items);
            pf.Show();
        }
        

        private void grossincomebutton_Click(object sender, EventArgs e)
        {
            sss_contrib = Convert.ToDouble(ssscontritxtbox.Text);
            pagibig_contrib = Convert.ToDouble(pagibigcontrittxtbox.Text);
            phil_contrib = Convert.ToDouble(philhealthcontritxtbox.Text);
            tax_contrib = Convert.ToDouble(tax_contribTxtbox.Text);
            sss_loan = Convert.ToDouble(sssloantxtbox.Text);
            pagibig_loan = Convert.ToDouble(pagibigloantxtbox.Text);
            salary_loan = Convert.ToDouble(salaryloantxtbox.Text);
            FSD = Convert.ToDouble(facultydeposittxtbox.Text);
            FSL = Convert.ToDouble(facultysavingstxtbox.Text);
            other_loan = Convert.ToDouble(other_loanTxtbox.Text);
            // formula
            total_contrib = sss_contrib + pagibig_contrib + phil_contrib + tax_contrib;
            total_loan = sss_loan + salary_loan + pagibig_loan + FSL + FSD + other_loan;
            total_deductions = total_contrib + total_loan;
            // convert back into string
            total_deducTxtbox.Text = total_deductions.ToString("n");
            net_income = gross_income - total_deductions;
            netincometxtbox.Text = net_income.ToString("n");
        }

        private void UserAccount_Database_Load(object sender, EventArgs e)
        {
            // Disable calculated fields
            income_basicintxtbox.Enabled = false;
            income_HonorariumTxtbox.Enabled = false;
            Income_otherTxtbox.Enabled = false;
            netincometxtbox.Enabled = false;
            grossIncometxtbox.Enabled = false;
            total_deducTxtbox.Enabled = false;

            // Set default values
            ssscontritxtbox.Text = "0.00";
            pagibigcontrittxtbox.Text = "0.00";
            philhealthcontritxtbox.Text = "0.00";
            tax_contribTxtbox.Text = "0.00";
            sssloantxtbox.Text = "0.00";
            pagibigloantxtbox.Text = "0.00";
            facultydeposittxtbox.Text = "0.00";
            facultysavingstxtbox.Text = "0.00";
            salaryloantxtbox.Text = "0.00";
            other_loanTxtbox.Text = "0.00";

            other_loanCombo.Items.Add("Other 1");
            other_loanCombo.Items.Add("Other 2");
            other_loanCombo.Items.Add("Other 3");

            picpathtxtbox.Hide();
        }

        private void cleartextboxes()
        {
            employeenumtxtbox.Clear(); fnametxtbox.Clear();
            Mnametxtbox.Clear();  Snametxtbox.Clear();
            civilstattxtbox.Clear(); designationtxtbox.Clear();
            numberDependentsTxtbox.Clear(); employeestatustxtbox.Clear();
            departmentTxtbox.Clear(); income_basicintxtbox.Clear();
            no_hours_basicIntxtbox.Clear(); rate_hour_basicIntxtbox.Clear();
            income_HonorariumTxtbox.Clear(); no_hoursHonotxtbox.Clear();
            rate_hourHonorTxtbox.Clear(); Income_otherTxtbox.Clear();
            no_HoursOtherTxtbox.Clear(); ratehour_OtherTxtbox.Clear();
            netincometxtbox.Clear(); grossIncometxtbox.Clear();
            ssscontritxtbox.Clear(); pagibigcontrittxtbox.Clear();
            philhealthcontritxtbox.Clear(); tax_contribTxtbox.Clear();
            sssloantxtbox.Clear(); pagibigloantxtbox.Clear();
            facultydeposittxtbox.Clear(); facultysavingstxtbox.Clear();
            other_loanCombo.Text = "Select other loan";
            total_deducTxtbox.Clear(); salaryloantxtbox.Clear();
            other_loanTxtbox.Clear(); Payslip_viewlistbox.Items.Clear();
            pictureBox1.Image = Image.FromFile("C:\\Users\\jhovany\\OneDrive\\Pictures\\question.png");


        }
    }
}
