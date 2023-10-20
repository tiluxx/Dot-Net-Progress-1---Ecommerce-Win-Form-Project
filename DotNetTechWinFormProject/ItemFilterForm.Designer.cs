namespace DotNetTechWinFormProject
{
    partial class ItemFilterForm
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
            this.viewOptionsGrp = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.customerIdTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.itemIdTxt = new System.Windows.Forms.TextBox();
            this.customerPurchasedItemsCheckBox = new System.Windows.Forms.RadioButton();
            this.itemPurchasedByCustomersCheckBox = new System.Windows.Forms.RadioButton();
            this.bestSellingCheckBox = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.itemGrd = new System.Windows.Forms.DataGridView();
            this.viewOptionsGrp.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // viewOptionsGrp
            // 
            this.viewOptionsGrp.Controls.Add(this.label2);
            this.viewOptionsGrp.Controls.Add(this.customerIdTxt);
            this.viewOptionsGrp.Controls.Add(this.label1);
            this.viewOptionsGrp.Controls.Add(this.itemIdTxt);
            this.viewOptionsGrp.Controls.Add(this.customerPurchasedItemsCheckBox);
            this.viewOptionsGrp.Controls.Add(this.itemPurchasedByCustomersCheckBox);
            this.viewOptionsGrp.Controls.Add(this.bestSellingCheckBox);
            this.viewOptionsGrp.Location = new System.Drawing.Point(12, 12);
            this.viewOptionsGrp.Name = "viewOptionsGrp";
            this.viewOptionsGrp.Size = new System.Drawing.Size(915, 103);
            this.viewOptionsGrp.TabIndex = 2;
            this.viewOptionsGrp.TabStop = false;
            this.viewOptionsGrp.Text = "View options";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(424, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Customer ID to filter";
            // 
            // customerIdTxt
            // 
            this.customerIdTxt.Location = new System.Drawing.Point(250, 77);
            this.customerIdTxt.Name = "customerIdTxt";
            this.customerIdTxt.Size = new System.Drawing.Size(168, 22);
            this.customerIdTxt.TabIndex = 5;
            this.customerIdTxt.TextChanged += new System.EventHandler(this.customerIdTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(424, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Item ID to filter";
            // 
            // itemIdTxt
            // 
            this.itemIdTxt.Location = new System.Drawing.Point(250, 48);
            this.itemIdTxt.Name = "itemIdTxt";
            this.itemIdTxt.Size = new System.Drawing.Size(168, 22);
            this.itemIdTxt.TabIndex = 3;
            this.itemIdTxt.TextChanged += new System.EventHandler(this.itemIdTxt_TextChanged);
            // 
            // customerPurchasedItemsCheckBox
            // 
            this.customerPurchasedItemsCheckBox.AutoSize = true;
            this.customerPurchasedItemsCheckBox.Location = new System.Drawing.Point(6, 75);
            this.customerPurchasedItemsCheckBox.Name = "customerPurchasedItemsCheckBox";
            this.customerPurchasedItemsCheckBox.Size = new System.Drawing.Size(186, 20);
            this.customerPurchasedItemsCheckBox.TabIndex = 2;
            this.customerPurchasedItemsCheckBox.TabStop = true;
            this.customerPurchasedItemsCheckBox.Text = "Customer purchases items";
            this.customerPurchasedItemsCheckBox.UseVisualStyleBackColor = true;
            this.customerPurchasedItemsCheckBox.CheckedChanged += new System.EventHandler(this.customerPurchasedItemsCheckBox_CheckedChanged);
            // 
            // itemPurchasedByCustomersCheckBox
            // 
            this.itemPurchasedByCustomersCheckBox.AutoSize = true;
            this.itemPurchasedByCustomersCheckBox.Location = new System.Drawing.Point(6, 48);
            this.itemPurchasedByCustomersCheckBox.Name = "itemPurchasedByCustomersCheckBox";
            this.itemPurchasedByCustomersCheckBox.Size = new System.Drawing.Size(210, 20);
            this.itemPurchasedByCustomersCheckBox.TabIndex = 1;
            this.itemPurchasedByCustomersCheckBox.TabStop = true;
            this.itemPurchasedByCustomersCheckBox.Text = "Items purchased by customers";
            this.itemPurchasedByCustomersCheckBox.UseVisualStyleBackColor = true;
            this.itemPurchasedByCustomersCheckBox.CheckedChanged += new System.EventHandler(this.itemPurchasedByCustomersCheckBox_CheckedChanged);
            // 
            // bestSellingCheckBox
            // 
            this.bestSellingCheckBox.AutoSize = true;
            this.bestSellingCheckBox.Location = new System.Drawing.Point(6, 21);
            this.bestSellingCheckBox.Name = "bestSellingCheckBox";
            this.bestSellingCheckBox.Size = new System.Drawing.Size(132, 20);
            this.bestSellingCheckBox.TabIndex = 0;
            this.bestSellingCheckBox.TabStop = true;
            this.bestSellingCheckBox.Text = "Best selling items";
            this.bestSellingCheckBox.UseVisualStyleBackColor = true;
            this.bestSellingCheckBox.CheckedChanged += new System.EventHandler(this.bestSellingCheckBox_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.itemGrd);
            this.groupBox2.Location = new System.Drawing.Point(12, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(915, 317);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product list";
            // 
            // itemGrd
            // 
            this.itemGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemGrd.Location = new System.Drawing.Point(6, 21);
            this.itemGrd.Name = "itemGrd";
            this.itemGrd.RowHeadersWidth = 51;
            this.itemGrd.RowTemplate.Height = 24;
            this.itemGrd.Size = new System.Drawing.Size(903, 290);
            this.itemGrd.TabIndex = 0;
            // 
            // ItemFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 450);
            this.Controls.Add(this.viewOptionsGrp);
            this.Controls.Add(this.groupBox2);
            this.Name = "ItemFilterForm";
            this.Text = "ItemFilterForm";
            this.Load += new System.EventHandler(this.ItemFilterForm_Load);
            this.viewOptionsGrp.ResumeLayout(false);
            this.viewOptionsGrp.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemGrd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox viewOptionsGrp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox itemIdTxt;
        private System.Windows.Forms.RadioButton customerPurchasedItemsCheckBox;
        private System.Windows.Forms.RadioButton itemPurchasedByCustomersCheckBox;
        private System.Windows.Forms.RadioButton bestSellingCheckBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView itemGrd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customerIdTxt;
    }
}