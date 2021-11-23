using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CSSamples2005
{
    public partial class Demo : Form
    {
        SqlConnection conn;
        public Demo()
        {
            InitializeComponent();
        }

        private void Demo_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.; Initial Catalog=Northwnd; User ID = sa; Pwd=sraza";
            conn.Open();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select employeeid from employees where username = '" + txtUserName.Text + "' and pwd = '" + txtPwd.Text + "'";

            //cmd.CommandText = "Select employeeid from employees where username =@username and pwd = @pwd";
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            try
            {

                string id = cmd.ExecuteScalar().ToString();
                MessageBox.Show("Employee id is :" + id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid User Name/Password");
            }

        }
    }
}
