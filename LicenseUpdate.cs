using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDPClientApplication
{
    public partial class LicenseUpdate : Form
    {
        string softwareName = "";
        public LicenseUpdate()
        {
            InitializeComponent();
           
            //txtExpireDate.ReadOnly = true;
            txtLicenseKey.ReadOnly = true;
            txtTotalUsers.ReadOnly = true;
            txtUsersAssigned.ReadOnly = true;
            txtUsersLeft.ReadOnly = true;
            txtVersion.ReadOnly = true;
            txtTimeActivated.ReadOnly = true;
        }

        private async void LicenseUpdate_Load(object sender, EventArgs e)
        {
            List<Software> softwareList = DatabaseConnection.ReadSoftwareList();
            if(softwareList.Count > 0)
            {
                InitSoftwareNames(softwareList);
            }
            else
            {
                SoftwareList obj = new SoftwareList();
                bool success = await Task.Factory.StartNew(() => obj.ReadSoftwareDetails());
                if (success)
                {
                    List<Software> softwareList1 = DatabaseConnection.ReadSoftwareList();
                    InitSoftwareNames(softwareList1);
                }
            }
        }

        private void InitSoftwareNames(List<Software> softwareList)
        {
            foreach(Software sft in softwareList)
            {
                comboBox.Items.Add(sft.name);
            }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            softwareName = comboBox.SelectedItem.ToString();
            License details = DatabaseConnection.ReadLicenseDetails(softwareName, StartUp.client.processorId);
            if (details != null)
            {
                expiredateTimePicker.Value = details.expireDate;
                //txtExpireDate.Text = details.expireDate;
                txtLicenseKey.Text = details.key;
                txtTotalUsers.Text = details.totalUsers;
                txtUsersAssigned.Text = details.usersAssigned;
                txtUsersLeft.Text = details.usersLeft;
                txtVersion.Text = details.version;
                txtTimeActivated.Text = details.timeActivated;
                dateTimePicker.Value = details.installDate;
            }
            else
            {
                //expiredateTimePicker.Value = details.expireDate;
                //txtExpireDate.Text = details.expireDate;
                txtLicenseKey.Text = "";
                txtTotalUsers.Text ="";
                txtUsersAssigned.Text = "";
                txtUsersLeft.Text = "";
                txtVersion.Text = "";
                txtTimeActivated.Text = "";
               // dateTimePicker.Value = details.installDate;
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtLicenseKey.ReadOnly = false;
            txtTotalUsers.ReadOnly = false;
            txtUsersAssigned.ReadOnly = false;
            txtUsersLeft.ReadOnly = false;
            txtVersion.ReadOnly = false;
            btnDone.Enabled = true;
            btnUpdate.Enabled = false;
            txtTimeActivated.ReadOnly = false;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (txtLicenseKey.Text == "")
            {
                var com = new CustomMessageBox("License Update", "License Key is mandatory", Properties.Resources.info_icon);
                com.ShowDialog();
            }

            if (txtTimeActivated.Text == "")
            {
                var com = new CustomMessageBox("License Update ", "License time is mandatory", Properties.Resources.info_icon);
                com.ShowDialog();
                return;
            }
            if (txtTotalUsers.Text == "")
            {
                var com = new CustomMessageBox("License Update ", "Total users is mandatory", Properties.Resources.info_icon);
                com.ShowDialog();
                return;
            }
            if (Convert.ToInt32(txtTotalUsers.Text) < Convert.ToInt32(txtUsersAssigned.Text))
            {
                var com = new CustomMessageBox("License Update ", "Total users cannot be less than assigned users", Properties.Resources.info_icon);
                com.ShowDialog();
                return;
            }
            License updatedDetails = new License();
            updatedDetails.expireDate = expiredateTimePicker.Value;
            updatedDetails.key = txtLicenseKey.Text;
            updatedDetails.softwareName = softwareName;
            updatedDetails.processorid = StartUp.client.processorId;
            updatedDetails.version = txtVersion.Text;
            updatedDetails.totalUsers = txtTotalUsers.Text;
            updatedDetails.usersAssigned = txtUsersAssigned.Text;
            updatedDetails.usersLeft = txtUsersLeft.Text;
            updatedDetails.timeActivated = txtTimeActivated.Text;
            updatedDetails.installDate = dateTimePicker.Value;

            bool isSucessful = DatabaseConnection.UpdateLicenseDetails(updatedDetails);
            if (isSucessful)
            {
                var com = new CustomMessageBox("License Update ", "License details updated successfully", Properties.Resources.tick_icon);
                com.ShowDialog();
                this.Close();
            }
            else
            {
                var com = new CustomMessageBox("License Update ", "Error while upadating licence details", Properties.Resources.cross_icon);
                com.ShowDialog();
            }
        }

        private void txtUsersAssigned_TextChanged(object sender, EventArgs e)
        {
            if (txtUsersAssigned.Text != "" && txtTotalUsers.Text != "")
            {
                txtUsersLeft.Text = (Convert.ToInt32(txtTotalUsers.Text) - Convert.ToInt32(txtUsersAssigned.Text)).ToString();
            }
        }

        private void txtTimeActivated_TextChanged(object sender, EventArgs e)
        {
            if (txtTimeActivated.Text != "")
            {
                int days = Convert.ToInt32(txtTimeActivated.Text);


                expiredateTimePicker.Value = DateTime.Today.AddDays(days);
            }
        }

        private void txtTotalUsers_TextChanged(object sender, EventArgs e)
        {
            if (txtUsersAssigned.Text != "" && txtTotalUsers.Text != "")
            {
                txtUsersLeft.Text = (Convert.ToInt32(txtTotalUsers.Text) - Convert.ToInt32(txtUsersAssigned.Text)).ToString();
            }
        }
    }
}
