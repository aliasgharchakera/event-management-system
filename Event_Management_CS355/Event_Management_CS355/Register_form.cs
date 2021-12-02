using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Event_Management_CS355
{
    public partial class Register_form : Form
    {
        public Register_form()
        {
            InitializeComponent();

        }
        public string conString = "Data Source=(local);Initial Catalog=Event_Management;Integrated Security=True";

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Register_form_Load(object sender, EventArgs e)
        {
            comboBox_location.Items.Add("Baithak");
            comboBox_location.Items.Add("Courts");
            comboBox_location.Items.Add("W-234");
            comboBox_location.Items.Add("E-001");
            comboBox_location.Items.Add("E-011");
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            

            this.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f2 = new Form1();
            f2.ShowDialog();
        }

        private void listBox_vendors_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;            conn.Open();
            cmd.CommandText = "select * from external_vendors";
            SqlDataReader grid_read = cmd.ExecuteReader();

            while (grid_read.Read())
            {
                listBox_vendors.Items.Add(grid_read["Name"]);
                /*                EventView_datagrid.Rows.Add(grid_read["eventName"]);
                */
            }

        }
    }
}
