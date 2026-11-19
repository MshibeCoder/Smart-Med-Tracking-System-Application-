namespace Smart_Med_Tracking_System
{
    partial class frmRecepient
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
            btnClose = new Button();
            btnBack = new Button();
            lblTracking = new Label();
            dgvRecipientData = new DataGridView();
            cmbRecipientView = new ComboBox();
            btnAddOrder = new Button();
            btnEditOrder = new Button();
            btnDeleteOrder = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRecipientData).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.GradientInactiveCaption;
            btnClose.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(651, 632);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(183, 72);
            btnClose.TabIndex = 0;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.GradientInactiveCaption;
            btnBack.Font = new Font("Segoe UI Black", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(49, 632);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(168, 72);
            btnBack.TabIndex = 1;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblTracking
            // 
            lblTracking.AutoSize = true;
            lblTracking.BackColor = Color.Transparent;
            lblTracking.Font = new Font("Segoe UI Black", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTracking.Location = new Point(121, 72);
            lblTracking.Name = "lblTracking";
            lblTracking.Size = new Size(749, 81);
            lblTracking.TabIndex = 2;
            lblTracking.Text = "SMART-MED TRACKING";
            // 
            // dgvRecipientData
            // 
            dgvRecipientData.AllowUserToAddRows = false;
            dgvRecipientData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecipientData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecipientData.Location = new Point(121, 257);
            dgvRecipientData.MultiSelect = false;
            dgvRecipientData.Name = "dgvRecipientData";
            dgvRecipientData.ReadOnly = true;
            dgvRecipientData.RowHeadersWidth = 51;
            dgvRecipientData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecipientData.Size = new Size(749, 188);
            dgvRecipientData.TabIndex = 3;
            // 
            // cmbRecipientView
            // 
            cmbRecipientView.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRecipientView.FormattingEnabled = true;
            cmbRecipientView.Items.AddRange(new object[] { "Shipments ", "Orders" });
            cmbRecipientView.Location = new Point(135, 183);
            cmbRecipientView.Name = "cmbRecipientView";
            cmbRecipientView.Size = new Size(151, 28);
            cmbRecipientView.TabIndex = 4;
            // 
            // btnAddOrder
            // 
            btnAddOrder.Location = new Point(382, 183);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(94, 29);
            btnAddOrder.TabIndex = 5;
            btnAddOrder.Text = "Add Order";
            btnAddOrder.UseVisualStyleBackColor = true;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // btnEditOrder
            // 
            btnEditOrder.Location = new Point(554, 183);
            btnEditOrder.Name = "btnEditOrder";
            btnEditOrder.Size = new Size(94, 29);
            btnEditOrder.TabIndex = 6;
            btnEditOrder.Text = "Edit Order";
            btnEditOrder.UseVisualStyleBackColor = true;
            btnEditOrder.Click += btnEditOrder_Click;
            // 
            // btnDeleteOrder
            // 
            btnDeleteOrder.Location = new Point(740, 183);
            btnDeleteOrder.Name = "btnDeleteOrder";
            btnDeleteOrder.Size = new Size(94, 29);
            btnDeleteOrder.TabIndex = 7;
            btnDeleteOrder.Text = "Delete Order";
            btnDeleteOrder.UseVisualStyleBackColor = true;
            btnDeleteOrder.Click += btnDeleteOrder_Click;
            // 
            // frmRecepient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Picture1;
            ClientSize = new Size(918, 739);
            Controls.Add(btnDeleteOrder);
            Controls.Add(btnEditOrder);
            Controls.Add(btnAddOrder);
            Controls.Add(cmbRecipientView);
            Controls.Add(dgvRecipientData);
            Controls.Add(lblTracking);
            Controls.Add(btnBack);
            Controls.Add(btnClose);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmRecepient";
            Text = "Recepient";
            ((System.ComponentModel.ISupportInitialize)dgvRecipientData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Button btnBack;
        private Label lblTracking;
        private DataGridView dgvRecipientData;
        private ComboBox cmbRecipientView;
        private Button btnAddOrder;
        private Button btnEditOrder;
        private Button btnDeleteOrder;
    }
}