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
        }

        private void btnResume_Click(object sender, EventArgs e)
        {

        }

        private void lblSelectFiles_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var fileDialog = new OpenFileDialog
            {
                Multiselect = true,
                Filter = "Dynamic libraries|*.dll|Static libraries|*.lib|Executables|*.exe|Drivers|*.sys|All|*.*"
            };
            if (DialogResult.OK == fileDialog.ShowDialog())
            {
                var selectedFiles = new List<string>();
                foreach (var fileName in fileDialog.FileNames)
                {
                    selectedFiles.Add(fileName);
                }

                lstSelectedFiles.DataSource = selectedFiles;

                // show default
                lblFileStatus.Text = "waiting for start...";
                lblFileSize.Text = "File size: ";
                lblFileProgress.Text = "waiting for start...";
                lblTotalProgress.Text = "waiting for start...";
            }
        }

        private void lvlDownloadedFileLocation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var folderDialog = new FolderBrowserDialog();
            if (DialogResult.OK == folderDialog.ShowDialog())
            {
                lblDownloadedFilesLocation.Text = "Saving to: " + folderDialog.SelectedPath;
            }
        }

        private class PEFilePDBInformation
        {
            public string PEFilePath { get; }
            public string PDBFileName { get; } // null ternimated pdb file
            public byte[] PDBGuid { get; } // 16 byte GUID
            public uint PDBAge { get; } // dword Age

            public PEFilePDBInformation(string peFilePath, string pdbFileName, byte[] pdbGuid, uint pdbAge)
            {
                PEFilePath = peFilePath;
                PDBFileName = pdbFileName;
                PDBGuid = pdbGuid;
                PDBAge = pdbAge;
            }
        }

        byte[] pdb20_cv_signature = { (byte)'N', (byte)'B', (byte)'1', (byte)'0' };
        byte[] pdb70_cv_signature = { (byte)'R', (byte)'S', (byte)'D', (byte)'S' };

        private PEFilePDBInformation ExtractPDBInformation(string peFilePath)
        {
            var peFile = new PeFile(peFilePath);
            if (peFile.IsValidPeFile)
            {
                var debugDir = peFile.ImageDebugDirectory;
                if (null == debugDir)
                {
                    throw new PEParsingException("Debug directory does not exist");
                }
                else
                {
                    // dirty code: IMAGE_DEBUG_TYPE_CODEVIEW = 2
                    if (debugDir.Characteristics != 2)
                    {
                        throw new PEParsingException("Bad debug characteristics");
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
                                var guid = fileReader.ReadBytes(16);
                                var age = fileReader.ReadUInt32();
                                var pdbFileName = fileReader.ReadString();
                                return new PEFilePDBInformation(peFilePath, pdbFileName, guid, age);
                            }
                            else
                            {
                                throw new PEParsingException("Bad CodeView signature");
                            }
                        }
                    }
                }
            }
            else
            {
                throw new PEParsingException("Not a valid PE");
            }
        }

        private string BuildPDBUrl(string peFilePath)
        {
            var pdbInfo = ExtractPDBInformation(peFilePath);
            return null;
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

        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
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
            }
        }
    }
}
