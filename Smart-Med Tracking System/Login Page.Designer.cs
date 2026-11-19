namespace Smart_Med_Tracking_System
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            lblUsername = new Label();
            lblPassword = new Label();
            btnClose = new Button();
            lblTrack = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnEnter = new Button();
            lblRole = new Label();
            cmbRoles = new ComboBox();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Segoe UI Black", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(310, 280);
            lblUsername.Margin = new Padding(4, 0, 4, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(299, 60);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "USERNAME :";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Segoe UI Black", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(310, 454);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(306, 60);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "PASSWORD :";
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.GradientInactiveCaption;
            btnClose.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(1066, 850);
            btnClose.Margin = new Padding(4, 5, 4, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(250, 90);
            btnClose.TabIndex = 4;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblTrack
            // 
            lblTrack.AutoSize = true;
            lblTrack.BackColor = Color.Transparent;
            lblTrack.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTrack.Location = new Point(283, 59);
            lblTrack.Margin = new Padding(4, 0, 4, 0);
            lblTrack.Name = "lblTrack";
            lblTrack.Size = new Size(898, 96);
            lblTrack.TabIndex = 5;
            lblTrack.Text = "SMART-MED TRACKING";
            lblTrack.Click += label3_Click;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(753, 280);
            txtUsername.Margin = new Padding(4, 5, 4, 5);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(395, 31);
            txtUsername.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(753, 479);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(395, 31);
            txtPassword.TabIndex = 7;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnEnter
            // 
            btnEnter.BackColor = SystemColors.GradientInactiveCaption;
            btnEnter.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnter.Location = new Point(283, 850);
            btnEnter.Margin = new Padding(4, 5, 4, 5);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(259, 90);
            btnEnter.TabIndex = 8;
            btnEnter.Text = "ENTER";
            btnEnter.UseVisualStyleBackColor = false;
            btnEnter.Click += btnEnter_Click;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.BackColor = Color.Transparent;
            lblRole.Font = new Font("Segoe UI Black", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(361, 612);
            lblRole.Margin = new Padding(4, 0, 4, 0);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(163, 60);
            lblRole.TabIndex = 9;
            lblRole.Text = "ROLE :";
            // 
            // cmbRoles
            // 
            cmbRoles.FormattingEnabled = true;
            cmbRoles.Items.AddRange(new object[] { "Administrator", "Assistant", "Recepient" });
            cmbRoles.Location = new Point(753, 637);
            cmbRoles.Margin = new Padding(4, 5, 4, 5);
            cmbRoles.Name = "cmbRoles";
            cmbRoles.Size = new Size(280, 33);
            cmbRoles.TabIndex = 10;
            cmbRoles.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1194, 941);
            Controls.Add(cmbRoles);
            Controls.Add(lblRole);
            Controls.Add(btnEnter);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblTrack);
            Controls.Add(btnClose);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmLogin";
            Text = "Login Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private Label lblPassword;
        private Button btnClose;
        private Label lblTrack;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnEnter;
        private Label lblRole;
        private ComboBox cmbRoles;
    }
}