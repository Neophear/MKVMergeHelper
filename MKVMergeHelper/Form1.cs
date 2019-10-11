using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MKVMergeHelper
{
    public partial class frmMain : Form
    {
        private string videoPath;
        private string subtitlePath;
        private string outputPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\MKV\\";

        public frmMain()
        {
            InitializeComponent();
            string[] args = Environment.GetCommandLineArgs();

            if (args.Length > 1)
            {
                videoPath = args[1];
                subtitlePath = args[2];

                if (args.Length == 4)
                    outputPath = args[3];

                StartMKVMerge();
                this.Close();
            }

            txtOutput.Text = outputPath;
        }

        private void btnBrowseVideo_Click(object sender, EventArgs e)
        {
            ofdVideo.ShowDialog();
        }

        private void btnBrowseSubtitle_Click(object sender, EventArgs e)
        {
            ofdSubtitle.ShowDialog();
        }

        private void ofdVideo_FileOk(object sender, CancelEventArgs e)
        {
            if (!ofdVideo.CheckFileExists)
                MessageBox.Show("File doesn't exist");
            else
                txtVideo.Text = ofdVideo.FileName;
        }

        private void ofdSubtitle_FileOk(object sender, CancelEventArgs e)
        {
            if (!ofdSubtitle.CheckFileExists)
                MessageBox.Show("File doesn't exist");
            else
                txtSubtitle.Text = ofdSubtitle.FileName;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            videoPath = txtVideo.Text;
            subtitlePath = txtSubtitle.Text;
            outputPath = txtOutput.Text;

            StartMKVMerge();
        }

        private void StartMKVMerge()
        {
            if (File.Exists(videoPath) && File.Exists(subtitlePath))
            {
                string arguments = "";
                string outputPathString = String.Format("{0}\\\\{1}.mkv", outputPath.Replace("\\", "\\\\"), Path.GetFileNameWithoutExtension(videoPath));

                arguments += String.Format("-o \"{0}\"", outputPathString);
                arguments += String.Format(" \"--forced-track\" \"0:no\" \"--forced-track\" \"1:no\" \"-a\" \"1\" \"-d\" \"0\" \"-S\" \"-T\" \"--no-global-tags\" \"--no-chapters\" \"(\"");
                arguments += String.Format(" \"{0}\"", videoPath.Replace("\\", "\\\\"));
                arguments += String.Format(" \")\" \"--language\" \"0:eng\" \"--default-track\" \"0:yes\" \"--forced-track\" \"0:no\" \"-s\" \"0\" \"-D\" \"-A\" \"-T\" \"--no-global-tags\" \"--no-chapters\" \"(\"");
                arguments += String.Format(" \"{0}\"", subtitlePath.Replace("\\", "\\\\"));
                arguments += String.Format(" \")\" \"--track-order\" \"0:0,0:1,1:0\"");

                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = @"C:\Program Files (x86)\MKVToolNix\mkvmerge.exe";
                startInfo.Arguments = arguments;
                Process.Start(startInfo);
            }
            else
            {
                MessageBox.Show("One or both files doesn't exist");
            }
        }

        private void DragEnterCopy(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void txtVideo_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] filePaths = (string[])(e.Data.GetData(DataFormats.FileDrop));
                txtVideo.Text = filePaths[0];
            }
        }

        private void txtSubtitle_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] filePaths = (string[])(e.Data.GetData(DataFormats.FileDrop));
                txtSubtitle.Text = filePaths[0];
            }
        }

        private void frmMain_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] filePaths = (string[])(e.Data.GetData(DataFormats.FileDrop));
                txtVideo.Text = filePaths[0];
                txtSubtitle.Text = filePaths[1];
            }
        }
    }
}