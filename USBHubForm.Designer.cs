namespace RDPClientApplication
{
    partial class USBHubForm
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
            this.listBoxUSBDevice = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_Machinename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.button_Enable = new System.Windows.Forms.Button();
            this.button_Disable = new System.Windows.Forms.Button();
            this.listBox_USBOtherDetails = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxUSBDevice
            // 
            this.listBoxUSBDevice.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listBoxUSBDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxUSBDevice.FormattingEnabled = true;
            this.listBoxUSBDevice.ItemHeight = 24;
            this.listBoxUSBDevice.Location = new System.Drawing.Point(28, 111);
            this.listBoxUSBDevice.Name = "listBoxUSBDevice";
            this.listBoxUSBDevice.Size = new System.Drawing.Size(776, 364);
            this.listBoxUSBDevice.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.textBox_Machinename);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1049, 88);
            this.panel1.TabIndex = 1;
            // 
            // textBox_Machinename
            // 
            this.textBox_Machinename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Machinename.Location = new System.Drawing.Point(132, 49);
            this.textBox_Machinename.Multiline = true;
            this.textBox_Machinename.Name = "textBox_Machinename";
            this.textBox_Machinename.Size = new System.Drawing.Size(249, 27);
            this.textBox_Machinename.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Machine Name";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.Location = new System.Drawing.Point(846, 121);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(168, 44);
            this.buttonRefresh.TabIndex = 2;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // button_Enable
            // 
            this.button_Enable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Enable.Location = new System.Drawing.Point(846, 188);
            this.button_Enable.Name = "button_Enable";
            this.button_Enable.Size = new System.Drawing.Size(168, 44);
            this.button_Enable.TabIndex = 3;
            this.button_Enable.Text = "Enable Device";
            this.button_Enable.UseVisualStyleBackColor = true;
            this.button_Enable.Click += new System.EventHandler(this.button_Enable_Click);
            // 
            // button_Disable
            // 
            this.button_Disable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Disable.Location = new System.Drawing.Point(846, 260);
            this.button_Disable.Name = "button_Disable";
            this.button_Disable.Size = new System.Drawing.Size(168, 44);
            this.button_Disable.TabIndex = 4;
            this.button_Disable.Text = "Disable Device";
            this.button_Disable.UseVisualStyleBackColor = true;
            this.button_Disable.Click += new System.EventHandler(this.button_Disable_Click);
            // 
            // listBox_USBOtherDetails
            // 
            this.listBox_USBOtherDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_USBOtherDetails.FormattingEnabled = true;
            this.listBox_USBOtherDetails.ItemHeight = 20;
            this.listBox_USBOtherDetails.Location = new System.Drawing.Point(820, 345);
            this.listBox_USBOtherDetails.Name = "listBox_USBOtherDetails";
            this.listBox_USBOtherDetails.Size = new System.Drawing.Size(217, 124);
            this.listBox_USBOtherDetails.TabIndex = 5;
            // 
            // USBHubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 596);
            this.Controls.Add(this.listBox_USBOtherDetails);
            this.Controls.Add(this.button_Disable);
            this.Controls.Add(this.button_Enable);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBoxUSBDevice);
            this.Name = "USBHubForm";
            this.Text = "USBHubForm";
            this.Load += new System.EventHandler(this.USBHubForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxUSBDevice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button button_Enable;
        private System.Windows.Forms.Button button_Disable;
        private System.Windows.Forms.TextBox textBox_Machinename;
        private System.Windows.Forms.ListBox listBox_USBOtherDetails;
    }
}