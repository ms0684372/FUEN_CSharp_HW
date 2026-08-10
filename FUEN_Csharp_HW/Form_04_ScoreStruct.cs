using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FUEN_Csharp_HW
{
    public partial class Form_04_ScoreStruct : Form
    {
        public Form_04_ScoreStruct()
        {
            InitializeComponent();
        }

        List<Student> students = new List<Student>();
        private void btnSave_Click(object sender, EventArgs e)
        {   //確認姓名欄位是否為空
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

        private void AddStudent(Student student)
        {
            students.Add(student);
            listStudent.Items.Add($"{students.Count} {student.Name}");
        }

        private bool VerifyTxtScore(TextBox textbox, out int score, string emptyMsg, string parseFailedMsg)
        {
            if (!InputValidator.ValidateInt(textbox, out score, emptyMsg, parseFailedMsg))
                return false;
            if (score < 0)
            {
                textbox.Focus();
                textbox.SelectAll();
                MessageBox.Show("分數不得小於0，");
                return false;
            }
            return true;
        }

        /// <summary>
        /// 選擇學生
        /// </summary>
        private void listStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value = listStudent.SelectedIndex;
            if (value < 0 || value >= students.Count)
                return;

            Student student = students[value];
            labelResult.Text = student.ToString();

            SubjectScore high = student.GetHighest();
            SubjectScore low = student.GetLowest();
            labelMaxAndMin.Text = $"最高分科目成績為:{high.Name}{high.Score}分\n最低分科目成績為:{low.Name}{low.Score}分";
        }

        private void OnBtnRemove_Click(object sender, EventArgs e)
        {
            int value = listStudent.SelectedIndex;
            if (value < 0 || value >= students.Count)
                return;

            Student student = students[value];
            DialogResult result = MessageBox.Show($"確定要刪除學生{student.Name}嗎", "刪除學生資料", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                students.RemoveAt(value);
                listStudent.Items.RemoveAt(listStudent.SelectedIndex);
                ClearResults();
                MessageBox.Show("刪除資料成功!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("確定要清空所有資料嗎?", "清空資料", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                students.Clear();
                listStudent.Items.Clear();
                ClearResults();
                MessageBox.Show("清空所有資料成功!");
            }    
        }

        private void ClearField()
        {
            textName.Text = textCh.Text = textMath.Text = textEn.Text = "";
        }

        private void ClearResults()
        {
            labelResult.Text = labelMaxAndMin.Text = "";
        }
    }
}
