using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUEN_Csharp_HW.Loan
{
    public class LoanData
    {
        public LoanData(decimal loanAmount, int year, decimal annualRate, decimal downPayment)
        {
            LoanAmount = loanAmount;
            Year = year;
            AnnualRate = annualRate;
            DownPayment = downPayment;
        }

        public decimal LoanAmount { get; set; }
        public int Year { get; set; }
        public decimal AnnualRate { get; set; }
        public decimal DownPayment { get; set; }

        public decimal PMT
        {
            get
            {
                decimal principal = LoanAmount - DownPayment;
                decimal monthlyRate = AnnualRate / 100 / 12;
                int month = Year * 12;

                decimal pmt;
                if (monthlyRate == 0)
                    pmt = principal / month;
                else
                    pmt = principal * monthlyRate / (1 - Convert.ToDecimal(Math.Pow(Convert.ToDouble(1 + monthlyRate), -month)));

                return pmt;
            }
        }

        public decimal TotalAmount
        {
            get
            {
                return PMT * Year * 12;
            }
        }
    }
}
