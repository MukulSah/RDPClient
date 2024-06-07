
namespace RDPClientApplication
{
    partial class ServerSoftwares
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerSoftwares));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabAvailable = new System.Windows.Forms.TabPage();
            this.lblProgressBar = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.listViewAvailableSoftware = new System.Windows.Forms.ListView();
            this.checkbox = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.softwareNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.softwareVersionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.targetMachineHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.licenseKeyHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.usersLeftHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expiryDateHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.downloadLinkHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.licenseIdHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.licenseVersionHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.serverProcessorIdHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.licenseValidatedHeade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.softwareIdHeade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnInstallSoftware = new System.Windows.Forms.Button();
            this.tabAll = new System.Windows.Forms.TabPage();
            this.listViewAllSoftware = new System.Windows.Forms.ListView();
            this.softwareNameHeaderAll = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.softwareVersionHeaderAll = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.targerMachineHeaderAll = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.licenseKeyHeaderAll = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.usersLeftHeaderAll = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.licenseExpireHeaderAll = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.downloadLinkHeaderAll = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.licenseIdHeaderAll = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.licenseVersionHeaderAll = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.serverIdAll = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl.SuspendLayout();
            this.tabAvailable.SuspendLayout();
            this.tabAll.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabAvailable);
            this.tabControl.Controls.Add(this.tabAll);
            this.tabControl.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl.Location = new System.Drawing.Point(13, 13);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(775, 293);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabAvailable
            // 
            this.tabAvailable.BackColor = System.Drawing.Color.Transparent;
            this.tabAvailable.Controls.Add(this.lblProgressBar);
            this.tabAvailable.Controls.Add(this.listViewAvailableSoftware);
            this.tabAvailable.Controls.Add(this.btnInstallSoftware);
            this.tabAvailable.Controls.Add(this.progressBar);
            this.tabAvailable.Location = new System.Drawing.Point(4, 24);
            this.tabAvailable.Name = "tabAvailable";
            this.tabAvailable.Padding = new System.Windows.Forms.Padding(3);
            this.tabAvailable.Size = new System.Drawing.Size(767, 265);
            this.tabAvailable.TabIndex = 1;
            this.tabAvailable.Text = "Available";
            // 
            // lblProgressBar
            // 
            this.lblProgressBar.AutoSize = true;
            this.lblProgressBar.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgressBar.Location = new System.Drawing.Point(385, 233);
            this.lblProgressBar.Name = "lblProgressBar";
            this.lblProgressBar.Size = new System.Drawing.Size(48, 15);
            this.lblProgressBar.TabIndex = 4;
            this.lblProgressBar.Text = "Label1";
            this.lblProgressBar.Visible = false;
            this.lblProgressBar.Click += new System.EventHandler(this.lblProgressBar_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(182, 229);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(197, 23);
            this.progressBar.TabIndex = 3;
            this.progressBar.Visible = false;
            // 
            // listViewAvailableSoftware
            // 
            this.listViewAvailableSoftware.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewAvailableSoftware.CheckBoxes = true;
            this.listViewAvailableSoftware.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.checkbox,
            this.softwareNameHeader,
            this.softwareVersionHeader,
            this.targetMachineHeader,
            this.licenseKeyHeader,
            this.usersLeftHeader,
            this.expiryDateHeader,
            this.downloadLinkHeader,
            this.licenseIdHeader,
            this.licenseVersionHeader,
            this.serverProcessorIdHeader,
            this.licenseValidatedHeade,
            this.softwareIdHeade});
            this.listViewAvailableSoftware.Font = new System.Drawing.Font("Cambria", 10.25F);
            this.listViewAvailableSoftware.GridLines = true;
            this.listViewAvailableSoftware.HideSelection = false;
            this.listViewAvailableSoftware.Location = new System.Drawing.Point(6, 6);
            this.listViewAvailableSoftware.Name = "listViewAvailableSoftware";
            this.listViewAvailableSoftware.OwnerDraw = true;
            this.listViewAvailableSoftware.Size = new System.Drawing.Size(744, 217);
            this.listViewAvailableSoftware.TabIndex = 2;
            this.listViewAvailableSoftware.UseCompatibleStateImageBehavior = false;
            this.listViewAvailableSoftware.View = System.Windows.Forms.View.Details;
            this.listViewAvailableSoftware.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewAvailableSoftware_ColumnClick);
            this.listViewAvailableSoftware.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listViewAvailableSoftware_DrawColumnHeader);
            this.listViewAvailableSoftware.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.listViewAvailableSoftware_DrawItem);
            this.listViewAvailableSoftware.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.listViewAvailableSoftware_DrawSubItem);
            // 
            // checkbox
            // 
            this.checkbox.Width = 40;
            // 
            // softwareNameHeader
            // 
            this.softwareNameHeader.Text = "Software Name";
            this.softwareNameHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // softwareVersionHeader
            // 
            this.softwareVersionHeader.Text = "Software Version";
            this.softwareVersionHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.softwareVersionHeader.Width = 108;
            // 
            // targetMachineHeader
            // 
            this.targetMachineHeader.Text = "Target Machine";
            this.targetMachineHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // licenseKeyHeader
            // 
            this.licenseKeyHeader.Text = "License Key";
            this.licenseKeyHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.licenseKeyHeader.Width = 125;
            // 
            // usersLeftHeader
            // 
            this.usersLeftHeader.Text = "Users Left";
            this.usersLeftHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.usersLeftHeader.Width = 82;
            // 
            // expiryDateHeader
            // 
            this.expiryDateHeader.DisplayIndex = 7;
            this.expiryDateHeader.Text = "License Expire Date";
            this.expiryDateHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.expiryDateHeader.Width = 147;
            // 
            // downloadLinkHeader
            // 
            this.downloadLinkHeader.DisplayIndex = 8;
            this.downloadLinkHeader.Text = "Download Link";
            this.downloadLinkHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.downloadLinkHeader.Width = 50;
            // 
            // licenseIdHeader
            // 
            this.licenseIdHeader.DisplayIndex = 9;
            this.licenseIdHeader.Text = "License ID";
            this.licenseIdHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.licenseIdHeader.Width = 68;
            // 
            // licenseVersionHeader
            // 
            this.licenseVersionHeader.DisplayIndex = 10;
            this.licenseVersionHeader.Text = "License Version";
            this.licenseVersionHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.licenseVersionHeader.Width = 73;
            // 
            // serverProcessorIdHeader
            // 
            this.serverProcessorIdHeader.DisplayIndex = 11;
            this.serverProcessorIdHeader.Text = "Server Processor ID";
            this.serverProcessorIdHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // licenseValidatedHeade
            // 
            this.licenseValidatedHeade.DisplayIndex = 6;
            this.licenseValidatedHeade.Text = "License Validated For (In Days)";
            this.licenseValidatedHeade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.licenseValidatedHeade.Width = 0;
            // 
            // softwareIdHeade
            // 
            this.softwareIdHeade.Text = "Software ID";
            this.softwareIdHeade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnInstallSoftware
            // 
            this.btnInstallSoftware.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstallSoftware.Location = new System.Drawing.Point(626, 229);
            this.btnInstallSoftware.Name = "btnInstallSoftware";
            this.btnInstallSoftware.Size = new System.Drawing.Size(124, 23);
            this.btnInstallSoftware.TabIndex = 1;
            this.btnInstallSoftware.Text = "Install Software";
            this.btnInstallSoftware.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInstallSoftware.UseVisualStyleBackColor = true;
            this.btnInstallSoftware.Click += new System.EventHandler(this.btnInstallSoftware_Click);
            // 
            // tabAll
            // 
            this.tabAll.Controls.Add(this.listViewAllSoftware);
            this.tabAll.Location = new System.Drawing.Point(4, 24);
            this.tabAll.Name = "tabAll";
            this.tabAll.Padding = new System.Windows.Forms.Padding(3);
            this.tabAll.Size = new System.Drawing.Size(767, 265);
            this.tabAll.TabIndex = 0;
            this.tabAll.Text = "All";
            this.tabAll.UseVisualStyleBackColor = true;
            // 
            // listViewAllSoftware
            // 
            this.listViewAllSoftware.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.softwareNameHeaderAll,
            this.softwareVersionHeaderAll,
            this.targerMachineHeaderAll,
            this.licenseKeyHeaderAll,
            this.usersLeftHeaderAll,
            this.licenseExpireHeaderAll,
            this.downloadLinkHeaderAll,
            this.licenseIdHeaderAll,
            this.licenseVersionHeaderAll,
            this.serverIdAll});
            this.listViewAllSoftware.HideSelection = false;
            this.listViewAllSoftware.Location = new System.Drawing.Point(7, 7);
            this.listViewAllSoftware.Name = "listViewAllSoftware";
            this.listViewAllSoftware.Size = new System.Drawing.Size(737, 152);
            this.listViewAllSoftware.TabIndex = 0;
            this.listViewAllSoftware.UseCompatibleStateImageBehavior = false;
            this.listViewAllSoftware.View = System.Windows.Forms.View.Details;
            // 
            // softwareNameHeaderAll
            // 
            this.softwareNameHeaderAll.Text = "Software Name";
            this.softwareNameHeaderAll.Width = 176;
            // 
            // softwareVersionHeaderAll
            // 
            this.softwareVersionHeaderAll.Text = "Software Version";
            // 
            // targerMachineHeaderAll
            // 
            this.targerMachineHeaderAll.Text = "Target Machine";
            // 
            // licenseKeyHeaderAll
            // 
            this.licenseKeyHeaderAll.Text = "License Key";
            // 
            // usersLeftHeaderAll
            // 
            this.usersLeftHeaderAll.Text = " Users Left";
            // 
            // licenseExpireHeaderAll
            // 
            this.licenseExpireHeaderAll.Text = "License Expire";
            // 
            // downloadLinkHeaderAll
            // 
            this.downloadLinkHeaderAll.Text = "Download Link";
            // 
            // licenseIdHeaderAll
            // 
            this.licenseIdHeaderAll.Text = "License ID";
            // 
            // licenseVersionHeaderAll
            // 
            this.licenseVersionHeaderAll.Text = "License Version";
            // 
            // serverIdAll
            // 
            this.serverIdAll.Text = "Server Processor Id";
            // 
            // ServerSoftwares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 315);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ServerSoftwares";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServerSoftwares";
            this.Load += new System.EventHandler(this.ServerSoftwares_Load);
            this.tabControl.ResumeLayout(false);
            this.tabAvailable.ResumeLayout(false);
            this.tabAvailable.PerformLayout();
            this.tabAll.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabAll;
        private System.Windows.Forms.TabPage tabAvailable;
        private System.Windows.Forms.Button btnInstallSoftware;
        private System.Windows.Forms.ListView listViewAvailableSoftware;
        private System.Windows.Forms.ColumnHeader checkbox;
        private System.Windows.Forms.ColumnHeader softwareNameHeader;
        private System.Windows.Forms.ColumnHeader softwareVersionHeader;
        private System.Windows.Forms.ColumnHeader targetMachineHeader;
        private System.Windows.Forms.ColumnHeader licenseKeyHeader;
        private System.Windows.Forms.ColumnHeader usersLeftHeader;
        private System.Windows.Forms.ColumnHeader licenseValidatedHeade;
        private System.Windows.Forms.ColumnHeader expiryDateHeader;
        private System.Windows.Forms.ColumnHeader downloadLinkHeader;
        private System.Windows.Forms.ColumnHeader licenseIdHeader;
        private System.Windows.Forms.ColumnHeader licenseVersionHeader;
        private System.Windows.Forms.ColumnHeader serverProcessorIdHeader;
        private System.Windows.Forms.ListView listViewAllSoftware;
        private System.Windows.Forms.ColumnHeader softwareNameHeaderAll;
        private System.Windows.Forms.ColumnHeader softwareVersionHeaderAll;
        private System.Windows.Forms.ColumnHeader targerMachineHeaderAll;
        private System.Windows.Forms.ColumnHeader licenseKeyHeaderAll;
        private System.Windows.Forms.ColumnHeader usersLeftHeaderAll;
        private System.Windows.Forms.ColumnHeader licenseExpireHeaderAll;
        private System.Windows.Forms.ColumnHeader downloadLinkHeaderAll;
        private System.Windows.Forms.ColumnHeader licenseIdHeaderAll;
        private System.Windows.Forms.ColumnHeader licenseVersionHeaderAll;
        private System.Windows.Forms.ColumnHeader serverIdAll;
        private System.Windows.Forms.ColumnHeader softwareIdHeade;
        private System.Windows.Forms.Label lblProgressBar;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}