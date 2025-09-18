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
    public partial class Lesson5_Activity : Form
    {
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
            income_tax = 0.00,
            sss_loan = 0.00,
            pagibig_loan = 0.00,
            FSD = 0.00,
            FSL = 0.00,
            salary_loan = 0.00,
            other_loan = 0.00,
            total_deductions = 0.00,
            net_income = 0.00,
            wisp = Convert.ToDouble("750"),
            deductions = 0.00,
            
            pagibig = Convert.ToDouble("200");



        private void savebttn_Click(object sender, EventArgs e)
        {
           
            string name = fnametxtbox.Text + " " + Mnametxtbox.Text + " " + Snametxtbox.Text;        
            Lesson5_SaveForm sf = new Lesson5_SaveForm();
            sf.employee_codesave.Text = employeenumtxtbox.Text;
            sf.employee_namesave.Text = name;
            sf.department_save.Text = departmenttxtbox.Text;
            sf.companytxtbox.Text = "Lyceum of the Philippines University Cavite";
            sf.cutoff_save.Text = paydatetxtbox.Text;
            sf.payperiod_save.Text = paydatetxtbox.Text;
            sf.withholdingtax_txtbox.Text = incometaxtxtbox.Text;
            sf.sss_contribSave.Text = ssscontritxtbox.Text;
            sf.PhilhealthSave.Text = philhealthcontritxtbox.Text;
            sf.hdmf_contribsave.Text = pagibigcontrittxtbox.Text;
            sf.sss_WIspsave.Text = wisp.ToString("n");
            sf.deductionsSAve.Text = deductions.ToString("n");
            sf.dayhrs_basic.Text = basic_income.ToString("n");
            sf.dayhrs_over.Text = other_income.ToString("n");
            sf.dayshrs_honor.Text = hono_income.ToString("n");
            sf.dayshrs_sub.Text = "0.00";
            sf.dayshrs_tardy.Text = "0.00";



            sf.textBox1.Text = gross_income.ToString("n");









            sf.Show();

        }

        private void newbttn_Click(object sender, EventArgs e)
        {
            foreach (Control textbox in this.Controls)
            {
                if (textbox is TextBox)
                {
                    ((TextBox)textbox).Clear();
                }
            }
        }

        private void netincomebttn_Click(object sender, EventArgs e)
        {
            //  CONVERT
            sss_loan = Convert.ToDouble(sssloantxtbox.Text);
            pagibig_loan = Convert.ToDouble(pagibigloantxtbox.Text);
            FSD = Convert.ToDouble(facultydeposittxtbox.Text);
            FSL = Convert.ToDouble(facultysavingstxtbox.Text);
            salary_loan = Convert.ToDouble(salaryloantxtbox.Text);
            other_loan = Convert.ToDouble(otherloantxtbox.Text);

            // COMPUTATION FOR TOTAL DEDUCTIONS AND NET INCOME
            total_deductions = sss_loan + pagibig_loan + FSD + FSL + salary_loan + other_loan + sss_contrib + phil_contrib + pagibig + income_tax;
            net_income = gross_income - total_deductions;

            //DISPLAY
            totaldeductionstxtbox.Text = total_deductions.ToString("n");
            netincometxtbox.Text = net_income.ToString("n");

        }

        public Lesson5_Activity()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void Lesson5_Activity_Load(object sender, EventArgs e)
        {
            income_basicintxtbox.Enabled = false;
            incomeHonorariumtxtbox.Enabled = false;
            IncomeOtherstxtbox.Enabled = false;
            grossIncometxtbox.Enabled = false;
            ssscontritxtbox.Enabled = false;
            philhealthcontritxtbox.Enabled = false;
            pagibigcontrittxtbox.Enabled=false;
            incometaxtxtbox.Enabled=false;
            totaldeductionstxtbox.Enabled=false;
            netincometxtbox.Enabled=false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void grossincomebutton_Click(object sender, EventArgs e)
        {

            // COMPUTATION FOR BASIC INCOME, HONORARIUM, AND OTHER INCOME
            rate_basic = Convert.ToDouble(rate_hour_basicIntxtbox.Text);
            no_hours_basic = Convert.ToDouble(no_hours_basicIntxtbox.Text);           
            rate_hono = Convert.ToDouble(ratehourHonorariumtxtbox.Text);
            no_hours_hono = Convert.ToDouble(noHoursHonorariumtxtbox.Text);           
            rate_other = Convert.ToDouble(ratehourOthertxtbox.Text);
            no_hours_others = Convert.ToDouble(nohoursOthertxtbox.Text);          
            basic_income = rate_basic * no_hours_basic;
            hono_income = rate_hono * no_hours_hono;
            other_income = rate_other * no_hours_others;


            // GROSS INCOME COMPUTATION
            gross_income = basic_income + hono_income + other_income;


            //COMPUTATION FOR PHILHEALTH CONTRIBUTIONS
            phil_contrib = gross_income * 0.05;
            
            //COMPUTATION FOR SSS CONTRIBUTIONS
            if (gross_income < 14750)
                sss_contrib = (gross_income * 0.15) + 10;
            else
                sss_contrib = (gross_income * 0.15) + 30;

            //COMPUTATIOM FOR INCOME TAX CONTRIBUTIONS
            if (gross_income <= 250000)
                income_tax = 0.00;
            else if (gross_income > 250000 && gross_income <= 400000)
                income_tax = (gross_income - 250000) * 0.15;
            else if (gross_income > 400000 && gross_income <= 800000)
                income_tax = 22500 + ((gross_income - 400000) * 0.20);
            else if (gross_income > 800000 && gross_income <= 2000000)
                income_tax = 102500 + ((gross_income - 800000) * 0.25);
            else if (gross_income > 2000000 && gross_income <= 8000000)
                income_tax = 402500 + ((gross_income - 2000000) * 0.30);
            else if (gross_income > 8000000)
                income_tax = 2202500 + ((gross_income - 8000000) * 0.35);



                //DISPLAYING RESULTS
            grossIncometxtbox.Text = gross_income.ToString("n");
            income_basicintxtbox.Text = basic_income.ToString("n");
            incomeHonorariumtxtbox.Text = hono_income.ToString("n");
            IncomeOtherstxtbox.Text = other_income.ToString("n");
            ssscontritxtbox.Text = sss_contrib.ToString("n");
            philhealthcontritxtbox.Text = phil_contrib.ToString("n");
            pagibigcontrittxtbox.Text = pagibig.ToString("n");
            incometaxtxtbox.Text = income_tax.ToString("n");


            // COMPUTATION FOR DEDUCTION IN THE SAVE FORM
            deductions = income_tax + sss_contrib + phil_contrib + pagibig + wisp;
            



        }
    }
}
