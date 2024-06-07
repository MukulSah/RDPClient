
namespace RDPClientApplication
{
    partial class Confirmation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Confirmation));
            this.label1 = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.circularProgressBarConfirmed = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBarInstallationCompled = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBarInstallationAccepted = new CircularProgressBar.CircularProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.circularProgressBarDownloadCompleted = new CircularProgressBar.CircularProgressBar();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Are you sure you want to install these softwares now ? ";
            // 
            // btnYes
            // 
            this.btnYes.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.Location = new System.Drawing.Point(483, 343);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(106, 23);
            this.btnYes.TabIndex = 1;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.Location = new System.Drawing.Point(595, 343);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(103, 23);
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.progressBar3);
            this.groupBox1.Controls.Add(this.progressBar2);
            this.groupBox1.Controls.Add(this.circularProgressBarConfirmed);
            this.groupBox1.Controls.Add(this.circularProgressBarInstallationCompled);
            this.groupBox1.Controls.Add(this.circularProgressBarInstallationAccepted);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.circularProgressBarDownloadCompleted);
            this.groupBox1.Location = new System.Drawing.Point(17, 390);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 98);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(423, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Confirmed ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Installation Completed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Installation Accepted";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Download Completed";
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(340, 40);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(95, 10);
            this.progressBar3.TabIndex = 22;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(209, 40);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(96, 10);
            this.progressBar2.TabIndex = 21;
            // 
            // circularProgressBarConfirmed
            // 
            this.circularProgressBarConfirmed.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBarConfirmed.AnimationSpeed = 500;
            this.circularProgressBarConfirmed.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBarConfirmed.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circularProgressBarConfirmed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBarConfirmed.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBarConfirmed.InnerMargin = 2;
            this.circularProgressBarConfirmed.InnerWidth = -1;
            this.circularProgressBarConfirmed.Location = new System.Drawing.Point(432, 23);
            this.circularProgressBarConfirmed.MarqueeAnimationSpeed = 2000;
            this.circularProgressBarConfirmed.Name = "circularProgressBarConfirmed";
            this.circularProgressBarConfirmed.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBarConfirmed.OuterMargin = -25;
            this.circularProgressBarConfirmed.OuterWidth = 26;
            this.circularProgressBarConfirmed.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBarConfirmed.ProgressWidth = 25;
            this.circularProgressBarConfirmed.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBarConfirmed.Size = new System.Drawing.Size(40, 40);
            this.circularProgressBarConfirmed.StartAngle = 270;
            this.circularProgressBarConfirmed.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarConfirmed.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBarConfirmed.SubscriptText = "";
            this.circularProgressBarConfirmed.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarConfirmed.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBarConfirmed.SuperscriptText = "";
            this.circularProgressBarConfirmed.TabIndex = 20;
            this.circularProgressBarConfirmed.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBarConfirmed.Value = 68;
            // 
            // circularProgressBarInstallationCompled
            // 
            this.circularProgressBarInstallationCompled.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBarInstallationCompled.AnimationSpeed = 500;
            this.circularProgressBarInstallationCompled.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBarInstallationCompled.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circularProgressBarInstallationCompled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBarInstallationCompled.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBarInstallationCompled.InnerMargin = 2;
            this.circularProgressBarInstallationCompled.InnerWidth = -1;
            this.circularProgressBarInstallationCompled.Location = new System.Drawing.Point(302, 23);
            this.circularProgressBarInstallationCompled.MarqueeAnimationSpeed = 2000;
            this.circularProgressBarInstallationCompled.Name = "circularProgressBarInstallationCompled";
            this.circularProgressBarInstallationCompled.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBarInstallationCompled.OuterMargin = -25;
            this.circularProgressBarInstallationCompled.OuterWidth = 26;
            this.circularProgressBarInstallationCompled.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBarInstallationCompled.ProgressWidth = 25;
            this.circularProgressBarInstallationCompled.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBarInstallationCompled.Size = new System.Drawing.Size(40, 40);
            this.circularProgressBarInstallationCompled.StartAngle = 270;
            this.circularProgressBarInstallationCompled.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarInstallationCompled.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBarInstallationCompled.SubscriptText = "";
            this.circularProgressBarInstallationCompled.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarInstallationCompled.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBarInstallationCompled.SuperscriptText = "";
            this.circularProgressBarInstallationCompled.TabIndex = 19;
            this.circularProgressBarInstallationCompled.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBarInstallationCompled.Value = 68;
            // 
            // circularProgressBarInstallationAccepted
            // 
            this.circularProgressBarInstallationAccepted.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBarInstallationAccepted.AnimationSpeed = 500;
            this.circularProgressBarInstallationAccepted.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBarInstallationAccepted.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circularProgressBarInstallationAccepted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBarInstallationAccepted.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBarInstallationAccepted.InnerMargin = 2;
            this.circularProgressBarInstallationAccepted.InnerWidth = -1;
            this.circularProgressBarInstallationAccepted.Location = new System.Drawing.Point(171, 23);
            this.circularProgressBarInstallationAccepted.MarqueeAnimationSpeed = 2000;
            this.circularProgressBarInstallationAccepted.Name = "circularProgressBarInstallationAccepted";
            this.circularProgressBarInstallationAccepted.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBarInstallationAccepted.OuterMargin = -25;
            this.circularProgressBarInstallationAccepted.OuterWidth = 26;
            this.circularProgressBarInstallationAccepted.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBarInstallationAccepted.ProgressWidth = 25;
            this.circularProgressBarInstallationAccepted.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBarInstallationAccepted.Size = new System.Drawing.Size(40, 40);
            this.circularProgressBarInstallationAccepted.StartAngle = 270;
            this.circularProgressBarInstallationAccepted.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarInstallationAccepted.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBarInstallationAccepted.SubscriptText = "";
            this.circularProgressBarInstallationAccepted.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarInstallationAccepted.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBarInstallationAccepted.SuperscriptText = "";
            this.circularProgressBarInstallationAccepted.TabIndex = 18;
            this.circularProgressBarInstallationAccepted.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBarInstallationAccepted.Value = 68;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(73, 40);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(99, 10);
            this.progressBar1.TabIndex = 17;
            // 
            // circularProgressBarDownloadCompleted
            // 
            this.circularProgressBarDownloadCompleted.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBarDownloadCompleted.AnimationSpeed = 500;
            this.circularProgressBarDownloadCompleted.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBarDownloadCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBarDownloadCompleted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBarDownloadCompleted.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBarDownloadCompleted.InnerMargin = 2;
            this.circularProgressBarDownloadCompleted.InnerWidth = -1;
            this.circularProgressBarDownloadCompleted.Location = new System.Drawing.Point(35, 23);
            this.circularProgressBarDownloadCompleted.MarqueeAnimationSpeed = 2000;
            this.circularProgressBarDownloadCompleted.Name = "circularProgressBarDownloadCompleted";
            this.circularProgressBarDownloadCompleted.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBarDownloadCompleted.OuterMargin = -25;
            this.circularProgressBarDownloadCompleted.OuterWidth = 26;
            this.circularProgressBarDownloadCompleted.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.circularProgressBarDownloadCompleted.ProgressWidth = 7;
            this.circularProgressBarDownloadCompleted.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBarDownloadCompleted.Size = new System.Drawing.Size(40, 40);
            this.circularProgressBarDownloadCompleted.StartAngle = 270;
            this.circularProgressBarDownloadCompleted.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarDownloadCompleted.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBarDownloadCompleted.SubscriptText = "";
            this.circularProgressBarDownloadCompleted.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBarDownloadCompleted.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBarDownloadCompleted.SuperscriptText = "";
            this.circularProgressBarDownloadCompleted.TabIndex = 16;
            this.circularProgressBarDownloadCompleted.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBarDownloadCompleted.Value = 68;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.Location = new System.Drawing.Point(15, 51);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 40;
            this.dataGridView.Size = new System.Drawing.Size(685, 276);
            this.dataGridView.TabIndex = 17;
            // 
            // Confirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 378);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Confirmation";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmation";
            this.Load += new System.EventHandler(this.Confirmation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar2;
        private CircularProgressBar.CircularProgressBar circularProgressBarConfirmed;
        private CircularProgressBar.CircularProgressBar circularProgressBarInstallationCompled;
        private CircularProgressBar.CircularProgressBar circularProgressBarInstallationAccepted;
        private System.Windows.Forms.ProgressBar progressBar1;
        private CircularProgressBar.CircularProgressBar circularProgressBarDownloadCompleted;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}