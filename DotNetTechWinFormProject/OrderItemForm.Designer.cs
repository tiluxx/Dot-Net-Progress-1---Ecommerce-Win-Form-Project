namespace DotNetTechWinFormProject
{
    partial class OrderItemForm
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
            this.changeItemQuanBtn = new System.Windows.Forms.Button();
            this.itemIdTxt = new System.Windows.Forms.TextBox();
            this.itemQuanUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.customerIdSelectedTxt = new System.Windows.Forms.TextBox();
            this.customerNameSelectedTxt = new System.Windows.Forms.TextBox();
            this.orderBtn = new System.Windows.Forms.Button();
            this.itemOrderList = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.itemCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.customerList = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.itemQuanUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemOrderList)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerList)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // changeItemQuanBtn
            // 
            this.changeItemQuanBtn.Location = new System.Drawing.Point(313, 164);
            this.changeItemQuanBtn.Name = "changeItemQuanBtn";
            this.changeItemQuanBtn.Size = new System.Drawing.Size(53, 23);
            this.changeItemQuanBtn.TabIndex = 15;
            this.changeItemQuanBtn.Text = "OK";
            this.changeItemQuanBtn.UseVisualStyleBackColor = true;
            this.changeItemQuanBtn.Click += new System.EventHandler(this.changeItemQuanBtn_Click);
            // 
            // itemIdTxt
            // 
            this.itemIdTxt.Location = new System.Drawing.Point(140, 164);
            this.itemIdTxt.Name = "itemIdTxt";
            this.itemIdTxt.Size = new System.Drawing.Size(76, 22);
            this.itemIdTxt.TabIndex = 14;
            this.itemIdTxt.Visible = false;
            // 
            // itemQuanUpDown
            // 
            this.itemQuanUpDown.Location = new System.Drawing.Point(222, 164);
            this.itemQuanUpDown.Name = "itemQuanUpDown";
            this.itemQuanUpDown.Size = new System.Drawing.Size(85, 22);
            this.itemQuanUpDown.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(85, 138);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(222, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Click a item row to edit order quantity";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 166);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Item Quantity";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // customerIdSelectedTxt
            // 
            this.customerIdSelectedTxt.Location = new System.Drawing.Point(106, 81);
            this.customerIdSelectedTxt.Name = "customerIdSelectedTxt";
            this.customerIdSelectedTxt.Size = new System.Drawing.Size(260, 22);
            this.customerIdSelectedTxt.TabIndex = 9;
            // 
            // customerNameSelectedTxt
            // 
            this.customerNameSelectedTxt.Location = new System.Drawing.Point(106, 53);
            this.customerNameSelectedTxt.Name = "customerNameSelectedTxt";
            this.customerNameSelectedTxt.Size = new System.Drawing.Size(260, 22);
            this.customerNameSelectedTxt.TabIndex = 8;
            // 
            // orderBtn
            // 
            this.orderBtn.Location = new System.Drawing.Point(137, 381);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(111, 35);
            this.orderBtn.TabIndex = 7;
            this.orderBtn.Text = "Order";
            this.orderBtn.UseVisualStyleBackColor = true;
            this.orderBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // itemOrderList
            // 
            this.itemOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemOrderList.Location = new System.Drawing.Point(6, 192);
            this.itemOrderList.Name = "itemOrderList";
            this.itemOrderList.RowHeadersWidth = 51;
            this.itemOrderList.RowTemplate.Height = 24;
            this.itemOrderList.Size = new System.Drawing.Size(360, 183);
            this.itemOrderList.TabIndex = 6;
            this.itemOrderList.Click += new System.EventHandler(this.itemOrderList_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(134, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Item ordered";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer ID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer information";
            // 
            // itemCheckedListBox
            // 
            this.itemCheckedListBox.FormattingEnabled = true;
            this.itemCheckedListBox.Location = new System.Drawing.Point(6, 21);
            this.itemCheckedListBox.Name = "itemCheckedListBox";
            this.itemCheckedListBox.Size = new System.Drawing.Size(356, 395);
            this.itemCheckedListBox.TabIndex = 0;
            this.itemCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.itemCheckedListBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.itemCheckedListBox);
            this.groupBox2.Location = new System.Drawing.Point(290, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 426);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item list";
            // 
            // customerList
            // 
            this.customerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerList.Location = new System.Drawing.Point(6, 21);
            this.customerList.Name = "customerList";
            this.customerList.RowHeadersWidth = 51;
            this.customerList.RowTemplate.Height = 24;
            this.customerList.Size = new System.Drawing.Size(260, 399);
            this.customerList.TabIndex = 0;
            this.customerList.Click += new System.EventHandler(this.agentList_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.changeItemQuanBtn);
            this.groupBox3.Controls.Add(this.itemIdTxt);
            this.groupBox3.Controls.Add(this.itemQuanUpDown);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.customerIdSelectedTxt);
            this.groupBox3.Controls.Add(this.customerNameSelectedTxt);
            this.groupBox3.Controls.Add(this.orderBtn);
            this.groupBox3.Controls.Add(this.itemOrderList);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(664, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(372, 426);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order detail";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.customerList);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 426);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer list";
            // 
            // OrderItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "OrderItemForm";
            this.Text = "OrderItemForm";
            this.Load += new System.EventHandler(this.OrderItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemQuanUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemOrderList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerList)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button changeItemQuanBtn;
        private System.Windows.Forms.TextBox itemIdTxt;
        private System.Windows.Forms.NumericUpDown itemQuanUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox customerIdSelectedTxt;
        private System.Windows.Forms.TextBox customerNameSelectedTxt;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.DataGridView itemOrderList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox itemCheckedListBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView customerList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}