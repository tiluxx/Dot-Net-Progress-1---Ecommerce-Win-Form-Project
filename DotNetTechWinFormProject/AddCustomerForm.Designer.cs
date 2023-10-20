namespace DotNetTechWinFormProject
{
    partial class AddCustomerForm
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
            this.customerGrd = new System.Windows.Forms.DataGridView();
            this.addBtn = new System.Windows.Forms.Button();
            this.customerAddressTxt = new System.Windows.Forms.TextBox();
            this.customerNameTxt = new System.Windows.Forms.TextBox();
            this.customerIdTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.customerInfoGroup = new System.Windows.Forms.GroupBox();
            this.productNameLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.customerGrd)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.customerInfoGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerGrd
            // 
            this.customerGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerGrd.Location = new System.Drawing.Point(6, 21);
            this.customerGrd.Name = "customerGrd";
            this.customerGrd.RowHeadersWidth = 51;
            this.customerGrd.RowTemplate.Height = 24;
            this.customerGrd.Size = new System.Drawing.Size(783, 292);
            this.customerGrd.TabIndex = 0;
            this.customerGrd.Click += new System.EventHandler(this.customerGrd_Click);
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
            // customerAddressTxt
            // 
            this.customerAddressTxt.Location = new System.Drawing.Point(426, 19);
            this.customerAddressTxt.Name = "customerAddressTxt";
            this.customerAddressTxt.Size = new System.Drawing.Size(363, 22);
            this.customerAddressTxt.TabIndex = 8;
            // 
            // customerNameTxt
            // 
            this.customerNameTxt.Location = new System.Drawing.Point(99, 49);
            this.customerNameTxt.Name = "customerNameTxt";
            this.customerNameTxt.Size = new System.Drawing.Size(229, 22);
            this.customerNameTxt.TabIndex = 7;
            // 
            // customerIdTxt
            // 
            this.customerIdTxt.Location = new System.Drawing.Point(99, 21);
            this.customerIdTxt.Name = "customerIdTxt";
            this.customerIdTxt.Size = new System.Drawing.Size(229, 22);
            this.customerIdTxt.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Address";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.customerGrd);
            this.groupBox2.Location = new System.Drawing.Point(12, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(795, 319);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer list";
            // 
            // customerInfoGroup
            // 
            this.customerInfoGroup.Controls.Add(this.customerAddressTxt);
            this.customerInfoGroup.Controls.Add(this.customerNameTxt);
            this.customerInfoGroup.Controls.Add(this.customerIdTxt);
            this.customerInfoGroup.Controls.Add(this.label5);
            this.customerInfoGroup.Controls.Add(this.label1);
            this.customerInfoGroup.Controls.Add(this.productNameLbl);
            this.customerInfoGroup.Location = new System.Drawing.Point(12, 12);
            this.customerInfoGroup.Name = "customerInfoGroup";
            this.customerInfoGroup.Size = new System.Drawing.Size(795, 86);
            this.customerInfoGroup.TabIndex = 6;
            this.customerInfoGroup.TabStop = false;
            this.customerInfoGroup.Text = "Customer information";
            // 
            // productNameLbl
            // 
            this.productNameLbl.AutoSize = true;
            this.productNameLbl.Location = new System.Drawing.Point(6, 49);
            this.productNameLbl.Name = "productNameLbl";
            this.productNameLbl.Size = new System.Drawing.Size(44, 16);
            this.productNameLbl.TabIndex = 0;
            this.productNameLbl.Text = "Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cancelBtn);
            this.groupBox1.Controls.Add(this.saveBtn);
            this.groupBox1.Controls.Add(this.deleteBtn);
            this.groupBox1.Controls.Add(this.editBtn);
            this.groupBox1.Controls.Add(this.addBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(795, 67);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Function";
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 501);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.customerInfoGroup);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddCustomerForm";
            this.Text = "AddCustomerForm";
            this.Load += new System.EventHandler(this.AddCustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerGrd)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.customerInfoGroup.ResumeLayout(false);
            this.customerInfoGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView customerGrd;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox customerAddressTxt;
        private System.Windows.Forms.TextBox customerNameTxt;
        private System.Windows.Forms.TextBox customerIdTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox customerInfoGroup;
        private System.Windows.Forms.Label productNameLbl;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}