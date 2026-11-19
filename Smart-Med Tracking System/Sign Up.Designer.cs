namespace Smart_Med_Tracking_System
{
    partial class frmSignUp
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
            txtID = new TextBox();
            txtPass = new TextBox();
            txtUser = new TextBox();
            txtConfirm = new TextBox();
            label1 = new Label();
            lblConfirm = new Label();
            lblPass = new Label();
            lblUser = new Label();
            btnEnter = new Button();
            btnBack = new Button();
            lblID = new Label();
            lblUserRole = new Label();
            cmbUserRoles = new ComboBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.Location = new Point(511, 475);
            txtID.Margin = new Padding(4, 5, 4, 5);
            txtID.Name = "txtID";
            txtID.Size = new Size(340, 31);
            txtID.TabIndex = 0;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(436, 644);
            txtPass.Margin = new Padding(4, 5, 4, 5);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(292, 31);
            txtPass.TabIndex = 1;
            txtPass.UseSystemPasswordChar = true;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(404, 276);
            txtUser.Margin = new Padding(4, 5, 4, 5);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(324, 31);
            txtUser.TabIndex = 2;
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new Point(593, 744);
            txtConfirm.Margin = new Padding(4, 5, 4, 5);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(314, 31);
            txtConfirm.TabIndex = 3;
            txtConfirm.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(131, 61);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(918, 96);
            label1.TabIndex = 4;
            label1.Text = "SMART-MED TRACKING ";
            // 
            // lblConfirm
            // 
            lblConfirm.AutoSize = true;
            lblConfirm.BackColor = Color.Transparent;
            lblConfirm.Font = new Font("Segoe UI Black", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConfirm.Location = new Point(42, 728);
            lblConfirm.Margin = new Padding(4, 0, 4, 0);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new Size(528, 60);
            lblConfirm.TabIndex = 5;
            lblConfirm.Text = "CONFIRM PASSWORD :";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.BackColor = Color.Transparent;
            lblPass.Font = new Font("Segoe UI Black", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPass.Location = new Point(42, 619);
            lblPass.Margin = new Padding(4, 0, 4, 0);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(306, 60);
            lblPass.TabIndex = 6;
            lblPass.Text = "PASSWORD :";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.BackColor = Color.Transparent;
            lblUser.Font = new Font("Segoe UI Black", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.Location = new Point(42, 249);
            lblUser.Margin = new Padding(4, 0, 4, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(299, 60);
            lblUser.TabIndex = 7;
            lblUser.Text = "USERNAME :";
            // 
            // btnEnter
            // 
            btnEnter.BackColor = SystemColors.GradientInactiveCaption;
            btnEnter.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnter.ForeColor = SystemColors.ControlText;
            btnEnter.Location = new Point(80, 856);
            btnEnter.Margin = new Padding(4, 5, 4, 5);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(252, 95);
            btnEnter.TabIndex = 8;
            btnEnter.Text = "ENTER";
            btnEnter.UseVisualStyleBackColor = false;
            btnEnter.Click += btnEnter_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.GradientInactiveCaption;
            btnBack.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(864, 856);
            btnBack.Margin = new Padding(4, 5, 4, 5);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(199, 95);
            btnBack.TabIndex = 9;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.BackColor = Color.Transparent;
            lblID.Font = new Font("Segoe UI Black", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblID.Location = new Point(36, 446);
            lblID.Margin = new Padding(4, 0, 4, 0);
            lblID.Name = "lblID";
            lblID.Size = new Size(467, 60);
            lblID.TabIndex = 10;
            lblID.Text = "IDENTITY NUMBER :";
            // 
            // lblUserRole
            // 
            lblUserRole.AutoSize = true;
            lblUserRole.BackColor = Color.Transparent;
            lblUserRole.Font = new Font("Segoe UI Black", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserRole.Location = new Point(42, 336);
            lblUserRole.Margin = new Padding(4, 0, 4, 0);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new Size(163, 60);
            lblUserRole.TabIndex = 11;
            lblUserRole.Text = "ROLE :";
            // 
            // cmbUserRoles
            // 
            cmbUserRoles.FormattingEnabled = true;
            cmbUserRoles.Items.AddRange(new object[] { "Administator", "Assistant", "Recipient" });
            cmbUserRoles.Location = new Point(268, 365);
            cmbUserRoles.Margin = new Padding(4, 5, 4, 5);
            cmbUserRoles.Name = "cmbUserRoles";
            cmbUserRoles.Size = new Size(223, 33);
            cmbUserRoles.TabIndex = 12;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Segoe UI Black", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(42, 530);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(377, 61);
            lblEmail.TabIndex = 13;
            lblEmail.Text = "EMAL ADDRESS";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(572, 556);
            txtEmail.Margin = new Padding(4, 4, 4, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(302, 31);
            txtEmail.TabIndex = 14;
            // 
            // frmSignUp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Picture1;
            ClientSize = new Size(1171, 971);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(cmbUserRoles);
            Controls.Add(lblUserRole);
            Controls.Add(lblID);
            Controls.Add(btnBack);
            Controls.Add(btnEnter);
            Controls.Add(lblUser);
            Controls.Add(lblPass);
            Controls.Add(lblConfirm);
            Controls.Add(label1);
            Controls.Add(txtConfirm);
            Controls.Add(txtUser);
            Controls.Add(txtPass);
            Controls.Add(txtID);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmSignUp";
            Text = "Sign Up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtID;
        private TextBox txtPass;
        private TextBox txtUser;
        private TextBox txtConfirm;
        private Label label1;
        private Label lblConfirm;
        private Label lblPass;
        private Label lblUser;
        private Button btnEnter;
        private Button btnBack;
        private Label lblID;
        private Label lblUserRole;
        private ComboBox cmbUserRoles;
        private Label lblEmail;
        private TextBox txtEmail;
    }
}    

     

    