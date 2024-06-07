
namespace RDPClientApplication
{
    partial class ControlPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlPanel));
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.btnHardware = new System.Windows.Forms.ToolStripButton();
            this.btnSoftware = new System.Windows.Forms.ToolStripButton();
            this.btnNetwork = new System.Windows.Forms.ToolStripButton();
            this.btnMinimize = new System.Windows.Forms.ToolStripButton();
            this.btnUsers = new System.Windows.Forms.ToolStripButton();
            this.btnTools = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.menuStripUsers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersListsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripHardware = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hardwareDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usbDevicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.softwareListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewSoftwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uninstallSoftwareMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewLicenseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licenseUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blockSoftwareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diableInstallationUninstallationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripSoftware = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Tool_MenuStrip = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.takeScreenshotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startRecordingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileAccessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.toolStrip1.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.menuStripUsers.SuspendLayout();
            this.menuStripHardware.SuspendLayout();
            this.menuStripSoftware.SuspendLayout();
            this.Tool_MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(306, 109);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClose,
            this.btnHardware,
            this.btnSoftware,
            this.btnNetwork,
            this.btnMinimize,
            this.btnUsers,
            this.btnTools});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(507, 58);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnClose
            // 
            this.btnClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnClose.AutoSize = false;
            this.btnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClose.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::RDPClientApplication.Properties.Resources.close_icon2;
            this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 79);
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClose.ToolTipText = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnHardware
            // 
            this.btnHardware.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHardware.Image = global::RDPClientApplication.Properties.Resources.hardware_icon1;
            this.btnHardware.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHardware.Name = "btnHardware";
            this.btnHardware.Size = new System.Drawing.Size(71, 55);
            this.btnHardware.Text = "Hardware";
            this.btnHardware.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHardware.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btnHardware.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHardware.Click += new System.EventHandler(this.btnHardware_Click);
            this.btnHardware.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnHardware_MouseDown);
            this.btnHardware.MouseEnter += new System.EventHandler(this.btnHardware_MouseEnter);
            this.btnHardware.MouseLeave += new System.EventHandler(this.btnHardware_MouseLeave);
            // 
            // btnSoftware
            // 
            this.btnSoftware.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoftware.Image = global::RDPClientApplication.Properties.Resources.software_icon;
            this.btnSoftware.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSoftware.Name = "btnSoftware";
            this.btnSoftware.Size = new System.Drawing.Size(64, 55);
            this.btnSoftware.Text = "Software";
            this.btnSoftware.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSoftware.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSoftware.Click += new System.EventHandler(this.btnSoftware_Click);
            this.btnSoftware.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSoftware_MouseDown);
            this.btnSoftware.MouseEnter += new System.EventHandler(this.btnSoftware_MouseEnter);
            this.btnSoftware.MouseLeave += new System.EventHandler(this.btnSoftware_MouseLeave);
            this.btnSoftware.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnSoftware_MouseUp);
            // 
            // btnNetwork
            // 
            this.btnNetwork.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNetwork.Image = global::RDPClientApplication.Properties.Resources.network_icon;
            this.btnNetwork.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNetwork.Name = "btnNetwork";
            this.btnNetwork.Size = new System.Drawing.Size(63, 55);
            this.btnNetwork.Text = "Network";
            this.btnNetwork.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNetwork.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNetwork.Click += new System.EventHandler(this.btnNetwork_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnMinimize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMinimize.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.Image = global::RDPClientApplication.Properties.Resources.minimize_icon;
            this.btnMinimize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(34, 55);
            this.btnMinimize.Text = "Minimize";
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMinimize.ToolTipText = "MInimize";
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnUsers.Image = global::RDPClientApplication.Properties.Resources.user___account;
            this.btnUsers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(109, 55);
            this.btnUsers.Text = "Users && Account";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUsers.MouseEnter += new System.EventHandler(this.btnUsers_MouseEnter);
            this.btnUsers.MouseLeave += new System.EventHandler(this.btnUsers_MouseLeave);
            this.btnUsers.MouseHover += new System.EventHandler(this.toolStripButton1_MouseHover);
            // 
            // btnTools
            // 
            this.btnTools.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTools.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTools.Image = global::RDPClientApplication.Properties.Resources.tool_icon;
            this.btnTools.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTools.Name = "btnTools";
            this.btnTools.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btnTools.Size = new System.Drawing.Size(57, 55);
            this.btnTools.Text = "Tools";
            this.btnTools.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTools.Click += new System.EventHandler(this.btnTools_Click);
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(306, 109);
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(253, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(306, 109);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // menuStripUsers
            // 
            this.menuStripUsers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.removeUserToolStripMenuItem,
            this.usersListsToolStripMenuItem});
            this.menuStripUsers.Name = "menuStripUsers";
            this.menuStripUsers.Size = new System.Drawing.Size(144, 70);
            this.menuStripUsers.MouseEnter += new System.EventHandler(this.menuStripUsers_MouseEnter);
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.addUserToolStripMenuItem.Text = "Add User";
            // 
            // removeUserToolStripMenuItem
            // 
            this.removeUserToolStripMenuItem.Name = "removeUserToolStripMenuItem";
            this.removeUserToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.removeUserToolStripMenuItem.Text = "Remove User";
            // 
            // usersListsToolStripMenuItem
            // 
            this.usersListsToolStripMenuItem.Name = "usersListsToolStripMenuItem";
            this.usersListsToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.usersListsToolStripMenuItem.Text = "Users List";
            // 
            // menuStripHardware
            // 
            this.menuStripHardware.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hardwareDetailsToolStripMenuItem,
            this.usbDevicesToolStripMenuItem});
            this.menuStripHardware.Name = "menuStripHardware";
            this.menuStripHardware.Size = new System.Drawing.Size(164, 48);
            this.menuStripHardware.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStripHardware_ItemClicked);
            this.menuStripHardware.MouseLeave += new System.EventHandler(this.menuStripHardware_MouseLeave);
            // 
            // hardwareDetailsToolStripMenuItem
            // 
            this.hardwareDetailsToolStripMenuItem.Name = "hardwareDetailsToolStripMenuItem";
            this.hardwareDetailsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.hardwareDetailsToolStripMenuItem.Text = "Hardware Details";
            this.hardwareDetailsToolStripMenuItem.Click += new System.EventHandler(this.hardwareDetailsToolStripMenuItem_Click_1);
            // 
            // usbDevicesToolStripMenuItem
            // 
            this.usbDevicesToolStripMenuItem.Name = "usbDevicesToolStripMenuItem";
            this.usbDevicesToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.usbDevicesToolStripMenuItem.Text = "USB Devices";
            this.usbDevicesToolStripMenuItem.Click += new System.EventHandler(this.usbDevicesToolStripMenuItem_Click_1);
            // 
            // softwareListToolStripMenuItem
            // 
            this.softwareListToolStripMenuItem.Name = "softwareListToolStripMenuItem";
            this.softwareListToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.softwareListToolStripMenuItem.Text = "Software List";
            this.softwareListToolStripMenuItem.Click += new System.EventHandler(this.softwareListToolStripMenuItem_Click);
            // 
            // addNewSoftwareToolStripMenuItem
            // 
            this.addNewSoftwareToolStripMenuItem.Name = "addNewSoftwareToolStripMenuItem";
            this.addNewSoftwareToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.addNewSoftwareToolStripMenuItem.Text = "Add New Software";
            this.addNewSoftwareToolStripMenuItem.Click += new System.EventHandler(this.addNewSoftwareToolStripMenuItem_Click);
            this.addNewSoftwareToolStripMenuItem.MouseLeave += new System.EventHandler(this.addNewSoftwareToolStripMenuItem_MouseLeave);
            // 
            // uninstallSoftwareMenuItem
            // 
            this.uninstallSoftwareMenuItem.Name = "uninstallSoftwareMenuItem";
            this.uninstallSoftwareMenuItem.Size = new System.Drawing.Size(251, 22);
            this.uninstallSoftwareMenuItem.Text = "Uninstall Software";
            this.uninstallSoftwareMenuItem.Click += new System.EventHandler(this.uninstallSoftwareMenuItem_Click);
            // 
            // viewLicenseDetailsToolStripMenuItem
            // 
            this.viewLicenseDetailsToolStripMenuItem.Name = "viewLicenseDetailsToolStripMenuItem";
            this.viewLicenseDetailsToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.viewLicenseDetailsToolStripMenuItem.Text = "View License Details";
            this.viewLicenseDetailsToolStripMenuItem.Click += new System.EventHandler(this.viewLicenseDetailsToolStripMenuItem_Click);
            // 
            // licenseUpdateToolStripMenuItem
            // 
            this.licenseUpdateToolStripMenuItem.Name = "licenseUpdateToolStripMenuItem";
            this.licenseUpdateToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.licenseUpdateToolStripMenuItem.Text = "License Update";
            this.licenseUpdateToolStripMenuItem.Click += new System.EventHandler(this.licenseUpdateToolStripMenuItem_Click);
            // 
            // blockSoftwareToolStripMenuItem
            // 
            this.blockSoftwareToolStripMenuItem.Name = "blockSoftwareToolStripMenuItem";
            this.blockSoftwareToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.blockSoftwareToolStripMenuItem.Text = "Block Software";
            // 
            // diableInstallationUninstallationToolStripMenuItem
            // 
            this.diableInstallationUninstallationToolStripMenuItem.Name = "diableInstallationUninstallationToolStripMenuItem";
            this.diableInstallationUninstallationToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.diableInstallationUninstallationToolStripMenuItem.Text = "Disable Installation/Uninstallation";
            this.diableInstallationUninstallationToolStripMenuItem.Click += new System.EventHandler(this.diableInstallationUninstallationToolStripMenuItem_Click);
            // 
            // menuStripSoftware
            // 
            this.menuStripSoftware.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.softwareListToolStripMenuItem,
            this.addNewSoftwareToolStripMenuItem,
            this.uninstallSoftwareMenuItem,
            this.viewLicenseDetailsToolStripMenuItem,
            this.licenseUpdateToolStripMenuItem,
            this.blockSoftwareToolStripMenuItem,
            this.diableInstallationUninstallationToolStripMenuItem});
            this.menuStripSoftware.Name = "menuStripSoftware";
            this.menuStripSoftware.Size = new System.Drawing.Size(252, 158);
            this.menuStripSoftware.Opening += new System.ComponentModel.CancelEventHandler(this.menuStripSoftware_Opening);
            this.menuStripSoftware.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStripSoftware_ItemClicked);
            this.menuStripSoftware.MouseLeave += new System.EventHandler(this.menuStripSoftware_MouseLeave);
            // 
            // Tool_MenuStrip
            // 
            this.Tool_MenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Tool_MenuStrip.Depth = 0;
            this.Tool_MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.takeScreenshotToolStripMenuItem,
            this.startRecordingToolStripMenuItem,
            this.fileAccessToolStripMenuItem,
            this.clipboardToolStripMenuItem});
            this.Tool_MenuStrip.MouseState = MaterialSkin.MouseState.HOVER;
            this.Tool_MenuStrip.Name = "materialContextMenuStrip1";
            this.Tool_MenuStrip.Size = new System.Drawing.Size(159, 92);
            // 
            // takeScreenshotToolStripMenuItem
            // 
            this.takeScreenshotToolStripMenuItem.Name = "takeScreenshotToolStripMenuItem";
            this.takeScreenshotToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.takeScreenshotToolStripMenuItem.Text = "Take Screenshot";
            this.takeScreenshotToolStripMenuItem.Click += new System.EventHandler(this.takeScreenshotToolStripMenuItem_Click);
            // 
            // startRecordingToolStripMenuItem
            // 
            this.startRecordingToolStripMenuItem.Name = "startRecordingToolStripMenuItem";
            this.startRecordingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.startRecordingToolStripMenuItem.Text = "Start Recording";
            this.startRecordingToolStripMenuItem.Click += new System.EventHandler(this.startRecordingToolStripMenuItem_Click);
            // 
            // fileAccessToolStripMenuItem
            // 
            this.fileAccessToolStripMenuItem.Name = "fileAccessToolStripMenuItem";
            this.fileAccessToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fileAccessToolStripMenuItem.Text = "File Access";
            // 
            // clipboardToolStripMenuItem
            // 
            this.clipboardToolStripMenuItem.Name = "clipboardToolStripMenuItem";
            this.clipboardToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clipboardToolStripMenuItem.Text = "Clipboard";
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(0, 0);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(200, 100);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = null;
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 58);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.toolStripContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 10);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ControlPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.menuStripUsers.ResumeLayout(false);
            this.menuStripHardware.ResumeLayout(false);
            this.menuStripSoftware.ResumeLayout(false);
            this.Tool_MenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnHardware;
        private System.Windows.Forms.ToolStripButton btnSoftware;
        private System.Windows.Forms.ToolStripButton btnMinimize;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ContextMenuStrip menuStripUsers;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersListsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip menuStripHardware;
        private System.Windows.Forms.ToolStripMenuItem hardwareDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usbDevicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem softwareListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewSoftwareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uninstallSoftwareMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewLicenseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licenseUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blockSoftwareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diableInstallationUninstallationToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip menuStripSoftware;
        private System.Windows.Forms.ToolStripButton btnNetwork;
        private System.Windows.Forms.ToolStripButton btnTools;
        private System.Windows.Forms.ToolStripButton btnUsers;
        private System.Windows.Forms.ToolStripButton btnClose;
        private MaterialSkin.Controls.MaterialContextMenuStrip Tool_MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem takeScreenshotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startRecordingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileAccessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clipboardToolStripMenuItem;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
    }
}

