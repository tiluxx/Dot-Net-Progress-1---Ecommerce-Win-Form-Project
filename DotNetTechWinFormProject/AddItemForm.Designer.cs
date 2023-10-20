namespace DotNetTechWinFormProject
{
    partial class AddItemForm
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
            this.itemGrd = new System.Windows.Forms.DataGridView();
            this.itemOriginCB = new System.Windows.Forms.ComboBox();
            this.itemUnitSizeCB = new System.Windows.Forms.ComboBox();
            this.itemPriceNum = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.itemQuanNum = new System.Windows.Forms.NumericUpDown();
            this.itemBrandTxt = new System.Windows.Forms.TextBox();
            this.itemSizeTxt = new System.Windows.Forms.TextBox();
            this.itemNameTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.itemIdTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.productNameLbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.itemInfoGroup = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.itemGrd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPriceNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemQuanNum)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.itemInfoGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemGrd
            // 
            this.itemGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemGrd.Location = new System.Drawing.Point(6, 21);
            this.itemGrd.Name = "itemGrd";
            this.itemGrd.RowHeadersWidth = 51;
            this.itemGrd.RowTemplate.Height = 24;
            this.itemGrd.Size = new System.Drawing.Size(895, 245);
            this.itemGrd.TabIndex = 0;
            this.itemGrd.Click += new System.EventHandler(this.productGrd_Click);
            // 
            // itemOriginCB
            // 
            this.itemOriginCB.FormattingEnabled = true;
            this.itemOriginCB.Location = new System.Drawing.Point(414, 49);
            this.itemOriginCB.Name = "itemOriginCB";
            this.itemOriginCB.Size = new System.Drawing.Size(207, 24);
            this.itemOriginCB.TabIndex = 3;
            // 
            // itemUnitSizeCB
            // 
            this.itemUnitSizeCB.FormattingEnabled = true;
            this.itemUnitSizeCB.Items.AddRange(new object[] {
            "m",
            "dm",
            "cm",
            "mm",
            "inches"});
            this.itemUnitSizeCB.Location = new System.Drawing.Point(251, 49);
            this.itemUnitSizeCB.Name = "itemUnitSizeCB";
            this.itemUnitSizeCB.Size = new System.Drawing.Size(66, 24);
            this.itemUnitSizeCB.TabIndex = 3;
            // 
            // itemPriceNum
            // 
            this.itemPriceNum.Location = new System.Drawing.Point(740, 49);
            this.itemPriceNum.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.itemPriceNum.Name = "itemPriceNum";
            this.itemPriceNum.Size = new System.Drawing.Size(118, 22);
            this.itemPriceNum.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(864, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "VND";
            // 
            // itemQuanNum
            // 
            this.itemQuanNum.Location = new System.Drawing.Point(740, 21);
            this.itemQuanNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.itemQuanNum.Name = "itemQuanNum";
            this.itemQuanNum.Size = new System.Drawing.Size(161, 22);
            this.itemQuanNum.TabIndex = 1;
            // 
            // itemBrandTxt
            // 
            this.itemBrandTxt.Location = new System.Drawing.Point(414, 21);
            this.itemBrandTxt.Name = "itemBrandTxt";
            this.itemBrandTxt.Size = new System.Drawing.Size(207, 22);
            this.itemBrandTxt.TabIndex = 8;
            // 
            // itemSizeTxt
            // 
            this.itemSizeTxt.Location = new System.Drawing.Point(110, 49);
            this.itemSizeTxt.Name = "itemSizeTxt";
            this.itemSizeTxt.Size = new System.Drawing.Size(135, 22);
            this.itemSizeTxt.TabIndex = 7;
            // 
            // itemNameTxt
            // 
            this.itemNameTxt.Location = new System.Drawing.Point(110, 21);
            this.itemNameTxt.Name = "itemNameTxt";
            this.itemNameTxt.Size = new System.Drawing.Size(207, 22);
            this.itemNameTxt.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Brand";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(673, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quantity";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(514, 21);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(95, 31);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(413, 21);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(95, 31);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(312, 21);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(95, 31);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(211, 21);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(95, 31);
            this.editBtn.TabIndex = 1;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(110, 21);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(95, 31);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(673, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Price";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.itemIdTxt);
            this.groupBox1.Controls.Add(this.cancelBtn);
            this.groupBox1.Controls.Add(this.saveBtn);
            this.groupBox1.Controls.Add(this.deleteBtn);
            this.groupBox1.Controls.Add(this.editBtn);
            this.groupBox1.Controls.Add(this.addBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(907, 58);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Function";
            // 
            // itemIdTxt
            // 
            this.itemIdTxt.Location = new System.Drawing.Point(801, 21);
            this.itemIdTxt.Name = "itemIdTxt";
            this.itemIdTxt.Size = new System.Drawing.Size(100, 22);
            this.itemIdTxt.TabIndex = 5;
            this.itemIdTxt.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Origin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item Size";
            // 
            // productNameLbl
            // 
            this.productNameLbl.AutoSize = true;
            this.productNameLbl.Location = new System.Drawing.Point(6, 24);
            this.productNameLbl.Name = "productNameLbl";
            this.productNameLbl.Size = new System.Drawing.Size(72, 16);
            this.productNameLbl.TabIndex = 0;
            this.productNameLbl.Text = "Item Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.itemGrd);
            this.groupBox2.Location = new System.Drawing.Point(12, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(907, 272);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Item list";
            // 
            // itemInfoGroup
            // 
            this.itemInfoGroup.Controls.Add(this.itemOriginCB);
            this.itemInfoGroup.Controls.Add(this.itemUnitSizeCB);
            this.itemInfoGroup.Controls.Add(this.itemPriceNum);
            this.itemInfoGroup.Controls.Add(this.label6);
            this.itemInfoGroup.Controls.Add(this.itemQuanNum);
            this.itemInfoGroup.Controls.Add(this.itemBrandTxt);
            this.itemInfoGroup.Controls.Add(this.itemSizeTxt);
            this.itemInfoGroup.Controls.Add(this.itemNameTxt);
            this.itemInfoGroup.Controls.Add(this.label5);
            this.itemInfoGroup.Controls.Add(this.label4);
            this.itemInfoGroup.Controls.Add(this.label3);
            this.itemInfoGroup.Controls.Add(this.label2);
            this.itemInfoGroup.Controls.Add(this.label1);
            this.itemInfoGroup.Controls.Add(this.productNameLbl);
            this.itemInfoGroup.Location = new System.Drawing.Point(12, 12);
            this.itemInfoGroup.Name = "itemInfoGroup";
            this.itemInfoGroup.Size = new System.Drawing.Size(907, 84);
            this.itemInfoGroup.TabIndex = 3;
            this.itemInfoGroup.TabStop = false;
            this.itemInfoGroup.Text = "Item information";
            // 
            // AddItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.itemInfoGroup);
            this.Name = "AddItemForm";
            this.Text = "AddItemForm";
            this.Load += new System.EventHandler(this.AddItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemGrd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemPriceNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemQuanNum)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.itemInfoGroup.ResumeLayout(false);
            this.itemInfoGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView itemGrd;
        private System.Windows.Forms.ComboBox itemOriginCB;
        private System.Windows.Forms.ComboBox itemUnitSizeCB;
        private System.Windows.Forms.NumericUpDown itemPriceNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown itemQuanNum;
        private System.Windows.Forms.TextBox itemBrandTxt;
        private System.Windows.Forms.TextBox itemSizeTxt;
        private System.Windows.Forms.TextBox itemNameTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox itemIdTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label productNameLbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox itemInfoGroup;
    }
}