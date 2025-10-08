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
            // this.WindowState = FormWindowState.Maximized;

            // scale once to fit the screen
           // ScaleToScreen();
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
            ComputeIncomes();

            //COMPUTATION FOR PHILHEALTH CONTRIBUTIONS
            phil_contrib = ComputePhilHealth(gross_income);

            //COMPUTATION FOR SSS CONTRIBUTIONS
            sss_contrib = ComputeSSS(gross_income);



            taxable_income = gross_income - sss_contrib - phil_contrib - pagibig;
            income_tax = ComputeTax(taxable_income);


            ////COMPUTATIOM FOR INCOME TAX CONTRIBUTIONS // CONVERT IT INTO  MONTHLY
            ////if (taxable_income <= 20833.33)
            //income_tax = 0.00;
            //else if (taxable_income > 20833.33 && taxable_income <= 33333.33)
            //    income_tax = (taxable_income - 20833.33) * 0.15;
            //else if (taxable_income > 33333.33 && taxable_income <= 66666.67)
            //    income_tax = 1875 + ((gross_income - 33333.33) * 0.20);
            //else if (taxable_income > 66666.67 && taxable_income <= 166666.67)
            //    income_tax = 8541.70 + ((taxable_income - 66666.67) * 0.25);
            //else if (taxable_income > 166666.67 && taxable_income <= 666666.67)
            //    income_tax = 33541.70 + ((taxable_income - 166666.67) * 0.30);
            //else if (taxable_income > 666666.67)
            //    income_tax = 183541.70 + ((taxable_income - 666666.67) * 0.35);


            // COMPUTATION FOR DEDUCTION IN THE SAVE FORM
            deductions = income_tax + sss_contrib + phil_contrib + pagibig + wisp;

            netpay = gross_income - deductions;

            //DISPLAYING RESULTS
            DisplayResults();

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
        private double ComputeSSS(double gross)
        {
            double[,] sssTable = {
        { 0, 5249.99, 250 },
        { 5250, 5749.99, 275 },
        { 5750, 6299.99, 300 },
        { 6300, 6749.99, 325 },
        { 6750, 7249.99, 350 },
        { 7250, 7749.99, 375 },
        { 7750, 8249.99, 400 },
        { 8250, 8749.99, 425 },
        { 8750, 9249.99, 450 },
        { 9250, 9749.99, 475 },
        { 9750, 10249.99, 500 },
        { 10250, 10749.99, 525 },
        { 10750, 11249.99, 550 },
        { 11250, 11749.99, 575 },
        { 11750, 12249.99, 600 },
        { 12250, 12749.99, 625 },
        { 12750, 13249.99, 650 },
        { 13250, 13749.99, 675 },
        { 13750, 14249.99, 700 },
        { 14250, 14749.99, 725 },
        { 14750, 15249.99, 750 },
        { 15250, 15749.99, 775 },
        { 15750, 16249.99, 800 },
        { 16250, 16749.99, 825 },
        { 16750, 17249.99, 850 },
        { 17250, 17749.99, 875 },
        { 17750, 18249.99, 900 },
        { 18250, 18749.99, 925 },
        { 18750, 19249.99, 950 },
        { 19250, 19749.99, 975 },
        { 19750, 20249.99, 1000 },
        { 20250, 20749.99, 1025 },
        { 20750, 21249.99, 1050 },
        { 21250, 21749.99, 1075 },
        { 21750, 22249.99, 1100 },
        { 22250, 22749.99, 1125 },
        { 22750, 23249.99, 1150 },
        { 23250, 23749.99, 1175 },
        { 23750, 24249.99, 1200 },
        { 24250, 24749.99, 1225 },
        { 24750, 25249.99, 1250 },
        { 25250, 25749.99, 1275 },
        { 25750, 26249.99, 1300 },
        { 26250, 26749.99, 1325 },
        { 26750, 27249.99, 1350 },
        { 27250, 27749.99, 1375 },
        { 27750, 28249.99, 1400 },
        { 28250, 28749.99, 1425 },
        { 28750, 29249.99, 1450 },
        { 29250, 29749.99, 1475 },
        { 29750, 30249.99, 1500 },
        { 30250, 30749.99, 1525 },
        { 30750, 31249.99, 1550 },
        { 31250, 31749.99, 1575 },
        { 31750, 32249.99, 1600 },
        { 32250, 32749.99, 1625 },
        { 32750, 33249.99, 1650 },
        { 33250, 33749.99, 1675 },
        { 33750, 34249.99, 1700 },
        { 34250, 34749.99, 1725 },
        { 34750, double.MaxValue, 1750 }
    };

            for (int i = 0; i < sssTable.GetLength(0); i++)
            {
                if (gross >= sssTable[i, 0] && gross <= sssTable[i, 1])
                {
                    return sssTable[i, 2] / 2;
                }
            }

            return 1750 / 2; // default highest
        }
        private double ComputePhilHealth(double gross)
        {
            return (gross * 0.05) / 2;
        }
        private double ComputeTax(double taxable)
        {
            double tax = 0.00;
            if (taxable <= 20833.33)
                tax = 0.00;
            else if (taxable <= 33333.33)
                tax = (taxable - 20833.33) * 0.15;
            else if (taxable <= 66666.67)
                tax = 1875 + ((taxable - 33333.33) * 0.20);
            else if (taxable <= 166666.67)
                tax = 8541.70 + ((taxable - 66666.67) * 0.25);
            else if (taxable <= 666666.67)
                tax = 33541.70 + ((taxable - 166666.67) * 0.30);
            else
                tax = 183541.70 + ((taxable - 666666.67) * 0.35);

            return tax / 2; // semi-monthly
        }
        private void ComputeIncomes()
        {
            rate_basic = Convert.ToDouble(rate_hour_basicIntxtbox.Text);
            no_hours_basic = Convert.ToDouble(no_hours_basicIntxtbox.Text);
            rate_hono = Convert.ToDouble(ratehourHonorariumtxtbox.Text);
            no_hours_hono = Convert.ToDouble(noHoursHonorariumtxtbox.Text);
            rate_other = Convert.ToDouble(ratehourOthertxtbox.Text);
            no_hours_others = Convert.ToDouble(nohoursOthertxtbox.Text);

            basic_income = rate_basic * no_hours_basic;
            hono_income = rate_hono * no_hours_hono;
            other_income = rate_other * no_hours_others;
            gross_income = basic_income + hono_income + other_income;
        }

        private void DisplayResults()
        {
            grossIncometxtbox.Text = gross_income.ToString("n");
            income_basicintxtbox.Text = basic_income.ToString("n");
            incomeHonorariumtxtbox.Text = hono_income.ToString("n");
            IncomeOtherstxtbox.Text = other_income.ToString("n");
            ssscontritxtbox.Text = sss_contrib.ToString("n");
            philhealthcontritxtbox.Text = phil_contrib.ToString("n");
            pagibigcontrittxtbox.Text = pagibig.ToString("n");
            incometaxtxtbox.Text = income_tax.ToString("n");
        }

    }

}



