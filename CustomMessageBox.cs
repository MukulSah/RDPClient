using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RDPClientApplication
{
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox(string title, string message, Image icon)
        {
            InitializeComponent();
            this.Text = title;
            labelMessage.Text = message;
            pictureBox.Image = Constant.ResizeImage(icon, pictureBox.Size);

        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelMessage_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
