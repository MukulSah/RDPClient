
namespace RDPClientApplication
{
    partial class LicenseUpdate
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
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.expiredateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTimeActivated = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtUsersAssigned = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUsersLeft = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotalUsers = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLicenseKey = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(166, 28);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(211, 23);
            this.comboBox.Sorted = true;
            this.comboBox.TabIndex = 112;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // expiredateTimePicker
            // 
            this.expiredateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.expiredateTimePicker.Font = new System.Drawing.Font("Cambria", 9F);
            this.expiredateTimePicker.Location = new System.Drawing.Point(166, 139);
            this.expiredateTimePicker.Name = "expiredateTimePicker";
            this.expiredateTimePicker.Size = new System.Drawing.Size(211, 22);
            this.expiredateTimePicker.TabIndex = 111;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(167, 328);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(210, 22);
            this.dateTimePicker.TabIndex = 110;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(18, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 109;
            this.label3.Text = "Install Date";
            // 
            // txtTimeActivated
            // 
            this.txtTimeActivated.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.txtTimeActivated.Location = new System.Drawing.Point(167, 100);
            this.txtTimeActivated.Name = "txtTimeActivated";
            this.txtTimeActivated.Size = new System.Drawing.Size(210, 23);
            this.txtTimeActivated.TabIndex = 108;
            this.txtTimeActivated.TextChanged += new System.EventHandler(this.txtTimeActivated_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(16, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 107;
            this.label4.Text = "Time Activated";
            // 
            // btnDone
            // 
            this.btnDone.Enabled = false;
            this.btnDone.Font = new System.Drawing.Font("Cambria", 12F);
            this.btnDone.Location = new System.Drawing.Point(302, 378);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 31);
            this.btnDone.TabIndex = 106;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnUpdate.Font = new System.Drawing.Font("Cambria", 12F);
            this.btnUpdate.Location = new System.Drawing.Point(192, 380);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 31);
            this.btnUpdate.TabIndex = 105;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtUsersAssigned
            // 
            this.txtUsersAssigned.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.txtUsersAssigned.Location = new System.Drawing.Point(167, 213);
            this.txtUsersAssigned.Name = "txtUsersAssigned";
            this.txtUsersAssigned.Size = new System.Drawing.Size(210, 23);
            this.txtUsersAssigned.TabIndex = 104;
            this.txtUsersAssigned.TextChanged += new System.EventHandler(this.txtUsersAssigned_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(18, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 103;
            this.label5.Text = "Users Assigned";
            // 
            // txtVersion
            // 
            this.txtVersion.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.txtVersion.Location = new System.Drawing.Point(167, 289);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(210, 23);
            this.txtVersion.TabIndex = 99;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(18, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 16);
            this.label6.TabIndex = 101;
            this.label6.Text = "Software Name";
            // 
            // txtUsersLeft
            // 
            this.txtUsersLeft.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.txtUsersLeft.Location = new System.Drawing.Point(167, 252);
            this.txtUsersLeft.Name = "txtUsersLeft";
            this.txtUsersLeft.Size = new System.Drawing.Size(210, 23);
            this.txtUsersLeft.TabIndex = 97;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(18, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 95;
            this.label7.Text = "Version";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(18, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 16);
            this.label8.TabIndex = 100;
            this.label8.Text = "Expiration Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(18, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 16);
            this.label9.TabIndex = 92;
            this.label9.Text = "License Key";
            // 
            // txtTotalUsers
            // 
            this.txtTotalUsers.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.txtTotalUsers.Location = new System.Drawing.Point(166, 174);
            this.txtTotalUsers.Name = "txtTotalUsers";
            this.txtTotalUsers.Size = new System.Drawing.Size(211, 23);
            this.txtTotalUsers.TabIndex = 98;
            this.txtTotalUsers.TextChanged += new System.EventHandler(this.txtTotalUsers_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(18, 259);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 16);
            this.label10.TabIndex = 93;
            this.label10.Text = "Users Left";
            // 
            // txtLicenseKey
            // 
            this.txtLicenseKey.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.txtLicenseKey.Location = new System.Drawing.Point(167, 63);
            this.txtLicenseKey.Name = "txtLicenseKey";
            this.txtLicenseKey.Size = new System.Drawing.Size(210, 23);
            this.txtLicenseKey.TabIndex = 96;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(18, 181);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 16);
            this.label11.TabIndex = 94;
            this.label11.Text = "Total Users";
            // 
            // LicenseUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 450);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.expiredateTimePicker);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTimeActivated);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtUsersAssigned);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtVersion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtUsersLeft);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTotalUsers);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtLicenseKey);
            this.Controls.Add(this.label11);
            this.Name = "LicenseUpdate";
            this.Text = "LicenseUpdate";
            this.Load += new System.EventHandler(this.LicenseUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.DateTimePicker expiredateTimePicker;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTimeActivated;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtUsersAssigned;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUsersLeft;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotalUsers;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLicenseKey;
        private System.Windows.Forms.Label label11;
    }
}