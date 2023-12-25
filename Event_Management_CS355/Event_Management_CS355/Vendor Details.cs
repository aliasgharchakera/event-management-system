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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=(local);Initial Catalog=Event_Management;Integrated Security=True";

        private void button_add_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conString);

            SqlCommand cmd = new SqlCommand("exec add_vendor @name = '" + textBox_name.Text + "', @number = '" + textBox_cont_num.Text + "', @email = '" + textBox_email.Text + "'", conn);
            cmd.Connection = conn;
            conn.Open();


/*            MessageBox.Show();*/
            /*MessageBox.Show(EventView_datagrid.Rows[0].Cells[0].ToString());
            */            /*cmd.CommandText = "exec delete_event @event_id = " + cellContent;*/
            /*            cmd.Parameters.Add(new SqlParameter("@user", email_textbox.Text));
            */


            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();/*
            cellContent = "";*/
            conn.Close();

            this.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_cont_num_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
