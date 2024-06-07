using SharpAvi.Output;
using SharpAvi;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace RDPClientApplication
{
    public partial class videoplayback_controlform : Form
    {
        private bool isRecording = false;
        private AviWriter writer;
        private IAviVideoStream videoStream;
        private Thread recordingThread;
        private Thread blinkingThread;
        private string videoFilePath;
        private readonly object lockObj = new object();

        public videoplayback_controlform()
        {
            InitializeComponent();
        }

        private void pictureBox_videoPlaybtn_Click_1(object sender, EventArgs e)
        {
            StartRecording();
        }

        private void pictureBox_videostopbtn_Click_1(object sender, EventArgs e)
        {
            StopRecording();
        }

        private void pictureBox_directorybtn_Click(object sender, EventArgs e)
        {
            string videoPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            string snapshotFolderPath = Path.Combine(videoPath, "SnapShot");
            try
            {
                if (Directory.Exists(snapshotFolderPath))
                {
                    System.Diagnostics.Process.Start("explorer.exe", snapshotFolderPath);
                }
                else
                {
                    MessageBox.Show("Directory does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while opening the directory: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StartRecording()
        {
            if (isRecording)
            {
                MessageBox.Show("Recording is already in progress.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string videoPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            string snapshotFolderPath = Path.Combine(videoPath, "SnapShot");

            if (!Directory.Exists(snapshotFolderPath))
            {
                Directory.CreateDirectory(snapshotFolderPath);
            }

            string filename = $"MacoInfotech_VideoRec_{DateTime.Now:yyyyMMdd_HHmm}.avi";
            videoFilePath = Path.Combine(snapshotFolderPath, filename);

            writer = new AviWriter(videoFilePath)
            {
                FramesPerSecond = 10,
                EmitIndex1 = true
            };

            videoStream = writer.AddVideoStream();
            videoStream.Width = Screen.PrimaryScreen.Bounds.Width;
            videoStream.Height = Screen.PrimaryScreen.Bounds.Height;
            videoStream.Codec = KnownFourCCs.Codecs.Uncompressed;
            videoStream.BitsPerPixel = BitsPerPixel.Bpp32;

            recordingThread = new Thread(RecordScreen);
            recordingThread.Start();

            blinkingThread = new Thread(BlinkIndicator);
            blinkingThread.Start();

            isRecording = true;
            recordingIndicatorPanel.BackColor = Color.Red;
        }

        private void StopRecording()
        {
            if (!isRecording)
            {
                MessageBox.Show("No recording in progress.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            isRecording = false;

            lock (lockObj)
            {
                writer.Close();
            }

            if (recordingThread.IsAlive)
            {
                recordingThread.Join();
            }

            if (blinkingThread.IsAlive)
            {
                blinkingThread.Join();
            }

            recordingIndicatorPanel.BackColor = SystemColors.AppWorkspace;

            MessageBox.Show($"Recording stopped and saved to: {videoFilePath}", "Recording Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Dispose();
        }

        private void RecordScreen()
        {
            Bitmap screenCapture = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics graphics = Graphics.FromImage(screenCapture);

            while (isRecording)
            {
                lock (lockObj)
                {
                    graphics.CopyFromScreen(0, 0, 0, 0, screenCapture.Size);

                    // Manually flip the bitmap horizontally
                   // screenCapture.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    
                    BitmapData frameData = screenCapture.LockBits(
                        new Rectangle(0, 0, screenCapture.Width, screenCapture.Height),
                        ImageLockMode.ReadOnly,
                        PixelFormat.Format32bppArgb);

                    int bufferSize = frameData.Stride * frameData.Height;
                    byte[] buffer = new byte[bufferSize];
                    Marshal.Copy(frameData.Scan0, buffer, 0, bufferSize);

                    videoStream.WriteFrame(true, buffer, 0, buffer.Length);
                    screenCapture.UnlockBits(frameData);
                }

                Thread.Sleep(100); // Control frame rate
            }

            screenCapture.Dispose();
            graphics.Dispose();
        }



        private void BlinkIndicator()
        {
            while (isRecording)
            {
                Invoke(new Action(() => recordingIndicatorPanel.BackColor = recordingIndicatorPanel.BackColor == Color.Red ? SystemColors.AppWorkspace : Color.Red));
                Thread.Sleep(500); // Blinking interval
            }

            Invoke(new Action(() => recordingIndicatorPanel.BackColor = SystemColors.AppWorkspace));
        }

        private void videoplayback_controlform_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isRecording)
            {
                StopRecording();
            }
        }
    }
}
