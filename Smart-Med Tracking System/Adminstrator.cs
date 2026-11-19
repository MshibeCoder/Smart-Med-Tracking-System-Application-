using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Smart_Med_Tracking_System
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
            cmbAdminTable.SelectedIndexChanged += cmbAdminTable_SelectedIndexChanged;
            cmbAdminTable.SelectedIndex = 0;
        }

        private void cmbAdminTable_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cmbAdminTable.SelectedItem?.ToString() == "Vaccines")
            {
                Database database = new Database();
                dgvAdminData.DataSource = database.GetVaccines();
            }
            else if (cmbAdminTable.SelectedItem?.ToString() == "Shipments & Sensors")
            {
                Database database = new Database();
                dgvAdminData.DataSource = database.GetShipmentsAndSensors();
            }
            else if (cmbAdminTable.SelectedItem?.ToString() == "Inventory Transactions")
            {
                Database database = new Database();
                dgvAdminData.DataSource = database.GetInventoryTransactions();
            }
            else if (cmbAdminTable.SelectedItem?.ToString() == "Notifications")
            {
                Database database = new Database();
                dgvAdminData.DataSource = database.GetNotifications();
            }
            else if (cmbAdminTable.SelectedItem?.ToString() == "Users")
            {
                Database database = new Database();
                dgvAdminData.DataSource = database.GetUsers();
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

        private void btnAddVaccine_Click(object sender, EventArgs e)
        {
            if (cmbAdminTable.SelectedItem?.ToString() != "Vaccines")
            {
                MessageBox.Show("Select Vaccines before adding a vaccine.");
                return;
            }

            using (frmAddVaccine addForm = new frmAddVaccine())
            {
                if (addForm.ShowDialog(this) == DialogResult.OK)
                {
                    Database database = new Database();
                    dgvAdminData.DataSource = database.GetVaccines();
                }
            }
        }

        private void btnEditVaccine_Click(object sender, EventArgs e)
        {
            if (cmbAdminTable.SelectedItem?.ToString() != "Vaccines")
            {
                MessageBox.Show("Select Vaccines first.");
                return;
            }

            if (dgvAdminData.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a vaccine row to edit.");
                return;
            }

            int vaccineId = Convert.ToInt32(
                dgvAdminData.SelectedRows[0].Cells["vaccineId"].Value);

            using (frmAddVaccine editForm = new frmAddVaccine(vaccineId))
            {
                if (editForm.ShowDialog(this) == DialogResult.OK)
                {
                    Database database = new Database();
                    dgvAdminData.DataSource = database.GetVaccines();
                }
            }
        }

        private void btnDeleteVaccine_Click(object sender, EventArgs e)
        {
            if (cmbAdminTable.SelectedItem?.ToString() != "Vaccines")
            {
                MessageBox.Show("Select Vaccines first.");
                return;
            }

            if (dgvAdminData.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a vaccine row to delete.");
                return;
            }

            int vaccineId = Convert.ToInt32(
                dgvAdminData.SelectedRows[0].Cells["vaccineId"].Value);

            DialogResult answer = MessageBox.Show(
                "Are you sure you want to delete this vaccine?",
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
                database.DeleteVaccine(vaccineId);

                MessageBox.Show("Vaccine deleted successfully.");
                dgvAdminData.DataSource = database.GetVaccines();
            }
            catch (Microsoft.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show(
                    "Could not delete this vaccine. It may be linked to shipments, inventory transactions, or notifications.\n\n" +
                    ex.Message);
            }
        }
    }
}
