namespace DotNetTechWinFormProject
{
    partial class OrderViewForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.orderGrd = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.orderIdTxt = new System.Windows.Forms.TextBox();
            this.printPreviewBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderGrd)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.orderGrd);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 426);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order list";
            // 
            // orderGrd
            // 
            this.orderGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderGrd.Location = new System.Drawing.Point(6, 21);
            this.orderGrd.Name = "orderGrd";
            this.orderGrd.RowHeadersWidth = 51;
            this.orderGrd.RowTemplate.Height = 24;
            this.orderGrd.Size = new System.Drawing.Size(547, 399);
            this.orderGrd.TabIndex = 0;
            this.orderGrd.Click += new System.EventHandler(this.orderGrd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.orderIdTxt);
            this.groupBox2.Controls.Add(this.printPreviewBtn);
            this.groupBox2.Location = new System.Drawing.Point(577, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 426);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Function";
            // 
            // orderIdTxt
            // 
            this.orderIdTxt.Location = new System.Drawing.Point(6, 65);
            this.orderIdTxt.Name = "orderIdTxt";
            this.orderIdTxt.Size = new System.Drawing.Size(100, 22);
            this.orderIdTxt.TabIndex = 1;
            this.orderIdTxt.Visible = false;
            // 
            // printPreviewBtn
            // 
            this.printPreviewBtn.Location = new System.Drawing.Point(6, 21);
            this.printPreviewBtn.Name = "printPreviewBtn";
            this.printPreviewBtn.Size = new System.Drawing.Size(199, 38);
            this.printPreviewBtn.TabIndex = 0;
            this.printPreviewBtn.Text = "Print Order";
            this.printPreviewBtn.UseVisualStyleBackColor = true;
            this.printPreviewBtn.Click += new System.EventHandler(this.printPreviewBtn_Click);
            // 
            // OrderViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "OrderViewForm";
            this.Text = "OrderViewForm";
            this.Load += new System.EventHandler(this.OrderViewForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderGrd)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView orderGrd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox orderIdTxt;
        private System.Windows.Forms.Button printPreviewBtn;
    }
}