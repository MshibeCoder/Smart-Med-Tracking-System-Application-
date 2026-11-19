using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Smart_Med_Tracking_System
{
    public partial class frmRecepient : Form
    {
        public frmRecepient()
        {
            InitializeComponent();

            cmbRecipientView.SelectedIndexChanged +=
                cmbRecipientView_SelectedIndexChanged;

            if (cmbRecipientView.SelectedIndex == -1)
            {
                cmbRecipientView.SelectedIndex = 0;
            }
            else
            {
                cmbRecipientView_SelectedIndexChanged(
                    cmbRecipientView, EventArgs.Empty);
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void cmbRecipientView_SelectedIndexChanged(object? sender, EventArgs e)
        {
            Database database = new Database();

            bool showOrderButtons = cmbRecipientView.SelectedIndex == 1;

            btnAddOrder.Visible = showOrderButtons;
            btnEditOrder.Visible = showOrderButtons;
            btnDeleteOrder.Visible = showOrderButtons;

            dgvRecipientData.DataSource = null;
            dgvRecipientData.AutoGenerateColumns = true;

            if (cmbRecipientView.SelectedIndex == 0)
            {
                var shipmentTable =
                    database.GetShipmentsForDestination("Greenacres Hospital");


                dgvRecipientData.DataSource = shipmentTable;
            }
            else if (cmbRecipientView.SelectedIndex == 1)
            {
                dgvRecipientData.DataSource =
                    database.GetOrdersForDestination("Greenacres Hospital");
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            using (frmOrderDetails orderForm = new frmOrderDetails())
            {
                if (orderForm.ShowDialog(this) == DialogResult.OK)
                {
                    Database database = new Database();
                    dgvRecipientData.DataSource =
                        database.GetOrdersForDestination("Greenacres Hospital");
                }
            }
        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            if (cmbRecipientView.SelectedIndex != 1)
            {
                MessageBox.Show("Select Orders first.");
                return;
            }

            if (dgvRecipientData.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select an order row to edit.");
                return;
            }

            int orderId = Convert.ToInt32(
                dgvRecipientData.SelectedRows[0].Cells["orderId"].Value);

            using (frmOrderDetails orderForm = new frmOrderDetails(orderId))
            {
                if (orderForm.ShowDialog(this) == DialogResult.OK)
                {
                    Database database = new Database();
                    dgvRecipientData.DataSource =
                        database.GetOrdersForDestination("Greenacres Hospital");
                }
            }
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (cmbRecipientView.SelectedIndex != 1)
            {
                MessageBox.Show("Select Orders first.");
                return;
            }

            if (dgvRecipientData.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select an order row to delete.");
                return;
            }

            int orderId = Convert.ToInt32(
                dgvRecipientData.SelectedRows[0].Cells["orderId"].Value);

            DialogResult answer = MessageBox.Show(
                "Are you sure you want to delete this order?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (answer != DialogResult.Yes)
            {
                return;
            }

            try
            {
                Database database = new Database();
                database.DeleteOrder(orderId);

                MessageBox.Show("Order deleted successfully.");
                dgvRecipientData.DataSource =
                    database.GetOrdersForDestination("Greenacres Hospital");
            }
            catch (Microsoft.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("Could not delete the order: " + ex.Message);
            } 
        }
    }
}
