using System.Data.SqlClient;

namespace register_login_system
{
    public partial class frm_register : Form
    {

        private string connect = "Data Source=SOMONOR;Initial Catalog=DBASP;Integrated Security=True;";

        public frm_register()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text.Trim();
            string password = txt_pw.Text;
            string confirm_pw = txt_cfpw.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirm_pw))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (password != confirm_pw)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            RegisterUser(username, password);

        }

        private void RegisterUser(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection(connect))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO tbl_user_login_register (username, user_pw) VALUES (@Username, @Password)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password); // Store passwords securely in production

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Registration successful!");
                        }
                        else
                        {
                            MessageBox.Show("Registration failed. Please try again.");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void lb_link_to_loginPage_Click(object sender, EventArgs e)
        {
            new frm_login().Show();
            this.Hide();
        }
    }
}
