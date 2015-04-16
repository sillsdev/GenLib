using System;
using System.IO;
using System.Collections;

namespace GenLib
{

    public static class Funct
    // various generic functions
    {
        public static string ShortFileName(string strFilePath)
        {
            string sfn = "";
            if (strFilePath != "")
            {
                int ndx = strFilePath.LastIndexOf(Constants.Backslash) + 1;
                int len = strFilePath.Length;
                if (ndx >= 0)
                {
                    sfn = strFilePath.Substring(ndx, len - ndx);	//remove folder
                    ndx = sfn.LastIndexOf(Constants.Period);
                    if (ndx >= 0)
                        sfn = sfn.Substring(0, ndx);                //remove extension
                }
            }
            return sfn;
        }

        public static string ShortFileNameWithExt(string strFilePath)
        {
            string sfn = "";
            if (strFilePath != "")
            {
                int ndx = strFilePath.LastIndexOf(Constants.Backslash) + 1;
                int len = strFilePath.Length;
                if (ndx >= 0)
                {
                    sfn = strFilePath.Substring(ndx, len - ndx);	//remove folder
                }
            }
            return sfn;
        }

        public static string GetFolder(string strFilePath)
        {
            string strPath = "";
            if (strFilePath != "")
            {
                int ndx = strFilePath.LastIndexOf(Constants.Backslash) + 1;
                int len = strFilePath.Length;
                if ((ndx >= 0) && (ndx < len))
                    strPath = strFilePath.Substring(0, ndx - 1);	//remove file name with extension
            }
            return strPath;
        }

        public static string GetInstalledFont()
        {
            string strFontName = "";
            SortedList slFonts = new SortedList();
            System.Drawing.Text.InstalledFontCollection ifc = new System.Drawing.Text.InstalledFontCollection();
            foreach (System.Drawing.FontFamily ff in ifc.Families)
            {
                switch (ff.Name)
                {
                    case "Andika":
                        slFonts.Add(1, ff.Name);
                        break;
                    case "Charis SIL":
                        slFonts.Add(2, ff.Name);
                        break;
                    case "Gentium Plus":
                        slFonts.Add(3, ff.Name);
                        break;
                    case "Doulos SIL":
                        slFonts.Add(4, ff.Name);
                        break;
                    case "Arial":
                        slFonts.Add(5, ff.Name);
                        break;
                    case "Times New Roman":
                        slFonts.Add(6, ff.Name);
                        break;
                    case "Microsoft Sans Serif":
                        slFonts.Add(7, ff.Name);
                        break;
                    case "Courier New":
                        slFonts.Add(8, ff.Name);
                        break;
                    default:
                        break;
                }
            }
            if (slFonts.Count > 0)
            {
                foreach (DictionaryEntry de in slFonts)
                {
                    strFontName = (string) de.Value;
                    break;
                }
            }
            return strFontName;
        }

        public static string GetUnicodeString(string s)
        {
            string strUnicode = "";
            string strVal = "";
            foreach (char c in s)
            {
                strVal = String.Format("{0:x4}", (int)c);
                strUnicode = strUnicode + strVal;
            }
            return strUnicode;
        }

        public static int GetPercentage(int num, int total)
        {
            if (total != 0)
            {
                double d = Convert.ToDouble(num) * Convert.ToDouble(100) / Convert.ToDouble(total);
                d = d + 0.01;
                return Convert.ToInt16(d);
            }
            else return 0;
        }
            
        public static ArrayList ConvertStringToArrayList(string str, string sep)
        {
            // str is the string to convert
            // sep is the string that separates the string into its elements
            ArrayList al = new ArrayList();
            int nBeg = 0;
            int nEnd = 0;
            string strElem = "";

            do
            {
                nEnd = str.IndexOf(sep, nBeg);
                if (nEnd < 0)
                    nEnd = str.Length;
                strElem = str.Substring(nBeg, nEnd - nBeg);
                if (strElem != "")
                    al.Add(strElem);
                nBeg = nEnd + sep.Length;
            }
            while (nBeg < str.Length);
            al.TrimToSize();
            return al;
        }

        public static string ConvertArrayListToString(ArrayList al, string sep)
        {
            // al is the array list to convert
            // sep is the string to separate the items in the array list
            string str = "";
            if (al != null)
            {
                if (al.Count > 0)
                {
                    for (int i = 0; i < al.Count; i++)
                    {
                        str += al[i].ToString() + sep;
                    }
                    str = str.Substring(0, str.Length - sep.Length);
                    str = str.Trim();
                }
            }
            return str;
        }

        public static void FolderCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            DirectoryInfo[] dirs = dir.GetDirectories();

            // If the source directory does not exist, throw an exception.
            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            // If the destination directory does not exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }


            // Get the file contents of the directory to copy.
            FileInfo[] files = dir.GetFiles();

            foreach (FileInfo file in files)
            {
                // Create the path to the new copy of the file.
                string temppath = Path.Combine(destDirName, file.Name);

                // Copy the file.
                file.CopyTo(temppath, true);
            }

            // If copySubDirs is true, copy the subdirectories.
            if (copySubDirs)
            {

                foreach (DirectoryInfo subdir in dirs)
                {
                    // Create the subdirectory.
                    string temppath = Path.Combine(destDirName, subdir.Name);

                    // Copy the subdirectories.
                    FolderCopy(subdir.FullName, temppath, copySubDirs);
                }
            }

        }

    }
}
