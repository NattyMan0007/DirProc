using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DirProc.Properties;

namespace DirProc
{
    public class Helper
    {
        /// <summary>
        ///     Removes a specified string from the values in a ListBox
        /// </summary>
        /// <param name="l">ListBox to iterate through</param>
        /// <param name="remove">String to Remove</param>
        /// <param name="path">Path to folder of files</param>
        public static void RemoveString(ListBox l, string remove, string path)
        {
            foreach (var file in l.Items.Cast<string>().Where(file => file.Contains(remove)))
            {
                try
                {
                    File.Move($"{path}\\{file}", $"{path}\\{file.Replace(remove, "")}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            foreach (var file in l.Items)
            {
                MainForm.RemoveList.Add($"{path}\\{file}");
            }
            ListFiles(l, MainForm.FolderPath);
        }

        /// <summary>
        ///     Replaces a string in ListBox Elements
        /// </summary>
        /// <param name="l">ListBox to iterate through</param>
        /// <param name="find">String to look for</param>
        /// <param name="replace">String to replace with</param>
        /// <param name="path">Path to folder of files</param>
        public static void ReplaceString(ListBox l, string find, string replace, string path)
        {
            foreach (var file in l.Items)
            {
                MainForm.ReplaceList.Add($"{path}\\{file}");
            }
            foreach (var file in l.Items.Cast<string>().Where(file => file.Contains(find)))
            {
                var fileNameWithoutExtension = Path.GetFileNameWithoutExtension(file);
                if (fileNameWithoutExtension == null) continue;
                string newfilename =
                    $"{path}\\{fileNameWithoutExtension.Replace(find, replace)}{Path.GetExtension(file)}";

                try
                {
                    File.Move($"{path}\\{file}", newfilename);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            foreach (var file in l.Items)
            {
                MainForm.ReplaceList.Add($"{path}\\{file}");
            }
            ListFiles(l, MainForm.FolderPath);
        }

        /// <summary>
        ///     Gets the parts of the input string
        /// </summary>
        /// <param name="group">Group identifier, 1 = start of pattern, 2 = end of pattern</param>
        /// <param name="input">Input String to parse</param>
        /// <returns></returns>
        public static string GetFileParts(int group, string input)
        {
            var m = Regex.Match(input, @"(^.*[A-Za-z][0-9]{1,4}[A-Za-z][0-9]{1,4})([^\n\r]*)").Groups[group];
            return m.Success ? m.Value : "";
        }

        /// <summary>
        ///     Automatically clean a folder based on the rule matching SnnEnn where n is a number
        /// </summary>
        /// <param name="l">ListBox to iterate through</param>
        /// <param name="path">Path to folder of files</param>
        public static void AutoClean(ListBox l, string path)
        {
            MainForm.RemoveList.Clear();
            foreach (var file in l.Items)
            {
                MainForm.RemoveList.Add($"{path}\\{file}");
            }
            var m =
                MessageBox.Show(Resources.AutoRemoveMessage,
                    Resources.AutoRemove_Caption, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (m == DialogResult.No) return;

            foreach (
                var file in
                    l.Items.Cast<string>()
                        .Where(file => file.Contains(GetFileParts(2, Path.GetFileNameWithoutExtension(file)))))
            {
                try
                {
                    if (GetFileParts(2, Path.GetFileNameWithoutExtension(file)) == "") continue;
                    File.Move($"{path}\\{file}",
                        $"{path}\\{GetFileParts(1, Path.GetFileNameWithoutExtension(file)) + Path.GetExtension(file)}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            ListFiles(l, MainForm.FolderPath);

            ReplaceString(l, ".", " ", path);
            ListFiles(l,MainForm.FolderPath);
            ReplaceString(l, "S H I E L D", "S.H.I.E.L.D", path);
        }

        /// <summary>
        ///     Lists files in a directory and displays them in a ListBox
        /// </summary>
        /// <param name="l">ListBox to write to</param>
        /// <param name="path">Path to files</param>
        public static void ListFiles(ListBox l, string path)
        {
            l.Items.Clear();
            var files = new List<string>();
            if (!string.IsNullOrEmpty(path))
            {
                files.AddRange(Directory.GetFiles(path));
            }
            else return;


            foreach (var name in files.AsEnumerable().OrderBy(x => x, new NaturalSortComparer()).ToList())
            {
                // ReSharper disable once AssignNullToNotNullAttribute
                l.Items.Add(Path.GetFileName(name));
            }
        }
    }

    /// <summary>
    ///     Sorting Class for IComparer
    /// </summary>
    public class NaturalSortComparer : IComparer<string>, IDisposable
    {
        private readonly bool _isAscending;

        private Dictionary<string, string[]> _table = new Dictionary<string, string[]>();

        /// <summary>
        ///     Creates a new NaturalSortComparer
        /// </summary>
        /// <param name="inAscendingOrder">sort in Ascending or Descending order, true is default (Ascending)</param>
        public NaturalSortComparer(bool inAscendingOrder = true)
        {
            _isAscending = inAscendingOrder;
        }

        public void Dispose()
        {
            _table.Clear();
            _table = null;
        }

        #region IComparer<string> Members

        public int Compare(string x, string y)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IComparer<string> Members

        int IComparer<string>.Compare(string x, string y)
        {
            if (x == y)
                return 0;

            string[] x1, y1;

            if (!_table.TryGetValue(x, out x1))
            {
                x1 = Regex.Split(x.Replace(" ", ""), "([0-9]+)");
                _table.Add(x, x1);
            }

            if (!_table.TryGetValue(y, out y1))
            {
                y1 = Regex.Split(y.Replace(" ", ""), "([0-9]+)");
                _table.Add(y, y1);
            }

            int returnVal;

            for (var i = 0; i < x1.Length && i < y1.Length; i++)
            {
                if (x1[i] == y1[i]) continue;
                returnVal = PartCompare(x1[i], y1[i]);
                return _isAscending ? returnVal : -returnVal;
            }

            if (y1.Length > x1.Length)
            {
                returnVal = 1;
            }
            else if (x1.Length > y1.Length)
            {
                returnVal = -1;
            }
            else
            {
                returnVal = 0;
            }

            return _isAscending ? returnVal : -returnVal;
        }

        private static int PartCompare(string left, string right)
        {
            int x, y;
            if (!int.TryParse(left, out x))
                return string.Compare(left, right, StringComparison.Ordinal);

            if (!int.TryParse(right, out y))
                return string.Compare(left, right, StringComparison.Ordinal);

            return x.CompareTo(y);
        }

        #endregion
    }
}