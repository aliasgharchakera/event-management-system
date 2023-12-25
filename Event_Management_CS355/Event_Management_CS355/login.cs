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

        public string conString = "Data Source=(local);Initial Catalog=Event_Management;Integrated Security=True";


        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();


            cmd.CommandText = "Select password_2 from Students where email = @user";
            cmd.Parameters.Add(new SqlParameter("@user", email_textbox.Text));

            cmd.CommandType = CommandType.Text;

            

            if (email_textbox.Text is null || password_textbox.Text is null)
            {
                MessageBox.Show("Enter credentials.");
            }
            else
            {
               /* try
                {*/

                    if (email_textbox.Text == "admin" && password_textbox.Text == "admin")
                    {
                        this.Hide();
                        Event_Viewer f2 = new Event_Viewer(true);
                        f2.ShowDialog();
                    }
                    else
                    {
                        string password = cmd.ExecuteScalar().ToString();

                        if ((password == password_textbox.Text) /*|| (password_textbox.Text = "guest")*/)
                        {
                            this.Hide();
                            Event_Viewer f2 = new Event_Viewer(false);
                            f2.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Wrong Password!!!!");
                        }
                    }
                /*}*/
                /*catch (Exception ex)
                {
                    MessageBox.Show("Unable to login");
                }*/
            }
            
        }
    }
}
