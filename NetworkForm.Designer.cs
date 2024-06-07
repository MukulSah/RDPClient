namespace RDPClientApplication
{
    partial class NetworkForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_Desktopname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label_subnetmask = new System.Windows.Forms.Label();
            this.label_IPv4Address = new System.Windows.Forms.Label();
            this.label_MacAddress = new System.Windows.Forms.Label();
            this.label_Status = new System.Windows.Forms.Label();
            this.label_Id = new System.Windows.Forms.Label();
            this.label_Description = new System.Windows.Forms.Label();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.textBox_Status = new System.Windows.Forms.TextBox();
            this.textBox_MacAddress = new System.Windows.Forms.TextBox();
            this.textBox_Ipv4address = new System.Windows.Forms.TextBox();
            this.textBox_SubnetMask = new System.Windows.Forms.TextBox();
            this.textBox_IPv6address = new System.Windows.Forms.TextBox();
            this.label_IPv6Address = new System.Windows.Forms.Label();
            this.textBox_speed = new System.Windows.Forms.TextBox();
            this.label_Speed = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.textBox_Desktopname);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 77);
            this.panel1.TabIndex = 0;
            // 
            // textBox_Desktopname
            // 
            this.textBox_Desktopname.Location = new System.Drawing.Point(117, 44);
            this.textBox_Desktopname.Name = "textBox_Desktopname";
            this.textBox_Desktopname.ReadOnly = true;
            this.textBox_Desktopname.Size = new System.Drawing.Size(237, 20);
            this.textBox_Desktopname.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Host Name";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(13, 124);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(51, 20);
            this.label_Name.TabIndex = 1;
            this.label_Name.Text = "Name";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(164, 123);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.ReadOnly = true;
            this.textBox_Name.Size = new System.Drawing.Size(367, 20);
            this.textBox_Name.TabIndex = 2;
            // 
            // label_subnetmask
            // 
            this.label_subnetmask.AutoSize = true;
            this.label_subnetmask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_subnetmask.Location = new System.Drawing.Point(13, 383);
            this.label_subnetmask.Name = "label_subnetmask";
            this.label_subnetmask.Size = new System.Drawing.Size(134, 20);
            this.label_subnetmask.TabIndex = 3;
            this.label_subnetmask.Text = "IPv4Subnet Mask";
            // 
            // label_IPv4Address
            // 
            this.label_IPv4Address.AutoSize = true;
            this.label_IPv4Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_IPv4Address.Location = new System.Drawing.Point(13, 346);
            this.label_IPv4Address.Name = "label_IPv4Address";
            this.label_IPv4Address.Size = new System.Drawing.Size(99, 20);
            this.label_IPv4Address.TabIndex = 4;
            this.label_IPv4Address.Text = "IPv4Address";
            // 
            // label_MacAddress
            // 
            this.label_MacAddress.AutoSize = true;
            this.label_MacAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MacAddress.Location = new System.Drawing.Point(13, 309);
            this.label_MacAddress.Name = "label_MacAddress";
            this.label_MacAddress.Size = new System.Drawing.Size(102, 20);
            this.label_MacAddress.TabIndex = 5;
            this.label_MacAddress.Text = "Mac Address";
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Status.Location = new System.Drawing.Point(13, 235);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(56, 20);
            this.label_Status.TabIndex = 6;
            this.label_Status.Text = "Status";
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Id.Location = new System.Drawing.Point(13, 200);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(23, 20);
            this.label_Id.TabIndex = 7;
            this.label_Id.Text = "Id";
            // 
            // label_Description
            // 
            this.label_Description.AutoSize = true;
            this.label_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Description.Location = new System.Drawing.Point(13, 163);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(89, 20);
            this.label_Description.TabIndex = 8;
            this.label_Description.Text = "Description";
            // 
            // textBox_Description
            // 
            this.textBox_Description.Location = new System.Drawing.Point(164, 163);
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.ReadOnly = true;
            this.textBox_Description.Size = new System.Drawing.Size(367, 20);
            this.textBox_Description.TabIndex = 9;
            // 
            // textBox_Id
            // 
            this.textBox_Id.Location = new System.Drawing.Point(164, 200);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.ReadOnly = true;
            this.textBox_Id.Size = new System.Drawing.Size(367, 20);
            this.textBox_Id.TabIndex = 10;
            // 
            // textBox_Status
            // 
            this.textBox_Status.Location = new System.Drawing.Point(164, 235);
            this.textBox_Status.Name = "textBox_Status";
            this.textBox_Status.ReadOnly = true;
            this.textBox_Status.Size = new System.Drawing.Size(367, 20);
            this.textBox_Status.TabIndex = 11;
            // 
            // textBox_MacAddress
            // 
            this.textBox_MacAddress.Location = new System.Drawing.Point(164, 309);
            this.textBox_MacAddress.Name = "textBox_MacAddress";
            this.textBox_MacAddress.ReadOnly = true;
            this.textBox_MacAddress.Size = new System.Drawing.Size(367, 20);
            this.textBox_MacAddress.TabIndex = 12;
            // 
            // textBox_Ipv4address
            // 
            this.textBox_Ipv4address.Location = new System.Drawing.Point(164, 346);
            this.textBox_Ipv4address.Name = "textBox_Ipv4address";
            this.textBox_Ipv4address.ReadOnly = true;
            this.textBox_Ipv4address.Size = new System.Drawing.Size(367, 20);
            this.textBox_Ipv4address.TabIndex = 13;
            // 
            // textBox_SubnetMask
            // 
            this.textBox_SubnetMask.Location = new System.Drawing.Point(164, 385);
            this.textBox_SubnetMask.Name = "textBox_SubnetMask";
            this.textBox_SubnetMask.ReadOnly = true;
            this.textBox_SubnetMask.Size = new System.Drawing.Size(367, 20);
            this.textBox_SubnetMask.TabIndex = 14;
            // 
            // textBox_IPv6address
            // 
            this.textBox_IPv6address.Location = new System.Drawing.Point(164, 424);
            this.textBox_IPv6address.Name = "textBox_IPv6address";
            this.textBox_IPv6address.ReadOnly = true;
            this.textBox_IPv6address.Size = new System.Drawing.Size(367, 20);
            this.textBox_IPv6address.TabIndex = 16;
            // 
            // label_IPv6Address
            // 
            this.label_IPv6Address.AutoSize = true;
            this.label_IPv6Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_IPv6Address.Location = new System.Drawing.Point(13, 422);
            this.label_IPv6Address.Name = "label_IPv6Address";
            this.label_IPv6Address.Size = new System.Drawing.Size(99, 20);
            this.label_IPv6Address.TabIndex = 15;
            this.label_IPv6Address.Text = "IPv6Address";
            // 
            // textBox_speed
            // 
            this.textBox_speed.Location = new System.Drawing.Point(164, 275);
            this.textBox_speed.Name = "textBox_speed";
            this.textBox_speed.ReadOnly = true;
            this.textBox_speed.Size = new System.Drawing.Size(367, 20);
            this.textBox_speed.TabIndex = 18;
            // 
            // label_Speed
            // 
            this.label_Speed.AutoSize = true;
            this.label_Speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Speed.Location = new System.Drawing.Point(14, 272);
            this.label_Speed.Name = "label_Speed";
            this.label_Speed.Size = new System.Drawing.Size(56, 20);
            this.label_Speed.TabIndex = 17;
            this.label_Speed.Text = "Speed";
            // 
            // NetworkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 508);
            this.Controls.Add(this.textBox_speed);
            this.Controls.Add(this.label_Speed);
            this.Controls.Add(this.textBox_IPv6address);
            this.Controls.Add(this.label_IPv6Address);
            this.Controls.Add(this.textBox_SubnetMask);
            this.Controls.Add(this.textBox_Ipv4address);
            this.Controls.Add(this.textBox_MacAddress);
            this.Controls.Add(this.textBox_Status);
            this.Controls.Add(this.textBox_Id);
            this.Controls.Add(this.textBox_Description);
            this.Controls.Add(this.label_Description);
            this.Controls.Add(this.label_Id);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.label_MacAddress);
            this.Controls.Add(this.label_IPv4Address);
            this.Controls.Add(this.label_subnetmask);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.panel1);
            this.Name = "NetworkForm";
            this.Text = "NetworkForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label_subnetmask;
        private System.Windows.Forms.Label label_IPv4Address;
        private System.Windows.Forms.Label label_MacAddress;
        private System.Windows.Forms.Label label_Status;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.TextBox textBox_Description;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.TextBox textBox_Status;
        private System.Windows.Forms.TextBox textBox_MacAddress;
        private System.Windows.Forms.TextBox textBox_Ipv4address;
        private System.Windows.Forms.TextBox textBox_SubnetMask;
        private System.Windows.Forms.TextBox textBox_IPv6address;
        private System.Windows.Forms.Label label_IPv6Address;
        private System.Windows.Forms.TextBox textBox_Desktopname;
        private System.Windows.Forms.TextBox textBox_speed;
        private System.Windows.Forms.Label label_Speed;
    }
}