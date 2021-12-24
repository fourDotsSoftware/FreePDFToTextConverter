using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace FreePDFToTextConverter
{
    class FileInfoHelper
    {
        public static string GetFileTypeDescription(string filepath)
        {
            try
            {
                NativeMethods.SHFILEINFO info = new NativeMethods.SHFILEINFO();

                string fileName = filepath;
                uint dwFileAttributes = NativeMethods.FILE_ATTRIBUTE.FILE_ATTRIBUTE_NORMAL;
                uint uFlags = (uint)(NativeMethods.SHGFI.SHGFI_TYPENAME | NativeMethods.SHGFI.SHGFI_USEFILEATTRIBUTES);

                NativeMethods.SHGetFileInfo(fileName, dwFileAttributes, ref info, (uint)Marshal.SizeOf(info), uFlags);

                return info.szTypeName;
            }
            catch
            {
                return "";
            }

        }
    }

    static class NativeMethods
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct SHFILEINFO
        {
            public IntPtr hIcon;
            public int iIcon;
            public uint dwAttributes;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szDisplayName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string szTypeName;
        };

        public static class FILE_ATTRIBUTE
        {
            public const uint FILE_ATTRIBUTE_NORMAL = 0x80;
        }

        public static class SHGFI
        {
            public const uint SHGFI_TYPENAME = 0x000000400;
            public const uint SHGFI_USEFILEATTRIBUTES = 0x000000010;
        }

        [DllImport("shell32.dll")]
        public static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes, ref SHFILEINFO psfi, uint cbSizeFileInfo, uint uFlags);
    }

}
