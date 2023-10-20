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
    public partial class LoginForm : Form
    {
        string strConn = ConfigurationManager.ConnectionStrings["DBConn"].ConnectionString;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTxt.Text;
            string password = pwdTxt.Text;

            if (username == null || username == "")
            {
                MessageBox.Show("Please enter your username", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (password == null || password == "")
            {
                MessageBox.Show("Please enter your password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (username == "admin" && password == "123456")
            {
                MessageBox.Show("Login successful!");
                MainForm formMain = new MainForm();
                formMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
