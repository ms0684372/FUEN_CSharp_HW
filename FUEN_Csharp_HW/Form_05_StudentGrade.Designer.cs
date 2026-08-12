namespace FUEN_Csharp_HW
{
    partial class Form_05_StudentGrade
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnAddRandom = new System.Windows.Forms.Button();
            this.btnAddRandom20 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.textEn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textMath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textCh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelStatistics = new System.Windows.Forms.Label();
            this.listviewStudents = new System.Windows.Forms.ListView();
            this.comboSubject = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textSeachLow = new System.Windows.Forms.TextBox();
            this.textSearchHigh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.textSearchHigh);
            this.splitContainer1.Panel1.Controls.Add(this.textSeachLow);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.comboSubject);
            this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer1.Panel1.Controls.Add(this.btnAdd);
            this.splitContainer1.Panel1.Controls.Add(this.textEn);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.textMath);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.textCh);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.textName);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.labelStatistics);
            this.splitContainer1.Panel2.Controls.Add(this.btnAddRandom20);
            this.splitContainer1.Panel2.Controls.Add(this.btnAddRandom);
            this.splitContainer1.Panel2.Controls.Add(this.listviewStudents);
            this.splitContainer1.Panel2.Controls.Add(this.btnStatistics);
            this.splitContainer1.Panel2.Controls.Add(this.btnReset);
            this.splitContainer1.Size = new System.Drawing.Size(800, 543);
            this.splitContainer1.SplitterDistance = 174;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnAddRandom
            // 
            this.btnAddRandom.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnAddRandom.Location = new System.Drawing.Point(52, 505);
            this.btnAddRandom.Name = "btnAddRandom";
            this.btnAddRandom.Size = new System.Drawing.Size(137, 28);
            this.btnAddRandom.TabIndex = 13;
            this.btnAddRandom.Text = "新增隨機資料";
            this.btnAddRandom.UseVisualStyleBackColor = true;
            this.btnAddRandom.Click += new System.EventHandler(this.btnAddRandom_Click);
            // 
            // btnAddRandom20
            // 
            this.btnAddRandom20.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnAddRandom20.Location = new System.Drawing.Point(195, 505);
            this.btnAddRandom20.Name = "btnAddRandom20";
            this.btnAddRandom20.Size = new System.Drawing.Size(137, 28);
            this.btnAddRandom20.TabIndex = 13;
            this.btnAddRandom20.Text = "新增隨機20筆";
            this.btnAddRandom20.UseVisualStyleBackColor = true;
            this.btnAddRandom20.Click += new System.EventHandler(this.btnAddRandom20_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnReset.Location = new System.Drawing.Point(338, 505);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(137, 28);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "重設所有資料";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnStatistics.Location = new System.Drawing.Point(481, 505);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(137, 28);
            this.btnStatistics.TabIndex = 13;
            this.btnStatistics.Text = "各科統計";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnAdd.Location = new System.Drawing.Point(19, 174);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(134, 28);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "加入學生資料";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // textEn
            // 
            this.textEn.Font = new System.Drawing.Font("新細明體", 12F);
            this.textEn.Location = new System.Drawing.Point(65, 132);
            this.textEn.Name = "textEn";
            this.textEn.Size = new System.Drawing.Size(88, 27);
            this.textEn.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F);
            this.label4.Location = new System.Drawing.Point(16, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "英文:";
            // 
            // textMath
            // 
            this.textMath.Font = new System.Drawing.Font("新細明體", 12F);
            this.textMath.Location = new System.Drawing.Point(65, 92);
            this.textMath.Name = "textMath";
            this.textMath.Size = new System.Drawing.Size(88, 27);
            this.textMath.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F);
            this.label3.Location = new System.Drawing.Point(16, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "數學:";
            // 
            // textCh
            // 
            this.textCh.Font = new System.Drawing.Font("新細明體", 12F);
            this.textCh.Location = new System.Drawing.Point(65, 51);
            this.textCh.Name = "textCh";
            this.textCh.Size = new System.Drawing.Size(88, 27);
            this.textCh.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F);
            this.label2.Location = new System.Drawing.Point(16, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "國文:";
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("新細明體", 12F);
            this.textName.Location = new System.Drawing.Point(65, 12);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(88, 27);
            this.textName.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 12F);
            this.label5.Location = new System.Drawing.Point(16, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "姓名:";
            // 
            // labelStatistics
            // 
            this.labelStatistics.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelStatistics.Font = new System.Drawing.Font("新細明體", 12F);
            this.labelStatistics.Location = new System.Drawing.Point(3, 347);
            this.labelStatistics.Name = "labelStatistics";
            this.labelStatistics.Size = new System.Drawing.Size(619, 155);
            this.labelStatistics.TabIndex = 1;
            // 
            // listviewStudents
            // 
            this.listviewStudents.BackColor = System.Drawing.SystemColors.Control;
            this.listviewStudents.Font = new System.Drawing.Font("新細明體", 12F);
            this.listviewStudents.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listviewStudents.HideSelection = false;
            this.listviewStudents.Location = new System.Drawing.Point(3, 3);
            this.listviewStudents.Name = "listviewStudents";
            this.listviewStudents.Size = new System.Drawing.Size(619, 341);
            this.listviewStudents.TabIndex = 0;
            this.listviewStudents.UseCompatibleStateImageBehavior = false;
            this.listviewStudents.View = System.Windows.Forms.View.Details;
            // 
            // comboSubject
            // 
            this.comboSubject.Font = new System.Drawing.Font("新細明體", 12F);
            this.comboSubject.FormattingEnabled = true;
            this.comboSubject.Location = new System.Drawing.Point(19, 311);
            this.comboSubject.Name = "comboSubject";
            this.comboSubject.Size = new System.Drawing.Size(134, 24);
            this.comboSubject.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F);
            this.label1.Location = new System.Drawing.Point(16, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "搜索成績範圍";
            // 
            // textSeachLow
            // 
            this.textSeachLow.Font = new System.Drawing.Font("新細明體", 12F);
            this.textSeachLow.Location = new System.Drawing.Point(19, 345);
            this.textSeachLow.Name = "textSeachLow";
            this.textSeachLow.Size = new System.Drawing.Size(56, 27);
            this.textSeachLow.TabIndex = 16;
            // 
            // textSearchHigh
            // 
            this.textSearchHigh.Font = new System.Drawing.Font("新細明體", 12F);
            this.textSearchHigh.Location = new System.Drawing.Point(97, 345);
            this.textSearchHigh.Name = "textSearchHigh";
            this.textSearchHigh.Size = new System.Drawing.Size(56, 27);
            this.textSearchHigh.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 12F);
            this.label6.Location = new System.Drawing.Point(80, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "-";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnSearch.Location = new System.Drawing.Point(19, 381);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(134, 28);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "搜尋";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form_05_StudentGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 543);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form_05_StudentGrade";
            this.Text = "Form_05_StudentGrade";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView listviewStudents;
        private System.Windows.Forms.Label labelStatistics;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox textEn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textMath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textCh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddRandom;
        private System.Windows.Forms.Button btnAddRandom20;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.ComboBox comboSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textSearchHigh;
        private System.Windows.Forms.TextBox textSeachLow;
        private System.Windows.Forms.Button btnSearch;
    }
}