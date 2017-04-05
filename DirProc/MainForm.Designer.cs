namespace DirProc
{
    sealed partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtRemoveFolderPath = new System.Windows.Forms.TextBox();
            this.lblFolder1 = new System.Windows.Forms.Label();
            this.btnRemoveBrowseFolder = new System.Windows.Forms.Button();
            this.lblFiles1 = new System.Windows.Forms.Label();
            this.lblRemove1 = new System.Windows.Forms.Label();
            this.txtRemoveString = new System.Windows.Forms.TextBox();
            this.btnRemoveProcess = new System.Windows.Forms.Button();
            this.btnRemoveClear = new System.Windows.Forms.Button();
            this.lvRemoveFilesList = new System.Windows.Forms.ListBox();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tbRemove = new System.Windows.Forms.TabPage();
            this.btnUndoRemove = new System.Windows.Forms.Button();
            this.btnRemoveAuto = new System.Windows.Forms.Button();
            this.btnRemoveRefresh = new System.Windows.Forms.Button();
            this.tbReplace = new System.Windows.Forms.TabPage();
            this.btnUndoReplace = new System.Windows.Forms.Button();
            this.btnReplaceRefresh = new System.Windows.Forms.Button();
            this.lblReplace = new System.Windows.Forms.Label();
            this.txtReplaceTextWith = new System.Windows.Forms.TextBox();
            this.txtReplaceFolderPath = new System.Windows.Forms.TextBox();
            this.lvReplaceFilesList = new System.Windows.Forms.ListBox();
            this.lblFolder2 = new System.Windows.Forms.Label();
            this.btnReplaceBrowse = new System.Windows.Forms.Button();
            this.btnReplaceClear = new System.Windows.Forms.Button();
            this.lblFiles2 = new System.Windows.Forms.Label();
            this.lblFind = new System.Windows.Forms.Label();
            this.btnReplaceProcess = new System.Windows.Forms.Button();
            this.txtReplaceTextFind = new System.Windows.Forms.TextBox();
            this.tabMain.SuspendLayout();
            this.tbRemove.SuspendLayout();
            this.tbReplace.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRemoveFolderPath
            // 
            this.txtRemoveFolderPath.Location = new System.Drawing.Point(52, 6);
            this.txtRemoveFolderPath.Name = "txtRemoveFolderPath";
            this.txtRemoveFolderPath.ReadOnly = true;
            this.txtRemoveFolderPath.Size = new System.Drawing.Size(338, 22);
            this.txtRemoveFolderPath.TabIndex = 0;
            // 
            // lblFolder1
            // 
            this.lblFolder1.AutoSize = true;
            this.lblFolder1.Location = new System.Drawing.Point(3, 9);
            this.lblFolder1.Name = "lblFolder1";
            this.lblFolder1.Size = new System.Drawing.Size(43, 13);
            this.lblFolder1.TabIndex = 1;
            this.lblFolder1.Text = "Folder:";
            // 
            // btnRemoveBrowseFolder
            // 
            this.btnRemoveBrowseFolder.Location = new System.Drawing.Point(396, 6);
            this.btnRemoveBrowseFolder.Name = "btnRemoveBrowseFolder";
            this.btnRemoveBrowseFolder.Size = new System.Drawing.Size(75, 22);
            this.btnRemoveBrowseFolder.TabIndex = 1;
            this.btnRemoveBrowseFolder.Text = "Browse...";
            this.btnRemoveBrowseFolder.UseVisualStyleBackColor = true;
            this.btnRemoveBrowseFolder.Click += new System.EventHandler(this.btnRemoveBrowseFolder_Click);
            // 
            // lblFiles1
            // 
            this.lblFiles1.AutoSize = true;
            this.lblFiles1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiles1.Location = new System.Drawing.Point(207, 29);
            this.lblFiles1.Name = "lblFiles1";
            this.lblFiles1.Size = new System.Drawing.Size(52, 20);
            this.lblFiles1.TabIndex = 4;
            this.lblFiles1.Text = "Files:";
            // 
            // lblRemove1
            // 
            this.lblRemove1.AutoSize = true;
            this.lblRemove1.Location = new System.Drawing.Point(3, 286);
            this.lblRemove1.Name = "lblRemove1";
            this.lblRemove1.Size = new System.Drawing.Size(95, 13);
            this.lblRemove1.TabIndex = 5;
            this.lblRemove1.Text = "String to remove:";
            // 
            // txtRemoveString
            // 
            this.txtRemoveString.Location = new System.Drawing.Point(104, 283);
            this.txtRemoveString.Name = "txtRemoveString";
            this.txtRemoveString.Size = new System.Drawing.Size(367, 22);
            this.txtRemoveString.TabIndex = 2;
            // 
            // btnRemoveProcess
            // 
            this.btnRemoveProcess.Location = new System.Drawing.Point(265, 309);
            this.btnRemoveProcess.Name = "btnRemoveProcess";
            this.btnRemoveProcess.Size = new System.Drawing.Size(125, 23);
            this.btnRemoveProcess.TabIndex = 3;
            this.btnRemoveProcess.Text = "Process Directory";
            this.btnRemoveProcess.UseVisualStyleBackColor = true;
            this.btnRemoveProcess.Click += new System.EventHandler(this.btnRemoveProcess_Click);
            // 
            // btnRemoveClear
            // 
            this.btnRemoveClear.Location = new System.Drawing.Point(396, 309);
            this.btnRemoveClear.Name = "btnRemoveClear";
            this.btnRemoveClear.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveClear.TabIndex = 7;
            this.btnRemoveClear.Text = "Clear";
            this.btnRemoveClear.UseVisualStyleBackColor = true;
            this.btnRemoveClear.Click += new System.EventHandler(this.btnRemoveClear_Click);
            // 
            // lvRemoveFilesList
            // 
            this.lvRemoveFilesList.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lvRemoveFilesList.FormattingEnabled = true;
            this.lvRemoveFilesList.ItemHeight = 17;
            this.lvRemoveFilesList.Location = new System.Drawing.Point(6, 52);
            this.lvRemoveFilesList.Name = "lvRemoveFilesList";
            this.lvRemoveFilesList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lvRemoveFilesList.Size = new System.Drawing.Size(465, 225);
            this.lvRemoveFilesList.TabIndex = 11;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tbRemove);
            this.tabMain.Controls.Add(this.tbReplace);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(538, 467);
            this.tabMain.TabIndex = 12;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tbcMain_SelectedIndexChanged);
            // 
            // tbRemove
            // 
            this.tbRemove.Controls.Add(this.btnUndoRemove);
            this.tbRemove.Controls.Add(this.btnRemoveAuto);
            this.tbRemove.Controls.Add(this.btnRemoveRefresh);
            this.tbRemove.Controls.Add(this.txtRemoveFolderPath);
            this.tbRemove.Controls.Add(this.lvRemoveFilesList);
            this.tbRemove.Controls.Add(this.lblFolder1);
            this.tbRemove.Controls.Add(this.btnRemoveBrowseFolder);
            this.tbRemove.Controls.Add(this.btnRemoveClear);
            this.tbRemove.Controls.Add(this.lblFiles1);
            this.tbRemove.Controls.Add(this.lblRemove1);
            this.tbRemove.Controls.Add(this.btnRemoveProcess);
            this.tbRemove.Controls.Add(this.txtRemoveString);
            this.tbRemove.Location = new System.Drawing.Point(4, 22);
            this.tbRemove.Name = "tbRemove";
            this.tbRemove.Padding = new System.Windows.Forms.Padding(3);
            this.tbRemove.Size = new System.Drawing.Size(530, 441);
            this.tbRemove.TabIndex = 0;
            this.tbRemove.Text = "Remove Text";
            this.tbRemove.UseVisualStyleBackColor = true;
            // 
            // btnUndoRemove
            // 
            this.btnUndoRemove.Location = new System.Drawing.Point(15, 309);
            this.btnUndoRemove.Name = "btnUndoRemove";
            this.btnUndoRemove.Size = new System.Drawing.Size(75, 23);
            this.btnUndoRemove.TabIndex = 5;
            this.btnUndoRemove.Text = "Undo";
            this.btnUndoRemove.UseVisualStyleBackColor = true;
            this.btnUndoRemove.Click += new System.EventHandler(this.btnUndoRemove_Click);
            // 
            // btnRemoveAuto
            // 
            this.btnRemoveAuto.Location = new System.Drawing.Point(96, 309);
            this.btnRemoveAuto.Name = "btnRemoveAuto";
            this.btnRemoveAuto.Size = new System.Drawing.Size(77, 23);
            this.btnRemoveAuto.TabIndex = 4;
            this.btnRemoveAuto.Text = "Auto Clean";
            this.btnRemoveAuto.UseVisualStyleBackColor = true;
            this.btnRemoveAuto.Click += new System.EventHandler(this.btnRemoveAuto_Click);
            // 
            // btnRemoveRefresh
            // 
            this.btnRemoveRefresh.Location = new System.Drawing.Point(179, 309);
            this.btnRemoveRefresh.Name = "btnRemoveRefresh";
            this.btnRemoveRefresh.Size = new System.Drawing.Size(80, 23);
            this.btnRemoveRefresh.TabIndex = 6;
            this.btnRemoveRefresh.Text = "Refresh";
            this.btnRemoveRefresh.UseVisualStyleBackColor = true;
            this.btnRemoveRefresh.Click += new System.EventHandler(this.btnRemoveRefresh_Click);
            // 
            // tbReplace
            // 
            this.tbReplace.Controls.Add(this.btnUndoReplace);
            this.tbReplace.Controls.Add(this.btnReplaceRefresh);
            this.tbReplace.Controls.Add(this.lblReplace);
            this.tbReplace.Controls.Add(this.txtReplaceTextWith);
            this.tbReplace.Controls.Add(this.txtReplaceFolderPath);
            this.tbReplace.Controls.Add(this.lvReplaceFilesList);
            this.tbReplace.Controls.Add(this.lblFolder2);
            this.tbReplace.Controls.Add(this.btnReplaceBrowse);
            this.tbReplace.Controls.Add(this.btnReplaceClear);
            this.tbReplace.Controls.Add(this.lblFiles2);
            this.tbReplace.Controls.Add(this.lblFind);
            this.tbReplace.Controls.Add(this.btnReplaceProcess);
            this.tbReplace.Controls.Add(this.txtReplaceTextFind);
            this.tbReplace.Location = new System.Drawing.Point(4, 22);
            this.tbReplace.Name = "tbReplace";
            this.tbReplace.Padding = new System.Windows.Forms.Padding(3);
            this.tbReplace.Size = new System.Drawing.Size(530, 441);
            this.tbReplace.TabIndex = 1;
            this.tbReplace.Text = "Replace Text";
            this.tbReplace.UseVisualStyleBackColor = true;
            // 
            // btnUndoReplace
            // 
            this.btnUndoReplace.Location = new System.Drawing.Point(103, 338);
            this.btnUndoReplace.Name = "btnUndoReplace";
            this.btnUndoReplace.Size = new System.Drawing.Size(75, 23);
            this.btnUndoReplace.TabIndex = 11;
            this.btnUndoReplace.Text = "Undo";
            this.btnUndoReplace.UseVisualStyleBackColor = true;
            this.btnUndoReplace.Click += new System.EventHandler(this.btnUndoReplace_Click);
            // 
            // btnReplaceRefresh
            // 
            this.btnReplaceRefresh.Location = new System.Drawing.Point(184, 338);
            this.btnReplaceRefresh.Name = "btnReplaceRefresh";
            this.btnReplaceRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnReplaceRefresh.TabIndex = 12;
            this.btnReplaceRefresh.Text = "Refresh";
            this.btnReplaceRefresh.UseVisualStyleBackColor = true;
            this.btnReplaceRefresh.Click += new System.EventHandler(this.btnReplaceRefresh_Click);
            // 
            // lblReplace
            // 
            this.lblReplace.AutoSize = true;
            this.lblReplace.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReplace.Location = new System.Drawing.Point(15, 312);
            this.lblReplace.Name = "lblReplace";
            this.lblReplace.Size = new System.Drawing.Size(78, 13);
            this.lblReplace.TabIndex = 23;
            this.lblReplace.Text = "Replace With:";
            // 
            // txtReplaceTextWith
            // 
            this.txtReplaceTextWith.Location = new System.Drawing.Point(100, 309);
            this.txtReplaceTextWith.Name = "txtReplaceTextWith";
            this.txtReplaceTextWith.Size = new System.Drawing.Size(371, 22);
            this.txtReplaceTextWith.TabIndex = 9;
            // 
            // txtReplaceFolderPath
            // 
            this.txtReplaceFolderPath.Location = new System.Drawing.Point(52, 6);
            this.txtReplaceFolderPath.Name = "txtReplaceFolderPath";
            this.txtReplaceFolderPath.ReadOnly = true;
            this.txtReplaceFolderPath.Size = new System.Drawing.Size(338, 22);
            this.txtReplaceFolderPath.TabIndex = 12;
            // 
            // lvReplaceFilesList
            // 
            this.lvReplaceFilesList.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lvReplaceFilesList.FormattingEnabled = true;
            this.lvReplaceFilesList.HorizontalScrollbar = true;
            this.lvReplaceFilesList.ItemHeight = 17;
            this.lvReplaceFilesList.Location = new System.Drawing.Point(6, 52);
            this.lvReplaceFilesList.Name = "lvReplaceFilesList";
            this.lvReplaceFilesList.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lvReplaceFilesList.Size = new System.Drawing.Size(465, 225);
            this.lvReplaceFilesList.Sorted = true;
            this.lvReplaceFilesList.TabIndex = 21;
            // 
            // lblFolder2
            // 
            this.lblFolder2.AutoSize = true;
            this.lblFolder2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolder2.Location = new System.Drawing.Point(3, 9);
            this.lblFolder2.Name = "lblFolder2";
            this.lblFolder2.Size = new System.Drawing.Size(43, 13);
            this.lblFolder2.TabIndex = 13;
            this.lblFolder2.Text = "Folder:";
            // 
            // btnReplaceBrowse
            // 
            this.btnReplaceBrowse.Location = new System.Drawing.Point(396, 6);
            this.btnReplaceBrowse.Name = "btnReplaceBrowse";
            this.btnReplaceBrowse.Size = new System.Drawing.Size(75, 22);
            this.btnReplaceBrowse.TabIndex = 7;
            this.btnReplaceBrowse.Text = "Browse...";
            this.btnReplaceBrowse.UseVisualStyleBackColor = true;
            this.btnReplaceBrowse.Click += new System.EventHandler(this.btnReplaceBrowse_Click);
            // 
            // btnReplaceClear
            // 
            this.btnReplaceClear.Location = new System.Drawing.Point(396, 338);
            this.btnReplaceClear.Name = "btnReplaceClear";
            this.btnReplaceClear.Size = new System.Drawing.Size(75, 23);
            this.btnReplaceClear.TabIndex = 13;
            this.btnReplaceClear.Text = "Clear";
            this.btnReplaceClear.UseVisualStyleBackColor = true;
            this.btnReplaceClear.Click += new System.EventHandler(this.btnReplaceClear_Click);
            // 
            // lblFiles2
            // 
            this.lblFiles2.AutoSize = true;
            this.lblFiles2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiles2.Location = new System.Drawing.Point(207, 29);
            this.lblFiles2.Name = "lblFiles2";
            this.lblFiles2.Size = new System.Drawing.Size(52, 20);
            this.lblFiles2.TabIndex = 15;
            this.lblFiles2.Text = "Files:";
            // 
            // lblFind
            // 
            this.lblFind.AutoSize = true;
            this.lblFind.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFind.Location = new System.Drawing.Point(29, 286);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(64, 13);
            this.lblFind.TabIndex = 16;
            this.lblFind.Text = "Find What:";
            // 
            // btnReplaceProcess
            // 
            this.btnReplaceProcess.Location = new System.Drawing.Point(265, 338);
            this.btnReplaceProcess.Name = "btnReplaceProcess";
            this.btnReplaceProcess.Size = new System.Drawing.Size(125, 23);
            this.btnReplaceProcess.TabIndex = 10;
            this.btnReplaceProcess.Text = "Process Directory";
            this.btnReplaceProcess.UseVisualStyleBackColor = true;
            this.btnReplaceProcess.Click += new System.EventHandler(this.btnReplaceProcess_Click);
            // 
            // txtReplaceTextFind
            // 
            this.txtReplaceTextFind.Location = new System.Drawing.Point(100, 283);
            this.txtReplaceTextFind.Name = "txtReplaceTextFind";
            this.txtReplaceTextFind.Size = new System.Drawing.Size(371, 22);
            this.txtReplaceTextFind.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(538, 467);
            this.Controls.Add(this.tabMain);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Directory Processor";
            this.tabMain.ResumeLayout(false);
            this.tbRemove.ResumeLayout(false);
            this.tbRemove.PerformLayout();
            this.tbReplace.ResumeLayout(false);
            this.tbReplace.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtRemoveFolderPath;
        private System.Windows.Forms.Label lblFolder1;
        private System.Windows.Forms.Button btnRemoveBrowseFolder;
        private System.Windows.Forms.Label lblFiles1;
        private System.Windows.Forms.Label lblRemove1;
        private System.Windows.Forms.TextBox txtRemoveString;
        private System.Windows.Forms.Button btnRemoveProcess;
        private System.Windows.Forms.Button btnRemoveClear;
        private System.Windows.Forms.ListBox lvRemoveFilesList;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tbRemove;
        private System.Windows.Forms.TabPage tbReplace;
        private System.Windows.Forms.TextBox txtReplaceFolderPath;
        private System.Windows.Forms.ListBox lvReplaceFilesList;
        private System.Windows.Forms.Label lblFolder2;
        private System.Windows.Forms.Button btnReplaceBrowse;
        private System.Windows.Forms.Button btnReplaceClear;
        private System.Windows.Forms.Label lblFiles2;
        private System.Windows.Forms.Label lblFind;
        private System.Windows.Forms.Button btnReplaceProcess;
        private System.Windows.Forms.TextBox txtReplaceTextFind;
        private System.Windows.Forms.Label lblReplace;
        private System.Windows.Forms.TextBox txtReplaceTextWith;
        private System.Windows.Forms.Button btnReplaceRefresh;
        private System.Windows.Forms.Button btnRemoveRefresh;
        private System.Windows.Forms.Button btnRemoveAuto;
        private System.Windows.Forms.Button btnUndoReplace;
        private System.Windows.Forms.Button btnUndoRemove;
    }
}

