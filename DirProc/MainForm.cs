#region

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DirProc.Properties;

#endregion

namespace DirProc
{
    public partial class MainForm : Form
    {
        public static string FolderPath;

        public static List<string> RemoveList = new List<string>();
        public static List<string> ReplaceList = new List<string>();
        private readonly FolderBrowserDialog _folderSelection = new FolderBrowserDialog();

        public MainForm()
        {
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowOnly;
            InitializeComponent();
            Size = new Size(506, 402);
            MinimumSize = new Size(506, 402);
            MaximumSize = new Size(506, 402);
            var enabledTimer = new Timer();
            enabledTimer.Tick += EnabledTimer_Tick;
            enabledTimer.Interval = 50;
            enabledTimer.Start();
        }

        private void EnabledTimer_Tick(object sender, EventArgs e)
        {
            var isEnabledRemove = lvRemoveFilesList.Items.Count != 0;
            var isEnabledReplace = lvReplaceFilesList.Items.Count != 0;

            btnUndoRemove.Enabled = isEnabledRemove;
            btnRemoveAuto.Enabled = isEnabledRemove;
            btnRemoveProcess.Enabled = isEnabledRemove;
            btnRemoveClear.Enabled = isEnabledRemove;
            btnRemoveRefresh.Enabled = isEnabledRemove;
            txtRemoveString.Enabled = isEnabledRemove;
            
            btnUndoReplace.Enabled = isEnabledReplace;
            btnReplaceClear.Enabled = isEnabledReplace;
            btnReplaceRefresh.Enabled = isEnabledReplace;
            btnReplaceProcess.Enabled = isEnabledReplace;
            txtReplaceTextFind.Enabled = isEnabledReplace;
            txtReplaceTextWith.Enabled = isEnabledReplace;
        }

        private void btnRemoveAuto_Click(object sender, EventArgs e)
        {
            Helper.AutoClean(lvRemoveFilesList, txtRemoveFolderPath.Text);
        }

        private void btnUndoRemove_Click(object sender, EventArgs e)
        {
            if (RemoveList.Count < lvRemoveFilesList.Items.Count || RemoveList.Count == 0)
            {
                MessageBox.Show(Resources.UndoMessage, Resources.UndoCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            for (var i = 0; i < lvRemoveFilesList.Items.Count; i++)
            {
                File.Move($"{txtRemoveFolderPath.Text}\\{lvRemoveFilesList.Items[i]}", RemoveList[i]);
            }
            RemoveList.Clear();
            Helper.ListFiles(lvRemoveFilesList, FolderPath);
        }

        private void btnUndoReplace_Click(object sender, EventArgs e)
        {
            if (ReplaceList.Count < lvReplaceFilesList.Items.Count || ReplaceList.Count == 0)
            {
                MessageBox.Show(Resources.UndoMessage, Resources.UndoCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            for (var i = 0; i < lvReplaceFilesList.Items.Count; i++)
            {
                File.Move($"{txtReplaceFolderPath.Text}\\{lvReplaceFilesList.Items[i]}", ReplaceList[i]);
            }
            ReplaceList.Clear();
            Helper.ListFiles(lvReplaceFilesList, FolderPath);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }
    
        #region Replace Tab

        private void btnReplaceBrowse_Click(object sender, EventArgs e)
        {
            ClearTab2();
            _folderSelection.ShowDialog();
            FolderPath = _folderSelection.SelectedPath;
            txtReplaceFolderPath.Text = FolderPath;
            Helper.ListFiles(lvReplaceFilesList, FolderPath);
            _folderSelection.Dispose();
        }

        private void btnReplaceProcess_Click(object sender, EventArgs e)
        {
            Helper.ReplaceString(lvReplaceFilesList, txtReplaceTextFind.Text, txtReplaceTextWith.Text,
                txtReplaceFolderPath.Text);
        }

        private void btnReplaceClear_Click(object sender, EventArgs e)
        {
            ClearTab2();
        }

        private void btnReplaceRefresh_Click(object sender, EventArgs e)
        {
            Helper.ListFiles(lvReplaceFilesList, FolderPath);
        }

        #endregion

        #region Remove Tab

        private void btnRemoveBrowseFolder_Click(object sender, EventArgs e)
        {
            ClearTab1();
            _folderSelection.ShowDialog();
            FolderPath = _folderSelection.SelectedPath;
            txtRemoveFolderPath.Text = FolderPath;
            Helper.ListFiles(lvRemoveFilesList, FolderPath);
            _folderSelection.Dispose();
        }

        private void btnRemoveProcess_Click(object sender, EventArgs e)
        {
            Helper.RemoveString(lvRemoveFilesList, txtRemoveString.Text, txtRemoveFolderPath.Text);
        }


        private void btnRemoveClear_Click(object sender, EventArgs e)
        {
            ClearTab1();
        }

        private void btnRemoveRefresh_Click(object sender, EventArgs e)
        {
            Helper.ListFiles(lvRemoveFilesList, FolderPath);
        }

        #endregion

        #region Operations

        private void tbcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabMain.SelectedIndex)
            {
                case 0:
                    Size = new Size(506, 402);
                    MinimumSize = new Size(506, 402);
                    MaximumSize = new Size(506, 402);
                    break;
                case 1:
                    Size = new Size(506, 432);
                    MinimumSize = new Size(506, 432);
                    MaximumSize = new Size(506, 432);
                    break;
            }
        }

        private void ClearTab1()
        {
            FolderPath = string.Empty;
            txtRemoveFolderPath.Clear();
            txtRemoveString.Clear();
            lvRemoveFilesList.Items.Clear();
            RemoveList.Clear();
        }

        private void ClearTab2()
        {
            FolderPath = string.Empty;
            txtReplaceFolderPath.Clear();
            txtReplaceTextFind.Clear();
            txtReplaceTextWith.Clear();
            lvReplaceFilesList.Items.Clear();
            ReplaceList.Clear();
        }

        #endregion
    }
}