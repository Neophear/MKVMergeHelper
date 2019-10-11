namespace MKVMergeHelper
{
    partial class frmMain
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
            this.grpbxVideo = new System.Windows.Forms.GroupBox();
            this.btnBrowseVideo = new System.Windows.Forms.Button();
            this.txtVideo = new System.Windows.Forms.TextBox();
            this.grpbxSubtitle = new System.Windows.Forms.GroupBox();
            this.btnBrowseSubtitle = new System.Windows.Forms.Button();
            this.txtSubtitle = new System.Windows.Forms.TextBox();
            this.ofdVideo = new System.Windows.Forms.OpenFileDialog();
            this.ofdSubtitle = new System.Windows.Forms.OpenFileDialog();
            this.btnStart = new System.Windows.Forms.Button();
            this.grpbxOutput = new System.Windows.Forms.GroupBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.grpbxVideo.SuspendLayout();
            this.grpbxSubtitle.SuspendLayout();
            this.grpbxOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbxVideo
            // 
            this.grpbxVideo.Controls.Add(this.btnBrowseVideo);
            this.grpbxVideo.Controls.Add(this.txtVideo);
            this.grpbxVideo.Location = new System.Drawing.Point(12, 12);
            this.grpbxVideo.Name = "grpbxVideo";
            this.grpbxVideo.Size = new System.Drawing.Size(136, 77);
            this.grpbxVideo.TabIndex = 0;
            this.grpbxVideo.TabStop = false;
            this.grpbxVideo.Text = "Video File";
            // 
            // btnBrowseVideo
            // 
            this.btnBrowseVideo.Location = new System.Drawing.Point(71, 45);
            this.btnBrowseVideo.Name = "btnBrowseVideo";
            this.btnBrowseVideo.Size = new System.Drawing.Size(55, 23);
            this.btnBrowseVideo.TabIndex = 1;
            this.btnBrowseVideo.Text = "Browse";
            this.btnBrowseVideo.UseVisualStyleBackColor = true;
            this.btnBrowseVideo.Click += new System.EventHandler(this.btnBrowseVideo_Click);
            // 
            // txtVideo
            // 
            this.txtVideo.AllowDrop = true;
            this.txtVideo.Location = new System.Drawing.Point(6, 19);
            this.txtVideo.Name = "txtVideo";
            this.txtVideo.Size = new System.Drawing.Size(120, 20);
            this.txtVideo.TabIndex = 0;
            this.txtVideo.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtVideo_DragDrop);
            this.txtVideo.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnterCopy);
            // 
            // grpbxSubtitle
            // 
            this.grpbxSubtitle.Controls.Add(this.btnBrowseSubtitle);
            this.grpbxSubtitle.Controls.Add(this.txtSubtitle);
            this.grpbxSubtitle.Location = new System.Drawing.Point(154, 12);
            this.grpbxSubtitle.Name = "grpbxSubtitle";
            this.grpbxSubtitle.Size = new System.Drawing.Size(136, 77);
            this.grpbxSubtitle.TabIndex = 2;
            this.grpbxSubtitle.TabStop = false;
            this.grpbxSubtitle.Text = "Subtitle File";
            // 
            // btnBrowseSubtitle
            // 
            this.btnBrowseSubtitle.Location = new System.Drawing.Point(71, 45);
            this.btnBrowseSubtitle.Name = "btnBrowseSubtitle";
            this.btnBrowseSubtitle.Size = new System.Drawing.Size(55, 23);
            this.btnBrowseSubtitle.TabIndex = 1;
            this.btnBrowseSubtitle.Text = "Browse";
            this.btnBrowseSubtitle.UseVisualStyleBackColor = true;
            this.btnBrowseSubtitle.Click += new System.EventHandler(this.btnBrowseSubtitle_Click);
            // 
            // txtSubtitle
            // 
            this.txtSubtitle.AllowDrop = true;
            this.txtSubtitle.Location = new System.Drawing.Point(6, 19);
            this.txtSubtitle.Name = "txtSubtitle";
            this.txtSubtitle.Size = new System.Drawing.Size(120, 20);
            this.txtSubtitle.TabIndex = 0;
            this.txtSubtitle.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtSubtitle_DragDrop);
            this.txtSubtitle.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnterCopy);
            // 
            // ofdVideo
            // 
            this.ofdVideo.Filter = "Video Files|*.mkv;*.mp4;*.avi|All files|*.*";
            this.ofdVideo.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdVideo_FileOk);
            // 
            // ofdSubtitle
            // 
            this.ofdSubtitle.Filter = "Subtitle Files|*.srt;*.sub|All files|*.*";
            this.ofdSubtitle.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdSubtitle_FileOk);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(357, 95);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // grpbxOutput
            // 
            this.grpbxOutput.Controls.Add(this.txtOutput);
            this.grpbxOutput.Location = new System.Drawing.Point(296, 12);
            this.grpbxOutput.Name = "grpbxOutput";
            this.grpbxOutput.Size = new System.Drawing.Size(136, 77);
            this.grpbxOutput.TabIndex = 3;
            this.grpbxOutput.TabStop = false;
            this.grpbxOutput.Text = "Output File";
            // 
            // txtOutput
            // 
            this.txtOutput.AllowDrop = true;
            this.txtOutput.Location = new System.Drawing.Point(6, 19);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(120, 20);
            this.txtOutput.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnStart;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 127);
            this.Controls.Add(this.grpbxOutput);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.grpbxSubtitle);
            this.Controls.Add(this.grpbxVideo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "MKVMergeHelper";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmMain_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnterCopy);
            this.grpbxVideo.ResumeLayout(false);
            this.grpbxVideo.PerformLayout();
            this.grpbxSubtitle.ResumeLayout(false);
            this.grpbxSubtitle.PerformLayout();
            this.grpbxOutput.ResumeLayout(false);
            this.grpbxOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxVideo;
        private System.Windows.Forms.Button btnBrowseVideo;
        private System.Windows.Forms.TextBox txtVideo;
        private System.Windows.Forms.GroupBox grpbxSubtitle;
        private System.Windows.Forms.Button btnBrowseSubtitle;
        private System.Windows.Forms.TextBox txtSubtitle;
        private System.Windows.Forms.OpenFileDialog ofdVideo;
        private System.Windows.Forms.OpenFileDialog ofdSubtitle;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox grpbxOutput;
        private System.Windows.Forms.TextBox txtOutput;

    }
}

