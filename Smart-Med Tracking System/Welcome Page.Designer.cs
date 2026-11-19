namespace Smart_Med_Tracking_System
{
    partial class frmWelcomePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogin = new Button();
            btnClose = new Button();
            lblWelcome = new Label();
            btnSignUp = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.GradientInactiveCaption;
            btnLogin.Font = new Font("Segoe UI Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(679, 490);
            btnLogin.Margin = new Padding(4, 5, 4, 5);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(370, 94);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.GradientInactiveCaption;
            btnClose.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(1312, 837);
            btnClose.Margin = new Padding(4, 5, 4, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(239, 94);
            btnClose.TabIndex = 1;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += button2_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.Black;
            lblWelcome.Location = new Point(629, 51);
            lblWelcome.Margin = new Padding(4, 0, 4, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(545, 96);
            lblWelcome.TabIndex = 2;
            lblWelcome.Text = "WELCOME TO ";
            lblWelcome.Click += label1_Click;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = SystemColors.GradientInactiveCaption;
            btnSignUp.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignUp.Location = new Point(125, 837);
            btnSignUp.Margin = new Padding(4, 5, 4, 5);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(254, 94);
            btnSignUp.TabIndex = 3;
            btnSignUp.Text = "SIGN UP";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(329, 180);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(1204, 96);
            label1.TabIndex = 4;
            label1.Text = "SMART-MED TRACKING SYSTEM";
            // 
            // frmWelcomePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background_Pic;
            ClientSize = new Size(1620, 945);
            Controls.Add(label1);
            Controls.Add(btnSignUp);
            Controls.Add(lblWelcome);
            Controls.Add(btnClose);
            Controls.Add(btnLogin);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmWelcomePage";
            Text = "Welcome Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Button btnClose;
        private Label lblWelcome;
        private Button btnSignUp;
        private Label label1;
    }
}
