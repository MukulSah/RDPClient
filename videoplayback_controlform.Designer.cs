namespace RDPClientApplication
{
    partial class videoplayback_controlform
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
            this.recordingIndicatorPanel = new System.Windows.Forms.Panel();
            this.pictureBox_playbtn = new System.Windows.Forms.PictureBox();
            this.pictureBox_directorybtn = new System.Windows.Forms.PictureBox();
            this.pictureBox_videostopbtn = new System.Windows.Forms.PictureBox();
            this.pictureBox_videoPlaybtn = new System.Windows.Forms.PictureBox();
            this.recordingIndicatorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_playbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_directorybtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_videostopbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_videoPlaybtn)).BeginInit();
            this.SuspendLayout();
            // 
            // recordingIndicatorPanel
            // 
            this.recordingIndicatorPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.recordingIndicatorPanel.Controls.Add(this.pictureBox_playbtn);
            this.recordingIndicatorPanel.Controls.Add(this.pictureBox_directorybtn);
            this.recordingIndicatorPanel.Controls.Add(this.pictureBox_videostopbtn);
            this.recordingIndicatorPanel.Controls.Add(this.pictureBox_videoPlaybtn);
            this.recordingIndicatorPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.recordingIndicatorPanel.Location = new System.Drawing.Point(0, -4);
            this.recordingIndicatorPanel.Name = "recordingIndicatorPanel";
            this.recordingIndicatorPanel.Size = new System.Drawing.Size(480, 86);
            this.recordingIndicatorPanel.TabIndex = 4;
            // 
            // pictureBox_playbtn
            // 
            this.pictureBox_playbtn.Image = global::RDPClientApplication.Properties.Resources.rec_button;
            this.pictureBox_playbtn.Location = new System.Drawing.Point(65, 19);
            this.pictureBox_playbtn.Name = "pictureBox_playbtn";
            this.pictureBox_playbtn.Size = new System.Drawing.Size(44, 50);
            this.pictureBox_playbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_playbtn.TabIndex = 7;
            this.pictureBox_playbtn.TabStop = false;
            // 
            // pictureBox_directorybtn
            // 
            this.pictureBox_directorybtn.Image = global::RDPClientApplication.Properties.Resources.foldericon;
            this.pictureBox_directorybtn.Location = new System.Drawing.Point(354, 18);
            this.pictureBox_directorybtn.Name = "pictureBox_directorybtn";
            this.pictureBox_directorybtn.Size = new System.Drawing.Size(62, 51);
            this.pictureBox_directorybtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_directorybtn.TabIndex = 6;
            this.pictureBox_directorybtn.TabStop = false;
            this.pictureBox_directorybtn.Click += new System.EventHandler(this.pictureBox_directorybtn_Click);
            // 
            // pictureBox_videostopbtn
            // 
            this.pictureBox_videostopbtn.Image = global::RDPClientApplication.Properties.Resources.stop_button;
            this.pictureBox_videostopbtn.Location = new System.Drawing.Point(174, 16);
            this.pictureBox_videostopbtn.Name = "pictureBox_videostopbtn";
            this.pictureBox_videostopbtn.Size = new System.Drawing.Size(66, 53);
            this.pictureBox_videostopbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_videostopbtn.TabIndex = 5;
            this.pictureBox_videostopbtn.TabStop = false;
            this.pictureBox_videostopbtn.Click += new System.EventHandler(this.pictureBox_videostopbtn_Click_1);
            // 
            // pictureBox_videoPlaybtn
            // 
            this.pictureBox_videoPlaybtn.Image = global::RDPClientApplication.Properties.Resources.play_button;
            this.pictureBox_videoPlaybtn.Location = new System.Drawing.Point(262, 18);
            this.pictureBox_videoPlaybtn.Name = "pictureBox_videoPlaybtn";
            this.pictureBox_videoPlaybtn.Size = new System.Drawing.Size(65, 53);
            this.pictureBox_videoPlaybtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_videoPlaybtn.TabIndex = 4;
            this.pictureBox_videoPlaybtn.TabStop = false;
            this.pictureBox_videoPlaybtn.Click += new System.EventHandler(this.pictureBox_videoPlaybtn_Click_1);
            // 
            // videoplayback_controlform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(480, 82);
            this.ControlBox = false;
            this.Controls.Add(this.recordingIndicatorPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "videoplayback_controlform";
            this.Text = "videoplayback_controlform";
            this.recordingIndicatorPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_playbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_directorybtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_videostopbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_videoPlaybtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel recordingIndicatorPanel;
        private System.Windows.Forms.PictureBox pictureBox_playbtn;
        private System.Windows.Forms.PictureBox pictureBox_directorybtn;
        private System.Windows.Forms.PictureBox pictureBox_videostopbtn;
        private System.Windows.Forms.PictureBox pictureBox_videoPlaybtn;
    }
}