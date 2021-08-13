
namespace Ordersystem
{
    partial class StartOrder
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtnHot = new System.Windows.Forms.RadioButton();
            this.radioBtnWarm = new System.Windows.Forms.RadioButton();
            this.radioBtnIce = new System.Windows.Forms.RadioButton();
            this.AddBtn = new System.Windows.Forms.Button();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxMark = new System.Windows.Forms.TextBox();
            this.NumUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.LableOrderList = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.NameBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.dataGridViewMenu = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.radioBtnBig = new System.Windows.Forms.RadioButton();
            this.radioBtnMiddle = new System.Windows.Forms.RadioButton();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.NameOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.need = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CupUp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "品名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "單價";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(449, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "數量";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "備註";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtnHot);
            this.groupBox1.Controls.Add(this.radioBtnWarm);
            this.groupBox1.Controls.Add(this.radioBtnIce);
            this.groupBox1.Location = new System.Drawing.Point(617, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 85);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "冰度";
            // 
            // radioBtnHot
            // 
            this.radioBtnHot.AutoSize = true;
            this.radioBtnHot.Location = new System.Drawing.Point(121, 45);
            this.radioBtnHot.Name = "radioBtnHot";
            this.radioBtnHot.Size = new System.Drawing.Size(61, 36);
            this.radioBtnHot.TabIndex = 2;
            this.radioBtnHot.TabStop = true;
            this.radioBtnHot.Text = "熱";
            this.radioBtnHot.UseVisualStyleBackColor = true;
            // 
            // radioBtnWarm
            // 
            this.radioBtnWarm.AutoSize = true;
            this.radioBtnWarm.Location = new System.Drawing.Point(59, 45);
            this.radioBtnWarm.Name = "radioBtnWarm";
            this.radioBtnWarm.Size = new System.Drawing.Size(61, 36);
            this.radioBtnWarm.TabIndex = 1;
            this.radioBtnWarm.TabStop = true;
            this.radioBtnWarm.Text = "溫";
            this.radioBtnWarm.UseVisualStyleBackColor = true;
            // 
            // radioBtnIce
            // 
            this.radioBtnIce.AutoSize = true;
            this.radioBtnIce.Location = new System.Drawing.Point(6, 45);
            this.radioBtnIce.Name = "radioBtnIce";
            this.radioBtnIce.Size = new System.Drawing.Size(61, 36);
            this.radioBtnIce.TabIndex = 0;
            this.radioBtnIce.TabStop = true;
            this.radioBtnIce.Text = "冰";
            this.radioBtnIce.UseVisualStyleBackColor = true;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(1074, 44);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(131, 49);
            this.AddBtn.TabIndex = 6;
            this.AddBtn.Text = "加入餐點";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.textBoxPrice.Location = new System.Drawing.Point(339, 16);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(117, 41);
            this.textBoxPrice.TabIndex = 8;
            // 
            // textBoxMark
            // 
            this.textBoxMark.Location = new System.Drawing.Point(71, 63);
            this.textBoxMark.Name = "textBoxMark";
            this.textBoxMark.Size = new System.Drawing.Size(540, 41);
            this.textBoxMark.TabIndex = 9;
            // 
            // NumUpDown
            // 
            this.NumUpDown.ForeColor = System.Drawing.Color.DarkRed;
            this.NumUpDown.Location = new System.Drawing.Point(515, 16);
            this.NumUpDown.Name = "NumUpDown";
            this.NumUpDown.Size = new System.Drawing.Size(96, 41);
            this.NumUpDown.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(811, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 32);
            this.label6.TabIndex = 14;
            this.label6.Text = "餐點明細表";
            // 
            // LableOrderList
            // 
            this.LableOrderList.BackColor = System.Drawing.Color.Bisque;
            this.LableOrderList.Location = new System.Drawing.Point(823, 159);
            this.LableOrderList.Multiline = true;
            this.LableOrderList.Name = "LableOrderList";
            this.LableOrderList.ReadOnly = true;
            this.LableOrderList.Size = new System.Drawing.Size(383, 442);
            this.LableOrderList.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(824, 626);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 32);
            this.label7.TabIndex = 16;
            this.label7.Text = "總金額";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.ForeColor = System.Drawing.Color.Red;
            this.textBoxTotal.Location = new System.Drawing.Point(920, 617);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(189, 41);
            this.textBoxTotal.TabIndex = 17;
            this.textBoxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // NameBtn
            // 
            this.NameBtn.Location = new System.Drawing.Point(71, 10);
            this.NameBtn.Name = "NameBtn";
            this.NameBtn.Size = new System.Drawing.Size(218, 49);
            this.NameBtn.TabIndex = 18;
            this.NameBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NameBtn.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 32);
            this.label8.TabIndex = 19;
            this.label8.Text = "已選餐點";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(1126, 612);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(80, 49);
            this.submitBtn.TabIndex = 20;
            this.submitBtn.Text = "送出";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // dataGridViewMenu
            // 
            this.dataGridViewMenu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridViewMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMenu.Location = new System.Drawing.Point(18, 124);
            this.dataGridViewMenu.Name = "dataGridViewMenu";
            this.dataGridViewMenu.RowHeadersWidth = 51;
            this.dataGridViewMenu.RowTemplate.Height = 27;
            this.dataGridViewMenu.Size = new System.Drawing.Size(781, 235);
            this.dataGridViewMenu.TabIndex = 12;
            this.dataGridViewMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMenu_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.radioBtnBig);
            this.groupBox2.Controls.Add(this.radioBtnMiddle);
            this.groupBox2.Location = new System.Drawing.Point(805, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 92);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "飲料升級";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(197, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 25);
            this.label10.TabIndex = 22;
            this.label10.Text = "+10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(80, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "+5";
            // 
            // radioBtnBig
            // 
            this.radioBtnBig.AutoSize = true;
            this.radioBtnBig.Location = new System.Drawing.Point(121, 45);
            this.radioBtnBig.Name = "radioBtnBig";
            this.radioBtnBig.Size = new System.Drawing.Size(86, 36);
            this.radioBtnBig.TabIndex = 2;
            this.radioBtnBig.TabStop = true;
            this.radioBtnBig.Text = "大杯";
            this.radioBtnBig.UseVisualStyleBackColor = true;
            // 
            // radioBtnMiddle
            // 
            this.radioBtnMiddle.AutoSize = true;
            this.radioBtnMiddle.Location = new System.Drawing.Point(6, 45);
            this.radioBtnMiddle.Name = "radioBtnMiddle";
            this.radioBtnMiddle.Size = new System.Drawing.Size(86, 36);
            this.radioBtnMiddle.TabIndex = 0;
            this.radioBtnMiddle.TabStop = true;
            this.radioBtnMiddle.Text = "中杯";
            this.radioBtnMiddle.UseVisualStyleBackColor = true;
            // 
            // ProductName
            // 
            this.ProductName.Frozen = true;
            this.ProductName.HeaderText = "品名";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 120;
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameOrder,
            this.category,
            this.need,
            this.OrderPrice,
            this.OrderNum,
            this.CupUp,
            this.OrderSubTotal});
            this.dataGridViewOrder.Location = new System.Drawing.Point(18, 397);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.RowHeadersWidth = 51;
            this.dataGridViewOrder.RowTemplate.Height = 27;
            this.dataGridViewOrder.Size = new System.Drawing.Size(781, 264);
            this.dataGridViewOrder.TabIndex = 21;
            // 
            // NameOrder
            // 
            this.NameOrder.HeaderText = "品名";
            this.NameOrder.MinimumWidth = 6;
            this.NameOrder.Name = "NameOrder";
            this.NameOrder.Width = 120;
            // 
            // category
            // 
            this.category.HeaderText = "類別";
            this.category.MinimumWidth = 6;
            this.category.Name = "category";
            this.category.Width = 110;
            // 
            // need
            // 
            this.need.HeaderText = "需求";
            this.need.MinimumWidth = 6;
            this.need.Name = "need";
            this.need.Width = 120;
            // 
            // OrderPrice
            // 
            this.OrderPrice.HeaderText = "單價";
            this.OrderPrice.MinimumWidth = 6;
            this.OrderPrice.Name = "OrderPrice";
            this.OrderPrice.Width = 110;
            // 
            // OrderNum
            // 
            this.OrderNum.HeaderText = "數量";
            this.OrderNum.MinimumWidth = 6;
            this.OrderNum.Name = "OrderNum";
            this.OrderNum.Width = 95;
            // 
            // CupUp
            // 
            this.CupUp.HeaderText = "升級";
            this.CupUp.MinimumWidth = 6;
            this.CupUp.Name = "CupUp";
            this.CupUp.Width = 125;
            // 
            // OrderSubTotal
            // 
            this.OrderSubTotal.HeaderText = "小計";
            this.OrderSubTotal.MinimumWidth = 6;
            this.OrderSubTotal.Name = "OrderSubTotal";
            this.OrderSubTotal.Width = 110;
            // 
            // StartOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 680);
            this.Controls.Add(this.dataGridViewOrder);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NameBtn);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LableOrderList);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewMenu);
            this.Controls.Add(this.NumUpDown);
            this.Controls.Add(this.textBoxMark);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微軟正黑體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "StartOrder";
            this.Text = "開始點餐";
            this.Load += new System.EventHandler(this.StartOrder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxMark;
        private System.Windows.Forms.NumericUpDown NumUpDown;
        private System.Windows.Forms.RadioButton radioBtnHot;
        private System.Windows.Forms.RadioButton radioBtnWarm;
        private System.Windows.Forms.RadioButton radioBtnIce;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox LableOrderList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Button NameBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.DataGridView dataGridViewMenu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioBtnBig;
        private System.Windows.Forms.RadioButton radioBtnMiddle;
        private new System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn category;
        private System.Windows.Forms.DataGridViewTextBoxColumn need;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn CupUp;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderSubTotal;
    }
}