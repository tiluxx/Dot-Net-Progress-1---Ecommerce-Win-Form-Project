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
    public partial class AddCustomerForm : Form
    {
        readonly String dbConn = ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;
        SqlConnection conn;
        SqlDataAdapter data;
        SqlCommand cm;
        DataTable tb;
        int btnType = 0;

        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(dbConn);
            conn.Open();
            showGRD();
            formload();
        }

        private string getCustomerDesc(string connectionString)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string sqlQuery = "select top 1 CustID from Customer order by CustID desc";
            SqlCommand cmd = new SqlCommand(sqlQuery, conn);

            SqlDataReader dr = cmd.ExecuteReader();
            string res = "";
            if (dr != null)
            {
                while (dr.Read())
                {
                    res = dr["CustID"].ToString();
                }
            }

            conn.Close();
            return res;
        }

        private string getNewCustomerID(string connectionString)
        {
            string res = getCustomerDesc(connectionString);
            if (res != null && !res.Equals(""))
            {
                int order = int.Parse(res.Substring(4)) + 1;
                if (order < 10)
                {
                    res = "CUS000000" + order.ToString();
                }
                else if (order < 100)
                {
                    res = "CUS00000" + order.ToString();
                }
                else if (order < 1000)
                {
                    res = "CUS0000" + order.ToString();
                }
                else if (order < 10000)
                {
                    res = "CUS000" + order.ToString();
                }
                else if (order < 100000)
                {
                    res = "CUS00" + order.ToString();
                }
                else if (order < 1000000)
                {
                    res = "CUS0" + order.ToString();
                }
                else
                {
                    res = "CUS" + order.ToString();
                }
                return res;
            }
            else
            {
                return "CUS0000001";
            }
        }

        public void enableGRP(bool b, GroupBox grp)
        {
            grp.Enabled = b;
        }

        public void showGRD()
        {
            string sql = "select CustID as ID, CustName as 'Customer Name', Address from Customer";
            data = new SqlDataAdapter(sql, conn);
            tb = new DataTable();
            data.Fill(tb);
            customerGrd.DataSource = tb;
            customerIdTxt.Enabled = false;
        }

        public void formload()
        {
            enableGRP(false, customerInfoGroup);
            addBtn.Enabled = true;
            deleteBtn.Enabled = false;
            editBtn.Enabled = false;
            saveBtn.Enabled = false;

            customerIdTxt.Enabled = false;
            customerIdTxt.Clear();
            customerNameTxt.Clear();
            customerAddressTxt.Clear();
            customerAddressTxt.Clear();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            btnType = 1;
            enableGRP(true, customerInfoGroup);
            customerIdTxt.Clear();
            customerNameTxt.Clear();
            customerAddressTxt.Clear();

            customerIdTxt.Enabled = false;
            customerNameTxt.Focus();
            deleteBtn.Enabled = false;
            editBtn.Enabled = false;
            saveBtn.Enabled = true;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            btnType = 2;
            enableGRP(true, customerInfoGroup);
            customerNameTxt.Focus();
            addBtn.Enabled = false;
            saveBtn.Enabled = true;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This delete action cannot undo!", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string inputCustomerId = customerIdTxt.Text;
                if (inputCustomerId.Equals(""))
                {
                    MessageBox.Show("An error occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string sql = "delete from Customer where CustID = '" + inputCustomerId + "'";
                cm = new SqlCommand(sql, conn);
                cm.ExecuteNonQuery();
                showGRD();
                formload();
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string sql = "";
            string customerName = customerNameTxt.Text;
            string customerAddress = customerAddressTxt.Text;

            if (customerName.Equals(""))
            {
                MessageBox.Show("Please enter a customer name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (customerAddress.Equals(""))
            {
                MessageBox.Show("Please enter a customer address", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (btnType == 1)
            {
                string customerId = getNewCustomerID(dbConn);
                sql = "insert into Customer values ('" + customerId + "', '" + customerName + "', '" + customerAddress + "')";
                cm = new SqlCommand(sql, conn);
                cm.ExecuteNonQuery();
            }
            else if (btnType == 2)
            {
                string inputCustomerId = customerIdTxt.Text;
                if (inputCustomerId.Equals(""))
                {
                    MessageBox.Show("An error occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                sql = "update Customer set CustName = '" + customerName + "', Address = '" + customerAddress + "' where CustID = '" + inputCustomerId + "'";
                cm = new SqlCommand(sql, conn);
                cm.ExecuteNonQuery();
            }
            showGRD();
            formload();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            formload();
        }

        private void customerGrd_Click(object sender, EventArgs e)
        {
            customerIdTxt.Text = customerGrd.CurrentRow.Cells[0].Value.ToString();
            customerNameTxt.Text = customerGrd.CurrentRow.Cells[1].Value.ToString();
            customerAddressTxt.Text = customerGrd.CurrentRow.Cells[2].Value.ToString();

            enableGRP(false, customerInfoGroup);
            addBtn.Enabled = false;
            deleteBtn.Enabled = true;
            editBtn.Enabled = true;
            saveBtn.Enabled = false;
        }
    }
}
