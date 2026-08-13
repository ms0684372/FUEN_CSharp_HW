namespace FUEN_Csharp_HW.UI
{
    partial class Form_04_ScoreStruct
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
            this.label1 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textCh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textMath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textEn = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelMaxAndMin = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.listStudent = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14F);
            this.label1.Location = new System.Drawing.Point(54, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名:";
            // 
            // textName
            // 
            this.textName.Font = new System.Drawing.Font("新細明體", 14F);
            this.textName.Location = new System.Drawing.Point(113, 56);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(172, 30);
            this.textName.TabIndex = 1;
            // 
            // textCh
            // 
            this.textCh.Font = new System.Drawing.Font("新細明體", 14F);
            this.textCh.Location = new System.Drawing.Point(113, 122);
            this.textCh.Name = "textCh";
            this.textCh.Size = new System.Drawing.Size(172, 30);
            this.textCh.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 14F);
            this.label2.Location = new System.Drawing.Point(54, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "國文:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 14F);
            this.label3.Location = new System.Drawing.Point(54, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "數學:";
            // 
            // textMath
            // 
            this.textMath.Font = new System.Drawing.Font("新細明體", 14F);
            this.textMath.Location = new System.Drawing.Point(113, 189);
            this.textMath.Name = "textMath";
            this.textMath.Size = new System.Drawing.Size(172, 30);
            this.textMath.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 14F);
            this.label4.Location = new System.Drawing.Point(54, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "英文:";
            // 
            // textEn
            // 
            this.textEn.Font = new System.Drawing.Font("新細明體", 14F);
            this.textEn.Location = new System.Drawing.Point(113, 258);
            this.textEn.Name = "textEn";
            this.textEn.Size = new System.Drawing.Size(172, 30);
            this.textEn.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelMaxAndMin);
            this.groupBox1.Controls.Add(this.labelResult);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 14F);
            this.groupBox1.Location = new System.Drawing.Point(542, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 307);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "成績";
            // 
            // labelMaxAndMin
            // 
            this.labelMaxAndMin.BackColor = System.Drawing.Color.White;
            this.labelMaxAndMin.ForeColor = System.Drawing.Color.Black;
            this.labelMaxAndMin.Location = new System.Drawing.Point(6, 202);
            this.labelMaxAndMin.Name = "labelMaxAndMin";
            this.labelMaxAndMin.Size = new System.Drawing.Size(244, 99);
            this.labelMaxAndMin.TabIndex = 1;
            // 
            // labelResult
            // 
            this.labelResult.BackColor = System.Drawing.Color.White;
            this.labelResult.ForeColor = System.Drawing.Color.Black;
            this.labelResult.Location = new System.Drawing.Point(6, 26);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(244, 169);
            this.labelResult.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("新細明體", 14F);
            this.btnSave.Location = new System.Drawing.Point(124, 320);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 44);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // listStudent
            // 
            this.listStudent.Font = new System.Drawing.Font("新細明體", 14F);
            this.listStudent.FormattingEnabled = true;
            this.listStudent.ItemHeight = 19;
            this.listStudent.Location = new System.Drawing.Point(319, 56);
            this.listStudent.Name = "listStudent";
            this.listStudent.Size = new System.Drawing.Size(203, 232);
            this.listStudent.TabIndex = 7;
            this.listStudent.SelectedIndexChanged += new System.EventHandler(this.listStudent_SelectedIndexChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("新細明體", 14F);
            this.btnRemove.Location = new System.Drawing.Point(319, 320);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(96, 44);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "刪除";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.OnBtnRemove_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("新細明體", 14F);
            this.btnClear.Location = new System.Drawing.Point(426, 320);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 44);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form_04_ScoreStruct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 427);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.listStudent);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textEn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textMath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textCh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label1);
            this.Name = "Form_04_ScoreStruct";
            this.Text = "Form_04_ScoreStruct";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textCh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textMath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textEn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label labelMaxAndMin;
        private System.Windows.Forms.ListBox listStudent;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
    }
}