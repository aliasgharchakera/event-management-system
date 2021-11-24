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
    public partial class Login_form : Form
    {
        
        public Login_form()
        {
            InitializeComponent();
        }

        private void Login_form_Load(object sender, EventArgs e)
        {

        }

        private void email_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string conString = "Data Source=ANOTHER-IDEAPAD;Initial Catalog = EventManagement; Integrated Security = True";


        private void button1_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            Event_Viewer f2 = new Event_Viewer();
            f2.ShowDialog();*/
            SqlConnection conn = new SqlConnection(conString);

            conn.Open();



            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            //cmd.CommandText = "Select username from employees where username = '" + txtUser.Text + "' and pwd = '" + txtPwd.Text + "'";
            cmd.CommandText = "Select pwd from Student where email = @user";
            cmd.Parameters.Add(new SqlParameter("@user", email_textbox.Text));
            /*cmd.Parameters.Add(new SqlParameter("@pwd", password_textbox.Text));*/

            cmd.CommandType = CommandType.Text;



            if (email_textbox.Text == "" || password_textbox.Text == "")
            {
                MessageBox.Show("Enter credentials.");
            }
            else
            {
                try
                {
                    /*string password = " ";
                    if (cmd.ExecuteScalar().ToString() is null)
                    {
                        MessageBox.Show("Enter something please!");
                    }
                    else
                    {
                        password = cmd.ExecuteScalar().ToString();
                    }*/

                    string password = cmd.ExecuteScalar().ToString();

                    if (password == password_textbox.Text)
                    {
                        this.Hide();
                        Event_Viewer f2 = new Event_Viewer();
                        f2.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Password!!!!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to login");
                }
            }




                // email_textbox.Text == student_id.email;
                //   student_id.password_2 == password_textbox.Text;
            
        }
    }
}
