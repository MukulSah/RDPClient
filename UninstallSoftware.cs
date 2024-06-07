using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RDPClientApplication
{
    public partial class UninstallSoftware : Form
    {
        const string registry_key = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
        public UninstallSoftware()
        {
            InitializeComponent();

            GetInstalledPrograms();
            //Console.WriteLine("int i = " + materialListView1.Items.Count);
        }
        public void GetInstalledApps()

        {

            string uninstallKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            string uninstallKey1 = @"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall";
            int i = 0;
            using (RegistryKey rk = Registry.LocalMachine.OpenSubKey(uninstallKey))
            {
                foreach (string skName in rk.GetSubKeyNames())
                {
                    i++;
                    using (RegistryKey sk = rk.OpenSubKey(skName))
                    {
                        try
                        {
                            var displayName = sk.GetValue("DisplayName");
                            var publisher = sk.GetValue("Publisher");
                            var installDate = sk.GetValue("InstallDate");
                            var size = sk.GetValue("EstimatedSize");
                            var version = sk.GetValue("DisplayVersion");
                            ListViewItem item = new ListViewItem();
                            if (displayName != null)
                            {
                                item.SubItems.Add(displayName.ToString());
                            }
                            else
                            {
                                continue;
                            }
                            if (publisher != null)
                            {
                                item.SubItems.Add(publisher.ToString());
                            }
                            else
                            {
                                item.SubItems.Add("");
                            }
                            if (installDate != null)
                            {
                                item.SubItems.Add(installDate.ToString());
                            }
                            else
                            {
                                item.SubItems.Add("");
                            }
                            if (size != null)
                            {
                                item.SubItems.Add(size.ToString());
                            }
                            else
                            {
                                item.SubItems.Add("");
                            }
                            if (version != null)
                            {
                                item.SubItems.Add(version.ToString());
                            }
                            else
                            {
                                item.SubItems.Add("");
                            }


                            listView1.Items.Add(item);
                        }

                        catch (Exception ex)

                        { }

                    }

                }

                //    label1.Text = listBox1.Items.Count.ToString();

            }

            using (RegistryKey rk = Registry.LocalMachine.OpenSubKey(uninstallKey1))
            {
                i++;
                foreach (string skName in rk.GetSubKeyNames())
                {

                    using (RegistryKey sk = rk.OpenSubKey(skName))
                    {
                        try
                        {
                            var displayName = sk.GetValue("DisplayName");
                            var publisher = sk.GetValue("Publisher");
                            var installDate = sk.GetValue("InstallDate");
                            var size = sk.GetValue("EstimatedSize");
                            var version = sk.GetValue("DisplayVersion");
                            ListViewItem item = new ListViewItem();
                            if (displayName != null)
                            {
                                item.SubItems.Add(displayName.ToString());
                            }
                            else
                            {
                                continue;
                            }
                            if (publisher != null)
                            {
                                item.SubItems.Add(publisher.ToString());
                            }
                            else
                            {
                                item.SubItems.Add("");
                            }
                            if (installDate != null)
                            {
                                item.SubItems.Add(installDate.ToString());
                            }
                            else
                            {
                                item.SubItems.Add("");
                            }
                            if (size != null)
                            {
                                item.SubItems.Add(size.ToString());
                            }
                            else
                            {
                                item.SubItems.Add("");
                            }
                            if (version != null)
                            {
                                item.SubItems.Add(version.ToString());
                            }
                            else
                            {
                                item.SubItems.Add("");
                            }


                            listView1.Items.Add(item);
                        }

                        catch (Exception ex)

                        { }

                    }

                }
                //Console.WriteLine("int i = " + i);
                //    label1.Text = listBox1.Items.Count.ToString();

            }

        }

        private IEnumerable<string> GetInstalledProgramsFromRegistry(RegistryView registryView)
        {
            var result = new List<string>();

            using (RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView).OpenSubKey(registry_key))
            {
                foreach (string subkey_name in key.GetSubKeyNames())
                {
                    using (RegistryKey sk = key.OpenSubKey(subkey_name))
                    {
                        if (IsProgramVisible(sk))
                        {
                            var displayName = sk.GetValue("DisplayName");
                            var publisher = sk.GetValue("Publisher");
                            var installDate = sk.GetValue("InstallDate");
                            var size = sk.GetValue("EstimatedSize");
                            var version = sk.GetValue("DisplayVersion");
                            ListViewItem item = new ListViewItem();
                            if (displayName != null)
                            {
                                item.SubItems.Add(displayName.ToString());
                            }
                            else
                            {
                                continue;
                            }
                            if (publisher != null)
                            {
                                item.SubItems.Add(publisher.ToString());
                            }
                            else
                            {
                                item.SubItems.Add("");
                            }
                            if (installDate != null)
                            {
                                item.SubItems.Add(installDate.ToString());
                            }
                            else
                            {
                                item.SubItems.Add("");
                            }
                            if (size != null)
                            {
                                item.SubItems.Add(size.ToString());
                            }
                            else
                            {
                                item.SubItems.Add("");
                            }
                            if (version != null)
                            {
                                item.SubItems.Add(version.ToString());
                            }
                            else
                            {
                                item.SubItems.Add("");
                            }


                            listView1.Items.Add(item);
                        }
                    }
                }
            }
            return result;

        }

        public List<string> GetInstalledPrograms()
        {
            var result = new List<string>();
            result.AddRange(GetInstalledProgramsFromRegistry(RegistryView.Registry32));
            result.AddRange(GetInstalledProgramsFromRegistry(RegistryView.Registry64));
            return result;
        }

        private static bool IsProgramVisible(RegistryKey subkey)
        {
            var name = (string)subkey.GetValue("DisplayName");
            var releaseType = (string)subkey.GetValue("ReleaseType");
            //var unistallString = (string)subkey.GetValue("UninstallString");
            var systemComponent = subkey.GetValue("SystemComponent");
            var parentName = (string)subkey.GetValue("ParentDisplayName");

            return
                !string.IsNullOrEmpty(name)
                && string.IsNullOrEmpty(releaseType)
                && string.IsNullOrEmpty(parentName)
                && (systemComponent == null);
        }



        private void listView1_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void listView1_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void listView1_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
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

        private void UninstallSoftware_Load(object sender, EventArgs e)
        {
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}
