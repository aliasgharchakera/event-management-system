using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Event_Management_CS355
{
    public partial class Event_Viewer : Form
    {
        bool isAdmin;
        string cellContent;
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


            cmd.CommandText = "select * from GridView1";
            /*cmd.Parameters.Add(new SqlParameter("@user", email_textbox.Text));*/

            cmd.CommandType = CommandType.Text;

            SqlDataReader grid_read = cmd.ExecuteReader();

            while (grid_read.Read())
            {
                EventView_datagrid.Rows.Add(grid_read["idEvent"],grid_read["eventName"],grid_read["StartTime"],grid_read["EndTime"],grid_read["locationName"],grid_read["Organizer"],grid_read["categoryName"],grid_read["isApproved"]);           
            }
            grid_read.Close();
            /*EventView_datagrid.Rows.Add("HUMUN", "29-Nov-2021", "Auditorium", "HU Public Speaking Club", "Competition");*/


            cmd.CommandText = "select * from locations";
            grid_read = cmd.ExecuteReader();

            while (grid_read.Read())
            {
                comboBox_location.Items.Add(grid_read["locationName"]);
                /*                EventView_datagrid.Rows.Add(grid_read["eventName"]);
                */
            }

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
            MessageBox.Show("debug");

            cellContent = EventView_datagrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

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
            //do not know what to add,pls add

            SqlConnection conn = new SqlConnection(conString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();


            cmd.CommandText = "select * from GridView1";
            /*cmd.Parameters.Add(new SqlParameter("@user", email_textbox.Text));*/

            cmd.CommandType = CommandType.Text;

            SqlDataReader grid_read = cmd.ExecuteReader();

            EventView_datagrid.Rows.Clear();
            while (grid_read.Read())
            {
                EventView_datagrid.Rows.Add(grid_read["idEvent"], grid_read["eventName"], grid_read["StartTime"], grid_read["EndTime"], grid_read["locationName"], grid_read["Organizer"], grid_read["categoryName"], grid_read["isApproved"]);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conString);
            
            SqlCommand cmd = new SqlCommand("exec delete_event_byname @event_name = '" + cellContent + "'", conn); 
            cmd.Connection = conn;
            conn.Open();


            MessageBox.Show(cellContent);
/*MessageBox.Show(EventView_datagrid.Rows[0].Cells[0].ToString());
*/            /*cmd.CommandText = "exec delete_event @event_id = " + cellContent;*/
/*            cmd.Parameters.Add(new SqlParameter("@user", email_textbox.Text));
*/
            

            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            cellContent = "";
            conn.Close();
        }
    }
}
