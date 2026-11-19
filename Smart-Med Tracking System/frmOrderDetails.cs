using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Smart_Med_Tracking_System
{
    public partial class frmOrderDetails : Form
    {
        private int? _orderId;
        public frmOrderDetails(int? orderId = null)
        {
            InitializeComponent();

            _orderId = orderId;

            Database database = new Database();

            cmbOrderShipment.DataSource =
                database.GetShipmentsForOrderSelection("Greenacres Hospital");

            cmbOrderShipment.DisplayMember = "shipmentDisplay";
            cmbOrderShipment.ValueMember = "shipmentId";
            cmbOrderShipment.SelectedIndex = -1;

            if (_orderId.HasValue)
            {
                this.Text = "Edit Order";
                btnSaveOrder.Text = "Update Order";
                LoadOrderDetails(_orderId.Value);
            }
        }

        private void LoadOrderDetails(int orderId)
        {
            Database database = new Database();
            var table = database.GetOrderById(orderId);

            if (table.Rows.Count == 0)
            {
                MessageBox.Show("The selected order could not be found.");
                this.Close();
                return;
            }

            var row = table.Rows[0];

            numQuantityOrdered.Value =
                Convert.ToDecimal(row["quantityOrdered"]);

            dtpOrderDate.Value =
                Convert.ToDateTime(row["orderDate"]);

            cmbOrderShipment.SelectedValue =
                Convert.ToInt32(row["shipmentId"]);
        }

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            if (cmbOrderShipment.SelectedIndex == -1)
            {
                MessageBox.Show("Select a shipment.");
                return;
            }

            try
            {
                int shipmentId = Convert.ToInt32(cmbOrderShipment.SelectedValue);
                int quantity = Decimal.ToInt32(numQuantityOrdered.Value);

                Database database = new Database();

                if (_orderId.HasValue)
                {
                    database.UpdateOrder(
                        _orderId.Value,
                        shipmentId,
                        quantity,
                        dtpOrderDate.Value);

                    MessageBox.Show("Order updated successfully.");
                }
                else
                {
                    database.AddOrder(
                        shipmentId,
                        quantity,
                        dtpOrderDate.Value);

                    MessageBox.Show("Order added successfully.");
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Microsoft.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("Could not save the order: " + ex.Message);
            }
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
