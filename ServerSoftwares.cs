using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;

namespace RDPClientApplication
{
    public partial class ServerSoftwares : Form
    {
        List<Software> requestedSoftwares;
        public ServerSoftwares()
        {
            InitializeComponent();
         
            this.listViewAvailableSoftware.CheckBoxes = true;
            

            // InitDataGridView();

            // InitData();

        }

        public ServerSoftwares(List<Software> requestedSoftwares)
        {
            InitializeComponent();
            this.requestedSoftwares = requestedSoftwares;
        }

        private void InitRequestSoftware(List<Software> requestedSoftwares)
        {
            foreach (Software sft in requestedSoftwares)
            {

                ListViewItem item = new ListViewItem();
                item.SubItems.Add(sft.name);
                item.SubItems.Add(sft.softwareVersion);
                item.SubItems.Add(sft.targetMachine);
                item.SubItems.Add(sft.licenseKey);
                item.SubItems.Add(sft.usersleft.ToString());

                item.SubItems.Add(sft.licenseExpireDate.ToString());
                item.SubItems.Add(sft.downloadLink);
                item.SubItems.Add(sft.licenseId.ToString());
                item.SubItems.Add(sft.licenseVersion);
                item.SubItems.Add(sft.serverProcessorId);
                item.SubItems.Add(sft.licenseValidatedFor.ToString());
                item.SubItems.Add(sft.softwareId.ToString());
                if (sft.usersleft > 0)
                {
                    listViewAvailableSoftware.Items.Add(item);
                }
            }
        }

        private void InitAvailableSoftwareData()
        {
            List<Software> list = DatabaseConnection.ReadServerSoftware();
            if (list.Count >0)
            {
                foreach (Software sft in list)
                {
                   
                    ListViewItem item = new ListViewItem();
                    item.SubItems.Add(sft.name);
                    item.SubItems.Add(sft.softwareVersion);
                    item.SubItems.Add(sft.targetMachine);
                    item.SubItems.Add(sft.licenseKey);
                    item.SubItems.Add(sft.usersleft.ToString());
             
                    item.SubItems.Add(sft.licenseExpireDate.ToString());
                    item.SubItems.Add(sft.downloadLink);
                    item.SubItems.Add(sft.licenseId.ToString());
                    item.SubItems.Add(sft.licenseVersion);
                    item.SubItems.Add(sft.serverProcessorId);
                    item.SubItems.Add(sft.licenseValidatedFor.ToString());
                    item.SubItems.Add(sft.softwareId.ToString()); 
                    if (sft.usersleft > 0)
                    {
                        listViewAvailableSoftware.Items.Add(item);
                    }
                }
                InitAllSoftwareData(list);
            }
        }

        private void InitAllSoftwareData(List<Software> list)
        {
           
            if (list.Count > 0)
            {
                foreach (Software sft in list)
                {

                    ListViewItem item = new ListViewItem(sft.name);
       
                    item.SubItems.Add(sft.softwareVersion);
                    item.SubItems.Add(sft.targetMachine);
                    item.SubItems.Add(sft.licenseKey);
                    item.SubItems.Add(sft.usersleft.ToString());
                    item.SubItems.Add(sft.licenseValidatedFor.ToString());
                    item.SubItems.Add(sft.licenseExpireDate.ToString());
                    item.SubItems.Add(sft.downloadLink);
                    item.SubItems.Add(sft.licenseId.ToString());
                    item.SubItems.Add(sft.licenseVersion);
                    item.SubItems.Add(sft.serverProcessorId);
                    item.SubItems.Add(sft.licenseValidatedFor.ToString()); 
                    listViewAllSoftware.Items.Add(item);

                }
            }
        }

        

