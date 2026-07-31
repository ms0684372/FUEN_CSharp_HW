namespace FUEN_Csharp_HW
{
    partial class Form_01_Hello
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtChName = new System.Windows.Forms.TextBox();
            this.txtEnName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtZodiacSign = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnHi = new System.Windows.Forms.Button();
            this.btnHello = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14F);
            this.label1.Location = new System.Drawing.Point(49, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名:";
            // 
            // txtChName
            // 
            this.txtChName.Font = new System.Drawing.Font("新細明體", 14F);
            this.txtChName.Location = new System.Drawing.Point(172, 38);
            this.txtChName.Name = "txtChName";
            this.txtChName.Size = new System.Drawing.Size(145, 30);
            this.txtChName.TabIndex = 1;
            // 
            // txtEnName
            // 
            this.txtEnName.Font = new System.Drawing.Font("新細明體", 14F);
            this.txtEnName.Location = new System.Drawing.Point(172, 88);
            this.txtEnName.Name = "txtEnName";
            this.txtEnName.Size = new System.Drawing.Size(145, 30);
            this.txtEnName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 14F);
            this.label2.Location = new System.Drawing.Point(49, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "English Name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGender
            // 
            this.txtGender.Font = new System.Drawing.Font("新細明體", 14F);
            this.txtGender.Location = new System.Drawing.Point(172, 139);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(145, 30);
            this.txtGender.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 14F);
            this.label3.Location = new System.Drawing.Point(49, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "性別:";
            // 
            // txtZodiacSign
            // 
            this.txtZodiacSign.Font = new System.Drawing.Font("新細明體", 14F);
            this.txtZodiacSign.Location = new System.Drawing.Point(172, 189);
            this.txtZodiacSign.Name = "txtZodiacSign";
            this.txtZodiacSign.Size = new System.Drawing.Size(145, 30);
            this.txtZodiacSign.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 14F);
            this.label4.Location = new System.Drawing.Point(49, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "星座:";
            // 
            // btnHi
            // 
            this.btnHi.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.btnHi.Location = new System.Drawing.Point(77, 274);
            this.btnHi.Name = "btnHi";
            this.btnHi.Size = new System.Drawing.Size(123, 51);
            this.btnHi.TabIndex = 8;
            this.btnHi.Text = "Say Hi";
            this.btnHi.UseVisualStyleBackColor = true;
            this.btnHi.Click += new System.EventHandler(this.OnBtnHi_Click);
            // 
            // btnHello
            // 
            this.btnHello.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.btnHello.Location = new System.Drawing.Point(264, 274);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(123, 51);
            this.btnHello.TabIndex = 9;
            this.btnHello.Text = "Say Hello";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.OnBtnHello_Click);
            // 
            // Form_01_Hello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 380);
            this.Controls.Add(this.btnHello);
            this.Controls.Add(this.btnHi);
            this.Controls.Add(this.txtZodiacSign);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEnName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtChName);
            this.Controls.Add(this.label1);
            this.Name = "Form_01_Hello";
            this.Text = "Hello! Welcome to C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChName;
        private System.Windows.Forms.TextBox txtEnName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtZodiacSign;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnHi;
        private System.Windows.Forms.Button btnHello;
    }
}

