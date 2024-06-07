
using System;

namespace RDPClientApplication
{
    partial class HardwareDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HardwareDetails));
            this.processoridlabel = new System.Windows.Forms.Label();
            this.hddlabel = new System.Windows.Forms.Label();
            this.physicalmemorylabel = new System.Windows.Forms.Label();
            this.baordmakerlabel = new System.Windows.Forms.Label();
            this.biosmakerlabel = new System.Windows.Forms.Label();
            this.cpuspeedlabel = new System.Windows.Forms.Label();
            this.cpumakerlabel = new System.Windows.Forms.Label();
            this.txtprocessId = new System.Windows.Forms.TextBox();
            this.txtHDDSerialNo = new System.Windows.Forms.TextBox();
            this.txtPhsicalMemory = new System.Windows.Forms.TextBox();
            this.txtBoardMaker = new System.Windows.Forms.TextBox();
            this.txtBiosMaker = new System.Windows.Forms.TextBox();
            this.txtCPUSpeed = new System.Windows.Forms.TextBox();
            this.txtCPUMaker = new System.Windows.Forms.TextBox();
            this.ramlabel = new System.Windows.Forms.Label();
            this.txtRamMemory = new System.Windows.Forms.TextBox();
            this.desktopname = new System.Windows.Forms.Label();
            this.txtDesktopName = new System.Windows.Forms.TextBox();
            this.macid = new System.Windows.Forms.Label();
            this.txtMacId = new System.Windows.Forms.TextBox();
            this.lblLoading = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // processoridlabel
            // 
            this.processoridlabel.AutoSize = true;
            this.processoridlabel.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.processoridlabel.Location = new System.Drawing.Point(24, 55);
            this.processoridlabel.Name = "processoridlabel";
            this.processoridlabel.Size = new System.Drawing.Size(87, 16);
            this.processoridlabel.TabIndex = 0;
            this.processoridlabel.Text = "Processor Id";
            // 
            // hddlabel
            // 
            this.hddlabel.AutoSize = true;
            this.hddlabel.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.hddlabel.Location = new System.Drawing.Point(24, 196);
            this.hddlabel.Name = "hddlabel";
            this.hddlabel.Size = new System.Drawing.Size(97, 16);
            this.hddlabel.TabIndex = 1;
            this.hddlabel.Text = "HDD Serial No";
            // 
            // physicalmemorylabel
            // 
            this.physicalmemorylabel.AutoSize = true;
            this.physicalmemorylabel.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.physicalmemorylabel.Location = new System.Drawing.Point(24, 126);
            this.physicalmemorylabel.Name = "physicalmemorylabel";
            this.physicalmemorylabel.Size = new System.Drawing.Size(115, 16);
            this.physicalmemorylabel.TabIndex = 2;
            this.physicalmemorylabel.Text = "Physical Memory";
            // 
            // baordmakerlabel
            // 
            this.baordmakerlabel.AutoSize = true;
            this.baordmakerlabel.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.baordmakerlabel.Location = new System.Drawing.Point(24, 233);
            this.baordmakerlabel.Name = "baordmakerlabel";
            this.baordmakerlabel.Size = new System.Drawing.Size(89, 16);
            this.baordmakerlabel.TabIndex = 3;
            this.baordmakerlabel.Text = "Board Maker";
            // 
            // biosmakerlabel
            // 
            this.biosmakerlabel.AutoSize = true;
            this.biosmakerlabel.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.biosmakerlabel.Location = new System.Drawing.Point(24, 270);
            this.biosmakerlabel.Name = "biosmakerlabel";
            this.biosmakerlabel.Size = new System.Drawing.Size(82, 16);
            this.biosmakerlabel.TabIndex = 4;
            this.biosmakerlabel.Text = "BIOS Maker";
            // 
            // cpuspeedlabel
            // 
            this.cpuspeedlabel.AutoSize = true;
            this.cpuspeedlabel.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.cpuspeedlabel.Location = new System.Drawing.Point(24, 349);
            this.cpuspeedlabel.Name = "cpuspeedlabel";
            this.cpuspeedlabel.Size = new System.Drawing.Size(74, 16);
            this.cpuspeedlabel.TabIndex = 5;
            this.cpuspeedlabel.Text = "CPU Speed";
            // 
            // cpumakerlabel
            // 
            this.cpumakerlabel.AutoSize = true;
            this.cpumakerlabel.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.cpumakerlabel.Location = new System.Drawing.Point(24, 309);
            this.cpumakerlabel.Name = "cpumakerlabel";
            this.cpumakerlabel.Size = new System.Drawing.Size(77, 16);
            this.cpumakerlabel.TabIndex = 6;
            this.cpumakerlabel.Text = "CPU Maker";
            // 
            // txtprocessId
            // 
            this.txtprocessId.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.txtprocessId.Location = new System.Drawing.Point(189, 51);
            this.txtprocessId.Name = "txtprocessId";
            this.txtprocessId.ReadOnly = true;
            this.txtprocessId.Size = new System.Drawing.Size(145, 23);
            this.txtprocessId.TabIndex = 7;
            // 
            // txtHDDSerialNo
            // 
            this.txtHDDSerialNo.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.txtHDDSerialNo.Location = new System.Drawing.Point(189, 193);
            this.txtHDDSerialNo.Name = "txtHDDSerialNo";
            this.txtHDDSerialNo.ReadOnly = true;
            this.txtHDDSerialNo.Size = new System.Drawing.Size(145, 23);
            this.txtHDDSerialNo.TabIndex = 8;
            // 
            // txtPhsicalMemory
            // 
            this.txtPhsicalMemory.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.txtPhsicalMemory.Location = new System.Drawing.Point(189, 122);
            this.txtPhsicalMemory.Name = "txtPhsicalMemory";
            this.txtPhsicalMemory.ReadOnly = true;
            this.txtPhsicalMemory.Size = new System.Drawing.Size(145, 23);
            this.txtPhsicalMemory.TabIndex = 9;
            // 
            // txtBoardMaker
            // 
            this.txtBoardMaker.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.txtBoardMaker.Location = new System.Drawing.Point(189, 229);
            this.txtBoardMaker.Name = "txtBoardMaker";
            this.txtBoardMaker.ReadOnly = true;
            this.txtBoardMaker.Size = new System.Drawing.Size(145, 23);
            this.txtBoardMaker.TabIndex = 10;
            // 
            // txtBiosMaker
            // 
            this.txtBiosMaker.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.txtBiosMaker.Location = new System.Drawing.Point(189, 266);
            this.txtBiosMaker.Name = "txtBiosMaker";
            this.txtBiosMaker.ReadOnly = true;
            this.txtBiosMaker.Size = new System.Drawing.Size(145, 23);
            this.txtBiosMaker.TabIndex = 11;
            // 
            // txtCPUSpeed
            // 
            this.txtCPUSpeed.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.txtCPUSpeed.Location = new System.Drawing.Point(189, 345);
            this.txtCPUSpeed.Name = "txtCPUSpeed";
            this.txtCPUSpeed.ReadOnly = true;
            this.txtCPUSpeed.Size = new System.Drawing.Size(145, 23);
            this.txtCPUSpeed.TabIndex = 12;
            // 
            // txtCPUMaker
            // 
            this.txtCPUMaker.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.txtCPUMaker.Location = new System.Drawing.Point(189, 307);
            this.txtCPUMaker.Name = "txtCPUMaker";
            this.txtCPUMaker.ReadOnly = true;
            this.txtCPUMaker.Size = new System.Drawing.Size(145, 23);
            this.txtCPUMaker.TabIndex = 13;
            // 
            // ramlabel
            // 
            this.ramlabel.AutoSize = true;
            this.ramlabel.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.ramlabel.Location = new System.Drawing.Point(24, 92);
            this.ramlabel.Name = "ramlabel";
            this.ramlabel.Size = new System.Drawing.Size(91, 16);
            this.ramlabel.TabIndex = 14;
            this.ramlabel.Text = "Ram Memory";
            // 
            // txtRamMemory
            // 
            this.txtRamMemory.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.txtRamMemory.Location = new System.Drawing.Point(189, 88);
            this.txtRamMemory.Name = "txtRamMemory";
            this.txtRamMemory.ReadOnly = true;
            this.txtRamMemory.Size = new System.Drawing.Size(145, 23);
            this.txtRamMemory.TabIndex = 15;
            // 
            // desktopname
            // 
            this.desktopname.AutoSize = true;
            this.desktopname.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.desktopname.Location = new System.Drawing.Point(24, 21);
            this.desktopname.Name = "desktopname";
            this.desktopname.Size = new System.Drawing.Size(99, 16);
            this.desktopname.TabIndex = 16;
            this.desktopname.Text = "Desktop Name";
            // 
            // txtDesktopName
            // 
            this.txtDesktopName.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesktopName.Location = new System.Drawing.Point(188, 15);
            this.txtDesktopName.Name = "txtDesktopName";
            this.txtDesktopName.ReadOnly = true;
            this.txtDesktopName.Size = new System.Drawing.Size(145, 23);
            this.txtDesktopName.TabIndex = 17;
            // 
            // macid
            // 
            this.macid.AutoSize = true;
            this.macid.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.macid.Location = new System.Drawing.Point(26, 164);
            this.macid.Name = "macid";
            this.macid.Size = new System.Drawing.Size(50, 16);
            this.macid.TabIndex = 18;
            this.macid.Text = "Mac Id";
            // 
            // txtMacId
            // 
            this.txtMacId.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.txtMacId.Location = new System.Drawing.Point(189, 157);
            this.txtMacId.Name = "txtMacId";
            this.txtMacId.ReadOnly = true;
            this.txtMacId.Size = new System.Drawing.Size(145, 23);
            this.txtMacId.TabIndex = 19;
            // 
            // lblLoading
            // 
            this.lblLoading.Depth = 0;
            this.lblLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLoading.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblLoading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLoading.Image = global::RDPClientApplication.Properties.Resources.loading;
            this.lblLoading.Location = new System.Drawing.Point(0, 0);
            this.lblLoading.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(349, 387);
            this.lblLoading.TabIndex = 20;
            // 
            // HardwareDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 387);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.txtCPUSpeed);
            this.Controls.Add(this.txtCPUMaker);
            this.Controls.Add(this.cpuspeedlabel);
            this.Controls.Add(this.txtMacId);
            this.Controls.Add(this.cpumakerlabel);
            this.Controls.Add(this.txtBiosMaker);
            this.Controls.Add(this.macid);
            this.Controls.Add(this.txtBoardMaker);
            this.Controls.Add(this.desktopname);
            this.Controls.Add(this.biosmakerlabel);
            this.Controls.Add(this.txtHDDSerialNo);
            this.Controls.Add(this.txtRamMemory);
            this.Controls.Add(this.txtDesktopName);
            this.Controls.Add(this.baordmakerlabel);
            this.Controls.Add(this.ramlabel);
            this.Controls.Add(this.processoridlabel);
            this.Controls.Add(this.txtPhsicalMemory);
            this.Controls.Add(this.hddlabel);
            this.Controls.Add(this.txtprocessId);
            this.Controls.Add(this.physicalmemorylabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HardwareDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hardware Details";
            this.Load += new System.EventHandler(this.HardwareDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.Label processoridlabel;
        private System.Windows.Forms.Label hddlabel;
        private System.Windows.Forms.Label physicalmemorylabel;
        private System.Windows.Forms.Label baordmakerlabel;
        private System.Windows.Forms.Label biosmakerlabel;
        private System.Windows.Forms.Label cpuspeedlabel;
        private System.Windows.Forms.Label cpumakerlabel;
        private System.Windows.Forms.TextBox txtprocessId;
        private System.Windows.Forms.TextBox txtHDDSerialNo;
        private System.Windows.Forms.TextBox txtPhsicalMemory;
        private System.Windows.Forms.TextBox txtBoardMaker;
        private System.Windows.Forms.TextBox txtBiosMaker;
        private System.Windows.Forms.TextBox txtCPUSpeed;
        private System.Windows.Forms.TextBox txtCPUMaker;
        private System.Windows.Forms.Label ramlabel;
        private System.Windows.Forms.TextBox txtRamMemory;
        private System.Windows.Forms.Label desktopname;
        private System.Windows.Forms.TextBox txtDesktopName;
        private System.Windows.Forms.Label macid;
        private System.Windows.Forms.TextBox txtMacId;
        private MaterialSkin.Controls.MaterialLabel lblLoading;
    }
}