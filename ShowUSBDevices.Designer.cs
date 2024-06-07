
namespace RDPClientApplication
{
    partial class ShowUSBDevices
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowUSBDevices));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.myListView = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnViewProperties = new System.Windows.Forms.ToolStripButton();
            this.btnRenoveDevice = new System.Windows.Forms.ToolStripButton();
            this.btnDisableUSBPorts = new System.Windows.Forms.ToolStripButton();
            this.btnDriverUpdate = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // myListView
            // 
            this.myListView.HideSelection = false;
            this.myListView.Location = new System.Drawing.Point(12, 27);
            this.myListView.Name = "myListView";
            this.myListView.Size = new System.Drawing.Size(767, 402);
            this.myListView.TabIndex = 0;
            this.myListView.UseCompatibleStateImageBehavior = false;
            this.myListView.ItemActivate += new System.EventHandler(this.myListView_ItemActivate);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnViewProperties,
            this.btnRenoveDevice,
            this.btnDisableUSBPorts,
            this.btnDriverUpdate});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnViewProperties
            // 
            this.btnViewProperties.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnViewProperties.Image = ((System.Drawing.Image)(resources.GetObject("btnViewProperties.Image")));
            this.btnViewProperties.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnViewProperties.Name = "btnViewProperties";
            this.btnViewProperties.Size = new System.Drawing.Size(92, 22);
            this.btnViewProperties.Text = "View Properties";
            this.btnViewProperties.Click += new System.EventHandler(this.btnViewProperties_Click);
            // 
            // btnRenoveDevice
            // 
            this.btnRenoveDevice.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnRenoveDevice.Image = ((System.Drawing.Image)(resources.GetObject("btnRenoveDevice.Image")));
            this.btnRenoveDevice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRenoveDevice.Name = "btnRenoveDevice";
            this.btnRenoveDevice.Size = new System.Drawing.Size(91, 22);
            this.btnRenoveDevice.Text = "Remove device";
            this.btnRenoveDevice.Click += new System.EventHandler(this.btnRenoveDevice_Click);
            // 
            // btnDisableUSBPorts
            // 
            this.btnDisableUSBPorts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDisableUSBPorts.Image = ((System.Drawing.Image)(resources.GetObject("btnDisableUSBPorts.Image")));
            this.btnDisableUSBPorts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDisableUSBPorts.Name = "btnDisableUSBPorts";
            this.btnDisableUSBPorts.Size = new System.Drawing.Size(103, 22);
            this.btnDisableUSBPorts.Text = "Disable USB Ports";
            this.btnDisableUSBPorts.Click += new System.EventHandler(this.btnDisableUSBPorts_Click);
            // 
            // btnDriverUpdate
            // 
            this.btnDriverUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDriverUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnDriverUpdate.Image")));
            this.btnDriverUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDriverUpdate.Name = "btnDriverUpdate";
            this.btnDriverUpdate.Size = new System.Drawing.Size(83, 22);
            this.btnDriverUpdate.Text = "Driver Update";
            this.btnDriverUpdate.Click += new System.EventHandler(this.btnDriverUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RDPClientApplication.Properties.Resources.Loading_icon;
            this.pictureBox1.Location = new System.Drawing.Point(186, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(414, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // ShowUSBDevices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.myListView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShowUSBDevices";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show USB Devices";
            this.Load += new System.EventHandler(this.ShowUSBDevices_Load);
            this.Shown += new System.EventHandler(this.ShowUSBDevices_Shown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListView myListView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnViewProperties;
        private System.Windows.Forms.ToolStripButton btnRenoveDevice;
        private System.Windows.Forms.ToolStripButton btnDisableUSBPorts;
        private System.Windows.Forms.ToolStripButton btnDriverUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}