
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RDPClientApplication
{
    public partial class Confirmation : Form
    {
        List<Software> list = new List<Software>();

        private  int imageHeight = 20;
        private int imageWidth = 20;

        public Confirmation(List<Software> list)
        {
            InitializeComponent();
            this.list = list;
            dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridView.RowHeadersVisible = false;
            dataGridView.AllowUserToAddRows = false;
            InitDataGridViewColumns();

            InitDataDridViewData();
        }

        private void InitDataDridViewData()
        {
            foreach (Software sft in list)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView);
                row.Cells[0].Value = sft.name;
                var imageCell = (DataGridViewImageCell)row.Cells[1];
                imageCell.Value = Constant.ResizeImage(Properties.Resources.tick_icon, new Size(imageWidth, imageHeight));
                dataGridView.Rows.Add(row);
            }
        }

        private void InitDataGridViewColumns()
        {
            //column 0 - Client ID
            DataGridViewTextBoxColumn softwareNamecolumn = new DataGridViewTextBoxColumn();
            softwareNamecolumn.HeaderText = "SOFTWARE NAME";
            softwareNamecolumn.Name = "softwarename";

            dataGridView.Columns.Add(softwareNamecolumn);

            //column 1 - downloadcomplete
            DataGridViewImageColumn donwloadComplete = new DataGridViewImageColumn();
            donwloadComplete.HeaderText = "DOWNLOAD COMPLETE";
            donwloadComplete.Name = "donwloadComplete";
            donwloadComplete.Image = Constant.ResizeImage(Properties.Resources.cross_icon, new Size(imageWidth, imageHeight));
           
            dataGridView.Columns.Add(donwloadComplete);

            //column 2 - installation request
            DataGridViewImageColumn installationrequest = new DataGridViewImageColumn();
            installationrequest.HeaderText = "INSTALLATION REQUEST";
            installationrequest.Name = "installationrequest";
            installationrequest.Image = Constant.ResizeImage(Properties.Resources.cross_icon, new Size(imageWidth, imageHeight));

            dataGridView.Columns.Add(installationrequest);

            //column 3 - installation DONE
            DataGridViewImageColumn installationdone = new DataGridViewImageColumn();
            installationdone.HeaderText = "INSTALLATION DONE";
            installationdone.Name = "installationdone";
            installationdone.Image = Constant.ResizeImage(Properties.Resources.cross_icon, new Size(imageWidth, imageHeight));
            
            dataGridView.Columns.Add(installationdone);

            //column 4 - CONFIRMED
            DataGridViewImageColumn confirmed = new DataGridViewImageColumn();
            confirmed.HeaderText = "CONFIRMED";
            confirmed.Name = "confirmed";
            confirmed.Image = Constant.ResizeImage(Properties.Resources.cross_icon, new Size(imageWidth, imageHeight));
           
            dataGridView.Columns.Add(confirmed);
        }

        private void Confirmation_Load(object sender, EventArgs e)
        {
            //int locationY = label1.Location.Y + 50;
            //foreach (Software sft in list)
            //{
                
            //    Label dynamicLabel = new Label()
            //    {
            //        AutoSize = true,
            //        Text = sft.name,
            //        Location = new Point(label1.Location.X , locationY)
            //    };
            //    this.Controls.Add(dynamicLabel);
            //   // groupBox1.Visible = true;
            //    //groupBox1.Location = new Point(dynamicLabel.Location.X, dynamicLabel.Location.Y + 20);
            //    circularProgressBarDownloadCompleted.Value = 100;



            //     locationY = locationY + 50;
            //}
        }

        private void btnYes_Click(object sender, EventArgs e)
        {

            // this.BeginInvoke((Action)(() => progressBar1.Value = /100));
            // circularProgressBarInstallationAccepted.Value = 100;
           for(int i = 0;i<dataGridView.Rows.Count;i++)
            {
                var imageCell = (DataGridViewImageCell)dataGridView.Rows[i].Cells[2];
                imageCell.Value = Constant.ResizeImage(Properties.Resources.tick_icon, new Size(imageWidth, imageHeight));
                
            }
                
            foreach (Software sft in list)
            {
                Process p = Process.Start(sft.softwareDownloadLocation);
                while (true)
                {
                    
                    if (p.HasExited)
                    {
                        break;
                    }
                   
                }
                InstallationSuccessful(sft);
            }
        }

        private void InstallationSuccessful(Software sft)
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                var nameCell = (DataGridViewTextBoxCell)dataGridView.Rows[i].Cells[0];
                if (nameCell.Value.ToString() == sft.name)
                {
                    var imageCell = (DataGridViewImageCell)dataGridView.Rows[i].Cells[3];
                    imageCell.Value = Constant.ResizeImage(Properties.Resources.tick_icon, new Size(imageWidth, imageHeight));
                }

            }
            DialogResult dialogResult = MessageBox.Show("Software installed successfully", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // circularProgressBarInstallationAccepted.Value = 100;
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    var nameCell = (DataGridViewTextBoxCell)dataGridView.Rows[i].Cells[0];
                    if (nameCell.Value.ToString() == sft.name)
                    {
                        var imageCell = (DataGridViewImageCell)dataGridView.Rows[i].Cells[4];
                        imageCell.Value = Constant.ResizeImage(Properties.Resources.tick_icon, new Size(imageWidth, imageHeight));
                    }

                }
                DatabaseConnection.InsertOrUpadteSoftwareInstallFromServer(sft, "Yes");
            }
            else if (dialogResult == DialogResult.No)
            {

                //save status in database
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    var nameCell = (DataGridViewTextBoxCell)dataGridView.Rows[i].Cells[0];
                    if (nameCell.Value.ToString() == sft.name)
                    {
                        var imageCell = (DataGridViewImageCell)dataGridView.Rows[i].Cells[4];
                        imageCell.Value = Constant.ResizeImage(Properties.Resources.cross_icon, new Size(imageWidth, imageHeight));
                    }

                }
                DatabaseConnection.InsertOrUpadteSoftwareInstallFromServer(sft, "No");
            }
        }
    }
}
