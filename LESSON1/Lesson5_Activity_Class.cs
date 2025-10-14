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
    public partial class Lesson5_Activity_Class : Form
    {
        private Size baseSize;
        private Payroll_variables payroll; // Create a Payroll object

        public Lesson5_Activity_Class()
        {
            InitializeComponent();
            payroll = new Payroll_variables(); // Initialize it
        }

        private void grossincomebutton_Click(object sender, EventArgs e)
        {
            // Set the rates and hours from textboxes
            payroll.BasicRate = Convert.ToDouble(rate_hour_basicIntxtbox.Text);
            payroll.BasicHours = Convert.ToDouble(no_hours_basicIntxtbox.Text);
            payroll.HonorariumRate = Convert.ToDouble(ratehourHonorariumtxtbox.Text);
            payroll.HonorariumHours = Convert.ToDouble(noHoursHonorariumtxtbox.Text);
            payroll.OtherRate = Convert.ToDouble(ratehourOthertxtbox.Text);
            payroll.OtherHours = Convert.ToDouble(nohoursOthertxtbox.Text);

            // Compute everything!
            payroll.ComputeAll();

            // Display results
            grossIncometxtbox.Text = payroll.GrossIncome.ToString("n");
            income_basicintxtbox.Text = payroll.BasicIncome.ToString("n");
            incomeHonorariumtxtbox.Text = payroll.HonorariumIncome.ToString("n");
            IncomeOtherstxtbox.Text = payroll.OtherIncome.ToString("n");
            ssscontritxtbox.Text = payroll.SSSContribution.ToString("n");
            philhealthcontritxtbox.Text = payroll.PhilHealthContribution.ToString("n");
            pagibigcontrittxtbox.Text = payroll.PagibigContribution.ToString("n");
            incometaxtxtbox.Text = payroll.IncomeTax.ToString("n");
        }

        private void Lesson5_Activity_Class_Load(object sender, EventArgs e)
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

            // Maximize the window (optional)
            this.WindowState = FormWindowState.Maximized;

            // Scale to fit the screen
            ScaleToScreen();
        }

        private void netincomebttn_Click(object sender, EventArgs e)
        {
            // Set loan values from textboxes
            payroll.SSSLoan = Convert.ToDouble(sssloantxtbox.Text);
            payroll.PagibigLoan = Convert.ToDouble(pagibigloantxtbox.Text);
            payroll.FacultyDeposit = Convert.ToDouble(facultydeposittxtbox.Text);
            payroll.FacultySavings = Convert.ToDouble(facultysavingstxtbox.Text);
            payroll.SalaryLoan = Convert.ToDouble(salaryloantxtbox.Text);
            payroll.OtherLoan = Convert.ToDouble(otherloantxtbox.Text);

            // Compute deductions and net income
            payroll.ComputeDeductions();

            // Display results
            totaldeductionstxtbox.Text = payroll.TotalDeductions.ToString("n");
            netincometxtbox.Text = payroll.NetIncome.ToString("n");
        }

        private void savebttn_Click(object sender, EventArgs e)
        {
            // Set employee information from textboxes
            payroll.EmployeeNumber = employeenumtxtbox.Text;
            payroll.FirstName = fnametxtbox.Text;
            payroll.MiddleName = Mnametxtbox.Text;
            payroll.LastName = Snametxtbox.Text;
            payroll.Department = departmenttxtbox.Text;
            payroll.PayDate = paydatetxtbox.Text;

            // Open save form
            Lesson5_SaveForm sf = new Lesson5_SaveForm();

            // Populate save form with payroll data
            sf.employee_codesave.Text = payroll.EmployeeNumber;
            sf.employee_namesave.Text = payroll.GetFullName();
            sf.department_save.Text = payroll.Department;
            sf.companytxtbox.Text = "Lyceum of the Philippines University Cavite";
            sf.cutoff_save.Text = payroll.PayDate;
            sf.payperiod_save.Text = payroll.PayDate;
            sf.withholdingtax_txtbox.Text = payroll.IncomeTax.ToString("n");
            sf.sss_contribSave.Text = payroll.SSSContribution.ToString("n");
            sf.PhilhealthSave.Text = payroll.PhilHealthContribution.ToString("n");
            sf.hdmf_contribsave.Text = payroll.PagibigContribution.ToString("n");
            sf.sss_WIspsave.Text = payroll.WISP.ToString("n");
            sf.deductionsSAve.Text = payroll.Deductions.ToString("n");
            sf.dayhrs_basic.Text = payroll.BasicIncome.ToString("n");
            sf.dayhrs_over.Text = payroll.OtherIncome.ToString("n");
            sf.dayshrs_honor.Text = payroll.HonorariumIncome.ToString("n");
            sf.dayshrs_sub.Text = "0.00";
            sf.dayshrs_tardy.Text = "0.00";
            sf.textBox2.Text = payroll.GrossIncome.ToString("n");
            sf.textBox19.Text = payroll.Deductions.ToString("n");
            sf.textBox20.Text = payroll.NetPay.ToString("n");
            sf.textBox3.Text = payroll.OtherIncome.ToString("n");
            sf.textBox1.Text = payroll.GrossIncome.ToString("n");

            // Show the save form
            sf.Show();
        }

        private void newbttn_Click(object sender, EventArgs e)
        {
            // Clear all textboxes
            foreach (Control textbox in this.Controls)
            {
                if (textbox is TextBox)
                {
                    ((TextBox)textbox).Clear();
                }
            }

            // Reset payroll object to new instance
            payroll = new Payroll_variables();
        }

        private void netincometxtbox_TextChanged(object sender, EventArgs e)
        {
            { }
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



