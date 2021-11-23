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
    public partial class Form1 : Form
    {
        SqlConnection con;
        public Form1()
        {
            InitializeComponent();

            con = new SqlConnection();
            con.ConnectionString = "Data Source=.\\sqlexpress01; Initial Catalog=Northwind; Integrated Security=true;";
            //con.ConnectionString = "Data Source=.; Initial Catalog=Northwnd; User ID = sa; Pwd=";

            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select CustomerID from customers";
            cmd.CommandType = CommandType.Text;
            SqlDataReader rd = cmd.ExecuteReader();
            
            while (rd.Read())
            {
                cboCustomerCode.Items.Add(rd["CustomerID"]);
            }
            rd.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select CustomerID, OrderDate, ShipName, ShipAddress,ShippedDate From Orders where OrderID = " + txtOrderID.Text;
            cmd.CommandType = CommandType.Text;
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read() == true)
            {
                cboCustomerCode.SelectedItem = rd["CustomerID"];
                dtpOrderDate.Value = Convert.ToDateTime(rd[1]);
                txtShipName.Text = rd[2].ToString();
                txtShipAddress.Text = rd[3].ToString();

                if (rd[4] != null)
                {
                    chkShipped.Checked = true;
                }
                else
                {
                    chkShipped.Checked = false;
                }
            }
            rd.Close();

            cmd.CommandText = "Select  P.ProductID, ProductName, OD.UnitPrice, Quantity, Discount from Products P, [Order Details] OD where P.ProductID = OD.ProductID and OrderID = " + txtOrderID.Text;
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            adapter.Fill(ds, "SearchResult");

            grdDetails.DataSource = ds.Tables["SearchResult"];
            grdDetails.Refresh();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlTransaction tran= con.BeginTransaction();
            
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Transaction = tran;
                cmd.Connection = con;
                cmd.CommandText = "Update Orders Set OrderDate = '" + dtpOrderDate.Value + "', ShipName = '" + txtShipName.Text + "', ShipAddress = '" + txtShipAddress.Text + "' where orderid = " + txtOrderID.Text;
                cmd.ExecuteNonQuery();
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //ReportViewer frmreport = new ReportViewer();
            //frmreport.OrderID = Convert.ToInt32(txtOrderID.Text);
            //frmreport.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }
    }
}