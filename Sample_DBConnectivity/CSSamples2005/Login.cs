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
    public partial class Login : Form
    {
        SqlConnection conn;
        public Login()
        {
            InitializeComponent();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            //cmd.CommandText = "Select username from employees where username = '" + txtUser.Text + "' and pwd = '" + txtPwd.Text + "'";
            cmd.CommandText = "Select username from employees where username = @user and pwd=@pwd";
            cmd.Parameters.Add(new SqlParameter("@user",txtUser.Text));
            cmd.Parameters.Add(new SqlParameter("@pwd", txtPwd.Text));

            cmd.CommandType = CommandType.Text;
            try
            {
                string employeeid = cmd.ExecuteScalar().ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to login");
            }



            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {

                conn = new SqlConnection("Data Source=.; Initial Catalog=Northwnd; User ID = sa; Pwd=sraza");
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
