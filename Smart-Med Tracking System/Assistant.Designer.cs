namespace Smart_Med_Tracking_System
{
    partial class frmAssistant
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
            lblSmart = new Label();
            btnBack = new Button();
            btnClose = new Button();
            dgvShipments = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvShipments).BeginInit();
            SuspendLayout();
            // 
            // lblSmart
            // 
            lblSmart.AutoSize = true;
            lblSmart.BackColor = Color.Transparent;
            lblSmart.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSmart.Location = new Point(112, 64);
            lblSmart.Name = "lblSmart";
            lblSmart.Size = new Size(749, 81);
            lblSmart.TabIndex = 0;
            lblSmart.Text = "SMART-MED TRACKING";
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.GradientInactiveCaption;
            btnBack.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(67, 679);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(173, 72);
            btnBack.TabIndex = 1;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.GradientInactiveCaption;
            btnClose.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(681, 679);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(176, 72);
            btnClose.TabIndex = 2;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // dgvShipments
            // 
            dgvShipments.AllowUserToAddRows = false;
            dgvShipments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvShipments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShipments.Location = new Point(131, 219);
            dgvShipments.Name = "dgvShipments";
            dgvShipments.ReadOnly = true;
            dgvShipments.RowHeadersWidth = 51;
            dgvShipments.Size = new Size(712, 188);
            dgvShipments.TabIndex = 3;
            // 
            // frmAssistant
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Picture1;
            ClientSize = new Size(920, 767);
            Controls.Add(dgvShipments);
            Controls.Add(btnClose);
            Controls.Add(btnBack);
            Controls.Add(lblSmart);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmAssistant";
            Text = "Assistant";
            ((System.ComponentModel.ISupportInitialize)dgvShipments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSmart;
        private Button btnBack;
        private Button btnClose;
        private DataGridView dgvShipments;
    }
}