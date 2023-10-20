using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNetTechWinFormProject
{
    public partial class AddItemForm : Form
    {
        readonly string dbConn = ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;
        SqlConnection conn;
        SqlDataAdapter data;
        SqlCommand cm;
        DataTable tb;
        int btnType = 0;

        public AddItemForm()
        {
            InitializeComponent();
        }

        private void AddItemForm_Load(object sender, EventArgs e)
        {
            List<string> countryList = getCountryList();
            foreach (string country in countryList)
            {
                itemOriginCB.Items.Add(country);
            }

            conn = new SqlConnection(dbConn);
            conn.Open();
            showGRD();
            formload();
        }

        private List<string> getCountryList()
        {
            List<string> countryList = new List<string>();
            CultureInfo[] getCultureInfo = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
            foreach (CultureInfo getCulture in getCultureInfo)
            {
                RegionInfo getRegionInfo = new RegionInfo(getCulture.LCID);
                if (!countryList.Contains(getRegionInfo.EnglishName))
                {
                    countryList.Add(getRegionInfo.EnglishName);
                }
            }
            countryList.Sort();
            return countryList;
        }

        private string getItemDesc(string connectionString)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string sqlQuery = "select top 1 ItemID from Item order by ItemID desc";
            SqlCommand cmd = new SqlCommand(sqlQuery, conn);

            SqlDataReader dr = cmd.ExecuteReader();
            string res = "";
            if (dr != null)
            {
                while (dr.Read())
                {
                    res = dr["ItemID"].ToString();
                }
            }

            conn.Close();
            return res;
        }

        private string getNewItemID(string connectionString)
        {
            string res = getItemDesc(connectionString);
            if (res != null && !res.Equals(""))
            {
                int order = int.Parse(res.Substring(4)) + 1;
                if (order < 10)
                {
                    res = "ITM000000" + order.ToString();
                }
                else if (order < 100)
                {
                    res = "ITM00000" + order.ToString();
                }
                else if (order < 1000)
                {
                    res = "ITM0000" + order.ToString();
                }
                else if (order < 10000)
                {
                    res = "ITM000" + order.ToString();
                }
                else if (order < 100000)
                {
                    res = "ITM00" + order.ToString();
                }
                else if (order < 1000000)
                {
                    res = "ITM0" + order.ToString();
                }
                else
                {
                    res = "ITM" + order.ToString();
                }
                return res;
            }
            else
            {
                return "ITM0000001";
            }
        }

        public void enableGRP(bool b, GroupBox grp)
        {
            grp.Enabled = b;
        }

        public void showGRD()
        {
            string sql = "select ItemID as ID, ItemName as 'item Name', Size, UnitSize as 'Unit Size', Brand, Origin, Quantity, Price from Item";
            data = new SqlDataAdapter(sql, conn);
            tb = new DataTable();
            data.Fill(tb);
            itemGrd.DataSource = tb;
        }

        public void formload()
        {
            enableGRP(false, itemInfoGroup);
            addBtn.Enabled = true;
            deleteBtn.Enabled = false;
            editBtn.Enabled = false;
            saveBtn.Enabled = false;

            itemIdTxt.Clear();
            itemNameTxt.Clear();
            itemSizeTxt.Clear();
            itemBrandTxt.Clear();
            itemOriginCB.ResetText();
            itemQuanNum.Value = 0;
            itemPriceNum.Value = 0;
        }

        private void productGrd_Click(object sender, EventArgs e)
        {
            itemIdTxt.Text = itemGrd.CurrentRow.Cells[0].Value.ToString();
            itemNameTxt.Text = itemGrd.CurrentRow.Cells[1].Value.ToString();
            itemSizeTxt.Text = itemGrd.CurrentRow.Cells[2].Value.ToString();
            itemUnitSizeCB.Text = itemGrd.CurrentRow.Cells[3].Value.ToString();
            itemBrandTxt.Text = itemGrd.CurrentRow.Cells[4].Value.ToString();
            itemOriginCB.Text = itemGrd.CurrentRow.Cells[5].Value.ToString();
            itemQuanNum.Value = Convert.ToDecimal(itemGrd.CurrentRow.Cells[6].Value.ToString());
            itemPriceNum.Value = Convert.ToDecimal(itemGrd.CurrentRow.Cells[7].Value.ToString());

            enableGRP(false, itemInfoGroup);
            addBtn.Enabled = false;
            deleteBtn.Enabled = true;
            editBtn.Enabled = true;
            saveBtn.Enabled = false;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            btnType = 1;
            enableGRP(true, itemInfoGroup);
            itemIdTxt.Clear();
            itemNameTxt.Clear();
            itemSizeTxt.Clear();
            itemBrandTxt.Clear();
            itemOriginCB.ResetText();
            itemQuanNum.Value = 0;
            itemPriceNum.Value = 0;

            itemNameTxt.Focus();
            deleteBtn.Enabled = false;
            editBtn.Enabled = false;
            saveBtn.Enabled = true;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            btnType = 2;
            enableGRP(true, itemInfoGroup);
            itemNameTxt.Focus();
            addBtn.Enabled = false;
            saveBtn.Enabled = true;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This delete action cannot undo!", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string inputItemId = itemIdTxt.Text;
                if (inputItemId.Equals(""))
                {
                    MessageBox.Show("An error occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string sql = "delete from Item where ItemID = '" + itemIdTxt.Text + "'";
                cm = new SqlCommand(sql, conn);
                cm.ExecuteNonQuery();
                showGRD();
                formload();
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string sql = "";
            string itemName = itemNameTxt.Text;
            string itemSize = itemSizeTxt.Text;
            string itemUnitSize = itemUnitSizeCB.SelectedItem != null ? itemUnitSizeCB.SelectedItem.ToString() : "";
            string itemBrand = itemBrandTxt.Text;
            string itemOrigin = itemOriginCB.SelectedItem != null ? itemOriginCB.SelectedItem.ToString() : "";
            int itemQuan = (int)itemQuanNum.Value;
            decimal itemPrice = itemPriceNum.Value;

            if (itemName.Equals(""))
            {
                MessageBox.Show("Please enter a item name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (itemSize.Equals(""))
            {
                MessageBox.Show("Please enter a item size", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (itemUnitSize.Equals(""))
            {
                MessageBox.Show("Please choose an unit size", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (itemBrand.Equals(""))
            {
                MessageBox.Show("Please enter a item brand", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (itemOrigin.Equals(""))
            {
                MessageBox.Show("Please choose a item origin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (btnType == 1)
            {
                string itemId = getNewItemID(dbConn);
                sql = "insert into Item values ('" + itemId + "', '" + itemName + "', '" + itemSize + "', '" + itemUnitSize + "', '" + itemBrand + "', '" + itemOrigin + "', " + itemQuan + ", " + itemPrice + ")";
                cm = new SqlCommand(sql, conn);
                cm.ExecuteNonQuery();
            }
            else if (btnType == 2)
            {
                string inputitemId = itemIdTxt.Text;
                if (inputitemId.Equals(""))
                {
                    MessageBox.Show("An error occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                sql = "update Item set ItemName = '" + itemName + "', Size = '" + itemSize + "', UnitSize = '" + itemUnitSize + "', Brand = '" + itemBrand + "', Origin = '" + itemOrigin + "', Quantity = " + itemQuan + ", Price = " + itemPrice + " where ItemID = '" + inputitemId + "'";
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
    }
}
