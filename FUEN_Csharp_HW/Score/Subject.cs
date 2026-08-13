using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUEN_Csharp_HW.Score
{
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
}
