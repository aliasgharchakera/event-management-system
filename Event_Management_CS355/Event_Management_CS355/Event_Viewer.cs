﻿using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Event_Management_CS355
{
    public partial class Event_Viewer : Form
    {
        bool isAdmin;
        public Event_Viewer()
        {
            InitializeComponent();
        }

        public Event_Viewer(bool privilege)
        {
            InitializeComponent();
            isAdmin = privilege;
        }
        public string conString = "Data Source=(local);Initial Catalog=Event_Management;Integrated Security=True";

        private void Event_Viewer_Load(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(conString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();


            cmd.CommandText = "select * from GridViewFinal";
            /*cmd.Parameters.Add(new SqlParameter("@user", email_textbox.Text));*/

            cmd.CommandType = CommandType.Text;

            SqlDataReader grid_read = cmd.ExecuteReader();

            while (grid_read.Read())
            {
                EventView_datagrid.Rows.Add(grid_read["eventName"]);           
            }

            /*EventView_datagrid.Rows.Add("HUMUN", "29-Nov-2021", "Auditorium", "HU Public Speaking Club", "Competition");*/
            
            
            if (isAdmin == false)
            {
                EventView_datagrid.ReadOnly = true;
                button_delete.Enabled = false;
                button_updateEvent.Enabled = false;
                button_Add.Enabled = false;
            }
        }

        private void EventView_datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(EventView_datagrid.CurrentRow.Cells.ToString());
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            /*this.Hide();*/
            Register_form f2 = new Register_form();
            f2.ShowDialog();
            // email_textbox.Text == student_id.email;
            //   student_id.password_2 == password_textbox.Text;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void Upcoming_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_student_only_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkbox_open_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_past_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox_filter_Enter(object sender, EventArgs e)
        {

        }

        private void button_update_Click(object sender, EventArgs e)
        {
            //do not know what to add
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
