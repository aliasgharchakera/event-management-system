using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace CSSamples2005
{
    public partial class ReportViewer : Form
    {
        public int OrderID;

        public ReportViewer()
        {
            InitializeComponent();
        }


        private void ReportViewer_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.; Initial Catalog=Northwind; User ID = sa; Pwd=sa";
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "CustOrdersDetail";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@OrderID", OrderID));
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "SearchResult");

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource("NorthwindDataSet_CustOrdersDetail", ds.Tables["SearchResult"]);
            reportViewer1.LocalReport.ReportEmbeddedResource = "CSSamples2005.Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Add(rds);

            reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}