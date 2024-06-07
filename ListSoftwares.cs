using Microsoft.Win32;
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
    public partial class ListSoftwares : Form
    {
        const string registry_key = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
        List<Software> softwareList = new List<Software>();
        System.Windows.Forms.ImageList myImageList1 = new ImageList();
        
        public ListSoftwares()
        {
            InitializeComponent();
            listView.Visible = false;
            pictureBox.Visible = true;
            panel1.Visible = false;
            pictureBox.Image = Constant.ResizeImage(Properties.Resources.Loading_icon, pictureBox.Size);
            pictureBox.Left = (this.ClientSize.Width - pictureBox.Width);
            pictureBox.Top = (this.ClientSize.Height - pictureBox.Height) ;

        }



        private void ListSoftwares_Load(object sender, EventArgs e)
        {
            

        }

        public List<Software> GetInstalledPrograms()
        {

            softwareList.AddRange(GetInstalledProgramsFromRegistry(RegistryView.Registry32));

            softwareList.AddRange(GetInstalledProgramsFromRegistry(RegistryView.Registry64));
            return softwareList;
        }

        private List<Software> GetInstalledProgramsFromRegistry(RegistryView registryView)
        {
            var result = new List<Software>();

            using (RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView).OpenSubKey(registry_key))
            {
                foreach (string subkey_name in key.GetSubKeyNames())
                {
                    using (RegistryKey subkey = key.OpenSubKey(subkey_name))
                    {
                        Software sft = new Software();
                        sft.name = subkey.GetValue("DisplayName") == null ? "" : subkey.GetValue("DisplayName") as string;

                        sft.softwareVersion = subkey.GetValue("DisplayVersion") == null ? "" : subkey.GetValue("DisplayVersion") as string;

                        sft.softwarePublisher = subkey.GetValue("Publisher") == null ? "" : subkey.GetValue("Publisher") as string;

                        sft.installationDate = subkey.GetValue("InstallDate") == null ? "" : subkey.GetValue("InstallDate") as string;

                        sft.installationLocation = subkey.GetValue("InstallLocation") == null ? "" : subkey.GetValue("InstallLocation") as string;
                        sft.installationSource = subkey.GetValue("InstallSource") == null ? "" : subkey.GetValue("InstallSource") as string;
                        sft.softwareSize = subkey.GetValue("EstimatedSize") == null ? "" : subkey.GetValue("EstimatedSize") as string;
                        sft.language = subkey.GetValue("Language") == null ? "" : subkey.GetValue("Language") as string;
                        sft.displayIcon = subkey.GetValue("DisplayIcon") == null ? "" : subkey.GetValue("DisplayIcon") as string;
                        sft.uninstallString = subkey.GetValue("UninstallString") == null ? "" : subkey.GetValue("UninstallString") as string;
                        sft.processorId = StartUp.client.processorId;
                        sft.desktopName = StartUp.client.name;
                       
                        if (sft.name != "")
                        {
                            
                            
                                Console.WriteLine("Software = " + sft.name + " -> " + sft.displayIcon + "  -> " + sft.uninstallString);
                            DatabaseConnection.SaveSoftwareDetails(sft);
                            result.Add(sft);
                            if(sft.displayIcon != "")
                            {
                                try
                                {
                                    if (sft.displayIcon.EndsWith(".exe"))
                                    {
                                        Icon icon = System.Drawing.Icon.ExtractAssociatedIcon(sft.displayIcon);
                                        Console.WriteLine("Icon = " + icon);
                                        sft.icon = icon.ToBitmap(); 
                                    }
                                    else
                                    {
                                        int index = sft.displayIcon.LastIndexOf(".exe");
                                        if (index >= 0)
                                        {

                                            string filepath = sft.displayIcon.Substring(0, index) + ".exe";
                                            Console.WriteLine(filepath);

                                            Icon icon = System.Drawing.Icon.ExtractAssociatedIcon(filepath);
                                            Console.WriteLine("Icon = " + icon);
                                            sft.icon = icon.ToBitmap();
                                        }
                                    }
                                    continue;

                                }
                                catch(Exception e)
                                {
                                    
                                }                           
                            }
                            if(sft.uninstallString != "")
                            {
                                try
                                {
                                    int index1 = sft.uninstallString.LastIndexOf(".exe");
                                    if (index1 >= 0)
                                    {

                                        string filepath = sft.uninstallString.Substring(0, index1) + ".exe";
                                        Console.WriteLine(filepath);

                                        Icon icon1 = System.Drawing.Icon.ExtractAssociatedIcon(filepath);
                                        Console.WriteLine("Icon uninstall = " + icon1);
                                        sft.icon = icon1.ToBitmap();
                                    }
                                    continue;

                                }

                                catch (Exception ex)
                                {

                                }
                            }
                            


                        }
                    }
                }
            }

            return result;
        }

        private void largeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripDropDownButton1.Image = largeIconToolStripMenuItem.Image;
            SetListViewData(80, View.LargeIcon);
           
        }

        private void smallIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            SetListViewData(40, View.SmallIcon);
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            toolStripDropDownButton1.Image = detailsToolStripMenuItem.Image;
            SetListViewData(20, View.Details);
            
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripDropDownButton1.Image = listToolStripMenuItem.Image;
            SetListViewData(40, View.List);
            
        }

        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripDropDownButton1.Image = tileToolStripMenuItem.Image;
            SetListViewData(40, View.Tile);
           
        }

        private void SetListViewData(int imageSize, View view)
        {
           
            listView.View = view;
            myImageList1.ImageSize = new Size(imageSize, imageSize);
            listView.Items.Clear();
            myImageList1.Images.Clear();
            int index = 0;
            foreach (var sft in softwareList)
            {
                if (sft.icon == null)
                {
                    sft.icon = Properties.Resources.windows_icon;
                }
                myImageList1.Images.Add(sft.icon);
                if (listView.Items.ContainsKey(sft.name))
                {
                    index++;
                    continue;
                }
                ListViewItem item = new ListViewItem(sft.name);
                item.Name = sft.name;
                item.ImageIndex = index;
                item.SubItems.Add(sft.softwarePublisher);
                
                item.SubItems.Add(sft.softwareSize);
                item.SubItems.Add(sft.softwareVersion);
                try
                {
                    DateTime dt = DateTime.ParseExact(sft.installationDate, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                    string result = dt.ToString("yyyy/MM/dd");
                    item.SubItems.Add(result);
                }
                catch(Exception ex)
                {
                    item.SubItems.Add(sft.installationDate);
                }
              
                item.SubItems.Add(sft.installationLocation);
                item.SubItems.Add(sft.installationSource);
               
                item.Font = new Font("Cambria", 12, FontStyle.Regular);
                listView.Items.Add(item);
                index++;
               
            }
          
            listView.LargeImageList = myImageList1;
            listView.SmallImageList = myImageList1;
            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listView.Columns[5].Width = 0;
            listView.Columns[6].Width = 0;
            listView.Items[0].Selected = true;
        }

        private async void ListSoftwares_Shown(object sender, EventArgs e)
        {
            List<Software> success = await Task.Factory.StartNew(() => GetInstalledPrograms());
            
            SetListViewData(20, View.Details);
            
            
            pictureBox.Visible = false;
            listView.Visible = true;
          
        }

        private void listView_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {
          
            //foreach(ListViewItem l in listView.Items)
            //{
            //    if(l == e.Item)
            //    {
            //        e.Item.BackColor = Color.LightSkyBlue;
            //    }
            //    else
            //    {
            //        l.BackColor = Color.White;
            //    }
            //}
        }

        private void listView_MouseLeave(object sender, EventArgs e)
        {

        }

        private void listView_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            var SelectedItem = listView.SelectedItems[0];
            lblName.Text = SelectedItem.SubItems[0].Text;
            lblProductVersion.Text = SelectedItem.SubItems[3].Text;
            lblPublisher.Text = SelectedItem.SubItems[1].Text;
            lblInstallLocation.Text = SelectedItem.SubItems[5].Text;
            lblInstallSource.Text = SelectedItem.SubItems[6].Text;
            lbelSize.Text = SelectedItem.SubItems[2].Text;

            pictureBoxSoftware.Image = Constant.ResizeImage(myImageList1.Images[SelectedItem.ImageIndex], pictureBoxSoftware.Size);
        }

        private void listView_ItemActivate(object sender, EventArgs e)
        {
            var itemName = listView.FocusedItem;
            
        }

        private void listView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            if(e.ColumnIndex == 5 || e.ColumnIndex == 6)
            {
                e.NewWidth = 0;
                e.Cancel = true;
            }
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }
    }

   
}
