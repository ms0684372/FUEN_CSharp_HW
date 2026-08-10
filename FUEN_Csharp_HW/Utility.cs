using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUEN_Csharp_HW
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

    public class Student
    {
        private string m_name;
        public string Name { get => m_name; }
        private List<SubjectScore> m_scoreList;

        public Student() { }

        public Student(string name, int chinese, int math, int english)
        {
            m_name = name;
            long before = GC.GetTotalMemory(true);
            m_scoreList = new List<SubjectScore>(3)
            {
                new SubjectScore(Subject.Chinese, chinese),
                new SubjectScore(Subject.Math, math),
                new SubjectScore(Subject.English, english)
            };
            long after = GC.GetTotalMemory(true);
            Console.WriteLine(after - before);
        }

        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < m_scoreList.Count; i++)
                sum += m_scoreList[i].Score;
            return sum;
        }

        public int Avg()
        {
            float sum = Sum();
            return Convert.ToInt32(Math.Round(sum / m_scoreList.Count, 0));
        }

        public SubjectScore GetHighest()
        {
            SubjectScore result = m_scoreList[0];

            for (int i = 1; i < m_scoreList.Count; i++)
            {
                if (m_scoreList[i].Score > result.Score)
                    result = m_scoreList[i];
            }

            return result;
        }

        public SubjectScore GetLowest()
        {
            SubjectScore result = m_scoreList[0];

            for (int i = 1; i < m_scoreList.Count; i++)
            {
                if (m_scoreList[i].Score < result.Score)
                    result = m_scoreList[i];
            }

            return result;
        }

        public override string ToString()
        {
            string result = $"姓名:{Name}\n";
            foreach (SubjectScore subjectScore in m_scoreList)
                result += $"{subjectScore.Name}:{subjectScore.Score}\n";
            return result;
        }
    }

    public struct SubjectScore
    {
        private Subject m_subject;
        public string Name
        {
            get
            {
                switch (m_subject)
                {
                    case Subject.Chinese:
                        return "國文";
                    case Subject.Math:
                        return "數學";
                    case Subject.English:
                        return "英文";
                    default:
                        return "科目名稱異常";
                }
            }
        }
        private int m_score;
        public int Score { get => m_score; }

        public SubjectScore(Subject subject, int score)
        {
            m_subject = subject;
            m_score = score;
        }
    }

    public enum Subject
    {
        Chinese = 0,
        Math,
        English
    }
}
