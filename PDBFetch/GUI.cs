using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PeNet;

namespace PDBFetch
{
    public partial class GUI : Form
    {
        private class PEParsingException : Exception
        {
            public PEParsingException()
            {
            }

            public PEParsingException(string msg) : base(msg)
            {
            }

            public PEParsingException(string msg, Exception inner) : base(msg, inner)
            {
            }
        }

        AutoCompleteStringCollection storedSymbolServers = new AutoCompleteStringCollection();

        public GUI()
        {
            InitializeComponent();
            txtSymbolServer.AutoCompleteCustomSource = storedSymbolServers;
            lblDownloadedFilesLocation.Text = "Save to: " + Directory.GetCurrentDirectory();
        }

        private ExecutionStatus executionStatus = ExecutionStatus.Stopped;

        private Dictionary<string, string> badFiles = new Dictionary<string, string>();

        private void lblSelectFiles_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (executionStatus == ExecutionStatus.Stopped)
            {
                var fileDialog = new OpenFileDialog
                {
                    Multiselect = true,
                    Filter = "Dynamic libraries|*.dll|Static libraries|*.lib|Executables|*.exe|Drivers|*.sys|All|*.*"
                };
                if (DialogResult.OK == fileDialog.ShowDialog())
                {
                    if (fileDialog.FileNames.Length > 0)
                    {
                        var selectedFiles = new List<string>();
                        foreach (var fileName in fileDialog.FileNames)
                        {
                            selectedFiles.Add(fileName);
                        }

                        lstSelectedFiles.DataSource = selectedFiles;

                        toolStripStatusLabelMain.Text = "Parsing selected file(s)...";
                        foreach (string filePath in lstSelectedFiles.Items)
                        {
                            try
                            {
                                toolStripStatusLabelMain.Text = "Parsing " + filePath;
                                var filePdbInfo = PeFilePdbInformation.ExtractPDBInformation(filePath);
                                peFilePdbInfo[filePath] = filePdbInfo;
                            }
                            catch (PEParsingException expt)
                            {
                                //badFiles.Add(filePath, expt.Message());
                                badFiles[filePath] = expt.Message;
                            }
                        }
                        toolStripStatusLabelMain.Text = "Parsing selected file(s)...finished";

                        // show default
                        lblFileProgress.Text = "waiting for download...";
                        lblTotalProgress.Text = "waiting for download...";

                        btnDownload.Enabled = true;
                        btnCancel.Enabled = false;
                    }
                }
            }
        }

