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
    public partial class UserAccount : Form
    {
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

        private void fnametxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void grossIncometxtbox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Income_otherTxtbox_TextChanged(object sender, EventArgs e)
        {
          
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

        private void ratehour_OtherTxtbox_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void income_HonorariumTxtbox_TextChanged(object sender, EventArgs e)
        {
            
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

        private void rate_hourHonorTxtbox_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void income_basicintxtbox_TextChanged(object sender, EventArgs e)
        {
           
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

        private void rate_hour_basicIntxtbox_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void newbttn_Click(object sender, EventArgs e)
        {
            Payslip_viewlistbox.Items.Add("Employee Number:".PadRight(30) + employeenumtxtbox.Text);
            Payslip_viewlistbox.Items.Add("Firstname:".PadRight(30) + fnametxtbox.Text);
            Payslip_viewlistbox.Items.Add("MiddleName:".PadRight(30) + Mnametxtbox.Text);



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

        private void pagibigloantxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        public UserAccount()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

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



        }
    }
}
