using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LESSON1
{
    public class Payroll_variables
    {
        // Employee Information
        public string EmployeeNumber { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public string PayDate { get; set; }

        // Income Rates and Hours
        public double BasicRate { get; set; }
        public double BasicHours { get; set; }
        public double HonorariumRate { get; set; }
        public double HonorariumHours { get; set; }
        public double OtherRate { get; set; }
        public double OtherHours { get; set; }

        // Computed Income
        public double BasicIncome { get; private set; }
        public double HonorariumIncome { get; private set; }
        public double OtherIncome { get; private set; }
        public double GrossIncome { get; private set; }

        // Contributions
        public double SSSContribution { get; private set; }
        public double PhilHealthContribution { get; private set; }
        public double PagibigContribution { get; private set; }
        public double IncomeTax { get; private set; }
        public double WISP { get; private set; }

        // Loans
        public double SSSLoan { get; set; }
        public double PagibigLoan { get; set; }
        public double FacultyDeposit { get; set; }
        public double FacultySavings { get; set; }
        public double SalaryLoan { get; set; }
        public double OtherLoan { get; set; }

        // Final Amounts
        public double TotalDeductions { get; private set; }
        public double NetIncome { get; private set; }
        public double TaxableIncome { get; private set; }
        public double NetPay { get; private set; }
        public double Deductions { get; private set; }

        // Constructor
        public Payroll_variables()
        {
            PagibigContribution = 200;
            WISP = 750;
        }

        // Get Full Name
        public string GetFullName()
        {
            return $"{FirstName} {MiddleName} {LastName}";
        }

        // Compute all incomes
        public void ComputeIncomes()
        {
            BasicIncome = BasicRate * BasicHours;
            HonorariumIncome = HonorariumRate * HonorariumHours;
            OtherIncome = OtherRate * OtherHours;
            GrossIncome = BasicIncome + HonorariumIncome + OtherIncome;
        }

        // Compute SSS Contribution
        public void ComputeSSSContribution()
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
                if (GrossIncome >= sssTable[i, 0] && GrossIncome <= sssTable[i, 1])
                {
                    SSSContribution = sssTable[i, 2] / 2;
                    return;
                }
            }

            SSSContribution = 1750 / 2; // default highest
        }

        // Compute PhilHealth Contribution
        public void ComputePhilHealthContribution()
        {
            PhilHealthContribution = (GrossIncome * 0.05) / 2;
        }

        // Compute Income Tax
        public void ComputeIncomeTax()
        {
            TaxableIncome = GrossIncome - SSSContribution - PhilHealthContribution - PagibigContribution;

            double tax = 0.00;
            if (TaxableIncome <= 20833.33)
                tax = 0.00;
            else if (TaxableIncome <= 33333.33)
                tax = (TaxableIncome - 20833.33) * 0.15;
            else if (TaxableIncome <= 66666.67)
                tax = 1875 + ((TaxableIncome - 33333.33) * 0.20);
            else if (TaxableIncome <= 166666.67)
                tax = 8541.70 + ((TaxableIncome - 66666.67) * 0.25);
            else if (TaxableIncome <= 666666.67)
                tax = 33541.70 + ((TaxableIncome - 166666.67) * 0.30);
            else
                tax = 183541.70 + ((TaxableIncome - 666666.67) * 0.35);

            IncomeTax = tax / 2; // semi-monthly
        }

        // Compute all contributions and taxes
        public void ComputeContributions()
        {
            ComputeSSSContribution();
            ComputePhilHealthContribution();
            ComputeIncomeTax();
        }

        // Compute Total Deductions and Net Income
        public void ComputeDeductions()
        {
            TotalDeductions = SSSLoan + PagibigLoan + FacultyDeposit + FacultySavings +
                            SalaryLoan + OtherLoan + SSSContribution + PhilHealthContribution +
                            PagibigContribution + IncomeTax;

            NetIncome = GrossIncome - TotalDeductions;
        }

        // Compute Net Pay (for save form)
        public void ComputeNetPay()
        {
            Deductions = IncomeTax + SSSContribution + PhilHealthContribution + PagibigContribution + WISP;
            NetPay = GrossIncome - Deductions;
        }

        // Master computation method - computes everything
        public void ComputeAll()
        {
            ComputeIncomes();
            ComputeContributions();
            ComputeNetPay();
        }
    }
}
    

