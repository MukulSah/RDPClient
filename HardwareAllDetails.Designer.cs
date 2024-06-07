
namespace RDPClientApplication
{
    partial class HardwareAllDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HardwareAllDetails));
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.listViewHardware = new RDPClientApplication.ListViewExtended();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDiskParition = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Image = global::RDPClientApplication.Properties.Resources.Loading_icon;
            this.label1.Location = new System.Drawing.Point(188, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 135);
            this.label1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDiskParition});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(700, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // listViewHardware
            // 
            this.listViewHardware.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewHardware.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewHardware.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewHardware.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewHardware.HideSelection = false;
            this.listViewHardware.Location = new System.Drawing.Point(0, 28);
            this.listViewHardware.Name = "listViewHardware";
            this.listViewHardware.Size = new System.Drawing.Size(700, 483);
            this.listViewHardware.TabIndex = 0;
            this.listViewHardware.UseCompatibleStateImageBehavior = false;
            this.listViewHardware.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 100;
            // 
            // btnDiskParition
            // 
            this.btnDiskParition.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDiskParition.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiskParition.Image = ((System.Drawing.Image)(resources.GetObject("btnDiskParition.Image")));
            this.btnDiskParition.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDiskParition.Name = "btnDiskParition";
            this.btnDiskParition.Size = new System.Drawing.Size(88, 22);
            this.btnDiskParition.Text = "Disk Partition";
            this.btnDiskParition.Click += new System.EventHandler(this.btnDiskParition_Click);
            // 
            // HardwareAllDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 514);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewHardware);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HardwareAllDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hardware Details";
            this.Load += new System.EventHandler(this.HardwareAllDetails_Load);
            this.Shown += new System.EventHandler(this.HardwareAllDetails_Shown);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.HardwareAllDetails_Paint);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListViewExtended listViewHardware;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnDiskParition;
    }
}