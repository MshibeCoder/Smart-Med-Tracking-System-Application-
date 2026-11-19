namespace Smart_Med_Tracking_System
{
    partial class frmOrderDetails
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
            cmbOrderShipment = new ComboBox();
            numQuantityOrdered = new NumericUpDown();
            dtpOrderDate = new DateTimePicker();
            btnSaveOrder = new Button();
            btnCancelOrder = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numQuantityOrdered).BeginInit();
            SuspendLayout();
            // 
            // cmbOrderShipment
            // 
            cmbOrderShipment.FormattingEnabled = true;
            cmbOrderShipment.Location = new Point(256, 68);
            cmbOrderShipment.Name = "cmbOrderShipment";
            cmbOrderShipment.Size = new Size(151, 28);
            cmbOrderShipment.TabIndex = 0;
            // 
            // numQuantityOrdered
            // 
            numQuantityOrdered.Location = new Point(257, 130);
            numQuantityOrdered.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numQuantityOrdered.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantityOrdered.Name = "numQuantityOrdered";
            numQuantityOrdered.Size = new Size(150, 27);
            numQuantityOrdered.TabIndex = 1;
            numQuantityOrdered.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Location = new Point(257, 187);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(250, 27);
            dtpOrderDate.TabIndex = 2;
            // 
            // btnSaveOrder
            // 
            btnSaveOrder.Location = new Point(257, 265);
            btnSaveOrder.Name = "btnSaveOrder";
            btnSaveOrder.Size = new Size(94, 29);
            btnSaveOrder.TabIndex = 3;
            btnSaveOrder.Text = "Save";
            btnSaveOrder.UseVisualStyleBackColor = true;
            btnSaveOrder.Click += btnSaveOrder_Click;
            // 
            // btnCancelOrder
            // 
            btnCancelOrder.Location = new Point(413, 265);
            btnCancelOrder.Name = "btnCancelOrder";
            btnCancelOrder.Size = new Size(94, 29);
            btnCancelOrder.TabIndex = 4;
            btnCancelOrder.Text = "Cancel";
            btnCancelOrder.UseVisualStyleBackColor = true;
            btnCancelOrder.Click += btnCancelOrder_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 76);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 5;
            label1.Text = "Shipment ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 130);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 6;
            label2.Text = "Quantity Ordered";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 192);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 7;
            label3.Text = "Order Date";
            // 
            // frmOrderDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelOrder);
            Controls.Add(btnSaveOrder);
            Controls.Add(dtpOrderDate);
            Controls.Add(numQuantityOrdered);
            Controls.Add(cmbOrderShipment);
            Name = "frmOrderDetails";
            Text = "Order Details";
            ((System.ComponentModel.ISupportInitialize)numQuantityOrdered).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbOrderShipment;
        private NumericUpDown numQuantityOrdered;
        private DateTimePicker dtpOrderDate;
        private Button btnSaveOrder;
        private Button btnCancelOrder;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}