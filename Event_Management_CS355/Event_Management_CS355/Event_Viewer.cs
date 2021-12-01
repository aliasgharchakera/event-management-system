using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Management_CS355
{
    public partial class Event_Viewer : Form
    {
        public Event_Viewer()
        {
            InitializeComponent();
        }

        private void Event_Viewer_Load(object sender, EventArgs e)
        {
            EventView_datagrid.Rows.Add("HUMUN", "29-Nov-2021", "Auditorium", "HU Public Speaking Club", "Competition");
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
    }
}
