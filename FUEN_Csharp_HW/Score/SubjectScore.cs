using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUEN_Csharp_HW.Score
{
    public class SubjectScore
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
        }
    }
}
