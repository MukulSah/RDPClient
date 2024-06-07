
namespace RDPClientApplication
{
    partial class StartUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartUp));
            this.desktoplabel = new System.Windows.Forms.Label();
            this.txtDesktopName = new System.Windows.Forms.TextBox();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.txtProcessorId = new System.Windows.Forms.TextBox();
            this.txtAgentStatus = new System.Windows.Forms.TextBox();
            this.clientIdLabel = new System.Windows.Forms.Label();
            this.processorIdLabel = new System.Windows.Forms.Label();
            this.agentStatusLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timerForAnyServerRequest = new System.Windows.Forms.Timer(this.components);
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.lableclientid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labeldekstopname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelservername = new System.Windows.Forms.Label();
            this.tickIconPictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timerForUnauthorizedSoftware = new System.Windows.Forms.Timer(this.components);
            this.timerForSoftwareInstallation = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tickIconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // desktoplabel
            // 
            this.desktoplabel.AutoSize = true;
            this.desktoplabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desktoplabel.Location = new System.Drawing.Point(35, 79);
            this.desktoplabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.desktoplabel.Name = "desktoplabel";
            this.desktoplabel.Size = new System.Drawing.Size(110, 19);
            this.desktoplabel.TabIndex = 0;
            this.desktoplabel.Text = "Desktop Name";
            // 
            // txtDesktopName
            // 
            this.txtDesktopName.BackColor = System.Drawing.SystemColors.Window;
            this.txtDesktopName.Enabled = false;
            this.txtDesktopName.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesktopName.Location = new System.Drawing.Point(166, 284);
            this.txtDesktopName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDesktopName.Name = "txtDesktopName";
            this.txtDesktopName.Size = new System.Drawing.Size(196, 25);
            this.txtDesktopName.TabIndex = 1;
            this.txtDesktopName.Text = "desktop name";
            this.txtDesktopName.Visible = false;
            // 
            // txtClientId
            // 
            this.txtClientId.Location = new System.Drawing.Point(75, 320);
            this.txtClientId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(182, 23);
            this.txtClientId.TabIndex = 2;
            this.txtClientId.Text = "client id";
            this.txtClientId.Visible = false;
            // 
            // txtProcessorId
            // 
            this.txtProcessorId.Location = new System.Drawing.Point(75, 315);
            this.txtProcessorId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtProcessorId.Name = "txtProcessorId";
            this.txtProcessorId.Size = new System.Drawing.Size(182, 23);
            this.txtProcessorId.TabIndex = 3;
            this.txtProcessorId.Text = "processorid";
            this.txtProcessorId.Visible = false;
            // 
            // txtAgentStatus
            // 
            this.txtAgentStatus.Location = new System.Drawing.Point(133, 315);
            this.txtAgentStatus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAgentStatus.Name = "txtAgentStatus";
            this.txtAgentStatus.Size = new System.Drawing.Size(182, 23);
            this.txtAgentStatus.TabIndex = 4;
            this.txtAgentStatus.Text = "yes";
            this.txtAgentStatus.Visible = false;
            // 
            // clientIdLabel
            // 
            this.clientIdLabel.AutoSize = true;
            this.clientIdLabel.Location = new System.Drawing.Point(14, 328);
            this.clientIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clientIdLabel.Name = "clientIdLabel";
            this.clientIdLabel.Size = new System.Drawing.Size(53, 15);
            this.clientIdLabel.TabIndex = 5;
            this.clientIdLabel.Text = "Client Id";
            this.clientIdLabel.Visible = false;
            // 
            // processorIdLabel
            // 
            this.processorIdLabel.AutoSize = true;
            this.processorIdLabel.Location = new System.Drawing.Point(14, 320);
            this.processorIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.processorIdLabel.Name = "processorIdLabel";
            this.processorIdLabel.Size = new System.Drawing.Size(78, 15);
            this.processorIdLabel.TabIndex = 6;
            this.processorIdLabel.Text = "Processor ID";
            this.processorIdLabel.Visible = false;
            // 
            // agentStatusLabel
            // 
            this.agentStatusLabel.AutoSize = true;
            this.agentStatusLabel.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agentStatusLabel.Location = new System.Drawing.Point(35, 122);
            this.agentStatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.agentStatusLabel.Name = "agentStatusLabel";
            this.agentStatusLabel.Size = new System.Drawing.Size(82, 19);
            this.agentStatusLabel.TabIndex = 7;
            this.agentStatusLabel.Text = "Connected";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 2000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timerForAnyServerRequest
            // 
            this.timerForAnyServerRequest.Enabled = true;
            this.timerForAnyServerRequest.Interval = 2000;
            this.timerForAnyServerRequest.Tick += new System.EventHandler(this.timerForAnyServerRequest_Tick);
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(63, 286);
            this.txtServerName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(116, 23);
            this.txtServerName.TabIndex = 8;
            this.txtServerName.Visible = false;
            // 
            // lableclientid
            // 
            this.lableclientid.AutoSize = true;
            this.lableclientid.Font = new System.Drawing.Font("Cambria", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableclientid.ForeColor = System.Drawing.Color.Crimson;
            this.lableclientid.Location = new System.Drawing.Point(145, 3);
            this.lableclientid.Name = "lableclientid";
            this.lableclientid.Size = new System.Drawing.Size(0, 43);
            this.lableclientid.TabIndex = 9;
            this.lableclientid.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Your Client ID";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(384, 62);
            this.label2.TabIndex = 11;
            // 
            // labeldekstopname
            // 
            this.labeldekstopname.AutoSize = true;
            this.labeldekstopname.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldekstopname.ForeColor = System.Drawing.Color.DimGray;
            this.labeldekstopname.Location = new System.Drawing.Point(183, 80);
            this.labeldekstopname.Name = "labeldekstopname";
            this.labeldekstopname.Size = new System.Drawing.Size(113, 17);
            this.labeldekstopname.TabIndex = 13;
            this.labeldekstopname.Text = "devicenamelabel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Server Name";
            this.label3.Visible = false;
            // 
            // labelservername
            // 
            this.labelservername.AutoSize = true;
            this.labelservername.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelservername.ForeColor = System.Drawing.Color.DimGray;
            this.labelservername.Location = new System.Drawing.Point(182, 166);
            this.labelservername.Name = "labelservername";
            this.labelservername.Size = new System.Drawing.Size(38, 19);
            this.labelservername.TabIndex = 15;
            this.labelservername.Text = "gjgh";
            this.labelservername.Visible = false;
            // 
            // tickIconPictureBox
            // 
            this.tickIconPictureBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("tickIconPictureBox.ErrorImage")));
            this.tickIconPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("tickIconPictureBox.Image")));
            this.tickIconPictureBox.Location = new System.Drawing.Point(186, 115);
            this.tickIconPictureBox.Name = "tickIconPictureBox";
            this.tickIconPictureBox.Size = new System.Drawing.Size(30, 30);
            this.tickIconPictureBox.TabIndex = 12;
            this.tickIconPictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(251, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Add new Software";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timerForUnauthorizedSoftware
            // 
            this.timerForUnauthorizedSoftware.Interval = 5000;
            this.timerForUnauthorizedSoftware.Tick += new System.EventHandler(this.timerForUnauthorizedSoftware_Tick);
            // 
            // timerForSoftwareInstallation
            // 
            this.timerForSoftwareInstallation.Interval = 10000;
            this.timerForSoftwareInstallation.Tick += new System.EventHandler(this.timerForSoftwareInstallation_Tick);
            // 
            // StartUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 203);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelservername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labeldekstopname);
            this.Controls.Add(this.tickIconPictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lableclientid);
            this.Controls.Add(this.txtServerName);
            this.Controls.Add(this.agentStatusLabel);
            this.Controls.Add(this.processorIdLabel);
            this.Controls.Add(this.clientIdLabel);
            this.Controls.Add(this.txtAgentStatus);
            this.Controls.Add(this.txtProcessorId);
            this.Controls.Add(this.txtClientId);
            this.Controls.Add(this.txtDesktopName);
            this.Controls.Add(this.desktoplabel);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "StartUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remote Desktop Connection - Client";
            this.Deactivate += new System.EventHandler(this.StartUp_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartUp_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StartUp_FormClosed);
            this.Load += new System.EventHandler(this.StartUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tickIconPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label desktoplabel;
        private System.Windows.Forms.TextBox txtDesktopName;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.TextBox txtProcessorId;
        private System.Windows.Forms.TextBox txtAgentStatus;
        private System.Windows.Forms.Label clientIdLabel;
        private System.Windows.Forms.Label processorIdLabel;
        private System.Windows.Forms.Label agentStatusLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timerForAnyServerRequest;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Label lableclientid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox tickIconPictureBox;
        private System.Windows.Forms.Label labeldekstopname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelservername;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timerForUnauthorizedSoftware;
        private System.Windows.Forms.Timer timerForSoftwareInstallation;
    }
}