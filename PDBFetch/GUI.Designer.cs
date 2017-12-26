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
            this.lblFileStatus = new System.Windows.Forms.Label();
            this.lblFileSize = new System.Windows.Forms.Label();
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
            this.layoutMainInformation.SuspendLayout();
            this.grpFileProgress.SuspendLayout();
            this.grpTotalProgress.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutMainInformation
            // 
            this.layoutMainInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutMainInformation.ColumnCount = 2;
            this.layoutMainInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.80042F));
            this.layoutMainInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 399F));
            this.layoutMainInformation.Controls.Add(this.lblSelectFiles, 1, 0);
            this.layoutMainInformation.Controls.Add(this.lblSymbolServer, 0, 0);
            this.layoutMainInformation.Controls.Add(this.txtSymbolServer, 1, 0);
            this.layoutMainInformation.Controls.Add(this.lstSelectedFiles, 0, 2);
            this.layoutMainInformation.Controls.Add(this.lblFileStatus, 0, 3);
            this.layoutMainInformation.Controls.Add(this.lblFileSize, 0, 4);
            this.layoutMainInformation.Controls.Add(this.grpFileProgress, 0, 6);
            this.layoutMainInformation.Controls.Add(this.lblDownloadedFilesLocation, 0, 5);
            this.layoutMainInformation.Controls.Add(this.grpTotalProgress, 0, 7);
            this.layoutMainInformation.Location = new System.Drawing.Point(4, 4);
            this.layoutMainInformation.Name = "layoutMainInformation";
            this.layoutMainInformation.RowCount = 8;
            this.layoutMainInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.29269F));
            this.layoutMainInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.70732F));
            this.layoutMainInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 182F));
            this.layoutMainInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.layoutMainInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.layoutMainInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.layoutMainInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.layoutMainInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.layoutMainInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutMainInformation.Size = new System.Drawing.Size(497, 476);
            this.layoutMainInformation.TabIndex = 0;
            // 
            // lblSelectFiles
            // 
            this.lblSelectFiles.AutoSize = true;
            this.layoutMainInformation.SetColumnSpan(this.lblSelectFiles, 2);
            this.lblSelectFiles.LinkArea = new System.Windows.Forms.LinkArea(0, 6);
            this.lblSelectFiles.Location = new System.Drawing.Point(3, 34);
            this.lblSelectFiles.Name = "lblSelectFiles";
            this.lblSelectFiles.Size = new System.Drawing.Size(292, 16);
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
            this.lblSymbolServer.Location = new System.Drawing.Point(3, 10);
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
            this.txtSymbolServer.Location = new System.Drawing.Point(101, 7);
            this.txtSymbolServer.Name = "txtSymbolServer";
            this.txtSymbolServer.Size = new System.Drawing.Size(393, 20);
            this.txtSymbolServer.TabIndex = 1;
            this.txtSymbolServer.Text = "http://msdl.microsoft.com/download/symbols";
            // 
            // lstSelectedFiles
            // 
            this.layoutMainInformation.SetColumnSpan(this.lstSelectedFiles, 2);
            this.lstSelectedFiles.FormattingEnabled = true;
            this.lstSelectedFiles.Location = new System.Drawing.Point(3, 53);
            this.lstSelectedFiles.Name = "lstSelectedFiles";
            this.lstSelectedFiles.Size = new System.Drawing.Size(491, 173);
            this.lstSelectedFiles.TabIndex = 3;
            this.lstSelectedFiles.SelectedIndexChanged += new System.EventHandler(this.lstSelectedFiles_SelectedIndexChanged);
            // 
            // lblFileStatus
            // 
            this.lblFileStatus.AutoSize = true;
            this.layoutMainInformation.SetColumnSpan(this.lblFileStatus, 2);
            this.lblFileStatus.Enabled = false;
            this.lblFileStatus.Location = new System.Drawing.Point(3, 232);
            this.lblFileStatus.Name = "lblFileStatus";
            this.lblFileStatus.Size = new System.Drawing.Size(37, 13);
            this.lblFileStatus.TabIndex = 4;
            this.lblFileStatus.Text = "Status";
            // 
            // lblFileSize
            // 
            this.lblFileSize.AutoSize = true;
            this.layoutMainInformation.SetColumnSpan(this.lblFileSize, 2);
            this.lblFileSize.Enabled = false;
            this.lblFileSize.Location = new System.Drawing.Point(3, 253);
            this.lblFileSize.Name = "lblFileSize";
            this.lblFileSize.Size = new System.Drawing.Size(47, 13);
            this.lblFileSize.TabIndex = 5;
            this.lblFileSize.Text = "File size:";
            // 
            // grpFileProgress
            // 
            this.layoutMainInformation.SetColumnSpan(this.grpFileProgress, 2);
            this.grpFileProgress.Controls.Add(this.lblFileProgress);
            this.grpFileProgress.Controls.Add(this.prgBarFileDownloading);
            this.grpFileProgress.Location = new System.Drawing.Point(3, 302);
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
            this.lblDownloadedFilesLocation.LinkArea = new System.Windows.Forms.LinkArea(0, 9);
            this.lblDownloadedFilesLocation.Location = new System.Drawing.Point(3, 275);
            this.lblDownloadedFilesLocation.Name = "lblDownloadedFilesLocation";
            this.lblDownloadedFilesLocation.Size = new System.Drawing.Size(115, 17);
            this.lblDownloadedFilesLocation.TabIndex = 3;
            this.lblDownloadedFilesLocation.TabStop = true;
            this.lblDownloadedFilesLocation.Text = "Saving to: C:\\Symbols";
            this.lblDownloadedFilesLocation.UseCompatibleTextRendering = true;
            this.lblDownloadedFilesLocation.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lvlDownloadedFileLocation_LinkClicked);
            // 
            // grpTotalProgress
            // 
            this.layoutMainInformation.SetColumnSpan(this.grpTotalProgress, 2);
            this.grpTotalProgress.Controls.Add(this.lblTotalProgress);
            this.grpTotalProgress.Controls.Add(this.progressBar1);
            this.grpTotalProgress.Location = new System.Drawing.Point(3, 389);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(47, 484);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(418, 46);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
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
            this.btnDownload.Location = new System.Drawing.Point(59, 3);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(90, 40);
            this.btnDownload.TabIndex = 4;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 543);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutMainInformation;
        private System.Windows.Forms.Label lblSymbolServer;
        private System.Windows.Forms.LinkLabel lblSelectFiles;
        private System.Windows.Forms.TextBox txtSymbolServer;
        private System.Windows.Forms.ListBox lstSelectedFiles;
        private System.Windows.Forms.Label lblFileStatus;
        private System.Windows.Forms.Label lblFileSize;
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
    }
}

