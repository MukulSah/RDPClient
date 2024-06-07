
namespace RDPClientApplication
{
    partial class licensedetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(licensedetails));
            this.panel_top = new System.Windows.Forms.Panel();
            this.dataGridViewSoftware = new System.Windows.Forms.DataGridView();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_LicenseKey = new System.Windows.Forms.TextBox();
            this.textBox_Version = new System.Windows.Forms.TextBox();
            this.textBox_Edition = new System.Windows.Forms.TextBox();
            this.textBox_ProductID = new System.Windows.Forms.TextBox();
            this.textBox_InstalledRam = new System.Windows.Forms.TextBox();
            this.textBox1_DeviceName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSoftware)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1183, 101);
            this.panel_top.TabIndex = 0;
            // 
            // dataGridViewSoftware
            // 
            this.dataGridViewSoftware.AllowUserToAddRows = false;
            this.dataGridViewSoftware.AllowUserToDeleteRows = false;
            this.dataGridViewSoftware.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSoftware.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSoftware.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSoftware.Location = new System.Drawing.Point(10, 117);
            this.dataGridViewSoftware.Name = "dataGridViewSoftware";
            this.dataGridViewSoftware.ReadOnly = true;
            this.dataGridViewSoftware.Size = new System.Drawing.Size(622, 511);
            this.dataGridViewSoftware.TabIndex = 0;
            // 
            // textBox_Search
            // 
            this.textBox_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Search.Location = new System.Drawing.Point(13, 60);
            this.textBox_Search.Multiline = true;
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(328, 35);
            this.textBox_Search.TabIndex = 1;
            this.textBox_Search.Text = "Search With Software Name";
            this.textBox_Search.TextChanged += new System.EventHandler(this.textBox_Search_TextChanged);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(235)))), ((int)(((byte)(65)))));
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(357, 60);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(97, 35);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "SEARCH";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.textBox_LicenseKey);
            this.panel1.Controls.Add(this.textBox_Version);
            this.panel1.Controls.Add(this.textBox_Edition);
            this.panel1.Controls.Add(this.textBox_ProductID);
            this.panel1.Controls.Add(this.textBox_InstalledRam);
            this.panel1.Controls.Add(this.textBox1_DeviceName);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(638, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 300);
            this.panel1.TabIndex = 3;
            // 
            // textBox_LicenseKey
            // 
            this.textBox_LicenseKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_LicenseKey.Location = new System.Drawing.Point(136, 247);
            this.textBox_LicenseKey.Multiline = true;
            this.textBox_LicenseKey.Name = "textBox_LicenseKey";
            this.textBox_LicenseKey.ReadOnly = true;
            this.textBox_LicenseKey.Size = new System.Drawing.Size(313, 20);
            this.textBox_LicenseKey.TabIndex = 13;
            // 
            // textBox_Version
            // 
            this.textBox_Version.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Version.Location = new System.Drawing.Point(136, 219);
            this.textBox_Version.Multiline = true;
            this.textBox_Version.Name = "textBox_Version";
            this.textBox_Version.ReadOnly = true;
            this.textBox_Version.Size = new System.Drawing.Size(313, 20);
            this.textBox_Version.TabIndex = 13;
            // 
            // textBox_Edition
            // 
            this.textBox_Edition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Edition.Location = new System.Drawing.Point(136, 192);
            this.textBox_Edition.Multiline = true;
            this.textBox_Edition.Name = "textBox_Edition";
            this.textBox_Edition.ReadOnly = true;
            this.textBox_Edition.Size = new System.Drawing.Size(313, 20);
            this.textBox_Edition.TabIndex = 13;
            // 
            // textBox_ProductID
            // 
            this.textBox_ProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ProductID.Location = new System.Drawing.Point(136, 124);
            this.textBox_ProductID.Multiline = true;
            this.textBox_ProductID.Name = "textBox_ProductID";
            this.textBox_ProductID.ReadOnly = true;
            this.textBox_ProductID.Size = new System.Drawing.Size(313, 20);
            this.textBox_ProductID.TabIndex = 13;
            // 
            // textBox_InstalledRam
            // 
            this.textBox_InstalledRam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_InstalledRam.Location = new System.Drawing.Point(136, 94);
            this.textBox_InstalledRam.Multiline = true;
            this.textBox_InstalledRam.Name = "textBox_InstalledRam";
            this.textBox_InstalledRam.ReadOnly = true;
            this.textBox_InstalledRam.Size = new System.Drawing.Size(313, 20);
            this.textBox_InstalledRam.TabIndex = 12;
            // 
            // textBox1_DeviceName
            // 
            this.textBox1_DeviceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_DeviceName.Location = new System.Drawing.Point(136, 64);
            this.textBox1_DeviceName.Multiline = true;
            this.textBox1_DeviceName.Name = "textBox1_DeviceName";
            this.textBox1_DeviceName.ReadOnly = true;
            this.textBox1_DeviceName.Size = new System.Drawing.Size(313, 20);
            this.textBox1_DeviceName.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "Licence Key";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Version";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Edition";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Windows Specification";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Product ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Installed RAM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Device Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Device Specification";
            // 
            // licensedetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 640);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.dataGridViewSoftware);
            this.Controls.Add(this.panel_top);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "licensedetails";
            this.Text = "licensedetails";
            this.Load += new System.EventHandler(this.licensedetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSoftware)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.DataGridView dataGridViewSoftware;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_LicenseKey;
        private System.Windows.Forms.TextBox textBox_Version;
        private System.Windows.Forms.TextBox textBox_Edition;
        private System.Windows.Forms.TextBox textBox_ProductID;
        private System.Windows.Forms.TextBox textBox_InstalledRam;
        private System.Windows.Forms.TextBox textBox1_DeviceName;
    }
}