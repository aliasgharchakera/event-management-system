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
    public partial class Register_form : Form
    {
        public Register_form()
        {
            InitializeComponent();

        }

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
    }
}
