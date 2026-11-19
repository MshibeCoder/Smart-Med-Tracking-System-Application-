using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Smart_Med_Tracking_System
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            this.AcceptButton = btnEnter;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
           

            if (cmbRoles.SelectedItem == null)
            {
                MessageBox.Show("Please select a role.");
                return;
            }

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string selectedRole = cmbRoles.SelectedItem.ToString()!;

            // Your ComboBox currently says "Recepient",
            // while the database role is spelled "Recipient".
            string databaseRole = selectedRole == "Recepient"
                ? "Recipient"
                : selectedRole;

            try
            {
                Database database = new Database();

                if (!database.ValidateLogin(username, password, databaseRole))
                {
                    MessageBox.Show("Username, password, or role is incorrect.");
                    return;
                }

                Form nextForm;

                switch (databaseRole)
                {
                    case "Administrator":
                        nextForm = new frmAdmin();
                        break;

                    case "Assistant":
                        nextForm = new frmAssistant();
                        break;

                    case "Recipient":
                        nextForm = new frmRecepient();
                        break;

                    default:
                        MessageBox.Show("That role is not supported.");
                        return;
                }

                nextForm.Show();
                this.Hide();
            }
            catch (Microsoft.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
