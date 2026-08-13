using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FUEN_Csharp_HW.Loan;

namespace FUEN_Csharp_HW.UI
{
    public partial class Form_02_1_Report : Form
    {
        public Form_02_1_Report(LoanData loanData)
        {
            InitializeComponent();

            labelLoanAmount.Text = loanData.LoanAmount.ToString("F0");
            labelYear.Text = loanData.Year.ToString();
            labelAnnualRate.Text = loanData.AnnualRate.ToString("F0");
            labelDownPayment.Text = loanData.DownPayment.ToString();
            labelMonthlyPay.Text = loanData.PMT.ToString("F0");
            labelTotalAmount.Text = loanData.TotalAmount.ToString("F0");
        }
    }
}
