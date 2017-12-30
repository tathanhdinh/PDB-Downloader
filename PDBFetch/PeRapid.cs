using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDBFetch
{
    class PeRapid
    {
        public class PeParsingException : Exception
        {
            public PeParsingException()
            {
            }

            public PeParsingException(string msg) : base(msg)
            {
            }

            public PeParsingException(string msg, Exception inner) : base(msg, inner)
            {
            }
        }

        public class IMAGE_DOS_HEADER
        {

            public ushort e_magic { get; }              // Magic number
            public ushort e_cblp { get; }               // Bytes on last page of file
            public ushort e_cp { get; }                 // Pages in file
            public ushort e_crlc { get; }               // Relocations
            public ushort e_cparhdr { get; }            // Size of header in paragraphs
            public ushort e_minalloc { get; }           // Minimum extra paragraphs needed
            public ushort e_maxalloc { get; }           // Maximum extra paragraphs needed
            public ushort e_ss { get; }                 // Initial (relative) SS value
            public ushort e_sp { get; }                 // Initial SP value
            public ushort e_csum { get; }               // Checksum
            public ushort e_ip { get; }                 // Initial IP value
            public ushort e_cs { get; }                 // Initial (relative) CS value
            public ushort e_lfarlc { get; }             // File address of relocation table
            public ushort e_ovno { get; }               // Overlay number
            public ushort e_res_0 { get; }              // Reserved words
            public ushort e_res_1 { get; }              // Reserved words
            public ushort e_res_2 { get; }              // Reserved words
            public ushort e_res_3 { get; }              // Reserved words
            public ushort e_oemid { get; }              // OEM identifier (for e_oeminfo)
            public ushort e_oeminfo { get; }            // OEM information; e_oemid specific
            public ushort e_res2_0 { get; }             // Reserved words
            public ushort e_res2_1 { get; }             // Reserved words
            public ushort e_res2_2 { get; }             // Reserved words
            public ushort e_res2_3 { get; }             // Reserved words
            public ushort e_res2_4 { get; }             // Reserved words
            public ushort e_res2_5 { get; }             // Reserved words
            public ushort e_res2_6 { get; }             // Reserved words
            public ushort e_res2_7 { get; }             // Reserved words
            public ushort e_res2_8 { get; }             // Reserved words
            public ushort e_res2_9 { get; }             // Reserved words
            public ushort e_lfanew { get; }             // File address of new exe header

            #region constructor
            public IMAGE_DOS_HEADER(BinaryReader reader)
            {
                e_magic = reader.ReadUInt16();
                e_cblp = reader.ReadUInt16();
                e_cp = reader.ReadUInt16();
                e_crlc = reader.ReadUInt16();
                e_cparhdr = reader.ReadUInt16();
                e_minalloc = reader.ReadUInt16();
                e_maxalloc = reader.ReadUInt16();
                e_ss = reader.ReadUInt16(); ;
                e_sp = reader.ReadUInt16();
                e_csum = reader.ReadUInt16();
                e_ip = reader.ReadUInt16();
                e_cs = reader.ReadUInt16();
                e_lfarlc = reader.ReadUInt16();
                e_ovno = reader.ReadUInt16();
                e_res_0 = reader.ReadUInt16();
                e_res_1 = reader.ReadUInt16();
                e_res_2 = reader.ReadUInt16();
                e_res_3 = reader.ReadUInt16();
                e_oemid = reader.ReadUInt16();
                e_res2_0 = reader.ReadUInt16();
                e_res2_1 = reader.ReadUInt16();
                e_res2_2 = reader.ReadUInt16();
                e_res2_3 = reader.ReadUInt16();
                e_res2_4 = reader.ReadUInt16();
                e_res2_5 = reader.ReadUInt16();
                e_res2_6 = reader.ReadUInt16();
                e_res2_7 = reader.ReadUInt16();
                e_res2_8 = reader.ReadUInt16();
                e_res2_9 = reader.ReadUInt16();
                e_lfanew = reader.ReadUInt16();
            }
            #endregion constructor
        }
        IMAGE_DOS_HEADER ImageDosHeader { get; }

        public class IMAGE_FILE_HEADER
        {
            public UInt16 Machine { get; }
            public UInt16 NumberOfSections { get; }
            public UInt32 TimeDateStamp { get; }
            public UInt32 PointerToSymbolTable { get; }
            public UInt32 NumberOfSymbols { get; }
            public UInt16 SizeOfOptionalHeader { get; }
            public UInt16 Characteristics { get; }
        }

        #region constructor
        PeRapid(string filePath)
        {
            var stream = new FileStream(filePath, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            var reader = new BinaryReader(stream);

            try
            {
                ImageDosHeader = new IMAGE_DOS_HEADER(reader);
            }
            catch
            {
                throw new PeParsingException("bad dos header");
            }

            if (0x5a4d != ImageDosHeader.e_magic)
            {
                throw new PeParsingException("magic bytes not found");
            }
            

        }
        #endregion constructor
    }
}
