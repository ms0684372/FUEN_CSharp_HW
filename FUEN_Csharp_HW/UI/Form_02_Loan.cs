using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FUEN_Csharp_HW.Loan;

namespace FUEN_Csharp_HW.UI
{
    public partial class Form_02_Loan : Form
    {
        public Form_02_Loan()
        {
            InitializeComponent();
        }

        private void OnBtnMonth_Click(object sender, EventArgs e)
        {
            if (!TryGetLoanData(out LoanData loanData))
                return;

            MessageBox.Show($"月付額: {loanData.PMT.ToString(format: "0")}元");
        }

        private void OnBtnTotal_Click(object sender, EventArgs e)
        {
            if (!TryGetLoanData(out LoanData loanData))
                return;

            MessageBox.Show($"總付款: {loanData.TotalAmount.ToString(format: "0")}元");
        }

        private bool TryGetLoanData(out LoanData loanData)
        {
            loanData = null;
            if (!VerifyLoanAmount(out decimal loanAmount) ||
                !VerifyTxtYear(out int year) ||
                !VerifyTxtAnnualRate(out decimal annualRate) ||
                !VerifyTxtDownPayment(out decimal downPayment))
                return false;

            if (loanAmount < downPayment)
            {
                MessageBox.Show("頭期款超過貸款金額", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            loanData = new LoanData(loanAmount, year, annualRate, downPayment);
            return true;
        }

        private bool VerifyLoanAmount(out decimal loanAmount)
        {
            loanAmount = -1;
            if (!InputValidator.ValidateDecimal(txtLoanAmount, out loanAmount, "請輸入貸款金額", "請正確輸入貸款金額"))
                return false;

            if (loanAmount <= 0)
            {
                MessageBox.Show("貸款金額異常", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLoanAmount.SelectAll();
                return false;
            }
            return true;
        }

        private bool VerifyTxtYear(out int year)
        {
            year = -1;
            if (!InputValidator.ValidateInt(txtYear, out year, "請輸入年份", "請正確輸入年份"))
                return false;
            
            if (year <= 0)
            {
                MessageBox.Show("年份數值異常", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAnnualRate.SelectAll();
                return false;
            }
            return true;
        }

        private bool VerifyTxtAnnualRate(out decimal annualRate)
        {
            annualRate = -1;
            if (!InputValidator.ValidateDecimal(txtAnnualRate, out annualRate, "請輸入利率", "請正確輸入利率"))
                return false;

            if (annualRate < 0)
            {
                MessageBox.Show("利率數值異常", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAnnualRate.SelectAll();
                return false;
            }
            return true;
        }

        private bool VerifyTxtDownPayment(out decimal downPayment)
        {
            downPayment = -1;
            if (!InputValidator.ValidateDecimal(txtDownPayment, out downPayment, "請輸入頭期款", "請正確輸入頭期款"))
                return false;

            if (downPayment < 0)
            {
                MessageBox.Show("頭期款數值異常", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDownPayment.SelectAll();
                return false;
            }
            return true;
        }

        private void OnBtnReport_Click(object sender, EventArgs e)
        {
            if(TryGetLoanData(out LoanData loanData))
            {
                Form_02_1_Report form = new Form_02_1_Report(loanData);
                form.Show();
            }
        }
    }
}

