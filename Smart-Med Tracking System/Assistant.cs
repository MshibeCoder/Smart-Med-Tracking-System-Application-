using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Smart_Med_Tracking_System
{
    public partial class frmAssistant : Form
    {
        public frmAssistant()
        {
            InitializeComponent();

            Database database = new Database();
            dgvShipments.DataSource = database.GetShipmentsAndSensors();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
