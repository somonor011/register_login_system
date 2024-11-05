using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace register_login_system
{
    public partial class frm_login : Form
    {
       
        private string connect = "Data Source=SOMONOR;Initial Catalog=DBASP;Integrated Security=True;";
        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_pw.Text;
            if (UsersLogin(username, password))
            {
                MessageBox.Show("Login Success");
               
                frm_dashboad ds = new frm_dashboad(username);
                ds.Show();

            }
            else
            {
                MessageBox.Show("Login Fail");
            }

        }

        private bool UsersLogin(string username, string password)
        {
            bool isAction = false;
            using (SqlConnection conn = new SqlConnection(connect))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(1) FROM tbl_user_login_register WHERE username=@Username AND user_pw=@Password";// @ mean ney tha tang variable
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        isAction = count > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message);
                }
            }
            return isAction;
        }

        private void checkbx_showpw_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lb_link_to_registerPage_Click(object sender, EventArgs e)
        {
            new frm_register().Show();
            this.Hide();
        }
    }
}
