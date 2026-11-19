using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Smart_Med_Tracking_System
{
    public partial class frmAddVaccine : Form
    {
        private int? _vaccineId;
        public frmAddVaccine(int? vaccineId = null)
        {
            InitializeComponent();

            _vaccineId = vaccineId;

            if (_vaccineId.HasValue)
            {
                this.Text = "Edit Vaccine";
                btnSaveVaccine.Text = "Update";
                LoadVaccineDetails(_vaccineId.Value);
            }
        }

        private void LoadVaccineDetails(int vaccineId)
        {
            Database database = new Database();
            DataTable table = database.GetVaccineById(vaccineId);

            if (table.Rows.Count == 0)
            {
                MessageBox.Show("The selected vaccine could not be found.");
                this.Close();
                return;
            }

            DataRow row = table.Rows[0];

            txtVaccineName.Text = Convert.ToString(row["vaccineName"]) ?? "";
            txtManufacturer.Text = Convert.ToString(row["manufacturer"]) ?? "";
            txtBatchNumber.Text = Convert.ToString(row["batchNumber"]) ?? "";
            dtpExpiryDate.Value = Convert.ToDateTime(row["expiryDate"]);
            numMinTemp.Value = Convert.ToDecimal(row["minTemp"]);
            numMaxTemp.Value = Convert.ToDecimal(row["maxTemp"]);
            numQuantity.Value = Convert.ToDecimal(row["quantity"]);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveVaccine_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtVaccineName.Text) ||
                string.IsNullOrWhiteSpace(txtManufacturer.Text) ||
                string.IsNullOrWhiteSpace(txtBatchNumber.Text))
            {
                MessageBox.Show("Complete all vaccine details.");
                return;
            }

            if (numMinTemp.Value >= numMaxTemp.Value)
            {
                MessageBox.Show("Minimum temperature must be lower than maximum temperature.");
                return;
            }

            try
            {
                Database database = new Database();

                if (_vaccineId.HasValue)
                {
                    database.UpdateVaccine(
                        _vaccineId.Value,
                        txtVaccineName.Text.Trim(),
                        txtManufacturer.Text.Trim(),
                        txtBatchNumber.Text.Trim(),
                        dtpExpiryDate.Value,
                        numMinTemp.Value,
                        numMaxTemp.Value,
                        Decimal.ToInt32(numQuantity.Value));

                    MessageBox.Show("Vaccine updated successfully.");
                }
                else
                {
                    database.AddVaccine(
                        txtVaccineName.Text.Trim(),
                        txtManufacturer.Text.Trim(),
                        txtBatchNumber.Text.Trim(),
                        dtpExpiryDate.Value,
                        numMinTemp.Value,
                        numMaxTemp.Value,
                        Decimal.ToInt32(numQuantity.Value));

                    MessageBox.Show("Vaccine added successfully.");
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Microsoft.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("Could not save the vaccine: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddVaccine_Load(object sender, EventArgs e)
        {

        }
    }
}
