namespace Smart_Med_Tracking_System
{
    partial class frmAdmin
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
            lblMed = new Label();
            btnBack = new Button();
            btnClose = new Button();
            dgvAdminData = new DataGridView();
            cmbAdminTable = new ComboBox();
            btnAddVaccine = new Button();
            btnEditVaccine = new Button();
            btnDeleteVaccine = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAdminData).BeginInit();
            SuspendLayout();
            // 
            // lblMed
            // 
            lblMed.AutoSize = true;
            lblMed.BackColor = Color.Transparent;
            lblMed.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblMed.Location = new Point(107, 76);
            lblMed.Name = "lblMed";
            lblMed.Size = new Size(749, 81);
            lblMed.TabIndex = 0;
            lblMed.Text = "SMART-MED TRACKING";
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.GradientInactiveCaption;
            btnBack.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(69, 672);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(178, 72);
            btnBack.TabIndex = 1;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.GradientInactiveCaption;
            btnClose.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(678, 672);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(179, 72);
            btnClose.TabIndex = 2;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // dgvAdminData
            // 
            dgvAdminData.AllowUserToAddRows = false;
            dgvAdminData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAdminData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdminData.Location = new Point(91, 299);
            dgvAdminData.Name = "dgvAdminData";
            dgvAdminData.ReadOnly = true;
            dgvAdminData.RowHeadersWidth = 51;
            dgvAdminData.Size = new Size(750, 188);
            dgvAdminData.TabIndex = 3;
            // 
            // cmbAdminTable
            // 
            cmbAdminTable.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAdminTable.FormattingEnabled = true;
            cmbAdminTable.Items.AddRange(new object[] { "Vaccines", "Shipments & Sensors", "Inventory Transactions", "Notifications", "Users" });
            cmbAdminTable.Location = new Point(96, 202);
            cmbAdminTable.Name = "cmbAdminTable";
            cmbAdminTable.Size = new Size(151, 28);
            cmbAdminTable.TabIndex = 4;
            // 
            // btnAddVaccine
            // 
            btnAddVaccine.Location = new Point(321, 201);
            btnAddVaccine.Name = "btnAddVaccine";
            btnAddVaccine.Size = new Size(136, 29);
            btnAddVaccine.TabIndex = 5;
            btnAddVaccine.Text = "Add Vaccine";
            btnAddVaccine.UseVisualStyleBackColor = true;
            btnAddVaccine.Click += btnAddVaccine_Click;
            // 
            // btnEditVaccine
            // 
            btnEditVaccine.Location = new Point(536, 202);
            btnEditVaccine.Name = "btnEditVaccine";
            btnEditVaccine.Size = new Size(116, 29);
            btnEditVaccine.TabIndex = 6;
            btnEditVaccine.Text = "Edit Vaccine";
            btnEditVaccine.UseVisualStyleBackColor = true;
            btnEditVaccine.Click += btnEditVaccine_Click;
            // 
            // btnDeleteVaccine
            // 
            btnDeleteVaccine.Location = new Point(727, 202);
            btnDeleteVaccine.Name = "btnDeleteVaccine";
            btnDeleteVaccine.Size = new Size(94, 29);
            btnDeleteVaccine.TabIndex = 7;
            btnDeleteVaccine.Text = "Delete Vaccine";
            btnDeleteVaccine.UseVisualStyleBackColor = true;
            btnDeleteVaccine.Click += btnDeleteVaccine_Click;
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Picture1;
            ClientSize = new Size(925, 772);
            Controls.Add(btnDeleteVaccine);
            Controls.Add(btnEditVaccine);
            Controls.Add(btnAddVaccine);
            Controls.Add(cmbAdminTable);
            Controls.Add(dgvAdminData);
            Controls.Add(btnClose);
            Controls.Add(btnBack);
            Controls.Add(lblMed);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmAdmin";
            Text = "Adminstrator";
            ((System.ComponentModel.ISupportInitialize)dgvAdminData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMed;
        private Button btnBack;
        private Button btnClose;
        private DataGridView dgvAdminData;
        private ComboBox cmbAdminTable;
        private Button btnAddVaccine;
        private Button btnEditVaccine;
        private Button btnDeleteVaccine;
    }
}