namespace PDBFetch
{
    partial class GUI
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI));
            this.layoutMainInformation = new System.Windows.Forms.TableLayoutPanel();
            this.lblSelectFiles = new System.Windows.Forms.LinkLabel();
            this.lblSymbolServer = new System.Windows.Forms.Label();
            this.txtSymbolServer = new System.Windows.Forms.TextBox();
            this.lstSelectedFiles = new System.Windows.Forms.ListBox();
            this.grpFileProgress = new System.Windows.Forms.GroupBox();
            this.lblFileProgress = new System.Windows.Forms.Label();
            this.prgBarFileDownloading = new System.Windows.Forms.ProgressBar();
            this.lblDownloadedFilesLocation = new System.Windows.Forms.LinkLabel();
            this.grpTotalProgress = new System.Windows.Forms.GroupBox();
            this.lblTotalProgress = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.backgroundWorkerMain = new System.ComponentModel.BackgroundWorker();
            this.layoutMainInformation.SuspendLayout();
            this.grpFileProgress.SuspendLayout();
            this.grpTotalProgress.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutMainInformation
            // 
            this.layoutMainInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutMainInformation.ColumnCount = 2;
            this.layoutMainInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutMainInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 399F));
            this.layoutMainInformation.Controls.Add(this.lblSelectFiles, 1, 0);
            this.layoutMainInformation.Controls.Add(this.lblSymbolServer, 0, 0);
            this.layoutMainInformation.Controls.Add(this.txtSymbolServer, 1, 0);
            this.layoutMainInformation.Controls.Add(this.lstSelectedFiles, 0, 2);
            this.layoutMainInformation.Controls.Add(this.grpFileProgress, 0, 4);
            this.layoutMainInformation.Controls.Add(this.lblDownloadedFilesLocation, 0, 3);
            this.layoutMainInformation.Controls.Add(this.grpTotalProgress, 0, 5);
            this.layoutMainInformation.Location = new System.Drawing.Point(4, 4);
            this.layoutMainInformation.Name = "layoutMainInformation";
            this.layoutMainInformation.RowCount = 6;
            this.layoutMainInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.29268F));
            this.layoutMainInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.70732F));
            this.layoutMainInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 182F));
            this.layoutMainInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.layoutMainInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.layoutMainInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.layoutMainInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutMainInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutMainInformation.Size = new System.Drawing.Size(497, 437);
            this.layoutMainInformation.TabIndex = 0;
            // 
            // lblSelectFiles
            // 
            this.lblSelectFiles.AutoSize = true;
            this.layoutMainInformation.SetColumnSpan(this.lblSelectFiles, 2);
            this.lblSelectFiles.LinkArea = new System.Windows.Forms.LinkArea(0, 12);
            this.lblSelectFiles.Location = new System.Drawing.Point(3, 37);
            this.lblSelectFiles.Name = "lblSelectFiles";
            this.lblSelectFiles.Size = new System.Drawing.Size(292, 17);
            this.lblSelectFiles.TabIndex = 2;
            this.lblSelectFiles.TabStop = true;
            this.lblSelectFiles.Text = "Select PE(s) for which the symbol (.pdb) files are needed.";
            this.lblSelectFiles.UseCompatibleTextRendering = true;
            this.lblSelectFiles.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSelectFiles_LinkClicked);
            // 
            // lblSymbolServer
            // 
            this.lblSymbolServer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSymbolServer.AutoSize = true;
            this.lblSymbolServer.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblSymbolServer.Location = new System.Drawing.Point(3, 12);
            this.lblSymbolServer.Name = "lblSymbolServer";
            this.lblSymbolServer.Size = new System.Drawing.Size(73, 13);
            this.lblSymbolServer.TabIndex = 1;
            this.lblSymbolServer.Text = "Symbol server";
            this.lblSymbolServer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSymbolServer
            // 
            this.txtSymbolServer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtSymbolServer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSymbolServer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSymbolServer.Location = new System.Drawing.Point(101, 8);
            this.txtSymbolServer.Name = "txtSymbolServer";
            this.txtSymbolServer.Size = new System.Drawing.Size(393, 20);
            this.txtSymbolServer.TabIndex = 1;
            this.txtSymbolServer.Text = "http://msdl.microsoft.com/download/symbols";
            // 
            // lstSelectedFiles
            // 
            this.layoutMainInformation.SetColumnSpan(this.lstSelectedFiles, 2);
            this.lstSelectedFiles.FormattingEnabled = true;
            this.lstSelectedFiles.Location = new System.Drawing.Point(3, 57);
            this.lstSelectedFiles.Name = "lstSelectedFiles";
            this.lstSelectedFiles.Size = new System.Drawing.Size(491, 173);
            this.lstSelectedFiles.TabIndex = 3;
            this.lstSelectedFiles.SelectedIndexChanged += new System.EventHandler(this.lstSelectedFiles_SelectedIndexChanged);
            // 
            // grpFileProgress
            // 
            this.layoutMainInformation.SetColumnSpan(this.grpFileProgress, 2);
            this.grpFileProgress.Controls.Add(this.lblFileProgress);
            this.grpFileProgress.Controls.Add(this.prgBarFileDownloading);
            this.grpFileProgress.Location = new System.Drawing.Point(3, 263);
            this.grpFileProgress.Name = "grpFileProgress";
            this.grpFileProgress.Size = new System.Drawing.Size(491, 76);
            this.grpFileProgress.TabIndex = 6;
            this.grpFileProgress.TabStop = false;
            this.grpFileProgress.Text = "File downloading progress";
            // 
            // lblFileProgress
            // 
            this.lblFileProgress.AutoSize = true;
            this.lblFileProgress.Location = new System.Drawing.Point(6, 53);
            this.lblFileProgress.Name = "lblFileProgress";
            this.lblFileProgress.Size = new System.Drawing.Size(163, 13);
            this.lblFileProgress.TabIndex = 1;
            this.lblFileProgress.Text = "Current file downloading progress";
            // 
            // prgBarFileDownloading
            // 
            this.prgBarFileDownloading.Location = new System.Drawing.Point(6, 19);
            this.prgBarFileDownloading.Name = "prgBarFileDownloading";
            this.prgBarFileDownloading.Size = new System.Drawing.Size(479, 30);
            this.prgBarFileDownloading.TabIndex = 0;
            // 
            // lblDownloadedFilesLocation
            // 
            this.lblDownloadedFilesLocation.AutoSize = true;
            this.layoutMainInformation.SetColumnSpan(this.lblDownloadedFilesLocation, 2);
            this.lblDownloadedFilesLocation.LinkArea = new System.Windows.Forms.LinkArea(0, 7);
            this.lblDownloadedFilesLocation.Location = new System.Drawing.Point(3, 236);
            this.lblDownloadedFilesLocation.Name = "lblDownloadedFilesLocation";
            this.lblDownloadedFilesLocation.Size = new System.Drawing.Size(46, 17);
            this.lblDownloadedFilesLocation.TabIndex = 3;
            this.lblDownloadedFilesLocation.TabStop = true;
            this.lblDownloadedFilesLocation.Text = "Save to:";
            this.lblDownloadedFilesLocation.UseCompatibleTextRendering = true;
            this.lblDownloadedFilesLocation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lvlDownloadedFileLocation_LinkClicked);
            // 
            // grpTotalProgress
            // 
            this.layoutMainInformation.SetColumnSpan(this.grpTotalProgress, 2);
            this.grpTotalProgress.Controls.Add(this.lblTotalProgress);
            this.grpTotalProgress.Controls.Add(this.progressBar1);
            this.grpTotalProgress.Location = new System.Drawing.Point(3, 350);
            this.grpTotalProgress.Name = "grpTotalProgress";
            this.grpTotalProgress.Size = new System.Drawing.Size(491, 76);
            this.grpTotalProgress.TabIndex = 7;
            this.grpTotalProgress.TabStop = false;
            this.grpTotalProgress.Text = "Total proress";
            // 
            // lblTotalProgress
            // 
            this.lblTotalProgress.AutoSize = true;
            this.lblTotalProgress.Location = new System.Drawing.Point(3, 52);
            this.lblTotalProgress.Name = "lblTotalProgress";
            this.lblTotalProgress.Size = new System.Drawing.Size(137, 13);
            this.lblTotalProgress.TabIndex = 1;
            this.lblTotalProgress.Text = "Total downloading progress";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 19);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(479, 30);
            this.progressBar1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDownload, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(47, 446);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(418, 46);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(268, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 40);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnDownload
            // 
            this.btnDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnDownload.Enabled = false;
            this.btnDownload.Location = new System.Drawing.Point(59, 3);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(90, 40);
            this.btnDownload.TabIndex = 4;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelMain});
            this.statusStripMain.Location = new System.Drawing.Point(0, 508);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(506, 22);
            this.statusStripMain.TabIndex = 2;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // toolStripStatusLabelMain
            // 
            this.toolStripStatusLabelMain.Name = "toolStripStatusLabelMain";
            this.toolStripStatusLabelMain.Size = new System.Drawing.Size(125, 17);
            this.toolStripStatusLabelMain.Text = "toolStripStatusLabelMain";
            this.toolStripStatusLabelMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // backgroundWorkerMain
            // 
            this.backgroundWorkerMain.WorkerReportsProgress = true;
            this.backgroundWorkerMain.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerMain_DoWork);
            this.backgroundWorkerMain.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerMain_ProgressChanged);
            this.backgroundWorkerMain.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerMain_RunWorkerCompleted);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 530);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.layoutMainInformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GUI";
            this.Text = "PDB Fetch - Fetching PDBs in a convenient way";
            this.layoutMainInformation.ResumeLayout(false);
            this.layoutMainInformation.PerformLayout();
            this.grpFileProgress.ResumeLayout(false);
            this.grpFileProgress.PerformLayout();
            this.grpTotalProgress.ResumeLayout(false);
            this.grpTotalProgress.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutMainInformation;
        private System.Windows.Forms.Label lblSymbolServer;
        private System.Windows.Forms.LinkLabel lblSelectFiles;
        private System.Windows.Forms.TextBox txtSymbolServer;
        private System.Windows.Forms.ListBox lstSelectedFiles;
        private System.Windows.Forms.GroupBox grpFileProgress;
        private System.Windows.Forms.ProgressBar prgBarFileDownloading;
        private System.Windows.Forms.LinkLabel lblDownloadedFilesLocation;
        private System.Windows.Forms.GroupBox grpTotalProgress;
        private System.Windows.Forms.Label lblFileProgress;
        private System.Windows.Forms.Label lblTotalProgress;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMain;
        private System.ComponentModel.BackgroundWorker backgroundWorkerMain;
    }
}

