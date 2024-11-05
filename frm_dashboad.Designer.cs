namespace register_login_system
{
    partial class frm_dashboad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            btn_home_page = new Guna.UI2.WinForms.Guna2Button();
            lb_admin = new Label();
            pictureBox1 = new PictureBox();
            panel_empty = new Guna.UI2.WinForms.Guna2Panel();
            panel_home = new Guna.UI2.WinForms.Guna2Panel();
            label1 = new Label();
            guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel_empty.SuspendLayout();
            panel_home.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel2
            // 
            guna2Panel2.BackColor = Color.DimGray;
            guna2Panel2.Controls.Add(btn_home_page);
            guna2Panel2.Controls.Add(lb_admin);
            guna2Panel2.Controls.Add(pictureBox1);
            guna2Panel2.CustomizableEdges = customizableEdges3;
            guna2Panel2.Dock = DockStyle.Left;
            guna2Panel2.Location = new Point(0, 0);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel2.Size = new Size(235, 656);
            guna2Panel2.TabIndex = 1;
            guna2Panel2.Paint += guna2Panel2_Paint;
            // 
            // btn_home_page
            // 
            btn_home_page.CustomizableEdges = customizableEdges1;
            btn_home_page.DisabledState.BorderColor = Color.DarkGray;
            btn_home_page.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_home_page.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_home_page.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_home_page.FillColor = Color.DimGray;
            btn_home_page.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_home_page.ForeColor = Color.White;
            btn_home_page.ImageOffset = new Point(-5, 0);
            btn_home_page.Location = new Point(0, 210);
            btn_home_page.Name = "btn_home_page";
            btn_home_page.PressedColor = Color.BlanchedAlmond;
            btn_home_page.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_home_page.Size = new Size(232, 42);
            btn_home_page.TabIndex = 2;
            btn_home_page.Text = "Home";
            btn_home_page.Click += btn_home_page_Click;
            // 
            // lb_admin
            // 
            lb_admin.AutoSize = true;
            lb_admin.BackColor = Color.DimGray;
            lb_admin.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_admin.ForeColor = Color.White;
            lb_admin.Location = new Point(72, 136);
            lb_admin.Name = "lb_admin";
            lb_admin.Size = new Size(105, 38);
            lb_admin.TabIndex = 1;
            lb_admin.Text = "Admin";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user_219964;
            pictureBox1.Location = new Point(61, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel_empty
            // 
            panel_empty.Controls.Add(panel_home);
            panel_empty.CustomizableEdges = customizableEdges7;
            panel_empty.Dock = DockStyle.Fill;
            panel_empty.Location = new Point(235, 0);
            panel_empty.Name = "panel_empty";
            panel_empty.ShadowDecoration.CustomizableEdges = customizableEdges8;
            panel_empty.Size = new Size(916, 656);
            panel_empty.TabIndex = 2;
            // 
            // panel_home
            // 
            panel_home.BackColor = SystemColors.ActiveBorder;
            panel_home.Controls.Add(label1);
            panel_home.CustomizableEdges = customizableEdges5;
            panel_home.Dock = DockStyle.Fill;
            panel_home.Location = new Point(0, 0);
            panel_home.Name = "panel_home";
            panel_home.ShadowDecoration.CustomizableEdges = customizableEdges6;
            panel_home.Size = new Size(916, 656);
            panel_home.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(313, 266);
            label1.Name = "label1";
            label1.Size = new Size(281, 62);
            label1.TabIndex = 0;
            label1.Text = "Home page";
            // 
            // frm_dashboad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 656);
            Controls.Add(panel_empty);
            Controls.Add(guna2Panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_dashboad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_dashboad";
            Load += frm_dashboad_Load;
            guna2Panel2.ResumeLayout(false);
            guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel_empty.ResumeLayout(false);
            panel_home.ResumeLayout(false);
            panel_home.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Label lb_admin;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btn_home_page;
        private Guna.UI2.WinForms.Guna2Panel panel_empty;
        private Guna.UI2.WinForms.Guna2Panel panel_home;
        private Label label1;
    }
}