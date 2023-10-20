using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetTechWinFormProject
{
    public partial class MainForm : Form
    {
        string strConn = ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void productManagementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddItemForm addItemForm = new AddItemForm();
            addItemForm.MdiParent = this;
            addItemForm.Show();
        }

        private void itemFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItemFilterForm itemFilterForm = new ItemFilterForm();
            itemFilterForm.MdiParent = this;
            itemFilterForm.Show();
        }

        private void customerManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomerForm = new AddCustomerForm();
            addCustomerForm.MdiParent = this;
            addCustomerForm.Show();
        }

        private void orderManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderItemForm orderItemForm = new OrderItemForm();
            orderItemForm.MdiParent = this;
            orderItemForm.Show();
        }

        private void viewOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderViewForm viewOrderForm = new OrderViewForm();
            viewOrderForm.MdiParent = this;
            viewOrderForm.Show();
        }
    }
}
