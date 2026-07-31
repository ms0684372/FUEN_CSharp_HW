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
    public partial class Form_01_Hello : Form
    {
        public Form_01_Hello()
        {
            InitializeComponent();
        }

        private string resultSample = "我是{0},\n英文名是{1}\n性別是{2}\n星座是{3}\n很高興認識你。";

        private void OnBtnHello_Click(object sender, EventArgs e)
        {
            string result = string.Format($"Hello, {resultSample}", txtChName.Text, txtEnName.Text, txtGender.Text, txtZodiacSign.Text);
            MessageBox.Show(result);
        }

        private void OnBtnHi_Click(object sender, EventArgs e)
        {
            string result = string.Format($"Hi, {resultSample}", txtChName.Text, txtEnName.Text, txtGender.Text, txtZodiacSign.Text);
            MessageBox.Show(result);
        }
    }
}
