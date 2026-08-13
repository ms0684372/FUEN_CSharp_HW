using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUEN_Csharp_HW.Score
{
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
}