        private void lvlDownloadedFileLocation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (executionStatus == ExecutionStatus.Stopped)
            {
                var folderDialog = new FolderBrowserDialog();
                if (DialogResult.OK == folderDialog.ShowDialog())
                {
                    lblDownloadedFilesLocation.Text = "Save to: " + folderDialog.SelectedPath;
                }
            }
        }

        private Dictionary<string, PeFilePdbInformation> peFilePdbInfo = new Dictionary<string, PeFilePdbInformation>();

        private class PeFilePdbInformation
        {
            //public string PEFilePath { get; }
            public ulong PeFileSize { get; }
            public bool Pe64Bit { get; }
            public string PdbFileName { get; } // null ternimated pdb file
            public byte[] PdbGuid { get; } // 16 byte GUID
            public uint PdbAge { get; } // dword Age

            PeFilePdbInformation(ulong peFileSize, bool pe64Bit, string pdbFileName, byte[] pdbGuid, uint pdbAge)
            {
                PeFileSize = peFileSize;
                Pe64Bit = pe64Bit;
                PdbFileName = pdbFileName;
                PdbGuid = pdbGuid;
                PdbAge = pdbAge;
            }

            static byte[] pdb20_cv_signature = { (byte)'N', (byte)'B', (byte)'1', (byte)'0' };
            static byte[] pdb70_cv_signature = { (byte)'R', (byte)'S', (byte)'D', (byte)'S' };

            public static PeFilePdbInformation ExtractPDBInformation(string peFilePath)
            {
                var peFileSize = 0ul;
                try
                {
                    peFileSize = (ulong)new FileInfo(peFilePath).Length;
                }
                catch (Exception)
                {
                    throw new PEParsingException("file cannot be accessed");
                }

                var peFile = new PeFile(peFilePath);
                if (PeFile.IsPEFile(peFilePath))
                {
                    var debugDir = peFile.ImageDebugDirectory;
                    if (null == debugDir)
                    {
                        throw new PEParsingException("debug directory does not exist");
                    }
                    else
                    {
                        // dirty code: IMAGE_DEBUG_TYPE_CODEVIEW = 2
                        if (debugDir.Characteristics != 2)
                        {
                            throw new PEParsingException("bad debug characteristics");
                        }
                        else
                        {
                            var fileStream = new FileStream(peFilePath, FileMode.Open, FileAccess.Read);
                            fileStream.Seek(debugDir.PointerToRawData, SeekOrigin.Begin);
                            var fileReader = new BinaryReader(fileStream);
                            var cvSignature = fileReader.ReadBytes(4);
                            if (cvSignature.SequenceEqual(pdb20_cv_signature))
                            {
                                // dirty code: CV_HEADER_OFFSET + CV_INFO_SIGNATURE + CV_INFO_AGE = 12
                                //fileStream.Seek(12, SeekOrigin.Current);
                                //return fileReader.ReadString();
                                throw new PEParsingException("PDB 2.0 is not supported");
                            }
                            else
                            {
                                if (cvSignature.SequenceEqual(pdb70_cv_signature))
                                {
                                    // dirty code: CV_INFO_GUID + CV_INFO_AGE = 20
                                    //fileStream.Seek(20, SeekOrigin.Current);
                                    //return fileReader.ReadString();
                                    var pe64Bit = peFile.Is64Bit;
                                    var guid = fileReader.ReadBytes(16);
                                    var age = fileReader.ReadUInt32();
                                    var extractedPdbFileName = fileReader.ReadString();
                                    var pdbFileName = extractedPdbFileName.Split('\\').Last();
                                    if (string.IsNullOrEmpty(pdbFileName))
                                    {
                                        throw new PEParsingException("empty PDB file name");
                                    }
                                    else
                                    {
                                        return new PeFilePdbInformation(peFileSize, pe64Bit, pdbFileName, guid, age);
                                    }
                                }
                                else
                                {
                                    throw new PEParsingException("bad CodeView signature");
                                }
                            }
                        }
                    }
                }
                else
                {
                    throw new PEParsingException("invalid PE");
                }
            }
        }

        private string BuildPDBUrl(string peFilePath)
        {
            var pdbInfo = PeFilePdbInformation.ExtractPDBInformation(peFilePath);
            return pdbInfo.PdbFileName;
        }

        //private void btnStart_Click(object sender, EventArgs e)
        //{
        //    var symbolServer = txtSymbolServer.Text;
        //    if (!String.IsNullOrEmpty(symbolServer))
        //    {
        //        storedSymbolServers.Add(symbolServer);

        //        // build PDB download url for each file
        //        foreach (var filePath in lstSelectedFiles.Items)
        //        {

        //        }
        //    }
        //}

        private void lstSelectedFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedFilePath = lstSelectedFiles.SelectedItem.ToString();
            //toolStripStatusLabelMain.Text = selectedFilePath;
            if (badFiles.ContainsKey(selectedFilePath))
            {
                toolStripStatusLabelMain.Text = "Error: " + badFiles[selectedFilePath];
            }
        }

        private enum ExecutionStatus
        {
            Stopped,
            ParsingPEs,
            DownloadingPDBs,
            Paused
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (executionStatus == ExecutionStatus.Stopped)
            {
                lstSelectedFiles.Enabled = false;
                lblSelectFiles.Enabled = false;
                lblDownloadedFilesLocation.Enabled = false;
                txtSymbolServer.Enabled = false;

                var symbolServer = txtSymbolServer.Text;
                if (!string.IsNullOrEmpty(symbolServer))
                {
                    storedSymbolServers.Add(symbolServer);

                    // build PDB download url for each file
                    foreach (var filePath in lstSelectedFiles.Items)
                    {
                        try
                        {

                        }
                        catch (PEParsingException parsingEx)
                        {

                        }
                    }

                    backgroundWorkerMain.RunWorkerAsync();
                }
            }
        }

        private void backgroundWorkerMain_DoWork(object sender, DoWorkEventArgs e)
        {
            //var txt = lblDownloadedFilesLocation.Text;
            lblDownloadedFilesLocation.Enabled = false;

        }

        private void backgroundWorkerMain_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorkerMain_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }
    }
}
