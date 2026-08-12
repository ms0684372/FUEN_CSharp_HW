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

    public enum Subject
    {
        Unknown = -1,
        Chinese = 0,
        Math = 1,
        English = 2,
    }

    public static class SubjectExtension
    {
        public static string GetDisplayName(Subject subject)
        {
            switch (subject)
            {
                case Subject.Chinese: return "國文";
                case Subject.Math: return "數學";
                case Subject.English: return "英文";
                default: return "未知科目";
            }
        }

        /// <summary>
        /// 取得全部Subject(不包含Unknown)
        /// </summary>
        public static List<Subject> GetAllSubject()
        {
            return Enum.GetValues(typeof(Subject))
                .Cast<Subject>()
                .Where(a => a != Subject.Unknown)   //排除Unknown
                .ToList();
        }
    }

    public class Student
    {
        private string m_name;
        public string Name { get => m_name; }
        private Dictionary<Subject, int> m_scoreMap = new Dictionary<Subject, int>();

        public Student() { }

        public Student(string name, int chinese, int math, int english)
        {
            m_name = name;

            //GC這幾行是在算記憶體增長, 現階段先不考慮, 先求有再求好
            //long before = GC.GetTotalMemory(true);
            m_scoreMap.Add(Subject.Chinese, chinese);
            m_scoreMap.Add(Subject.Math, math);
            m_scoreMap.Add(Subject.English, english);
            //long after = GC.GetTotalMemory(true);
            //Console.WriteLine(after - before);
        }

        public void SetScore(Subject subject, int score)
        {
            m_scoreMap[subject] = score;
        }

        public int GetScore(Subject subject)
        {
            if (!m_scoreMap.TryGetValue(subject, out int score))
                return -1;

            return score;
        }

        /// <summary>
        /// 姓名, 國, 英, 數, 總, 均, 高, 低
        /// </summary>
        public string[] GetResult()
        {
            string[] result = new string[]
            {
                Name,
                GetScore(Subject.Chinese).ToString(),
                GetScore(Subject.English).ToString(),
                GetScore(Subject.Math).ToString(),
                Sum().ToString(),
                Avg().ToString(),
                GetHighest().ToString(),
                GetLowest().ToString(),
            };
            return result;
        }

        /// <summary>
        /// 各科總和
        /// </summary>
        public int Sum()
        {
            int sum = 0;
            foreach (KeyValuePair<Subject, int> pair in m_scoreMap)
                sum += pair.Value;
            return sum;
        }

        /// <summary>
        /// 各科平均
        /// </summary>
        public float Avg()
        {
            if (m_scoreMap.Count <= 0)
                return 0;

            float sum = Sum();
            return Convert.ToInt32(Math.Round(sum / m_scoreMap.Count, 1));
        }

        /// <summary>
        /// 找最高分科目
        /// </summary>
        public SubjectScore GetHighest()
        {
            Subject subject = Subject.Unknown;
            int score = -1;

            foreach (KeyValuePair<Subject, int> pair in m_scoreMap)
            {
                if (pair.Value > score)
                {
                    subject = pair.Key;
                    score = pair.Value;
                }
            }
            return new SubjectScore(subject, score);
        }

        /// <summary>
        /// 找最低分科目
        /// </summary>
        public SubjectScore GetLowest()
        {
            Subject subject = Subject.Unknown;
            int score = 9999;

            foreach (KeyValuePair<Subject, int> pair in m_scoreMap)
            {
                if (pair.Value < score)
                {
                    subject = pair.Key;
                    score = pair.Value;
                }
            }
            return new SubjectScore(subject, score);
        }

        public override string ToString()
        {
            string result = $"姓名:{Name}\n";
            foreach (var v in m_scoreMap)
                result += $"{SubjectExtension.GetDisplayName(v.Key)}:{v.Value}\n";
            return result;
        }
    }

    public struct SubjectScore
    {
        private Subject m_subject;
        public Subject Subject { get => m_subject; }
        public string Name { get => SubjectExtension.GetDisplayName(m_subject); }
        private int m_score;
        public int Score { get => m_score; }

        public SubjectScore(Subject subject, int score)
        {
            m_subject = subject;
            m_score = score;
        }

        public override string ToString()
        {
            return $"{Name}{m_score}";
            ;
        }
    }
}
