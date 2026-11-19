namespace Smart_Med_Tracking_System
{
    partial class frmAddVaccine
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtVaccineName = new TextBox();
            txtManufacturer = new TextBox();
            txtBatchNumber = new TextBox();
            dtpExpiryDate = new DateTimePicker();
            numMinTemp = new NumericUpDown();
            numMaxTemp = new NumericUpDown();
            numQuantity = new NumericUpDown();
            btnSaveVaccine = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numMinTemp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMaxTemp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(409, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(149, 25);
            label1.TabIndex = 0;
            label1.Text = "Add New Vaccine";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 88);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(122, 25);
            label2.TabIndex = 1;
            label2.Text = "Vaccine Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 156);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(117, 25);
            label3.TabIndex = 2;
            label3.Text = "Manufacturer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 220);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(125, 25);
            label4.TabIndex = 3;
            label4.Text = "Batch Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 286);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(101, 25);
            label5.TabIndex = 4;
            label5.Text = "Expiry Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(52, 342);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(191, 25);
            label6.TabIndex = 5;
            label6.Text = "Minimum Temperature";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(54, 405);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(194, 25);
            label7.TabIndex = 6;
            label7.Text = "Maximum Temperature";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(54, 462);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(80, 25);
            label8.TabIndex = 7;
            label8.Text = "Quantity";
            // 
            // txtVaccineName
            // 
            txtVaccineName.Location = new Point(320, 79);
            txtVaccineName.Margin = new Padding(4, 4, 4, 4);
            txtVaccineName.Name = "txtVaccineName";
            txtVaccineName.Size = new Size(155, 31);
            txtVaccineName.TabIndex = 8;
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(320, 136);
            txtManufacturer.Margin = new Padding(4, 4, 4, 4);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(155, 31);
            txtManufacturer.TabIndex = 9;
            // 
            // txtBatchNumber
            // 
            txtBatchNumber.Location = new Point(320, 199);
            txtBatchNumber.Margin = new Padding(4, 4, 4, 4);
            txtBatchNumber.Name = "txtBatchNumber";
            txtBatchNumber.Size = new Size(155, 31);
            txtBatchNumber.TabIndex = 10;
            // 
            // dtpExpiryDate
            // 
            dtpExpiryDate.Location = new Point(320, 278);
            dtpExpiryDate.Margin = new Padding(4, 4, 4, 4);
            dtpExpiryDate.Name = "dtpExpiryDate";
            dtpExpiryDate.Size = new Size(312, 31);
            dtpExpiryDate.TabIndex = 11;
            // 
            // numMinTemp
            // 
            numMinTemp.DecimalPlaces = 2;
            numMinTemp.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numMinTemp.Location = new Point(320, 334);
            numMinTemp.Margin = new Padding(4, 4, 4, 4);
            numMinTemp.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numMinTemp.Name = "numMinTemp";
            numMinTemp.Size = new Size(188, 31);
            numMinTemp.TabIndex = 12;
            // 
            // numMaxTemp
            // 
            numMaxTemp.DecimalPlaces = 2;
            numMaxTemp.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numMaxTemp.Location = new Point(320, 396);
            numMaxTemp.Margin = new Padding(4, 4, 4, 4);
            numMaxTemp.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numMaxTemp.Name = "numMaxTemp";
            numMaxTemp.Size = new Size(188, 31);
            numMaxTemp.TabIndex = 13;
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(320, 454);
            numQuantity.Margin = new Padding(4, 4, 4, 4);
            numQuantity.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(188, 31);
            numQuantity.TabIndex = 14;
            // 
            // btnSaveVaccine
            // 
            btnSaveVaccine.Location = new Point(585, 458);
            btnSaveVaccine.Margin = new Padding(4, 4, 4, 4);
            btnSaveVaccine.Name = "btnSaveVaccine";
            btnSaveVaccine.Size = new Size(118, 36);
            btnSaveVaccine.TabIndex = 15;
            btnSaveVaccine.Text = "Save";
            btnSaveVaccine.UseVisualStyleBackColor = true;
            btnSaveVaccine.Click += btnSaveVaccine_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(778, 458);
            btnCancel.Margin = new Padding(4, 4, 4, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(118, 36);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmAddVaccine
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background_Pic;
            ClientSize = new Size(1000, 562);
            Controls.Add(btnCancel);
            Controls.Add(btnSaveVaccine);
            Controls.Add(numQuantity);
            Controls.Add(numMaxTemp);
            Controls.Add(numMinTemp);
            Controls.Add(dtpExpiryDate);
            Controls.Add(txtBatchNumber);
            Controls.Add(txtManufacturer);
            Controls.Add(txtVaccineName);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "frmAddVaccine";
            Text = "frmAddVaccine";
            Load += frmAddVaccine_Load;
            ((System.ComponentModel.ISupportInitialize)numMinTemp).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMaxTemp).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtVaccineName;
        private TextBox txtManufacturer;
        private TextBox txtBatchNumber;
        private DateTimePicker dtpExpiryDate;
        private NumericUpDown numMinTemp;
        private NumericUpDown numMaxTemp;
        private NumericUpDown numQuantity;
        private Button btnSaveVaccine;
        private Button btnCancel;
    }
}