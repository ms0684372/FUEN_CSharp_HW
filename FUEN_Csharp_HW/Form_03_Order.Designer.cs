namespace FUEN_Csharp_HW
{
    partial class Form_03_Order
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
            this.groupMenu = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBeer = new System.Windows.Forms.Button();
            this.btnTequila = new System.Windows.Forms.Button();
            this.btnWhisky = new System.Windows.Forms.Button();
            this.btnWine = new System.Windows.Forms.Button();
            this.groupOrderList = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.labelOrderList = new System.Windows.Forms.Label();
            this.groupPrice = new System.Windows.Forms.GroupBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.groupPayment = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreditCard = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.groupMenu.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupOrderList.SuspendLayout();
            this.groupPrice.SuspendLayout();
            this.groupPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupMenu
            // 
            this.groupMenu.Controls.Add(this.flowLayoutPanel1);
            this.groupMenu.Font = new System.Drawing.Font("新細明體", 14F);
            this.groupMenu.Location = new System.Drawing.Point(25, 57);
            this.groupMenu.Name = "groupMenu";
            this.groupMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupMenu.Size = new System.Drawing.Size(216, 331);
            this.groupMenu.TabIndex = 1;
            this.groupMenu.TabStop = false;
            this.groupMenu.Text = "菜單 Menu";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.btnBeer);
            this.flowLayoutPanel1.Controls.Add(this.btnTequila);
            this.flowLayoutPanel1.Controls.Add(this.btnWhisky);
            this.flowLayoutPanel1.Controls.Add(this.btnWine);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 26);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(210, 302);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // btnBeer
            // 
            this.btnBeer.Location = new System.Drawing.Point(8, 8);
            this.btnBeer.Name = "btnBeer";
            this.btnBeer.Size = new System.Drawing.Size(85, 120);
            this.btnBeer.TabIndex = 2;
            this.btnBeer.Text = "啤酒\nBeer\nNT$ 120";
            this.btnBeer.UseVisualStyleBackColor = true;
            this.btnBeer.Click += new System.EventHandler(this.btnBeer_Click);
            // 
            // btnTequila
            // 
            this.btnTequila.Location = new System.Drawing.Point(8, 134);
            this.btnTequila.Name = "btnTequila";
            this.btnTequila.Size = new System.Drawing.Size(85, 120);
            this.btnTequila.TabIndex = 2;
            this.btnTequila.Text = "龍舌蘭\nTequila\nNT$ 180";
            this.btnTequila.UseVisualStyleBackColor = true;
            this.btnTequila.Click += new System.EventHandler(this.btnTequila_Click);
            // 
            // btnWhisky
            // 
            this.btnWhisky.Location = new System.Drawing.Point(99, 8);
            this.btnWhisky.Name = "btnWhisky";
            this.btnWhisky.Size = new System.Drawing.Size(85, 120);
            this.btnWhisky.TabIndex = 2;
            this.btnWhisky.Text = "威士忌\nWhisky\nNT$ 350";
            this.btnWhisky.UseVisualStyleBackColor = true;
            this.btnWhisky.Click += new System.EventHandler(this.btnWhisky_Click);
            // 
            // btnWine
            // 
            this.btnWine.Location = new System.Drawing.Point(99, 134);
            this.btnWine.Name = "btnWine";
            this.btnWine.Size = new System.Drawing.Size(85, 120);
            this.btnWine.TabIndex = 2;
            this.btnWine.Text = "紅酒\nWine\nNT$ 320";
            this.btnWine.UseVisualStyleBackColor = true;
            this.btnWine.Click += new System.EventHandler(this.btnWine_Click);
            // 
            // groupOrderList
            // 
            this.groupOrderList.Controls.Add(this.btnClear);
            this.groupOrderList.Controls.Add(this.labelOrderList);
            this.groupOrderList.Font = new System.Drawing.Font("新細明體", 14F);
            this.groupOrderList.Location = new System.Drawing.Point(507, 57);
            this.groupOrderList.Name = "groupOrderList";
            this.groupOrderList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupOrderList.Size = new System.Drawing.Size(273, 331);
            this.groupOrderList.TabIndex = 2;
            this.groupOrderList.TabStop = false;
            this.groupOrderList.Text = "購物清單 List";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(180, 288);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 43);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.OnBtnClear_Click);
            // 
            // labelOrderList
            // 
            this.labelOrderList.BackColor = System.Drawing.Color.White;
            this.labelOrderList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelOrderList.Location = new System.Drawing.Point(6, 26);
            this.labelOrderList.Name = "labelOrderList";
            this.labelOrderList.Size = new System.Drawing.Size(261, 254);
            this.labelOrderList.TabIndex = 0;
            this.labelOrderList.Text = "尚未點餐";
            this.labelOrderList.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupPrice
            // 
            this.groupPrice.Controls.Add(this.labelPrice);
            this.groupPrice.Font = new System.Drawing.Font("新細明體", 14F);
            this.groupPrice.Location = new System.Drawing.Point(255, 57);
            this.groupPrice.Name = "groupPrice";
            this.groupPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupPrice.Size = new System.Drawing.Size(233, 85);
            this.groupPrice.TabIndex = 2;
            this.groupPrice.TabStop = false;
            this.groupPrice.Text = "總金額 Total Price";
            // 
            // labelPrice
            // 
            this.labelPrice.BackColor = System.Drawing.Color.Black;
            this.labelPrice.ForeColor = System.Drawing.Color.White;
            this.labelPrice.Location = new System.Drawing.Point(6, 34);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(221, 39);
            this.labelPrice.TabIndex = 0;
            this.labelPrice.Text = "NT$ 0";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupPayment
            // 
            this.groupPayment.Controls.Add(this.btnCreditCard);
            this.groupPayment.Controls.Add(this.btnCash);
            this.groupPayment.Font = new System.Drawing.Font("新細明體", 14F);
            this.groupPayment.Location = new System.Drawing.Point(255, 167);
            this.groupPayment.Name = "groupPayment";
            this.groupPayment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupPayment.Size = new System.Drawing.Size(233, 114);
            this.groupPayment.TabIndex = 3;
            this.groupPayment.TabStop = false;
            this.groupPayment.Text = "付款方式";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("新細明體", 10F);
            this.label1.Location = new System.Drawing.Point(369, 262);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "信用卡享九折優惠!";
            // 
            // btnCreditCard
            // 
            this.btnCreditCard.Location = new System.Drawing.Point(124, 42);
            this.btnCreditCard.Name = "btnCreditCard";
            this.btnCreditCard.Size = new System.Drawing.Size(87, 43);
            this.btnCreditCard.TabIndex = 1;
            this.btnCreditCard.Text = "信用卡";
            this.btnCreditCard.UseVisualStyleBackColor = true;
            this.btnCreditCard.Click += new System.EventHandler(this.OnBtnCreditCard_Click);
            // 
            // btnCash
            // 
            this.btnCash.Location = new System.Drawing.Point(19, 42);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(87, 43);
            this.btnCash.TabIndex = 0;
            this.btnCash.Text = "現金";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.OnBtnCash_Click);
            // 
            // Form_03_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupPayment);
            this.Controls.Add(this.groupPrice);
            this.Controls.Add(this.groupOrderList);
            this.Controls.Add(this.groupMenu);
            this.Font = new System.Drawing.Font("新細明體", 9F);
            this.Name = "Form_03_Order";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Form_03_Order";
            this.groupMenu.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupOrderList.ResumeLayout(false);
            this.groupPrice.ResumeLayout(false);
            this.groupPayment.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupMenu;
        private System.Windows.Forms.GroupBox groupOrderList;
        private System.Windows.Forms.GroupBox groupPrice;
        private System.Windows.Forms.Button btnBeer;
        private System.Windows.Forms.GroupBox groupPayment;
        private System.Windows.Forms.Button btnCreditCard;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnWine;
        private System.Windows.Forms.Button btnWhisky;
        private System.Windows.Forms.Button btnTequila;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label labelOrderList;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Button btnClear;
    }
}