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
    public partial class PAYROL_DATABASE : Form
    {
        payrol_dbconnection pd = new payrol_dbconnection();
        Payroll_Variables_Database pv = new Payroll_Variables_Database();
        private string picpath;
        private OpenFileDialog openFileDialog1;

        private Size baseSize;

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

        private void new_button_Click(object sender, EventArgs e)
        {
            // This clears all fields so you can start over
            cleartextboxes();

            // Put the cursor back in the Employee ID box
            employeenumtxtbox.Focus();
        }

        private void Search_Edit_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(paydateCombo.Text))
                {
                    MessageBox.Show("Please enter a Pay Date to load payroll data.");
                    return;
                }

                pd.payrol_sql = "SELECT pos_empRegTbl.emp_id, emp_fname, " +
                   "emp_mname, emp_surname, emp_status, position, emp_no_of_dependents, " +
                   "emp_work_status, emp_department, picpath, basic_rate_hr, " +
                   "basic_no_of_hrs_cutOff, basic_income_per_cutOff, honorarium_rate_hr, " +
                   "honorarium_no_of_hrs_cutOff, honorarium_income_per_cutOff, " +
                   "other_rate_hr, other_no_of_hrs_cutOff, other_income_per_cutOff, " +
                   "sss_contrib, philhealth_contrib, pagibig_contrib, tax_contrib, " +
                   "sss_loan, pagibig_loan, fac_savings_deposit, fac_savings_loan, " +
                   "salary_loan, other_loans, total_deductions, gross_income, " +
                   "net_income, pay_date FROM pos_empRegTbl INNER JOIN payrolTbl " +
                   "ON pos_empRegTbl.emp_id = payrolTbl.emp_id WHERE " +
                   "payrolTbl.emp_id = '" + employeenumtxtbox.Text + "' AND " +
                   "payrolTbl.pay_date = '" + paydateCombo.Text + "'";

                pd.payrol_cmd();
                pd.payrol_sqladapterSelect();
                pd.payrol_sqldatasetSELECT();

                if (pd.payrol_sql_dataset.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("No payroll record found. You can create a new one by clicking Save.");
                    return;
                }

                // Load payroll data
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

                MessageBox.Show("Payroll data loaded successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading payroll data: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files (*.gif, *.jpg, *.png, *.bmp, *.jpeg)|*.gif;*.jpg;*.png;*.bmp;*.jpeg";
            openFileDialog1.Title = "Select an Employee Picture";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Get the selected file path
                    picpath = openFileDialog1.FileName;

                    // Display the picture in the picture box
                    pictureBox1.Image = System.Drawing.Image.FromFile(picpath);

                    // Store the path in a hidden textbox (you might have picpathtxtbox for this)
                    picpathtxtbox.Text = picpath;

                    MessageBox.Show("Picture selected successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading picture: " + ex.Message);
                }
            }
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(employeenumtxtbox.Text))
                {
                    MessageBox.Show("Please enter an Employee ID");
                    return;
                }

                pd.payrol_sql = "SELECT emp_id, emp_fname, emp_mname, emp_surname, emp_status, " +
                   "position, emp_no_of_dependents, emp_work_status, emp_department, picpath " +
                   "FROM pos_empRegTbl WHERE emp_id = '" + employeenumtxtbox.Text + "'";

                pd.payrol_cmd();
                pd.payrol_sqladapterSelect();
                pd.payrol_sqldatasetSELECT();

                if (pd.payrol_sql_dataset.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Employee not found!");
                    return;
                }

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

                MessageBox.Show("Employee found!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching employee: " + ex.Message);
            }            
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(employeenumtxtbox.Text))
                {
                    MessageBox.Show("Please search for an employee first");
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure you want to delete this payroll record?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                    return;

                pd.payrol_sql = "DELETE FROM payrolTbl WHERE payrolTbl.emp_id = '" + employeenumtxtbox.Text + "'";
                pd.payrol_cmd();
                pd.payrol_sqladapterDelete();
                MessageBox.Show("Payroll record deleted successfully!");
                cleartextboxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting payroll record: " + ex.Message);
            }
        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            try
            {
                pd.payrol_sql =
                    "UPDATE pos_empRegTbl SET picpath = '" + picpathtxtbox.Text + "' " +
                    "WHERE emp_id = '" + employeenumtxtbox.Text + "'";

                pd.payrol_cmd();
                pd.payrol_sqladapterUpdate();

                pd.payrol_sql =
                    "UPDATE payrolTbl SET " +
                    "basic_rate_hr = '" + rate_hour_basicIntxtbox.Text + "', " +
                    "basic_no_of_hrs_cutOff = '" + no_hours_basicIntxtbox.Text + "', " +
                    "basic_income_per_cutOff = '" + income_basicintxtbox.Text + "', " +
                    "honorarium_rate_hr = '" + rate_hourHonorTxtbox.Text + "', " +
                    "honorarium_no_of_hrs_cutOff = '" + no_hoursHonotxtbox.Text + "', " +
                    "honorarium_income_per_cutOff = '" + income_HonorariumTxtbox.Text + "', " +
                    "other_rate_hr = '" + ratehour_OtherTxtbox.Text + "', " +
                    "other_no_of_hrs_cutOff = '" + no_HoursOtherTxtbox.Text + "', " +
                    "other_income_per_cutOff = '" + Income_otherTxtbox.Text + "', " +
                    "sss_contrib = '" + ssscontritxtbox.Text + "', " +
                    "philhealth_contrib = '" + philhealthcontritxtbox.Text + "', " +
                    "pagibig_contrib = '" + pagibigcontrittxtbox.Text + "', " +
                    "tax_contrib = '" + tax_contribTxtbox.Text + "', " +
                    "sss_loan = '" + sssloantxtbox.Text + "', " +
                    "pagibig_loan = '" + pagibigloantxtbox.Text + "', " +
                    "fac_savings_deposit = '" + facultydeposittxtbox.Text + "', " +
                    "fac_savings_loan = '" + facultysavingstxtbox.Text + "', " +
                    "salary_loan = '" + salaryloantxtbox.Text + "', " +
                    "other_loans = '" + other_loanTxtbox.Text + "', " +
                    "total_deductions = '" + total_deducTxtbox.Text + "', " +
                    "gross_income = '" + grossIncometxtbox.Text + "', " +
                    "net_income = '" + netincometxtbox.Text + "' " +
                    "WHERE emp_id = '" + employeenumtxtbox.Text + "' AND " +
                    "pay_date = '" + paydateCombo.Text + "'";

                pd.payrol_cmd();
                pd.payrol_sqladapterUpdate();
                MessageBox.Show("Payroll and Picture updated successfully!");
                cleartextboxes();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating payroll: " + ex.Message);
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            try
            {
                // --- VALIDATION START ---

                // 1. Check if ID is empty
                if (string.IsNullOrEmpty(employeenumtxtbox.Text))
                {
                    MessageBox.Show("Please enter an Employee ID.");
                    return;
                }

                // 2. Check if ID is a NUMBER (Fixes your "letter" problem)
                int parsedId;
                if (!int.TryParse(employeenumtxtbox.Text, out parsedId))
                {
                    MessageBox.Show("Employee ID must be a number!");
                    return; // Stops the code here
                }

                // 3. Check if an employee was actually found/loaded
                // (Prevents saving if you typed a number but didn't click Search)
                if (string.IsNullOrEmpty(fnametxtbox.Text))
                {
                    MessageBox.Show("Please SEARCH for a valid employee record first.");
                    return;
                }

                // 4. Check Pay Date
                if (string.IsNullOrEmpty(paydateCombo.Text))
                {
                    MessageBox.Show("Please enter a Pay Date.");
                    return;
                }

                // --- VALIDATION END ---


                // PROCEED TO SAVE
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
                    "', '" + employeenumtxtbox.Text + // This is now safe because we checked it above
                    "', '" + paydateCombo.Text + "')";

                pd.payrol_cmd();
                pd.payrol_sqladapterInsert();
                MessageBox.Show("Payroll saved successfully!");
                cleartextboxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving payroll: " + ex.Message);
            }
        }

        private void updatebttn_Click(object sender, EventArgs e)
        {
            //codes for calling the other form connected to the current form
            PAYROL_DATABASE_PRINTFORM pf = new PAYROL_DATABASE_PRINTFORM();
            //codes to display the contents of the listbox from other form to the current form.
            pf.Display_ListBox.Items.AddRange(this.Payslip_viewlistbox.Items);
            pf.Show();
        }

           

        private void no_HoursOtherTxtbox_TextChanged(object sender, EventArgs e)
        {           
            if (Double.TryParse(ratehour_OtherTxtbox.Text, out rate_other) &&
                Double.TryParse(no_HoursOtherTxtbox.Text, out no_hours_others))
            {
                other_income = rate_other * no_hours_others;
                gross_income = basic_income + hono_income + other_income;
                Income_otherTxtbox.Text = other_income.ToString("n");
                grossIncometxtbox.Text = gross_income.ToString("n");

            }
            else
            {
                MessageBox.Show("Please enter valid numbers for hours and rate.");
            }       

        }


        private void no_hoursHonotxtbox_TextChanged(object sender, EventArgs e)
        {
        
            if (Double.TryParse(rate_hourHonorTxtbox.Text, out rate_hono) &&
                Double.TryParse(no_hoursHonotxtbox.Text, out no_hours_hono))
            {
                hono_income = rate_hono * no_hours_hono;
                income_HonorariumTxtbox.Text = hono_income.ToString("n");
            }
            else
            {
                MessageBox.Show("Please enter valid numbers for hours and rate");
            }
        }

 
        private void no_hours_basicIntxtbox_TextChanged(object sender, EventArgs e)
        {
            

            if (Double.TryParse(no_hours_basicIntxtbox.Text, out no_hours_basic) &&
                Double.TryParse(rate_hour_basicIntxtbox.Text, out rate_basic))
            {
                basic_income = no_hours_basic * rate_basic;
                income_basicintxtbox.Text = basic_income.ToString("n");
            }
            else
            {
                MessageBox.Show("Please enter valid numbers for hours and rate.");
            }

        }



        private void newbttn_Click(object sender, EventArgs e)
        {
            //payslip view list box
            Payslip_viewlistbox.Items.Add("Employee Number:".PadRight(30) + employeenumtxtbox.Text);
            Payslip_viewlistbox.Items.Add("Firstname:".PadRight(30) + fnametxtbox.Text);
            Payslip_viewlistbox.Items.Add("MiddleName:".PadRight(30) + Mnametxtbox.Text);
            Payslip_viewlistbox.Items.Add("Surname:".PadRight(30) + Snametxtbox.Text);
            Payslip_viewlistbox.Items.Add("Designation:".PadRight(30) + designationtxtbox.Text);
            Payslip_viewlistbox.Items.Add("Employee Status:".PadRight(30) + employeestatustxtbox.Text);
            Payslip_viewlistbox.Items.Add("DEpartment:".PadRight(30) + departmentTxtbox.Text);
            Payslip_viewlistbox.Items.Add("Pay Date:".PadRight(30) + paydateCombo.Text);
            Payslip_viewlistbox.Items.Add("_________________________________________________________________");

            Payslip_viewlistbox.Items.Add("BP Num. of Hrs.:".PadRight(30) + "P" +  no_hours_basicIntxtbox.Text);
            Payslip_viewlistbox.Items.Add("BP Rate / Hr.:".PadRight(30) + "P" +  rate_hour_basicIntxtbox.Text);
            Payslip_viewlistbox.Items.Add("Basic Pay Income:".PadRight(30) + "P" + income_basicintxtbox.Text);
            Payslip_viewlistbox.Items.Add("");
            Payslip_viewlistbox.Items.Add("HI Num. of Hrs.:".PadRight(30) + "P" +  no_hoursHonotxtbox.Text);
            Payslip_viewlistbox.Items.Add("HI Rate / Hr.:".PadRight(30) + "P" + rate_hourHonorTxtbox.Text);
            Payslip_viewlistbox.Items.Add("Honararium Income:".PadRight(30) + "P" + income_HonorariumTxtbox.Text);
            Payslip_viewlistbox.Items.Add("");
            Payslip_viewlistbox.Items.Add("OTI Num. of Hrs.:".PadRight(30) + "P" + no_HoursOtherTxtbox.Text);
            Payslip_viewlistbox.Items.Add("OTI Rate / Hr.:".PadRight(30) + "P" + ratehour_OtherTxtbox.Text);
            Payslip_viewlistbox.Items.Add("Other Income:".PadRight(30) + "P" + Income_otherTxtbox.Text);
            Payslip_viewlistbox.Items.Add("_________________________________________________________________");
            
            Payslip_viewlistbox.Items.Add("SSS Contribution:".PadRight(30) + "P" + ssscontritxtbox.Text);
            Payslip_viewlistbox.Items.Add("PhilHealth Contribution:".PadRight(30) + "P" + philhealthcontritxtbox.Text);
            Payslip_viewlistbox.Items.Add("Pagibig Contribution:".PadRight(30) +"P" + pagibigcontrittxtbox.Text);
            Payslip_viewlistbox.Items.Add("Tax Contribution:".PadRight(30) + "P" + tax_contribTxtbox.Text);
            Payslip_viewlistbox.Items.Add("SSS Loan:".PadRight(30) + "P" + sssloantxtbox.Text);
            Payslip_viewlistbox.Items.Add("Pagibig Loan:".PadRight(30) + "P" + pagibigloantxtbox.Text);
            Payslip_viewlistbox.Items.Add("Faculty Savings Deposit:".PadRight(30) + "P" + facultydeposittxtbox.Text);
            Payslip_viewlistbox.Items.Add("Faculty Savings Loan:".PadRight(30) + "P" + facultysavingstxtbox.Text);
            Payslip_viewlistbox.Items.Add("Salary Loan:".PadRight(30) + "P" + salaryloantxtbox.Text);
            Payslip_viewlistbox.Items.Add("Other Loan:".PadRight(30) + "P" + other_loanTxtbox.Text);
            Payslip_viewlistbox.Items.Add("_________________________________________________________________");

            Payslip_viewlistbox.Items.Add("Total Deduction:".PadRight(30) + "P" + total_deducTxtbox.Text);
            Payslip_viewlistbox.Items.Add("Gross Income:".PadRight(30) + "P" + grossIncometxtbox.Text);
            Payslip_viewlistbox.Items.Add("Net Income:".PadRight(30) + "P" + netincometxtbox.Text);




        }

        private void grossincomebutton_Click(object sender, EventArgs e)
        {
            try
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

                MessageBox.Show("Deductions calculated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating deductions: " + ex.Message);
            }
        }


        public PAYROL_DATABASE()
        {
            pd.payrol_connString();
            InitializeComponent();
            openFileDialog1 = new OpenFileDialog();

        }



        private void UserAccount_Load(object sender, EventArgs e)
        {
            income_basicintxtbox.Enabled = false;
            income_HonorariumTxtbox.Enabled = false;
            Income_otherTxtbox.Enabled = false;
            netincometxtbox.Enabled = false;
            grossIncometxtbox.Enabled = false;
            total_deducTxtbox.Enabled = false;
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

            // scaling to the highest level
            baseSize = this.Size;

            // maximize the window
            this.WindowState = FormWindowState.Maximized;

            // scale once to fit the screen
            ScaleToScreen();

        }
        private void cleartextboxes()
        {
            employeenumtxtbox.Clear(); fnametxtbox.Clear();
            Mnametxtbox.Clear(); Snametxtbox.Clear();
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

        private void ScaleToScreen()
        {
            float scaleX = (float)Screen.PrimaryScreen.Bounds.Width / baseSize.Width;
            float scaleY = (float)Screen.PrimaryScreen.Bounds.Height / baseSize.Height;

            // Scale all controls
            this.Scale(new SizeF(scaleX, scaleY));

            // Scale fonts too
            foreach (Control ctrl in this.Controls)
            {
                ctrl.Font = new Font(ctrl.Font.FontFamily, ctrl.Font.Size * Math.Min(scaleX, scaleY));
            }
        }
    }
}
