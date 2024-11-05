using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace register_login_system
{
    public partial class frm_dashboad : Form
    {
        private string username;
        public frm_dashboad(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {
            lb_admin.Text =username;
        }
    }
}