        private void HeaderCheckBox_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabControl.TabPages["tabAvailable"])//your specific tabname
            {
                // your stuff
                //InitData();
            }
        }

        private async void btnInstallSoftware_Click(object sender, EventArgs e)
        {
            progressBar.Visible = true;
            lblProgressBar.Visible = true;
            System.Windows.Forms.ListView.CheckedListViewItemCollection checkedItems = listViewAvailableSoftware.CheckedItems;
            List<Software> links = new List<Software>();
            foreach (ListViewItem item in checkedItems)
            {
                Software sft = new Software();
                sft.name = item.SubItems[1].Text;
                sft.serverProcessorId = item.SubItems[10].Text;
                sft.downloadLink = item.SubItems[7].Text;
                sft.softwareId = Convert.ToInt32(item.SubItems[12].Text);
            
                links.Add(sft);
           
            }
            if (links.Count > 0)
            {
                progressBar.Visible = true;
                lblProgressBar.Visible = true;
                lblProgressBar.Text = "Downloading EXE...";
                progressBar.Value = 0;

                List<Software> downloaded = await Task.Factory.StartNew(() => DownloadSoftwaresExe(links));
                if (downloaded.Count > 0)
                {
                    lblProgressBar.Text = "Download Completed";
                    var com = new Confirmation(downloaded);
                    com.ShowDialog();

                }


            }

        }
     
        private List<Software> DownloadSoftwaresExe(List<Software> links)
        {
            int i = 10;
            List<Software> downloadedSfts = new List<Software>();
            foreach(Software sft in links)
            {
                Software downloadedsft = sft;

                this.BeginInvoke((Action)(() => progressBar.Value = i));
                try
                {
                    string downloadsPath = KnownFolders.GetDownloadsPath();
                    //download zip file
                    WebClient client = new WebClient();
                    if (System.IO.File.Exists(downloadsPath + "\\" + "Zipped.zip"))
                    {
                        System.IO.File.Delete(downloadsPath + "\\" + "Zipped.zip");
                    }
                    client.DownloadFile(sft.downloadLink + "& confirm=XWPY", downloadsPath + "\\" + "Zipped.zip");
                    //extract the zip file
                    ICollection<string> file;
                    using (var unzipfile = new ZipFile(downloadsPath + "\\" + "Zipped.zip"))
                    {
                        file = unzipfile.EntryFileNames;
                        if (System.IO.File.Exists(downloadsPath + "\\" + file.ElementAt(0)))
                        {
                            System.IO.File.Delete(downloadsPath + "\\" + file.ElementAt(0));

                        }
                        unzipfile.ExtractAll(downloadsPath);
                        downloadedsft.softwareDownloadLocation = downloadsPath + "\\" + file.ElementAt(0);
                    }
                    
                    i += 20;
                    this.BeginInvoke((Action)(() => progressBar.Value = i));
                    //update database
                    DatabaseConnection.InsertOrUpadteSoftwareDownloadFromServer(sft, "Yes");
                    i += 20;
                   
                }
                catch(Exception ex)
                {
                    i += 30; DatabaseConnection.InsertOrUpadteSoftwareDownloadFromServer(sft, "No");
                }
                finally
                {
                    downloadedSfts.Add(downloadedsft);
                }
                
            }
            this.BeginInvoke((Action)(() => progressBar.Value = 100));
           
            return downloadedSfts;
        }

        private void ServerSoftwares_Load(object sender, EventArgs e)
        {
            if(requestedSoftwares == null)
            {
                InitAvailableSoftwareData();
            }
            else
            {
                InitRequestSoftware(requestedSoftwares);
            }
            
            listViewAvailableSoftware.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            
        }

        private void listViewAvailableSoftware_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.DrawBackground();
                bool value = false;
                try
                {
                    value = Convert.ToBoolean(e.Header.Tag);
                }
                catch (Exception)
                {
                }
                CheckBoxRenderer.DrawCheckBox(e.Graphics, new Point(e.Bounds.Left + 4, e.Bounds.Top + 4),
                    value ? System.Windows.Forms.VisualStyles.CheckBoxState.CheckedNormal :
                    System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedNormal);
            }
            else
            {
                e.DrawDefault = true;
            }

           
        }

        private void listViewAvailableSoftware_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void listViewAvailableSoftware_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void listViewAvailableSoftware_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column == 0)
            {
                bool value = false;
                try
                {
                    value = Convert.ToBoolean(this.listViewAvailableSoftware.Columns[e.Column].Tag);
                }
                catch (Exception)
                {
                }
                this.listViewAvailableSoftware.Columns[e.Column].Tag = !value;
                foreach (ListViewItem item in this.listViewAvailableSoftware.Items)
                {
                    item.Checked = !value;
                    
                }
                   
                
                
                this.listViewAvailableSoftware.Invalidate();
            }


        }

        private void lblProgressBar_Click(object sender, EventArgs e)
        {

        }
    }
}
