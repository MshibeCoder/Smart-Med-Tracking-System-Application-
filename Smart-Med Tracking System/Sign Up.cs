using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Smart_Med_Tracking_System
{
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text) ||
                string.IsNullOrWhiteSpace(txtUser.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPass.Text) ||
                string.IsNullOrWhiteSpace(txtConfirm.Text))
            {
                MessageBox.Show("Complete all the fields.");
                return;
            }

            if (txtPass.Text != txtConfirm.Text)
            {
                MessageBox.Show("The passwords do not match.");
                return;
            }

            if (cmbUserRoles.SelectedItem == null)
            {
                MessageBox.Show("Please select a role.");
                return;
            }

            try
            {
                Database database = new Database();

                database.RegisterUser(
                    txtID.Text.Trim(),
                    txtUser.Text.Trim(),
                    txtPass.Text,
                    txtEmail.Text.Trim(),
                    cmbUserRoles.SelectedItem.ToString()!);

                MessageBox.Show("Account created. You can now sign in.");
                this.Close();
            }
            catch (Microsoft.Data.SqlClient.SqlException ex)
            {
                if (ex.Number == 2601 || ex.Number == 2627)
                {
                    MessageBox.Show("That identity number, username, or email is already registered.");
                }
                else
                {
                    MessageBox.Show("Could not create the account: " + ex.Message);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmWelcomePage welcomePage = new frmWelcomePage();
            welcomePage.Show();
        }
    }
}
