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
    public partial class OrderItemForm : Form
    {
        readonly string dbConn = ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;
        SqlConnection conn;
        SqlDataAdapter data;
        SqlCommand cm;
        DataTable tb;

        public OrderItemForm()
        {
            InitializeComponent();
        }

        private void OrderItemForm_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(dbConn);
            conn.Open();
            showCustomerGRD(customerList);
            showItemCheckListBox();
        }

        public void showCustomerGRD(DataGridView grd)
        {
            string sql = "select CustID as ID, CustName as 'Customer Name', Address from Customer";
            data = new SqlDataAdapter(sql, conn);
            tb = new DataTable();
            data.Fill(tb);
            grd.DataSource = tb;
        }

        public void showItemCheckListBox()
        {
            string sql = "select * from Item";
            data = new SqlDataAdapter(sql, conn);
            tb = new DataTable();
            data.Fill(tb);

            // get product data
            List<string> productList = new List<string> { };
            foreach (DataRow dbRow in tb.Rows)
            {
                List<string> productDataRow = new List<string> { };
                foreach (DataColumn dbCol in tb.Columns)
                {
                    productDataRow.Add(dbRow[dbCol].ToString());
                }
                string productData = productDataRow[0] + "-" + productDataRow[1];
                productList.Add(productData);
            }

            // add to check list box
            foreach (string data in productList)
            {
                itemCheckedListBox.Items.Add(data);
            }
        }

        private string getOrderDesc(string connectionString)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string sqlQuery = "select top 1 OrderID from _Order order by OrderID desc";
            SqlCommand cmd = new SqlCommand(sqlQuery, conn);

            SqlDataReader dr = cmd.ExecuteReader();
            string res = "";
            if (dr != null)
            {
                while (dr.Read())
                {
                    res = dr["OrderID"].ToString();
                }
            }

            conn.Close();
            return res;
        }

        private string getNewOrderID(string connectionString)
        {
            string res = getOrderDesc(connectionString);
            if (res != null && !res.Equals(""))
            {
                int order = int.Parse(res.Substring(4)) + 1;
                if (order < 10)
                {
                    res = "ORD000000" + order.ToString();
                }
                else if (order < 100)
                {
                    res = "ORD00000" + order.ToString();
                }
                else if (order < 1000)
                {
                    res = "ORD0000" + order.ToString();
                }
                else if (order < 10000)
                {
                    res = "ORD000" + order.ToString();
                }
                else if (order < 100000)
                {
                    res = "ORD00" + order.ToString();
                }
                else if (order < 1000000)
                {
                    res = "ORD0" + order.ToString();
                }
                else
                {
                    res = "ORD" + order.ToString();
                }
                return res;
            }
            else
            {
                return "ORD0000001";
            }
        }

        private string getOrderDetailDesc(string connectionString)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string sqlQuery = "select top 1 ID from OrderDetail order by ID desc";
            SqlCommand cmd = new SqlCommand(sqlQuery, conn);

            SqlDataReader dr = cmd.ExecuteReader();
            string res = "";
            if (dr != null)
            {
                while (dr.Read())
                {
                    res = dr["ID"].ToString();
                }
            }

            conn.Close();
            return res;
        }

        private string getNewOrderDetailID(string connectionString)
        {
            string res = getOrderDetailDesc(connectionString);
            if (res != null && !res.Equals(""))
            {
                int order = int.Parse(res.Substring(4)) + 1;
                if (order < 10)
                {
                    res = "ODT000000" + order.ToString();
                }
                else if (order < 100)
                {
                    res = "ODT00000" + order.ToString();
                }
                else if (order < 1000)
                {
                    res = "ODT0000" + order.ToString();
                }
                else if (order < 10000)
                {
                    res = "ODT000" + order.ToString();
                }
                else if (order < 100000)
                {
                    res = "ODT00" + order.ToString();
                }
                else if (order < 1000000)
                {
                    res = "ODT0" + order.ToString();
                }
                else
                {
                    res = "ODT" + order.ToString();
                }
                return res;
            }
            else
            {
                return "ODT0000001";
            }
        }

        private void itemCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable itemOrderTb = new DataTable();
            itemOrderTb.Columns.Add("ID");
            itemOrderTb.Columns.Add("Product name");
            itemOrderTb.Columns.Add("Quantity");

            foreach (var item in itemCheckedListBox.CheckedItems)
            {
                string productData = item.ToString();
                string[] productDataLst = productData.Split('-');

                DataRow row = itemOrderTb.NewRow();
                row["ID"] = productDataLst[0];
                row["Product name"] = productDataLst[1];
                row["Quantity"] = 1;
                itemOrderTb.Rows.Add(row);
            }

            itemOrderList.DataSource = itemOrderTb;
        }

        private void agentList_Click(object sender, EventArgs e)
        {
            customerIdSelectedTxt.Text = customerList.CurrentRow.Cells[0].Value.ToString();
            customerNameSelectedTxt.Text = customerList.CurrentRow.Cells[1].Value.ToString();
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            if (customerIdSelectedTxt.Text.Equals(""))
            {
                MessageBox.Show("Please choose a customer", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (itemCheckedListBox.CheckedItems.Count <= 0)
            {
                MessageBox.Show("Please choose a product", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string orderId = getNewOrderID(dbConn);
            string customerId = customerIdSelectedTxt.Text;

            string sql = "insert into _Order values ('" + orderId + "', '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + customerId + "')";
            cm = new SqlCommand(sql, conn);
            cm.ExecuteNonQuery();

            int tbRowCount = itemOrderList.Rows.Count - 1;
            for (int i = 0; i < tbRowCount; ++i)
            {
                string orderDetailId = getNewOrderDetailID(dbConn);
                string productIdOrder = itemOrderList.Rows[i].Cells[0].Value.ToString();
                decimal productQuanOrder = Convert.ToDecimal(itemOrderList.Rows[i].Cells[2].Value.ToString());
                sql = "insert into OrderDetail values ('" + orderDetailId + "', '" + orderId + "', '" + productIdOrder + "', '" + productQuanOrder + "', 'Product')";
                cm = new SqlCommand(sql, conn);
                cm.ExecuteNonQuery();

                decimal newQuan = getProductQuanInStock(productIdOrder) - productQuanOrder;
                sql = "update Item set Quantity = " + newQuan;
                cm = new SqlCommand(sql, conn);
                cm.ExecuteNonQuery();

                MessageBox.Show("Add order successfully");
            }
        }

        private void itemOrderList_Click(object sender, EventArgs e)
        {
            itemIdTxt.Text = itemOrderList.CurrentRow.Cells[0].Value.ToString();
            itemQuanUpDown.Value = Convert.ToDecimal(itemOrderList.CurrentRow.Cells[2].Value.ToString());
        }

        private decimal getProductQuanInStock(string productId)
        {
            string sql = "select Quantity from Item where ItemID = '" + productId + "'";
            data = new SqlDataAdapter(sql, conn);
            DataTable res = new DataTable();
            data.Fill(res);

            return Convert.ToDecimal(res.Rows[0][0].ToString());
        }

        private void changeItemQuanBtn_Click(object sender, EventArgs e)
        {
            decimal productQuanVal = itemQuanUpDown.Value;
            if (productQuanVal <= 0)
            {
                itemQuanUpDown.Value = 1;
                return;
            }

            if (itemIdTxt.Text.Equals("") || itemIdTxt == null)
            {
                return;
            }

            if (getProductQuanInStock(itemIdTxt.Text) < productQuanVal)
            {
                MessageBox.Show("Product is not enough in the stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int tbRowCount = itemOrderList.Rows.Count;
            for (int i = 0; i < tbRowCount; ++i)
            {
                if (itemOrderList.Rows[i].Cells[0].Value.ToString() == itemIdTxt.Text)
                {
                    itemOrderList.Rows[i].Cells[2].Value = productQuanVal;
                    return;
                }
            }
        }
    }
}
