
namespace RDPClientApplication
{
    partial class ListSoftwares
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListSoftwares));
            this.listView = new System.Windows.Forms.ListView();
            this.softwareNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.publisherHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sizeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.versionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.installDateHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.installLocationHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.installSourceHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbelSize = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblInstallSource = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblInstallLocation = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProductVersion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pictureBoxSoftware = new System.Windows.Forms.PictureBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.largeIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSoftware)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.softwareNameHeader,
            this.publisherHeader,
            this.sizeHeader,
            this.versionHeader,
            this.installDateHeader,
            this.installLocationHeader,
            this.installSourceHeader});
            this.listView.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(0, 28);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(800, 312);
            this.listView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listView_ColumnWidthChanging);
            this.listView.ItemActivate += new System.EventHandler(this.listView_ItemActivate);
            this.listView.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.listView_ItemMouseHover);
            this.listView.Click += new System.EventHandler(this.listView_Click);
            this.listView.MouseLeave += new System.EventHandler(this.listView_MouseLeave);
            // 
            // softwareNameHeader
            // 
            this.softwareNameHeader.Text = "Software Name";
            // 
            // publisherHeader
            // 
            this.publisherHeader.Text = "Publisher";
            // 
            // sizeHeader
            // 
            this.sizeHeader.Text = "Size";
            // 
            // versionHeader
            // 
            this.versionHeader.Text = "Version";
            // 
            // installDateHeader
            // 
            this.installDateHeader.Text = "Install Date";
            // 
            // installLocationHeader
            // 
            this.installLocationHeader.Text = "Install Location";
            this.installLocationHeader.Width = 0;
            // 
            // installSourceHeader
            // 
            this.installSourceHeader.Text = "Install Source";
            this.installSourceHeader.Width = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lbelSize);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblInstallSource);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblInstallLocation);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblPublisher);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblProductVersion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.pictureBoxSoftware);
            this.panel1.Location = new System.Drawing.Point(0, 343);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 105);
            this.panel1.TabIndex = 6;
            // 
            // lbelSize
            // 
            this.lbelSize.AutoSize = true;
            this.lbelSize.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.lbelSize.Location = new System.Drawing.Point(515, 59);
            this.lbelSize.Name = "lbelSize";
            this.lbelSize.Size = new System.Drawing.Size(41, 15);
            this.lbelSize.TabIndex = 11;
            this.lbelSize.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.label5.Location = new System.Drawing.Point(425, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Size";
            // 
            // lblInstallSource
            // 
            this.lblInstallSource.AutoSize = true;
            this.lblInstallSource.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.lblInstallSource.Location = new System.Drawing.Point(513, 33);
            this.lblInstallSource.Name = "lblInstallSource";
            this.lblInstallSource.Size = new System.Drawing.Size(41, 15);
            this.lblInstallSource.TabIndex = 9;
            this.lblInstallSource.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.label4.Location = new System.Drawing.Point(424, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Install Source";
            // 
            // lblInstallLocation
            // 
            this.lblInstallLocation.AutoSize = true;
            this.lblInstallLocation.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.lblInstallLocation.Location = new System.Drawing.Point(236, 80);
            this.lblInstallLocation.Name = "lblInstallLocation";
            this.lblInstallLocation.Size = new System.Drawing.Size(41, 15);
            this.lblInstallLocation.TabIndex = 7;
            this.lblInstallLocation.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.label3.Location = new System.Drawing.Point(128, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Install Location";
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.lblPublisher.Location = new System.Drawing.Point(236, 56);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(41, 15);
            this.lblPublisher.TabIndex = 5;
            this.lblPublisher.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.label2.Location = new System.Drawing.Point(129, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Publisher";
            // 
            // lblProductVersion
            // 
            this.lblProductVersion.AutoSize = true;
            this.lblProductVersion.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductVersion.Location = new System.Drawing.Point(236, 34);
            this.lblProductVersion.Name = "lblProductVersion";
            this.lblProductVersion.Size = new System.Drawing.Size(41, 15);
            this.lblProductVersion.TabIndex = 3;
            this.lblProductVersion.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product Version";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(116, 10);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(90, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Software Name";
            // 
            // pictureBoxSoftware
            // 
            this.pictureBoxSoftware.Location = new System.Drawing.Point(22, 13);
            this.pictureBoxSoftware.Name = "pictureBoxSoftware";
            this.pictureBoxSoftware.Size = new System.Drawing.Size(73, 71);
            this.pictureBoxSoftware.TabIndex = 0;
            this.pictureBoxSoftware.TabStop = false;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::RDPClientApplication.Properties.Resources.Loading_icon;
            this.pictureBox.Location = new System.Drawing.Point(200, 83);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(447, 212);
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.largeIconToolStripMenuItem,
            this.detailsToolStripMenuItem,
            this.listToolStripMenuItem,
            this.tileToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::RDPClientApplication.Properties.Resources.details_icon;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Margin = new System.Windows.Forms.Padding(5, 1, 10, 1);
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 23);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // largeIconToolStripMenuItem
            // 
            this.largeIconToolStripMenuItem.Image = global::RDPClientApplication.Properties.Resources.large_icon;
            this.largeIconToolStripMenuItem.Name = "largeIconToolStripMenuItem";
            this.largeIconToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.largeIconToolStripMenuItem.Text = "Large Icon";
            this.largeIconToolStripMenuItem.Click += new System.EventHandler(this.largeIconToolStripMenuItem_Click);
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.Image = global::RDPClientApplication.Properties.Resources.details_icon;
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.detailsToolStripMenuItem.Text = "Details";
            this.detailsToolStripMenuItem.Click += new System.EventHandler(this.detailsToolStripMenuItem_Click);
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Image = global::RDPClientApplication.Properties.Resources.list_icon;
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listToolStripMenuItem.Text = "List";
            this.listToolStripMenuItem.Click += new System.EventHandler(this.listToolStripMenuItem_Click);
            // 
            // tileToolStripMenuItem
            // 
            this.tileToolStripMenuItem.Image = global::RDPClientApplication.Properties.Resources.tiles_icon;
            this.tileToolStripMenuItem.Name = "tileToolStripMenuItem";
            this.tileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tileToolStripMenuItem.Text = "Tile";
            this.tileToolStripMenuItem.Click += new System.EventHandler(this.tileToolStripMenuItem_Click);
            // 
            // ListSoftwares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.listView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListSoftwares";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Softwares";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ListSoftwares_Load);
            this.Shown += new System.EventHandler(this.ListSoftwares_Shown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSoftware)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader softwareNameHeader;
        private System.Windows.Forms.ColumnHeader publisherHeader;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem largeIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader sizeHeader;
        private System.Windows.Forms.ColumnHeader versionHeader;
        private System.Windows.Forms.ColumnHeader installDateHeader;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblProductVersion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pictureBoxSoftware;
        private System.Windows.Forms.Label lbelSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblInstallSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblInstallLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader installLocationHeader;
        private System.Windows.Forms.ColumnHeader installSourceHeader;
    }
}