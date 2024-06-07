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
    public partial class BlockSoftware : Form
    {
        public BlockSoftware()
        {
            InitializeComponent();
            
           
            // imglist to hold img
            ImageList imgs = new ImageList();
            imgs.ImageSize = new Size(10, 10);
            imgs.Images.Add(Properties.Resources.block_icon);

            // bind img to listiew
            listView1.SmallImageList = imgs;

            ListViewItem item = new ListViewItem();
            item.SubItems.Add("Visual Studio");
            item.SubItems.Add("Blocked");

            //item.ImageIndex = 0;
            listView1.Items.Add(item);
            //ListViewItem listViewItem = new ListViewItem();
            //listViewItem.SubItems.Add("hgdsja");
            //listView1.SelectedItems[0].ImageIndex = 1;
            //listView1.Items.Add(listViewItem);
            //listView1.Items.Add("hjghj", 0);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BlockSoftware_Load(object sender, EventArgs e)
        {
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

        }
    }
}
