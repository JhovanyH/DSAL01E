using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LESSON1
{
    public partial class Lesson5_Activity : Form
    {
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
            income_tax = 0.00,
            sss_loan = 0.00,
            pagibig_loan = 0.00,
            FSD = 0.00,
            FSL = 0.00,
            salary_loan = 0.00,
            other_loan = 0.00,
            total_deductions = 0.00,
            net_income = 0.00,
            wisp = 750,
            deductions = 0.00,
            netpay = 0.00,
            taxable_income = 0.00,
            pagibig = 200;

        private void netincometxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void savebttn_Click(object sender, EventArgs e)
        {
            //CALL FROM ANOTHER DIMENSION
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
            sf.textBox2.Text = gross_income.ToString("n");
            sf.textBox19.Text = sf.deductionsSAve.Text;
            sf.textBox20.Text = netpay.ToString("n");
            sf.textBox3.Text = other_income.ToString("n");





            //DISPLAY

            sf.textBox1.Text = gross_income.ToString("n");









            sf.Show();

        }

        private void newbttn_Click(object sender, EventArgs e)
        {
            //FOR EASY AND INSTANT CLEARING
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
            //DISABLING THE TEXTBOXES
            income_basicintxtbox.Enabled = false;
            incomeHonorariumtxtbox.Enabled = false;
            IncomeOtherstxtbox.Enabled = false;
            grossIncometxtbox.Enabled = false;
            ssscontritxtbox.Enabled = false;
            philhealthcontritxtbox.Enabled = false;
            pagibigcontrittxtbox.Enabled = false;
            incometaxtxtbox.Enabled = false;
            totaldeductionstxtbox.Enabled = false;
            netincometxtbox.Enabled = false;
            

            //scaling to the highest level
            baseSize = this.Size;

            // maximize the window
            this.WindowState = FormWindowState.Maximized;

            // scale once to fit the screen
            ScaleToScreen();
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
            phil_contrib = gross_income * 0.05/2;

            //COMPUTATION FOR SSS CONTRIBUTIONS
            if (gross_income < 5250)
            {
                sss_contrib = 250.00 / 2;
            }

            else if (gross_income > 5250 && gross_income <= 5749.99)
            {
                sss_contrib = 275.00 / 2;
            }
            else if (gross_income > 5749.99 && gross_income <= 6299.99)
            {
                sss_contrib = 300.00 / 2;
            }
            else if (gross_income > 62499.99 && gross_income <= 6749.99)
            {
                sss_contrib = 325.00 / 2;
            }
            else if (gross_income > 6749.99 && gross_income <= 7249.99)
            {
                sss_contrib = 350.00 / 2;
            }
            else if (gross_income > 7249.99 && gross_income <= 7749.99)
            {
                sss_contrib = 375.00 / 2;
            }
            else if (gross_income > 7749.99 && gross_income <= 8249.99)
            {
                sss_contrib = 400.00 / 2;
            }
            else if (gross_income > 8249.99 && gross_income <= 8749.99)
            {
                sss_contrib = 425.00 / 2;
            }
            else if (gross_income > 8749.99 && gross_income <= 9249.99)
            {
                sss_contrib = 450.00 / 2;
            }
            else if (gross_income > 9249.99 && gross_income <= 9749.99)
            {
                sss_contrib = 475.00 / 2;
            }
            else if (gross_income > 9749.99 && gross_income <= 10499.99)
            {
                sss_contrib = 500.00 / 2;
            }
            else if (gross_income > 102499.99 && gross_income <= 10749.99)
            {
                sss_contrib = 525.00 / 2;
            }
            else if (gross_income > 10749.99 && gross_income <= 11249.99)
            {
                sss_contrib = 550.00 / 2;
            }
            else if (gross_income > 11249.99 && gross_income <= 11749.99)
            {
                sss_contrib = 575.00 / 2;
            }
            else if (gross_income > 11749.99 && gross_income <= 12249.99)
            {
                sss_contrib = 600.00 / 2;
            }
            else if (gross_income > 12249.99 && gross_income <= 12749.99)
            {
                sss_contrib = 625.00 / 2;
            }
            else if (gross_income > 12749.99 && gross_income <= 13249.99)
            {
                sss_contrib = 650.00 / 2;
            }

            else if (gross_income > 13249.99 && gross_income <= 13749.99)
            {
                sss_contrib = 675.00 / 2;
            }
            else if (gross_income > 13749.99 && gross_income <= 14499.99)
            {
                sss_contrib = 700.00 / 2;
            }
            else if (gross_income > 142499.99 && gross_income <= 14749.99)
            {
                sss_contrib = 725.00 / 2;
            }
            else if (gross_income > 14749.99 && gross_income <= 15249.99)
            {
                sss_contrib = 750.00 / 2;
            }
            else if (gross_income > 15249.99 && gross_income <= 15749.99)
            {
                sss_contrib = 775.00 / 2;
            }
            else if (gross_income > 15749.99 && gross_income <= 16249.99)
            {
                sss_contrib = 800.00 / 2;
            }
            else if (gross_income > 16249.99 && gross_income <= 16749.99)
            {
                sss_contrib = 825.00 / 2;
            }
            else if (gross_income > 16749.99 && gross_income <= 17249.99)
            {
                sss_contrib = 850.00 / 2;
            }
            else if (gross_income > 17249.99 && gross_income <= 17749.99)
            {
                sss_contrib = 875.00 / 2;
            }
            else if (gross_income > 17749.99 && gross_income <= 18499.99)
            {
                sss_contrib = 900.00 / 2;
            }
            else if (gross_income > 182499.99 && gross_income <= 18749.99)
            {
                sss_contrib = 925.00 / 2;
            }
            else if (gross_income > 18749.99 && gross_income <= 19249.99)
            {
                sss_contrib = 950.00 / 2;
            }
            else if (gross_income > 19249.99 && gross_income <= 19749.99)
            {
                sss_contrib = 975.00 / 2;
            }
            else if (gross_income > 19749.99 && gross_income <= 20249.99)
            {
                sss_contrib = 1000.00 / 2;
            }
            else if (gross_income > 20249.99 && gross_income <= 20749.99)
            {
                sss_contrib = 1025.00 / 2;
            }
            else if (gross_income > 20749.99 && gross_income <= 21249.99)
            {
                sss_contrib = 1050.00 / 2;
            }
            else if (gross_income > 21249.99 && gross_income <= 21749.99)
            {
                sss_contrib = 1075.00 / 2;
            }
            else if (gross_income > 21749.99 && gross_income <= 22249.99)
            {
                sss_contrib = 1100.00 / 2;
            }
            else if (gross_income > 22249.99 && gross_income <= 22749.99)
            {
                sss_contrib = 1125.00 / 2;
            }
            else if (gross_income > 22749.99 && gross_income <= 23249.99)
            {
                sss_contrib = 1150.00 / 2;
            }
            else if (gross_income > 23249.99 && gross_income <= 23749.99)
            {
                sss_contrib = 1175.00 / 2;
            }
            else if (gross_income > 23749.99 && gross_income <= 24249.99)
            {
                sss_contrib = 1200.00 / 2;
            }
            else if (gross_income > 24249.99 && gross_income <= 24749.99)
            {
                sss_contrib = 1225.00 / 2;
            }
            else if (gross_income > 24749.99 && gross_income <= 25249.99)
            {
                sss_contrib = 1250.00 / 2;
            }
            else if (gross_income > 25249.99 && gross_income <= 25749.99)
            {
                sss_contrib = 1275.00 / 2;
            }
            else if (gross_income > 25749.99 && gross_income <= 26249.99)
            {
                sss_contrib = 1300.00 / 2;
            }
            else if (gross_income > 26249.99 && gross_income <= 26749.99)
            {
                sss_contrib = 1325.00 / 2;
            }
            else if (gross_income > 26749.99 && gross_income <= 27249.99)
            {
                sss_contrib = 1350.00 / 2;
            }
            else if (gross_income > 27249.99 && gross_income <= 27749.99)
            {
                sss_contrib = 1375.00 / 2;
            }
            else if (gross_income > 27749.99 && gross_income <= 28249.99)
            {
                sss_contrib = 1400.00 / 2;
            }
            else if (gross_income > 28249.99 && gross_income <= 28749.99)
            {
                sss_contrib = 1425.00 / 2;
            }
            else if (gross_income > 28749.99 && gross_income <= 29249.99)
            {
                sss_contrib = 1450.00 / 2;
            }
            else if (gross_income > 29249.99 && gross_income <= 29749.99)
            {
                sss_contrib = 1475.00 / 2;
            }
            else if (gross_income > 29749.99 && gross_income <= 30249.99)
            {
                sss_contrib = 1500.00 / 2;
            }
            else if (gross_income > 30249.99 && gross_income <= 30749.99)
            {
                sss_contrib = 1525.00 / 2;
            }
            else if (gross_income > 30749.99 && gross_income <= 31249.99)
            {
                sss_contrib = 1550.00 / 2;
            }
            else if (gross_income > 31249.99 && gross_income <= 31749.99)
            {
                sss_contrib = 1575.00 / 2;
            }
            else if (gross_income > 31749.99 && gross_income <= 32249.99)
            {
                sss_contrib = 1600.00 / 2;
            }
            else if (gross_income > 32249.99 && gross_income <= 32749.99)
            {
                sss_contrib = 1625.00 / 2;
            }
            else if (gross_income > 32749.99 && gross_income <= 33249.99)
            {
                sss_contrib = 1650.00 / 2;
            }
            else if (gross_income > 33249.99 && gross_income <= 33749.99)
            {
                sss_contrib = 1675.00 / 2;
            }
            else if (gross_income > 33749.99 && gross_income <= 34249.99)
            {
                sss_contrib = 1700.00 / 2;
            }
            else if (gross_income > 34249.99 && gross_income <= 34749.99)
            {
                sss_contrib = 1725.00 / 2;
            }
            else
            {
                sss_contrib = 1750.00 / 2;  // For incomes above 34,750
            }




            taxable_income = gross_income - sss_contrib - phil_contrib - pagibig;


            //COMPUTATIOM FOR INCOME TAX CONTRIBUTIONS // CONVERT IT INTO  MONTHLY
            if (taxable_income <= 20833.33)
                income_tax = 0.00;
            else if (taxable_income > 20833.33 && taxable_income <= 33333.33)
                income_tax = (taxable_income - 20833.33) * 0.15;
            else if (taxable_income > 33333.33 && taxable_income <= 66666.67)
                income_tax = 1875 + ((gross_income - 33333.33) * 0.20);
            else if (taxable_income > 66666.67 && taxable_income <= 166666.67)
                income_tax = 8541.70 + ((taxable_income - 66666.67) * 0.25);
            else if (taxable_income > 166666.67 && taxable_income <= 666666.67)
                income_tax = 33541.70 + ((taxable_income - 166666.67) * 0.30);
            else if (taxable_income > 666666.67)
                income_tax = 183541.70 + ((taxable_income - 666666.67) * 0.35);


            //SEMI MONTHLY
            income_tax = income_tax / 2;



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

            netpay = gross_income - deductions;


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



