using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetTechWinFormProject
{
    public partial class ItemFilterForm : Form
    {
        readonly String dbConn = ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;
        SqlConnection conn;
        SqlDataAdapter data;
        SqlCommand cm;
        DataTable tb;

        public ItemFilterForm()
        {
            InitializeComponent();
        }

        private void ItemFilterForm_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(dbConn);
            conn.Open();
            itemIdTxt.Enabled = false;
            customerIdTxt.Enabled = false;
        }

        void showGRD(string sql)
        {
            data = new SqlDataAdapter(sql, conn);
            tb = new DataTable();
            data.Fill(tb);
            itemGrd.DataSource = tb;
        }

        private void bestSellingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (bestSellingCheckBox.Checked)
            {
                itemIdTxt.Clear();
                itemIdTxt.Enabled = false;
                customerIdTxt.Clear();
                customerIdTxt.Enabled = false;
                string sql = "select I1.ItemID as ID, I1.ItemName as 'Product name', I1.Size, I1.UnitSize as 'Unit size', I1.Brand, I1.Origin, I1.Price, sum(O1.Quantity) as 'Selling amount'" +
                        " from Item I1, OrderDetail O1" +
                        " where I1.ItemID = O1.ItemID" +
                        " group by I1.ItemID, I1.ItemID, I1.ItemName, I1.Size, I1.UnitSize, I1.Brand, I1.Origin, I1.Price" +
                        " having sum(O1.Quantity) >= all(" +
                            " select sum(O2.Quantity)" +
                            " from Item I2, OrderDetail O2" +
                            " where I2.ItemID = O2.ItemID" +
                            " group by I2.ItemID)";
                showGRD(sql);
            }
        }

        private void itemPurchasedByCustomersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (itemPurchasedByCustomersCheckBox.Checked)
            {
                itemIdTxt.Enabled = true;
                customerIdTxt.Clear();
                customerIdTxt.Enabled = false;
            }
        }

        private void customerPurchasedItemsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (customerPurchasedItemsCheckBox.Checked)
            {
                customerIdTxt.Enabled = true;
                itemIdTxt.Clear();
                itemIdTxt.Enabled = false;
            }
        }

        private void itemIdTxt_TextChanged(object sender, EventArgs e)
        {
            if (itemPurchasedByCustomersCheckBox.Checked)
            {
                string sql = "select distinct I.*, A.CustName" +
                        " from Item I, OrderDetail OD, _Order O, Customer A" +
                        $" where O.OrderID = OD.OrderID and I.ItemID = OD.ItemID and A.CustID = O.CustID and I.ItemID = '{itemIdTxt.Text}'";
                showGRD(sql);
            }
        }

        private void customerIdTxt_TextChanged(object sender, EventArgs e)
        {
            if (customerPurchasedItemsCheckBox.Checked)
            {
                string sql = "select distinct I.*, A.CustName" +
                        " from Item I, OrderDetail OD, _Order O, Customer A" +
                        $" where O.OrderID = OD.OrderID and I.ItemID = OD.ItemID and A.CustID = O.CustID and A.CustID = '{customerIdTxt.Text}'";
                showGRD(sql);
            }
        }
    }
}
