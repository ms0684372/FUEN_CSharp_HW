using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FUEN_Csharp_HW
{
    public partial class Form_05_StudentGrade : Form
    {
        private List<Student> studentsList = new List<Student>();
        private const int ScoreMax = 100;
        private const int ScoreMin = 0;

        public Form_05_StudentGrade()
        {
            InitializeComponent();

            List<Subject> subjects = SubjectExtension.GetAllSubject();
            InitializeStudentColumn(subjects);
            InitializeComboSubject(subjects);
        }

        private void InitializeStudentColumn(List<Subject> subjects)
        {

            List<ColumnHeader> columnHeaders = new List<ColumnHeader>();
            columnHeaders.Add(listviewStudents.Columns.Add("姓名"));
            foreach (Subject subject in subjects)
                columnHeaders.Add(listviewStudents.Columns.Add(SubjectExtension.GetDisplayName(subject)));
            columnHeaders.Add(listviewStudents.Columns.Add("總分"));
            columnHeaders.Add(listviewStudents.Columns.Add("平均"));
            columnHeaders.Add(listviewStudents.Columns.Add("最高"));
            columnHeaders.Add(listviewStudents.Columns.Add("最低"));

            /* 
             * 讓姓名欄位大概寬1.5倍
             * 1.5x + (columnHeaders.Count-1)x = listStudents.Width;
             */

            int width = (int)(listviewStudents.Width / (columnHeaders.Count + 0.5f));
            int nameWidth = listviewStudents.Width - (width * (columnHeaders.Count - 1));
            columnHeaders[0].Width = nameWidth;
            for (int i = 1; i < columnHeaders.Count; i++)
            {
                columnHeaders[i].Width = width;
            }
        }

        /// <summary>
        /// 初始化科目下拉選單
        /// </summary>
        private void InitializeComboSubject(List<Subject> subjects)
        {
            foreach (Subject subject in subjects)
            {
                comboSubject.Items.Add(SubjectExtension.GetDisplayName(subject));
            }
            comboSubject.SelectedIndex = 0; //預設設為0
            //Console.WriteLine(comboSubject.SelectedIndex);
        }

        /// <summary>
        /// 驗證分數欄位, 失敗時會自動Focus和SelectAll
        /// </summary>
        private bool VerifyTxtScore(TextBox textbox, out int score, string emptyMsg, string parseFailedMsg)
        {
            if (!InputValidator.ValidateInt(textbox, out score, emptyMsg, parseFailedMsg))
                return false;
            if (score < ScoreMin || score > ScoreMax)
            {
                textbox.Focus();
                textbox.SelectAll();
                MessageBox.Show($"請輸入{ScoreMin}至{ScoreMax}的數值");
                return false;
            }
            return true;
        }

        /// <summary>
        /// 新增單筆學生資料
        /// </summary>
        private void AddStudent(Student student)
        {
            studentsList.Add(student);
            CreateStudentItem(student);
        }

        /// <summary>
        /// 新增多筆學生資料
        /// </summary>
        public void AddStudents(ICollection<Student> values)
        {
            studentsList.AddRange(values);
            CreateStudentItems(values);
        }



        /// <summary>
        /// 清空輸入欄位
        /// </summary>
        private void ClearField()
        {
            textName.Text = textCh.Text = textMath.Text = textEn.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {   //確認姓名欄位
            if (string.IsNullOrEmpty(textName.Text.Trim()))
            {
                textName.Focus();
                MessageBox.Show("請輸入姓名");
                return;
            }

            //驗證各科分數欄位
            if (!VerifyTxtScore(textCh, out int scoreCh, "請輸入國文分數", "請正確輸入分數") ||
                !VerifyTxtScore(textMath, out int scoreMath, "請輸入數學分數", "請正確輸入分數") ||
                !VerifyTxtScore(textEn, out int scoreEn, "請輸入英文分數", "請正確輸入分數"))
                return;

            //驗證通過 新增學生資料
            Student student = new Student(textName.Text, scoreCh, scoreMath, scoreEn);
            AddStudent(student);

            //結束 清空輸入欄位
            ClearField();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            List<Subject> subjectList = SubjectExtension.GetAllSubject();
            Dictionary<Subject, int> sumMap = new Dictionary<Subject, int>();
            Dictionary<Subject, int> highMap = new Dictionary<Subject, int>();
            Dictionary<Subject, int> lowMap = new Dictionary<Subject, int>();

            foreach (Subject subject in subjectList)
            {
                sumMap.Add(subject, 0);
                highMap.Add(subject, -1);
                lowMap.Add(subject, 999);
            }

            foreach (Student stu in studentsList)
            {
                foreach (Subject subject in subjectList)
                {
                    int score = stu.GetScore(subject);
                    sumMap[subject] += score;

                    if (score > highMap[subject])
                        highMap[subject] = score;
                    if (score < lowMap[subject])
                        lowMap[subject] = score;
                }
            }

            StringBuilder builder = new StringBuilder();
            builder.Append("總分");
            foreach (Subject subject in subjectList)
                builder.Append($" {SubjectExtension.GetDisplayName(subject)}:{sumMap[subject]}");
            builder.Append("\n");

            builder.Append("最高分");
            foreach (Subject subject in subjectList)
                builder.Append($" {SubjectExtension.GetDisplayName(subject)}:{highMap[subject]} ");
            builder.Append("\n");

            builder.Append("最低分");
            foreach (Subject subject in subjectList)
                builder.Append($" {SubjectExtension.GetDisplayName(subject)}:{lowMap[subject]} ");
            builder.Append("\n");

            labelStatistics.Text = builder.ToString();
            foreach (var v in sumMap)
                Console.WriteLine($"{SubjectExtension.GetDisplayName(v.Key)}:{v.Value}");
        }

        private void btnAddRandom_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            Student stu = new Student((studentsList.Count + 1).ToString(),
                chinese: rd.Next(ScoreMin, ScoreMax + 1),
                math: rd.Next(ScoreMin, ScoreMax + 1),
                english: rd.Next(ScoreMin, ScoreMax + 1));
            AddStudent(stu);
        }

        private void btnAddRandom20_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            int index = studentsList.Count + 1;
            int count = 20;

            List<Student> newStudents = new List<Student>(count);
            for (int i = 0; i < count; i++, index++)
            {
                Student stu = new Student(index.ToString(),
                    chinese: rd.Next(ScoreMin, ScoreMax + 1),
                    math: rd.Next(ScoreMin, ScoreMax + 1),
                    english: rd.Next(ScoreMin, ScoreMax + 1));
                newStudents.Add(stu);
            }

            AddStudents(newStudents);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            studentsList.Clear();
            listviewStudents.Items.Clear();
        }

        private void OnBtnSearch_Click(object sender, EventArgs e)
        {
            if (comboSubject.SelectedIndex < 0)
            {
                MessageBox.Show("請選擇科目");
                return;
            }

            if (!VerifyTxtScore(textSeachLow, out int lowScore, "請輸入最低分", "請正確輸入最低分數值") ||
               !VerifyTxtScore(textSearchHigh, out int highScore, "請輸入最高分", "請正確輸入最高分數值"))
            {
                return;
            }

            //if (highScore < lowScore)
            //{
            //    MessageBox.Show("最低分高於最低分");
            //    return;
            //}

            List<Subject> subjects = SubjectExtension.GetAllSubject();
            Subject subject = subjects[comboSubject.SelectedIndex];
            List<Student> tempList = studentsList.FindAll((stu) =>
            {
                int score = stu.GetScore(subject);
                return score > lowScore && score < highScore;
            });

            listviewStudents.Items.Clear();
            CreateStudentItems(tempList);
        }

        private void CreateStudentItem(Student student)
        {
            /* 
             * ListViewItem的SubItem底層是用陣列當容器
             * ListViewItem.Text 是取自SubItem[0]
             * 建議一開始就將所需的全部內容(姓名, 分數等)都準備好
             */
            ListViewItem item = new ListViewItem(student.GetResult());
            listviewStudents.Items.Add(item);
        }

        private void CreateStudentItems(ICollection<Student> students)
        {
            /* 
             * ListViewItem的SubItem底層是用陣列當容器
             * ListViewItem.Text 是取自SubItem[0]
             * 建議一開始就將所需的全部內容(姓名, 分數等)都準備好
             */
            foreach (Student student in students)
            {
                ListViewItem item = new ListViewItem(student.GetResult());
                listviewStudents.Items.Add(item);
            }
        }
    }
}
